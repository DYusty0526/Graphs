using System;
using System.Windows.Forms;

namespace Graphs
{
    public partial class Form1 : Form
    {
        private GraphControl GraphControl;

        public Form1()
        {
            InitializeComponent();

            barGraph = new GraphControl
            {
                Location = new System.Drawing.Point(50, 50),
                Size = new System.Drawing.Size(400, 300)
            };
            Controls.Add(bargraph);

            btn_AddDataPoint.Click += btn_AddDataPoint_Click;
        }
        private void btn_AddDataPoint_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_DataPoint.Text, out int dataPoint))
            {
                barGraph.AddDataPoint(dataPoint); 
                txt_DataPoint.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }
    }
}
