#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Syncfusion.Windows.Controls.Gantt;
using Syncfusion.Windows.Controls.Grid;
using System.Threading;

namespace ProjectStatistics
{
    /// <summary>
    /// Interaction logic for StatisticsWindow.xaml
    /// </summary>
    public partial class StatisticsWindow 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticsWindow"/> class.
        /// </summary>
        public StatisticsWindow(StatisticsViewModel view)
        {
            InitializeComponent();
            this.DataContext = view;
        }
    }   
}

