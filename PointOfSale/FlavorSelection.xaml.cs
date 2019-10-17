﻿/* FlavorSlection.xaml.cs
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public FlavorSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Continue after any of the flavors are selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void EntreeSelect(object sender, RoutedEventArgs args)
        {

        }
    }
}