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
        /// Changes the screen to the side selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SideSelect(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection());
        }
        /// <summary>
        /// Changes the screen to the drink select
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void DrinkSelect(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection());
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
