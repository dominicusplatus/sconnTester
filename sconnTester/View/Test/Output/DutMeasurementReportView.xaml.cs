﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NLog;
using Prism.Regions;
using sconnTester.Infrastracture;
using sconnTester.Model.Test.Result;
using sconnTester.ViewModel;

namespace sconnTester.View
{
    /// <summary>
    /// Interaction logic for DutMeasurementReportView.xaml
    /// </summary>

    [Export(TesterViewContracts.TesterContractOutput)]
    [ViewSortHint("01")]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public partial class DutMeasurementReportView : UserControl
    {
        [Import]
        public IRegionManager RegionManager;

        public DutMeasurementReportView()
        {
            InitializeComponent();
        }


        [ImportingConstructor]
        public DutMeasurementReportView(ITestResultSummary viewModel)
        {
            this.DataContext = viewModel;
            InitializeComponent();
        }

    }


}
