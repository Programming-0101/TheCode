using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic.F.Examples
{
    public class StockItem
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
        public bool IsPricedAtCost
        {
            get
            {
                bool atCost = false;
                if (ProfitMargin == 0)
                    atCost = true;
                return atCost;
            }
        }
 
        public bool IsPricedBelowCost
        {
            get
            {
                bool belowCost;
                if (ProfitMargin< 0)
                    belowCost = true;
                else
                    belowCost = false;
                return belowCost;
            }
        }
    }
}
