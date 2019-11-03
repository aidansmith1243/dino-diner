/* OrderTest.cs
 * Author: Aidan Smith
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class OrderTest
    {
        [Fact]
        public void EntreeOrderTest()
        {
            Order o = new Order();
            o.Add(new DinoNuggets());
            Assert.Equal(4.25 + 4.25*o.SalesTaxRate,o.TotalCost,2);
        }
        [Fact]
        public void DrinkOrderTest()
        {
            Order o = new Order();
            o.Add(new Water());
            Assert.Equal(0.10 + 0.10 * o.SalesTaxRate, o.TotalCost, 2);
        }
        [Fact]
        public void ComboOrderTest()
        {
            Order o = new Order();
            o.Add(new CretaceousCombo(new VelociWrap()));
            Assert.Equal(10.47, o.TotalCost, 2);
        }
        [Fact]
        public void SideOrderTest()
        {
            Order o = new Order();
            o.Add(new Fryceritops());
            Assert.Equal(0.99 + 0.99 * o.SalesTaxRate, o.TotalCost, 2);
        }
        [Fact]
        public void MultipleOrderItems()
        {
            Order o = new Order();
            o.Add(new Fryceritops());
            o.Add(new Water());
            o.Add(new DinoNuggets());
            Assert.Equal((0.99 + 0.1 + 4.25 )* (1+ o.SalesTaxRate), o.TotalCost, 2);
        }

        [Fact]
        public void SubtotalCostShouldNotBeNegative()
        {
            Order O = new Order();
            Fryceritops f = new Fryceritops();
            f.Price = -11111;
            O.Add(f);
            Assert.Equal(0, O.SubtotalCost, 2);

        }
    }
}
