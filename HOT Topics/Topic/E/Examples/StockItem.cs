using System;
using System.Linq;

namespace Topic.E.Examples
{
    internal class StockItem
    {
        public double Cost { get; set; }

        public double ProfitMargin { get; set; }

        public StockItem(string itemName, double cost, double profitMargin)
        {
            this.ItemName = itemName;
            this.Cost = cost;
            this.ProfitMargin = profitMargin;
        }

        public string ItemName { get; set; }

        public double Price
        {
            get
            {
                // Round to the nearest cent
                double price = Cost;
                price += Cost * (ProfitMargin / 100);
                return Math.Round(price * 100) / 100.0;
            }
        }
    }
}
