using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySimulation
{
    public partial class PerformanceMeasuresTableForm : Form
    {
        Decimal endingInventoryAverage;
        Decimal shortageQuantityAverage;
        public PerformanceMeasuresTableForm()
        {
            InitializeComponent();
        }

        public PerformanceMeasuresTableForm(Decimal endingInventoryAverage, Decimal shortageQuantityAverage)
        {
            this.endingInventoryAverage = endingInventoryAverage;
            this.shortageQuantityAverage = shortageQuantityAverage;
            InitializeComponent();
        }

        private void PerformanceMeasuresTableForm_Load(object sender, EventArgs e)
        {
            endingInventoryAverageLabel.Text = Convert.ToString(endingInventoryAverage);
            shortageQuantityAverageLabel.Text = Convert.ToString(shortageQuantityAverage);
        }
    }
}
