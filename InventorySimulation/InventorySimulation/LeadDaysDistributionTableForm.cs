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
    public partial class LeadDaysDistributionTableForm : Form
    {
        List<Distribution> distributionTable;
        public LeadDaysDistributionTableForm()
        {
            InitializeComponent();
        }
        public LeadDaysDistributionTableForm(List<Distribution> distributionTable)
        {
            this.distributionTable = distributionTable;
            InitializeComponent();
        }
        private void LeadDaysDistributionTableForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = distributionTable;
        }
    }
}
