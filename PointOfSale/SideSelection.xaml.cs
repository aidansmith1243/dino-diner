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
        /// <summary>
        /// stores the combo if that is what is being edited
        /// </summary>
        private CretaceousCombo comboChange = null;
        /// <summary>
        /// Constructor to edit a combo
        /// </summary>
        /// <param name="combo"></param>
        public SideSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            comboChange = combo;

        }
        /// <summary>
        /// Constructor to edit a side 
        /// </summary>
        /// <param name="side"></param>
        public SideSelection(Side side)
        {
            InitializeComponent();
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
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
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
                    NavigationService.Navigate(new MenuCategorySelection());

                }
                if (comboChange != null)
                {
                    switch (btn.Name)
                    {
                        case "Small":
                            comboChange.Side.Size = DinoDiner.Menu.Size.Small;
                            break;
                        case "Medium":
                            comboChange.Side.Size = DinoDiner.Menu.Size.Medium;
                            break;
                        case "Large":
                            comboChange.Side.Size = DinoDiner.Menu.Size.Large;
                            break;
                    }
                    NavigationService.GoBack();

                }

            }
            //NavigationService.Navigate(new MenuCategorySelection());
            //NavigationService.GoBack();

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
                if (comboChange != null)
                {
                    comboChange.Side = s;
                }
                else
                {
                    order.Add(s);
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
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
                if (comboChange != null)
                {
                    comboChange.Side = s;
                }
                else
                {
                    order.Add(s);
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
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
                if (comboChange != null)
                {
                    comboChange.Side = s;
                }
                else
                {
                    order.Add(s);
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
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
                if (comboChange != null)
                {
                    comboChange.Side = s;
                }
                else
                {
                    order.Add(s);
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
            }

        }
        /// <summary>
        /// Returns to the main menu 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void DoneSelected(object sender, RoutedEventArgs args)
        {
            if (comboChange != null)
                NavigationService.Navigate(new CustomizeCombo(comboChange));
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
