#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.UI.Xaml.Diagram;
using System;
using System.Collections.Generic;
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

namespace Connectors
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Syncfusion.SfSkinManager.SfSkinManager.SetVisualStyle(propertyPanel, Syncfusion.SfSkinManager.VisualStyles.Office2016Colorful);
        }

        private void Diagram_Loaded(object sender, RoutedEventArgs e)
        {
            FitToPageParameter fitToPage = new FitToPageParameter() { FitToPage = FitToPage.FitToPage, Region = Region.PageSettings };
            (Diagram.Info as IGraphInfo).Commands.FitToPage.Execute(fitToPage);
        }
    }
}
