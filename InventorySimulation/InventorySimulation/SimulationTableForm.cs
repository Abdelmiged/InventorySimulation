using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryModels;

namespace InventorySimulation
{
    public partial class SimulationTableForm : Form
    {
        List<SimulationCase> simulationTable;
        public SimulationTableForm()
        {
            InitializeComponent();
        }

        public SimulationTableForm(List<SimulationCase> simulationTable)
        {
            this.simulationTable = simulationTable;
            InitializeComponent();
        }

        private void SimulationTableForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = simulationTable;
        }
    }
}
