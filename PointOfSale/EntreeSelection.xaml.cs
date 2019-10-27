/* EntreeSelection.xaml.cs
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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        /// <summary>
        /// Constructor to initialize components
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// TODO add to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void EntreeSelect(object sender, RoutedEventArgs args)
        {
            
        }
        /// <summary>
        /// Adds the selected item to the menu and moves back to the main window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void BrontowurstSelect(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Brontowurst s = new Brontowurst();
                order.Items.Add(s);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
        /// <summary>
        /// Adds the selected item to the menu and moves back to the main window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void DinoNuggetSelect(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Entree s = new DinoNuggets();
                order.Items.Add(s);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
        /// <summary>
        /// Adds the selected item to the menu and moves back to the main window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void PrehistoricPBJSelect(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Entree s = new PrehistoricPBJ();
                order.Items.Add(s);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
        /// <summary>
        /// Adds the selected item to the menu and moves back to the main window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void PterodactylwingsSelect(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Entree s = new PterodactylWings();
                order.Items.Add(s);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
        /// <summary>
        /// Adds the selected item to the menu and moves back to the main window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SteakosaurusBugerSelect(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Entree s = new SteakosaurusBurger();
                order.Items.Add(s);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
        /// <summary>
        /// Adds the selected item to the menu and moves back to the main window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void TRexKingBurgerSelect(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Entree s = new TRexKingBurger();
                order.Items.Add(s);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
        /// <summary>
        /// Adds the selected item to the menu and moves back to the main window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void VelociwrapSelect(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Entree s = new VelociWrap();
                order.Items.Add(s);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
        /// <summary>
        /// Returns to the main menu 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void DoneSelected(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
