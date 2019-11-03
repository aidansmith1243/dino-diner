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
        /*/// <summary>
        /// Moves to the combo customized screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void ComboSelect(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }*/
        public void BrontowurstSelect(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                order.Add(new CretaceousCombo(new Brontowurst()));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();

                NavigationService.Navigate(new CustomizeCombo());
            }
        }
        public void DinoNuggetSelect(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new CretaceousCombo(new DinoNuggets()));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();

                NavigationService.Navigate(new CustomizeCombo());
            }
        }
        public void PrehistoricPBJSelect(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new CretaceousCombo(new PrehistoricPBJ()));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();

                NavigationService.Navigate(new CustomizeCombo());
            }
        }
        public void PterodactylwingsSelect(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new CretaceousCombo(new PterodactylWings()));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();

                NavigationService.Navigate(new CustomizeCombo());
            }
        }
        public void SteakosaurusBugerSelect(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new CretaceousCombo(new SteakosaurusBurger()));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();

                NavigationService.Navigate(new CustomizeCombo());
            }
        }
        public void TRexKingBurgerSelect(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new CretaceousCombo(new TRexKingBurger()));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();

                NavigationService.Navigate(new CustomizeCombo());
            }
        }
        public void VelociwrapSelect(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new CretaceousCombo(new VelociWrap()));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();

                NavigationService.Navigate(new CustomizeCombo());
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
