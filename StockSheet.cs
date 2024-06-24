using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatGlassCutOptimiser
{
    public class StockSheet
    {
        public int Id { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Quantity { get; set; }
        public int Cost { get; set; }
        public List<GlassPanel> Panels { get; set; } = new List<GlassPanel>();
    }
}
