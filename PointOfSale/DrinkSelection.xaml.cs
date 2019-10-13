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
        }
        /// <summary>
        /// used to make the size selection buttons into radio buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SizeSelect(object sender, RoutedEventArgs args)
        {
            Button btn = (Button)sender;
            Large.Background = Brushes.LightGray;
            Medium.Background = Brushes.LightGray;
            Small.Background = Brushes.LightGray;
            btn.Background = Brushes.Gray;

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
                    break;
                case "Decaf":
                    break;
                case "Flavor":
                    NavigationService.Navigate(new FlavorSelection());
                    break;
            }


        }
    }
}
