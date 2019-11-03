/* OrderControl.xaml.cs
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
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// The navigation service to control
        /// </summary>
        public NavigationService NavigationService { get; set; }
        /// <summary>
        /// Removes an item from the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnRemoveOrderItem(object sender, EventArgs args)
        {
            if (DataContext is Order order)
                if (sender is FrameworkElement element)
                    if (element.DataContext is IOrderItem item)
                        order.Remove(item);
        }
        /// <summary>
        /// Runs when an item is selected in the order box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnSelectionChanged(object sender, EventArgs args)
        {
            if(OrderItems.SelectedItem is Side side)
            {
                NavigationService?.Navigate(new SideSelection(side));
                
            }
            if (OrderItems.SelectedItem is Drink drink)
            {
                NavigationService?.Navigate(new DrinkSelection(drink));
            }
        }
        /// <summary>
        /// Runs when the cancel button is clicked to remove items and 
        /// return to menu screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void CancelSelected(object sender, EventArgs args)
        {
            if (DataContext is Order order) 
            {
                order.Items.Clear();
                order.OnCollectionChanged(null,null);
            }
               
            NavigationService?.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// TODO figure out what this does
        /// </summary>
        private void MountItemListener()
        {
            if(DataContext is Order order)
            {
                //order.Items.CollectionChanged += OnCollectionChanged;
                //order.PropertyChanged += OnCollectionChanged;
            }
        }
        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnCollectionChanged(object sender, EventArgs args)
        {
            Console.WriteLine("changed data context");
            
            //CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
        }
        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="ags"></param>
        public void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs ags) 
        { 
            MountItemListener(); 
        }
    }
}
