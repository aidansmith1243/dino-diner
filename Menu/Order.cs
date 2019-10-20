using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    public class Order
    {
        public ObservableCollection<IOrderItem> Items { get; set; }
        public double SubtotalCost { get; }
        public double SalesTaxRate { get; protected set; }
        public double SalesTaxCost { get; }
        public double TotalCost { get; }
    }
}
