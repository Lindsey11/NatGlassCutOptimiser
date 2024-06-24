using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatGlassCutOptimiser
{
    public class DynamicGlassCutter
    {
        // Optimize the cutting of panels using dynamic programming approach
        public StockSheet OptimizeCutting(StockSheet sheet, List<GlassPanel> panels)
        {
            int[,] dp = new int[sheet.Width + 1, sheet.Height + 1];
            int[,] fromWidth = new int[sheet.Width + 1, sheet.Height + 1];
            int[,] fromHeight = new int[sheet.Width + 1, sheet.Height + 1];

            // Fill the DP table with maximum used area for each subproblem
            foreach (var panel in panels)
            {
                for (int width = sheet.Width; width >= panel.Width; width--)
                {
                    for (int height = sheet.Height; height >= panel.Height; height--)
                    {
                        // Try to place the panel horizontally
                        int areaWithNewPanelHorizontally = dp[width - panel.Width, height] + panel.Width * panel.Height;
                        if (areaWithNewPanelHorizontally > dp[width, height])
                        {
                            dp[width, height] = areaWithNewPanelHorizontally;
                            fromWidth[width, height] = panel.Width;
                            fromHeight[width, height] = 0;
                        }

                        // Try to place the panel vertically
                        int areaWithNewPanelVertically = dp[width, height - panel.Height] + panel.Width * panel.Height;
                        if (areaWithNewPanelVertically > dp[width, height])
                        {
                            dp[width, height] = areaWithNewPanelVertically;
                            fromWidth[width, height] = 0;
                            fromHeight[width, height] = panel.Height;
                        }
                    }
                }
            }

            // Place panels on the sheet
            int curWidth = sheet.Width;
            int curHeight = sheet.Height;

            while (curWidth > 0 && curHeight > 0)
            {
                if (fromWidth[curWidth, curHeight] > 0)
                {
                    int panelWidth = fromWidth[curWidth, curHeight];
                    sheet.Panels.Add(new GlassPanel
                    {
                        Width = panelWidth,
                        Height = curHeight,
                        PositionX = curWidth - panelWidth,
                        PositionY = 0
                    });
                    curWidth -= panelWidth;
                }
                else if (fromHeight[curWidth, curHeight] > 0)
                {
                    int panelHeight = fromHeight[curWidth, curHeight];
                    sheet.Panels.Add(new GlassPanel
                    {
                        Width = curWidth,
                        Height = panelHeight,
                        PositionX = 0,
                        PositionY = curHeight - panelHeight
                    });
                    curHeight -= panelHeight;
                }
                else
                {
                    break;
                }
            }

            return sheet;
        }
    }
}
