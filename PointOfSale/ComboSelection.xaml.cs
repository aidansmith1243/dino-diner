/* ComboSelection.xaml.cs
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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        /// <summary>
        /// Constructor to initialize components
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Perform actions when the this entree button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void BrontowurstSelect(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                CretaceousCombo c = new CretaceousCombo(new Brontowurst());
                order.Add(c);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();

                NavigationService.Navigate(new EntreeCustomization(c));
            }
        }
        /// <summary>
        /// Perform actions when the this entree button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void DinoNuggetSelect(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo c = new CretaceousCombo(new DinoNuggets());
                order.Add(c);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();

                NavigationService.Navigate(new EntreeCustomization(c));
            }
        }
        /// <summary>
        /// Perform actions when the this entree button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void PrehistoricPBJSelect(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo c = new CretaceousCombo(new PrehistoricPBJ());
                order.Add(c);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();

                NavigationService.Navigate(new EntreeCustomization(c));
            }
        }
        /// <summary>
        /// Perform actions when the this entree button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void PterodactylwingsSelect(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo c = new CretaceousCombo(new PterodactylWings());
                order.Add(c);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();

                NavigationService.Navigate(new CustomizeCombo(c));
            }
        }
        /// <summary>
        /// Perform actions when the this entree button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SteakosaurusBugerSelect(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo c = new CretaceousCombo(new SteakosaurusBurger());
                order.Add(c);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();

                NavigationService.Navigate(new EntreeCustomization(c));
            }
        }
        /// <summary>
        /// Perform actions when the this entree button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void TRexKingBurgerSelect(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo c = new CretaceousCombo(new TRexKingBurger());
                order.Add(c);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();

                NavigationService.Navigate(new EntreeCustomization(c));
            }
        }
        /// <summary>
        /// Perform actions when the this entree button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void VelociwrapSelect(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo c = new CretaceousCombo(new VelociWrap());
                order.Add(c);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();

                NavigationService.Navigate(new EntreeCustomization(c));
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
