/* FlavorSlection.xaml.cs
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
        /// Constructor
        /// </summary>
        public FlavorSelection(Sodasaurus drink)
        {
            InitializeComponent();
            DataContext = drink;
        }
        /// <summary>
        /// Change the flavor and go back to drink selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void CherrySelect(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda)
                {
                    soda.Flavor = SodasaurusFlavor.Cherry;
                    NavigationService.GoBack();
                }
            }
            
        }
        /// <summary>
        /// Change the flavor and go back to drink selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void ChocolateSelect(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda)
                {
                    soda.Flavor = SodasaurusFlavor.Chocolate;
                    NavigationService.GoBack();
                }
            }
        }
        /// <summary>
        /// Change the flavor and go back to drink selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void ColaSelect(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda)
                {
                    soda.Flavor = SodasaurusFlavor.Cola;
                    NavigationService.GoBack();
                }
            }
        }
        /// <summary>
        /// Change the flavor and go back to drink selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void LimeSelect(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda)
                {
                    soda.Flavor = SodasaurusFlavor.Lime;
                    NavigationService.GoBack();
                }
            }
        }
        /// <summary>
        /// Change the flavor and go back to drink selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void RootSelect(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda)
                {
                    soda.Flavor = SodasaurusFlavor.RootBeer;
                    NavigationService.GoBack();
                }
            }
        }
        /// <summary>
        /// Change the flavor and go back to drink selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void VanillaSelect(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda)
                {
                    soda.Flavor = SodasaurusFlavor.Vanilla;
                    NavigationService.GoBack();
                }
            }
        }
        /// <summary>
        /// Change the flavor and go back to drink selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OrangeSelect(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda)
                {
                    soda.Flavor = SodasaurusFlavor.Orange;
                    NavigationService.GoBack();
                }
            }
        }
    }
}
