/* SideSelection.xaml.cs
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
            DataContext = side;
        }
        /// <summary>
        /// Used to make the size buttons into radio buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SizeSelect(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Large.Background = Brushes.LightGray;
            Medium.Background = Brushes.LightGray;
            Small.Background = Brushes.LightGray;
            btn.Background = Brushes.Gray;

            if (DataContext is Order order)
            {
                if(CollectionViewSource.GetDefaultView(order.Items).CurrentItem is  Side side)
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
            }

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
                order.Items.Add(s);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }

        }
    }
}
