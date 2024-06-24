using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatGlassCutOptimiser
{
    public class DataAccess
    {
        public List<StockSheet> FetchStockSheets()
        {
            var stockSheets = new List<StockSheet>
            {
                new StockSheet { Id = 1, Width = 1862, Height = 1219, Quantity = 1, Cost = 229 },
                new StockSheet { Id = 2, Width = 3210, Height = 2440, Quantity = 40, Cost = 7890 },
                new StockSheet { Id = 3, Width = 3210, Height = 2250, Quantity = 92, Cost = 7250 },
                new StockSheet { Id = 4, Width = 2440, Height = 1830, Quantity = 304, Cost = 4530 }
            };

            return stockSheets;
        }

        public List<GlassPanel> FetchPanelOrders()
        {
            var parts = new List<GlassPanel>
            {
                new GlassPanel { Id = 1, Width = 700, Height = 484 },
                new GlassPanel { Id = 2, Width = 501, Height = 249 },
                new GlassPanel { Id = 3, Width = 1132, Height = 675 },
                new GlassPanel { Id = 4, Width = 485, Height = 433 },
                new GlassPanel { Id = 5, Width = 522, Height = 466 },
                new GlassPanel { Id = 6, Width = 362, Height = 1756 },
                new GlassPanel { Id = 7, Width = 362, Height = 1756 },
                new GlassPanel { Id = 8, Width = 1726, Height = 926 }
           
            };

            return parts;
        }
    }
}
