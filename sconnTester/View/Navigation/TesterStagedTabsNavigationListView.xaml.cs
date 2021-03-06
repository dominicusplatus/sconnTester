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
using sconnTester.ViewModel;

namespace sconnTester.View.Navigation
{
    /// <summary>
    /// Interaction logic for TesterStagedTabsNavigationListView.xaml
    /// </summary>

    [Export]
    [ViewSortHint("01")]
    public partial class TesterStagedTabsNavigationListView : UserControl
    {
        private Logger _nlogger = LogManager.GetCurrentClassLogger();

        [Import]
        public IRegionManager RegionManager;

        public TesterStagedTabsNavigationListView()
        {
            InitializeComponent();
        }


        [ImportingConstructor]
        public TesterStagedTabsNavigationListView(TesterStagesListViewModel viewModel)
        {
            this.DataContext = viewModel;
            InitializeComponent();
        }

    }
}
