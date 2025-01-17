﻿/* DrinkSelection.xaml.cs
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
        private CretaceousCombo comboChange = null;
        public DrinkSelection(CretaceousCombo c)
        {
            InitializeComponent();
            comboChange = c;

        }
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();

            if(drink is Tyrannotea t)
            {
                TyrannoteaSelect(null, null);
            }
            if (drink is Water w)
            {
                WaterSelect(null, null);
            }
            if (drink is JurassicJava j)
            {
                JurrassicJavaSelect(null, null);
            }
            if (drink is Sodasaurus s)
            {
                SodasaurusSelect(null, null);
            }
            TyrannoteaBtn.IsEnabled = false;
            SodasaurusBtn.IsEnabled = false;
            JurassicBtn.IsEnabled = false;
            WaterBtn.IsEnabled = false;

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
            Special2.Visibility = Visibility.Hidden;
            Ice.Content = "Hold Ice";
            Ice.Visibility = Visibility.Visible;
            if (DataContext is Order order)
            {
                Drink s = new Sodasaurus();
                if (comboChange != null)
                {
                    comboChange.Drink = s;
                }
                else
                {
                    order.Add(s);
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
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
            Special2.Content = "Add Lemon";
            Special2.Visibility = Visibility.Visible;
            
            Ice.Content = "Hold Ice";
            Ice.Visibility = Visibility.Visible;

            if (DataContext is Order order)
            {
                Drink s = new Water();
                if (comboChange != null)
                {
                    comboChange.Drink = s;
                }
                else
                {
                    order.Add(s);
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
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
            Special2.Content = "Room for Cream";
            Special2.Visibility = Visibility.Visible;

            Ice.Content = "Add Ice";
            Ice.Visibility = Visibility.Visible;
            if (DataContext is Order order)
            {
                Drink s = new JurassicJava();
                if (comboChange != null)
                {
                    comboChange.Drink = s;
                }
                else
                {
                    order.Add(s);
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
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
            Special2.Content = "Add Lemon";
            Special2.Visibility = Visibility.Visible;
            
            Ice.Content = "Hold Ice";
            Ice.Visibility = Visibility.Visible;

            if (DataContext is Order order)
            {
                Drink s = new Tyrannotea();
                if (comboChange != null)
                {
                    comboChange.Drink = s;
                }
                else
                {
                    order.Add(s);
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
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
                if(comboChange != null)
                    switch (btn.Name)
                    {
                        case "Small":
                            comboChange.Drink.Size = DinoDiner.Menu.Size.Small;
                            break;
                        case "Medium":
                            comboChange.Drink.Size = DinoDiner.Menu.Size.Medium;
                            break;
                        case "Large":
                            comboChange.Drink.Size = DinoDiner.Menu.Size.Large;
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
                    {
                        if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Tyrannotea drink)
                        {
                            drink.Sweet = true;
                        }
                        if (comboChange?.Drink is Tyrannotea d)
                            d.Sweet = true;
                    }
                    break;
                case "Decaf":
                    if (DataContext is Order o2)
                    {
                        if (CollectionViewSource.GetDefaultView(o2.Items).CurrentItem is JurassicJava dr2)
                        {
                            dr2.Decaf = true;
                        }
                        if (comboChange?.Drink is JurassicJava d)
                            d.Decaf = true;
                    }
                    break;
                case "Flavor":
                    if (DataContext is Order o3)
                    {
                        if (CollectionViewSource.GetDefaultView(o3.Items).CurrentItem is Sodasaurus d3)
                            NavigationService.Navigate(new FlavorSelection(d3));
                        if (comboChange?.Drink is Sodasaurus d)
                            NavigationService.Navigate(new FlavorSelection(d));
                    }
                    break;
            }
        }
        /// <summary>
        /// Special button for adding lemon or adding room for cream
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SpecialSelect2(object sender, RoutedEventArgs args)
        {
            Button btn = (Button)sender;
            string name = btn.Content.ToString();
            switch (name)
            {
                case "Add Lemon":
                    if (DataContext is Order order)
                    {
                        if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Tyrannotea drink)
                        {
                            drink.AddLemon();
                        }
                        if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Water drink2)
                        {
                            drink2.AddLemon();
                        }
                        if (comboChange?.Drink is Tyrannotea d)
                            d.AddLemon();
                        if (comboChange?.Drink is Water d2)
                            d2.AddLemon();

                    }
                    break;
                case "Room for Cream":
                    if (DataContext is Order o2)
                    {
                        if (CollectionViewSource.GetDefaultView(o2.Items).CurrentItem is JurassicJava java)
                        {
                            java.LeaveRoomForCream();
                        }
                        if (comboChange?.Drink is JurassicJava j)
                            j.LeaveRoomForCream();
                    }
                    break;
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
                if (comboChange?.Drink is Water w)
                    w.HoldIce();
                if (comboChange?.Drink is Tyrannotea t)
                    t.HoldIce();
                if (comboChange?.Drink is JurassicJava j)
                    j.AddIce();
                if (comboChange?.Drink is Sodasaurus s)
                    s.HoldIce();
            }
        }
        /// <summary>
        /// Move to the menu selection screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void DoneSelect(object sender, RoutedEventArgs args)
        {
            if(comboChange != null)
                NavigationService.Navigate(new CustomizeCombo(comboChange));
            else
                NavigationService.Navigate(new MenuCategorySelection());

        }
    }
}
