using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Graphs
{
    public class GraphControl : Control
    {
        private List<int> dataPoints = new List<int>();

        public GraphControl()
        {
            this.DoubleBuffered = true;
        }

        public void AddDataPoint(int dataPoint)
        {
            dataPoints.Add(dataPoint);
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            int barWidth = 30;
            int spacing = 10;
            int startX = 25;

            int maxValue = dataPoints.Count > 0 ? Math.Abs(dataPoints[0]) : 0;
            foreach (int value in dataPoints)
            {
                if (Math.Abs(value) > maxValue)
                {
                    maxValue = Math.Abs(value);
                }
            }

            // Set a scale factor for the Y axis based on the maximum value
            float scaleFactor = (this.Height - 30) / (float)maxValue; // Adjust the graph size based on the control's height

            // Draw the Y-axis
            g.DrawLine(Pens.Black, 30, 0, 30, this.Height); // Y-axis line

            // Draw the X-axis
            g.DrawLine(Pens.Black, 0, this.Height - 20, this.Width, this.Height - 20); // X-axis line

            // Loop through the data points and draw the bars
            for (int i = 0; i < dataPoints.Count; i++)
            {
                int value = dataPoints[i];
                int barHeight = (int)(Math.Abs(value) * scaleFactor); 

                Color barColor = value > 0 ? Color.Green : Color.Red; // Green for positive, Red for negative
                Brush brush = new SolidBrush(barColor);
                g.FillRectangle(brush, startX + i * (barWidth + spacing), this.Height - barHeight - 20, barWidth, barHeight);

                g.DrawString(i.ToString(), this.Font, Brushes.Black, startX + i * (barWidth + spacing), this.Height - 15);

                //BONUS//
                int labelY = value < 0 ? this.Height - 30 - barHeight - 15 : this.Height - 25; // Position the label above for negative bars, below for positive bars
                g.DrawString(i.ToString(), this.Font, Brushes.Black, startX + i * (barWidth + spacing) + (barWidth / 4), labelY); 
            }

            DrawLegend(g);
        }
        private void DrawLegend(Graphics g)
        {
            int legendX = 50; 
            int legendY = this.Height - 70; 
            int boxSize = 20;  

            g.FillRectangle(new SolidBrush(Color.Green), legendX, legendY, boxSize, boxSize); // Green box
            g.DrawString("Positive", this.Font, Brushes.Black, legendX + boxSize + 5, legendY); // Label for Positive

            g.FillRectangle(new SolidBrush(Color.Red), legendX, legendY + boxSize + 5, boxSize, boxSize); // Red box
            g.DrawString("Negative", this.Font, Brushes.Black, legendX + boxSize + 5, legendY + boxSize + 5); // Label for Negative
        }
        //BONUS//

    }
}
