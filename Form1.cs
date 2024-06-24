using System.IO;

namespace NatGlassCutOptimiser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void optimise_Click(object sender, EventArgs e)
        {
            var cutter = new DynamicGlassCutter();
            var data = new DataAccess();
            var dataStockSheets = data.FetchStockSheets();
            var dataPanels = data.FetchPanelOrders();

            var optimizedSheet = cutter.OptimizeCutting(dataStockSheets.FirstOrDefault(), dataPanels);

            // Draw the optimized cutting layout
            DrawPanels(optimizedSheet);

        }

        private void DrawPanels(StockSheet sheet)
        {
            var graphics = panel1.CreateGraphics();
            var scaleFactor = 0.1;
            graphics.Clear(Color.White);
            var rnd = new Random();
            foreach (var panel in sheet.Panels)
            {
                var rect = new Rectangle(
                    (int)(panel.PositionX * scaleFactor),
                    (int)(panel.PositionY * scaleFactor),
                    (int)(panel.Width * scaleFactor),
                    (int)(panel.Height * scaleFactor)
                );
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                var brush = new SolidBrush(randomColor);
                graphics.DrawRectangle(Pens.Black, rect);
                graphics.FillRectangle(brush, rect);
                graphics.DrawString($"{panel.Width}x{panel.Height} mm", DefaultFont, Brushes.Black, rect.Location);
            }
        }
    }
}
