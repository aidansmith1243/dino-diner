/*
 * MainWindow.xaml.cs
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Constructor for the main window
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            // Test order stuff
            Order order = DataContext as Order;
            if (order != null)
            {
                order.Items.Add(new DinoNuggets());
                order.Items.Add(new Sodasaurus());
                Triceritots t = new Triceritots();
                t.Size = DinoDiner.Menu.Size.Large;
                order.Items.Add(t);
                SteakosaurusBurger sb = new SteakosaurusBurger();
                sb.HoldBun();
                sb.HoldMustard();
                order.Items.Add(sb);
            }
        }

        private void PassOnDataContext()
        {
            Page page = OrderUI.Content as Page;
            if(page != null)
            {
                page.DataContext = OrderUI.DataContext;
            }
        }

        public void OnLoadCompleted(object sender, NavigationEventArgs args)
        {
            PassOnDataContext();
        }
        public void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            PassOnDataContext();
        }
    }
}
