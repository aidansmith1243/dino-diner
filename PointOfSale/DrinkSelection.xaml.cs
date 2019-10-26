/* DrinkSelection.xaml.cs
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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Used for when the soda is selected and allows flavor to be visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SodasaurusSelect(object sender, RoutedEventArgs args)
        {
            Special.Content = "Flavor";
            Special.Visibility = Visibility.Visible;
            Lemon.Visibility = Visibility.Hidden;
            Ice.Content = "Hold Ice";
            if (DataContext is Order order)
            {
                Drink s = new Sodasaurus();
                order.Items.Add(s);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }
        /// <summary>
        /// When water is selected it allows for lemon to be visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void WaterSelect(object sender, RoutedEventArgs args)
        {
            Special.Visibility = Visibility.Hidden;
            Lemon.Visibility = Visibility.Visible;
            Ice.Content = "Hold Ice";
            if (DataContext is Order order)
            {
                Drink s = new Water();
                order.Items.Add(s);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }
        /// <summary>
        /// Coffee is selected and allows the choice of decaf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void JurrassicJavaSelect(object sender, RoutedEventArgs args)
        {
            Special.Content = "Decaf";
            Special.Visibility = Visibility.Visible;
            Lemon.Visibility = Visibility.Hidden;
            Ice.Content = "Add Ice";
            if (DataContext is Order order)
            {
                Drink s = new JurassicJava();
                order.Items.Add(s);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }
        /// <summary>
        /// When tea is seleced and allows the sweet button to appear
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void TyrannoteaSelect(object sender, RoutedEventArgs args)
        {
            Special.Content = "Sweet";
            Special.Visibility = Visibility.Visible;
            Lemon.Visibility = Visibility.Visible;
            Ice.Content = "Hold Ice";
            if (DataContext is Order order)
            {
                Drink s = new Tyrannotea();
                order.Items.Add(s);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }
        /// <summary>
        /// used to make the size selection buttons into radio buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SizeSelect(object sender, RoutedEventArgs args)
        {
            
            Button btn = (Button)sender;
            /*Large.Background = Brushes.LightGray;
            Medium.Background = Brushes.LightGray;
            Small.Background = Brushes.LightGray;
            btn.Background = Brushes.Gray;
            */
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                    switch (btn.Name)
                    {
                        case "Small":
                            drink.Size = DinoDiner.Menu.Size.Small;
                            break;
                        case "Medium":
                            drink.Size = DinoDiner.Menu.Size.Medium;
                            break;
                        case "Large":
                            drink.Size = DinoDiner.Menu.Size.Large;
                            break;
                    }
            }

        }
        /// <summary>
        /// When the special button for sweet, decaf, or flavor is selected and perform
        /// actions based on what the button is.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SpecialSelect(object sender, RoutedEventArgs args)
        {
            Button btn = (Button)sender;
            string name = btn.Content.ToString();
            switch (name)
            {
                case "Sweet":
                    if (DataContext is Order order)
                        if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Tyrannotea drink)
                        {
                            drink.Sweet = true;
                        }
                    break;
                case "Decaf":
                    if (DataContext is Order o2)
                        if (CollectionViewSource.GetDefaultView(o2.Items).CurrentItem is JurassicJava dr2)
                        {
                            dr2.Decaf = true;
                        }
                    break;
                case "Flavor":
                    if (DataContext is Order o3)
                        if (CollectionViewSource.GetDefaultView(o3.Items).CurrentItem is Sodasaurus d3)
                            NavigationService.Navigate(new FlavorSelection(d3));
                    break;
            }
        }
        /// <summary>
        /// Adds lemons to the various drinks that allow it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddLemon(object sender, RoutedEventArgs args) 
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Water drink)
                {
                    drink.AddLemon();
                }
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Tyrannotea d2)
                {
                    d2.AddLemon();
                }
            }
        }
        /// <summary>
        /// Changes the ice property of the drink selected by adding or removing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void ChangeIce(object sender, RoutedEventArgs args) 
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Water drink)
                {
                    drink.HoldIce();
                }
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Tyrannotea d2)
                {
                    d2.HoldIce();
                }
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is JurassicJava d3)
                {
                    d3.AddIce();
                }
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus d4)
                {
                    d4.HoldIce();
                }
            }
        }
    }
}
