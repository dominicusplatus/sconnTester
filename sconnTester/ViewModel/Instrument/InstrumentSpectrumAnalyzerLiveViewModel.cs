using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Threading;
using NationalInstruments.VisaNS;
using OxyPlot;
using Prism.Mvvm;
using Timer = System.Timers.Timer;

namespace sconnTester.ViewModel.Instrument
{

    public class MTObservableCollection<T> : ObservableCollection<T>
    {
        public override event NotifyCollectionChangedEventHandler CollectionChanged;
        protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            NotifyCollectionChangedEventHandler CollectionChanged = this.CollectionChanged;
            if (CollectionChanged != null)
                foreach (NotifyCollectionChangedEventHandler nh in CollectionChanged.GetInvocationList())
                {
                    DispatcherObject dispObj = nh.Target as DispatcherObject;
                    if (dispObj != null)
                    {
                        Dispatcher dispatcher = dispObj.Dispatcher;
                        if (dispatcher != null && !dispatcher.CheckAccess())
                        {
                            dispatcher.BeginInvoke(
                                (Action)(() => nh.Invoke(this,
                                    new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset))),
                                DispatcherPriority.DataBind);
                            continue;
                        }
                    }
                    nh.Invoke(this, e);
                }
        }
    }


    [Export]
    public class InstrumentSpectrumAnalyzerLiveViewModel : BindableBase
    {
        public string Title { get; set; }

        private MTObservableCollection<DataPoint> _points;

        public MessageBasedSession VisaSession { get; set; }

        public MTObservableCollection<DataPoint> Points
        {
            get { return _points; }
            set
            {
                _points = value;
                OnPropertyChanged();
            }
        }

        public PlotModel Model { get; set; }

        public  Timer timer{ get; set; }

        private SynchronizationContext context;


        private double f(int i)
        {
            var f1 = Math.Sin(i);
            return f1;
        }


        private void FakeData()
        {
            //context.Send(x =>
            //    Points.Clear(), null
            //    );

            Points.Clear();
            for (int i = 0; i < 1000; i++)
            {
                DataPoint pt = new DataPoint(f(i),f(i));
             //   double val = f(i);
                //context.Send(x =>
                // Points.Add(val), null
                //);

                Points.Add(pt);
            }
        }



        public InstrumentSpectrumAnalyzerLiveViewModel()
        {
            Points = new MTObservableCollection<DataPoint>();
          //  FakeData();
           // FakeStatic();
          //  SampleVisa();

             context = SynchronizationContext.Current;
            if (VisaStart())
            {

                timer = new Timer { Interval = 100 };
                timer.Elapsed += timer_Elapsed;
                timer.Start();
            }

        }

        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
           // FakeStatic();
            SampleVisa();
        }


        bool VisaStart()
        {
            var mbSession = (MessageBasedSession)ResourceManager.GetLocalManager().Open("TCPIP::192.168.1.129::INSTR");
            if (mbSession != null)
            {
                VisaSession = mbSession;
                return true;
            }
            return false;
        }

        void SampleVisa()
        {

            if (VisaSession != null)
            {

                VisaSession.Write(":WAV:SOUR CHAN2");
                VisaSession.Write(" :WAV:MODE RAW");
                VisaSession.Write(":WAV:FORM BYTE");

                VisaSession.Write(":WAV:STAR 1");
                VisaSession.Write(":WAV:STOP 640000");

                VisaSession.Write(":WAV:RES");
                VisaSession.Write(":WAV:BEG");
                VisaSession.Write(":WAV:DATA?");

                var data = VisaSession.ReadByteArray();

                Random rnd = new Random();
                var tmp = new MTObservableCollection<DataPoint>();
                for (int i = 0; i < data.Length; i++)
                {
                    DataPoint pt = new DataPoint(i, data[i]);
                    tmp.Add(pt);
                }
                Points = tmp;

               // mbSession.Write(":WAVeform:DATA?"); //Send Write command to VISA resource

               // var strRead = mbSession.ReadString(); //Read string from VISA resource

            }
            //Instantiate and open a Message Based VISA Session
        }

        void FakeStatic()
        {
           // Points.Clear();
               Random rnd = new Random();
               var tmp  = new MTObservableCollection<DataPoint>();
            for (int i = 0; i < 200; i++)
            {
                DataPoint pt = new DataPoint(rnd.Next(0, 100), rnd.Next(0, 100));
                tmp.Add(pt);
            }
            Points = tmp;
        }




    }

}
