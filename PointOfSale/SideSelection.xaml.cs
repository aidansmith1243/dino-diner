/* SideSelection.xaml.cs
 * Author: Aidan Smith
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page 
    {
        /// <summary>
        /// Constructor to initialize components
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }
        public SideSelection(Side side)
        {
            InitializeComponent();
            //DataContext = side;
            MeteorBtn.IsEnabled = false;
            MezzorellaBtn.IsEnabled = false;
            FryceritopsBtn.IsEnabled = false;
            TriceritotsBtn.IsEnabled = false;
        }
        /// <summary>
        /// Used to make the size buttons into radio buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SizeSelect(object sender, RoutedEventArgs e)
        {
            
            Button btn = (Button)sender;

            if (DataContext is Order order)
            {
                if(CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                switch (btn.Name)
                {
                    case "Small":
                            side.Size = DinoDiner.Menu.Size.Small;
                        break;
                    case "Medium":
                            side.Size = DinoDiner.Menu.Size.Medium;
                            break;
                    case "Large":
                            side.Size = DinoDiner.Menu.Size.Large;
                            break;
                }
                //order.OnCollectionChanged(null, null); // Refreshes the price shown on the order
            }
            NavigationService.Navigate(new MenuCategorySelection());

        }
        /// <summary>
        /// Adds fryceritops to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddFryceritops(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                Side s = new Fryceritops();
                order.Add(s);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }

        }
        /// <summary>
        /// Adds side to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddMeteorMacCheese(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                Side s = new MeteorMacAndCheese();
                order.Add(s);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }

        }
        /// <summary>
        /// Adds side to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddMezzorellaSticks(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                Side s = new MezzorellaSticks();
                order.Add(s);
                //CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentTo(s);
                Console.WriteLine(CollectionViewSource.GetDefaultView(order.Items).CurrentItem);
            }

        }
        /// <summary>
        /// Adds side to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTricertots(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                Side s = new Triceritots();
                order.Add(s);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
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
