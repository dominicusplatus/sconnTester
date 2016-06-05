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
using Prism.Regions;
using sconnTester.Model.Test.Result;

namespace sconnTester.View
{
    /// <summary>
    /// Interaction logic for DutConnectionStatusView.xaml
    /// </summary>
    /// 



    [Export]
    [ViewSortHint("01")]
    public partial class DutConnectionStatusView : UserControl
    {
        [Import]
        public IRegionManager RegionManager;

        [ImportingConstructor]
        public DutConnectionStatusView()
        {
            InitializeComponent();
        }
        
    }


}
