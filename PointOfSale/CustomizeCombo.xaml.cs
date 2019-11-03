/* CustomizeCombo.xaml.cs
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
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        /// <summary>
        /// Constructor for initializing components
        /// </summary>
        public CustomizeCombo()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Constructor to start with a combo
        /// </summary>
        /// <param name="c"></param>
        public CustomizeCombo(CretaceousCombo c)
        {
            InitializeComponent();
            Drink d = c.Drink;
            if(d is JurassicJava)
            {
                DrinkImage.Source = new BitmapImage(new Uri("Assets/DinoDiner-13.png",UriKind.Relative));
                DrinkLabel.Text = "Jurassic Java";
            }
            else if(d is Water)
            {
                DrinkImage.Source = new BitmapImage(new Uri("Assets/DinoDiner-15.png", UriKind.Relative));
                DrinkLabel.Text = "Water";
            }
            else if(d is Sodasaurus)
            {
                DrinkImage.Source = new BitmapImage(new Uri("Assets/DinoDiner-14.png", UriKind.Relative));
                DrinkLabel.Text = "Sodasaurus";
            }
            else if(d is Tyrannotea)
            {
                DrinkImage.Source = new BitmapImage(new Uri("Assets/DinoDiner-12.png", UriKind.Relative));
                DrinkLabel.Text = "Tyrannotea";
            }

            Side s = c.Side;
            if(s is Fryceritops)
            {
                SideImage.Source = new BitmapImage(new Uri("Assets/DinoDiner-08.png", UriKind.Relative));
                SideLabel.Text = "Fryceritops";
            }
            else if (s is MeteorMacAndCheese)
            {
                SideImage.Source = new BitmapImage(new Uri("Assets/DinoDiner-09.png", UriKind.Relative));
                SideLabel.Text = "Meteor Mac & Cheese";
            }
            else if (s is MezzorellaSticks)
            {
                SideImage.Source = new BitmapImage(new Uri("Assets/DinoDiner-10.png", UriKind.Relative));
                SideLabel.Text = "Mezzorella Sticks";
            }
            else if (s is Triceritots)
            {
                SideImage.Source = new BitmapImage(new Uri("Assets/DinoDiner-11.png", UriKind.Relative));
                SideLabel.Text = "Triceritots";
            }
            /*
            SideImage.Source =  
            SideLabel.Text =
            DrinkImage.Source =
            DrinkLabel.Text =*/
        }
        /// <summary>
        /// Changes the screen to the side selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SideSelect(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    NavigationService.Navigate(new SideSelection(combo));
                }
            }
        }
        /// <summary>
        /// Changes the screen to the drink select
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void DrinkSelect(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    NavigationService.Navigate(new DrinkSelection(combo));
                }
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
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    switch (btn.Name)
                    {
                        case "Small":
                            combo.Size = DinoDiner.Menu.Size.Small;
                            break;
                        case "Medium":
                            combo.Size = DinoDiner.Menu.Size.Medium;
                            break;
                        case "Large":
                            combo.Size = DinoDiner.Menu.Size.Large;
                            break;
                    }
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
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
