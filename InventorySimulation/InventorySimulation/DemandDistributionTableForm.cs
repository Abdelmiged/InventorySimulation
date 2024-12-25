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
    public partial class DemandDistributionTableForm : Form
    {
        List<Distribution> distributionTable;
        public DemandDistributionTableForm()
        {
            InitializeComponent();
        }

        public DemandDistributionTableForm(List<Distribution> distributionTable)
        {
            this.distributionTable = distributionTable;
            InitializeComponent();
        }

        private void DemandDistributionTableForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = distributionTable;
        }
    }
}
