﻿/*
 * MainWindow.xaml.cs
 * Author: Aidan Smith
 */
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
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Constructor for the main window
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            OrderControl.NavigationService = OrderUI.NavigationService;

        }
        /// <summary>
        /// Passes on the data context to new pages
        /// </summary>
        private void PassOnDataContext()
        {
            Page page = OrderUI.Content as Page;
            if(page != null)
            {
                page.DataContext = OrderUI.DataContext;
            }
            
        }
        /// <summary>
        /// Passes on the datacontext when screen is loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnLoadCompleted(object sender, NavigationEventArgs args)
        {
            PassOnDataContext();
        }
        /// <summary>
        /// passes on the changes to the datacontext
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            PassOnDataContext();
        }
    }
}
