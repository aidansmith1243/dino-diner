/* MenuCategorySelection.xaml
 * Author: Aida Smith
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
    /// Interaction logic for MenuCategorySelection.xaml
    /// </summary>
    public partial class MenuCategorySelection : Page
    {
        /// <summary>
        /// Constructor to initialize components.
        /// </summary>
        public MenuCategorySelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Change to the combo selection screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void ComboSelect(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new ComboSelection());
        }
        /// <summary>
        /// Change to the side selection screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SideSelect(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection());
        }
        /// <summary>
        /// change to the Entree Selection screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void EntreeSelect(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new EntreeSelection());
        }
        /// <summary>
        /// change to the drink selection screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void DrinkSelect(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
    }
}
