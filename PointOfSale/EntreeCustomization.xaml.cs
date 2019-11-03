/*EntreeCustomization.xaml.cs
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
    /// Interaction logic for EntreeCustomization.xaml
    /// </summary>
    public partial class EntreeCustomization : Page
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public EntreeCustomization()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Creates all of the customizations for the sender entree
        /// </summary>
        /// <param name="e"></param>
        public EntreeCustomization(Entree e)
        {
            InitializeComponent();
            if(e is DinoNuggets d)
            {
                Button b = new Button();
                b.Content = "Add Nugget";
                b.Click += AddNugget;
                
                MainPanel.Children.Add(b);
            }
            else if(e is Brontowurst br)
            {
                Button b = new Button();
                b.Content = "Hold Bun";
                b.Click += HoldBun;
                Button b2 = new Button();
                b2.Content = "Hold Peppers";
                b2.Click += HoldPeppers;
                Button b3 = new Button();
                b3.Content = "Hold Onion";
                b3.Click += HoldOnion;

                MainPanel.Children.Add(b);
                MainPanel.Children.Add(b2);
                MainPanel.Children.Add(b3);
            }
            else if(e is PrehistoricPBJ p)
            {
                Button b = new Button();
                b.Content = "Hold Peanut Butter";
                b.Click += HoldPeanutButter;
                Button b2 = new Button();
                b2.Content = "Hold Jelly";
                b2.Click += HoldJelly;

                MainPanel.Children.Add(b);
                MainPanel.Children.Add(b2);
            }
            else if(e is PterodactylWings t)
            {
                // No modifications for wings
                
            }
            else if(e is SteakosaurusBurger s)
            {
                Button b = new Button();
                b.Content = "Hold Bun";
                b.Click += HoldBun;
                Button b2 = new Button();
                b2.Content = "Hold Pickle";
                b2.Click += HoldPickle;
                Button b3 = new Button();
                b3.Content = "Hold Ketchup";
                b3.Click += HoldKetchup;
                Button b4 = new Button();
                b4.Content = "Hold Mustard";
                b4.Click += HoldMustard;

                MainPanel.Children.Add(b);
                MainPanel.Children.Add(b2);
                MainPanel.Children.Add(b3);
                MainPanel.Children.Add(b4);
            }
            else if(e is TRexKingBurger r)
            {
                Button b = new Button();
                b.Content = "Hold Bun";
                b.Click += HoldBun;
                Button b2 = new Button();
                b2.Content = "Hold Pickle";
                b2.Click += HoldPickle;
                Button b3 = new Button();
                b3.Content = "Hold Ketchup";
                b3.Click += HoldKetchup;
                Button b4 = new Button();
                b4.Content = "Hold Mustard";
                b4.Click += HoldMustard;

                Button b5 = new Button();
                b5.Content = "Hold Lettuce";
                b5.Click += HoldLettuce;
                Button b6 = new Button();
                b6.Content = "Hold Tomato";
                b6.Click += HoldTomato;
                Button b7 = new Button();
                b7.Content = "Hold Mayo";
                b7.Click += HoldMayo;
                Button b8 = new Button();
                b8.Content = "Hold Onion";
                b8.Click += HoldOnion;

                MainPanel.Children.Add(b);
                MainPanel.Children.Add(b2);
                MainPanel.Children.Add(b3);
                MainPanel.Children.Add(b4);
                
                MainPanel.Children.Add(b5);
                MainPanel.Children.Add(b6);
                MainPanel.Children.Add(b7);
                MainPanel.Children.Add(b8);
            }
            else if(e is VelociWrap v)
            {
                Button b = new Button();
                b.Content = "Hold Dressing";
                b.Click += HoldDressing;
                Button b2 = new Button();
                b2.Content = "Hold Lettuce";
                b2.Click += HoldLettuce;
                Button b3 = new Button();
                b3.Content = "Hold Cheese";
                b3.Click += HoldCheese;

                MainPanel.Children.Add(b);
                MainPanel.Children.Add(b2);
                MainPanel.Children.Add(b3);
            }

            

        }
        /// <summary>
        /// Performs the action on the selected entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldCheese(object sender, EventArgs args)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is VelociWrap e)
                    e.HoldCheese();
        }
        /// <summary>
        /// Performs the action on the selected entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldDressing(object sender, EventArgs args)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is VelociWrap e)
                    e.HoldDressing();
        }
        /// <summary>
        /// Performs the action on the selected entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldMayo(object sender, EventArgs args)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger e)
                    e.HoldMayo();
        }
        /// <summary>
        /// Performs the action on the selected entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldTomato(object sender, EventArgs args)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger e)
                    e.HoldTomato();
        }
        /// <summary>
        /// Performs the action on the selected entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldLettuce(object sender, EventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger e)
                    e.HoldLettuce();
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is VelociWrap v)
                    v.HoldLettuce();
            }
        }
        /// <summary>
        /// Performs the action on the selected entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldMustard(object sender, EventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is SteakosaurusBurger e)
                    e.HoldMustard();
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger r)
                    r.HoldMustard();
            }
        }
        /// <summary>
        /// Performs the action on the selected entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldKetchup(object sender, EventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is SteakosaurusBurger e)
                    e.HoldKetchup();
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger r)
                    r.HoldKetchup();
            }
        }
        /// <summary>
        /// Performs the action on the selected entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldPickle(object sender, EventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is SteakosaurusBurger e)
                    e.HoldPickle();
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger r)
                    r.HoldPickle();
            }
        }
        /// <summary>
        /// Performs the action on the selected entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldJelly(object sender, EventArgs args)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is PrehistoricPBJ e)
                    e.HoldJelly();
        }
        /// <summary>
        /// Performs the action on the selected entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldPeanutButter(object sender, EventArgs args)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is PrehistoricPBJ e)
                    e.HoldPeanutButter();
        }
        /// <summary>
        /// Performs the action on the selected entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldPeppers(object sender, EventArgs args)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Brontowurst e)
                    e.HoldPeppers();
        }
        /// <summary>
        /// Performs the action on the selected entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldBun(object sender, EventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Brontowurst e)
                    e.HoldBun();
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is SteakosaurusBurger x)
                    x.HoldBun();
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger r)
                    r.HoldBun();
            }
        }
        /// <summary>
        /// Performs the action on the selected entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void HoldOnion(object sender, EventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Brontowurst e)
                    e.HoldOnion();
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger r)
                    r.HoldOnion();
            }
        }
        /// <summary>
        /// Performs the action on the selected entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddNugget(object sender, EventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoNuggets e)
                    e.AddNugget();
            }
        }
        /// <summary>
        /// returns to the main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void DoneSelect(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
