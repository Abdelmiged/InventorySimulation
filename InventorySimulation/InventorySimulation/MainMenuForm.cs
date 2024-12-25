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
using System.IO;

namespace InventorySimulation
{
    public partial class MainMenuForm : Form
    {
        SimulationSystem system;
        public MainMenuForm()
        {
            InitializeComponent();
        }

        public MainMenuForm(SimulationSystem system)
        {
            this.system = system;
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string textFile = openFileDialog1.FileName;
            string textFileContent = File.ReadAllText(textFile);
            ExtractInputValues.FillData(system, textFileContent);
            SystemNotificationLabelController("");
            DisplayData();
        }

        private void DisplayData()
        {
            orderUpToLabel.Text = Convert.ToString(system.OrderUpTo);
            reviewPeriodLabel.Text = Convert.ToString(system.ReviewPeriod);
            startLeadDaysLabel.Text = Convert.ToString(system.StartLeadDays);
            startInventoryQuantityLabel.Text = Convert.ToString(system.StartInventoryQuantity);
            startOrderQuantityLabel.Text = Convert.ToString(system.StartOrderQuantity);
            numberOfDaysLabel.Text = Convert.ToString(system.NumberOfDays);
        }

        private void demandDistributionTableButton_Click(object sender, EventArgs e)
        {
            if(system.DemandDistribution.Count != 0)
            {
                DemandDistributionTableForm demandDistributionTableForm = new DemandDistributionTableForm(system.DemandDistribution);
                SystemNotificationLabelController("");
                demandDistributionTableForm.Show();
            }
            else
                SystemNotificationLabelController("Please choose a text file!");
        }

        private void leadDaysDistributionTableButton_Click(object sender, EventArgs e)
        {
            if (system.LeadDaysDistribution.Count != 0)
            {
                LeadDaysDistributionTableForm leadDaysDistributionTableForm = new LeadDaysDistributionTableForm(system.LeadDaysDistribution);
                SystemNotificationLabelController("");
                leadDaysDistributionTableForm.Show();
            }
            else
                SystemNotificationLabelController("Please choose a text file!");
        }

        private void SystemNotificationLabelController(string message, string color = "red")
        {
            if (color.ToLower() == "red")
            {
                systemNotificationLabel.ForeColor = Color.Red;
                systemNotificationLabel.Text = message;
            }
            else if (color.ToLower() == "green")
            {
                systemNotificationLabel.ForeColor = Color.Green;
                systemNotificationLabel.Text = message;
            }
        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            Simulation simulator = new Simulation(system);
            if(system.DemandDistribution.Count != 0)
            {
                simulator.BeginSimulation();
                SystemNotificationLabelController("Simulation Done!", "green");
            }
            else
                SystemNotificationLabelController("Please choose a text file!");
        }

        private void simulationTableButton_Click(object sender, EventArgs e)
        {
            if (system.SimulationTable.Count != 0)
            {
                SimulationTableForm simulationTableForm = new SimulationTableForm(system.SimulationTable);
                SystemNotificationLabelController("");
                simulationTableForm.Show();
            }
            else
                SystemNotificationLabelController("Please begin simulation first!");
        }

        private void performanceMeasuresTableButton_Click(object sender, EventArgs e)
        {
            if(system.SimulationTable.Count != 0)
            {
                PerformanceMeasuresTableForm performanceMeasuresTableForm = new PerformanceMeasuresTableForm(system.PerformanceMeasures.EndingInventoryAverage, system.PerformanceMeasures.ShortageQuantityAverage);
                SystemNotificationLabelController("");
                performanceMeasuresTableForm.Show();
            }
            else
                SystemNotificationLabelController("Please begin simulation first!");
        }
    }
}
