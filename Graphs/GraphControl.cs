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
        public List<int> DataPoints { get; set; } = new List<int>();
        public int MaxValue { get; private set; }
        public int MinValue { get; private set; }
        public int BarSpacing { get; set; } = 10;

        private List<Color> BarColors { get; } = new List<Color>
    {
        Color.Blue, Color.Green, Color.Orange, Color.Purple, Color.Red, Color.Yellow
    };

    }
}
