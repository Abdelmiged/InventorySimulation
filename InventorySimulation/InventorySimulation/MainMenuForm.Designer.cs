
namespace InventorySimulation
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.orderUpToLabel = new System.Windows.Forms.Label();
            this.reviewPeriodLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startOrderQuantityLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startInventoryQuantityLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.startLeadDaysLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numberOfDaysLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.demandDistributionTableButton = new System.Windows.Forms.Button();
            this.leadDaysDistributionTableButton = new System.Windows.Forms.Button();
            this.performanceMeasuresTableButton = new System.Windows.Forms.Button();
            this.simulationTableButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.beginButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.systemNotificationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(32, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Up To";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // orderUpToLabel
            // 
            this.orderUpToLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orderUpToLabel.Location = new System.Drawing.Point(226, 53);
            this.orderUpToLabel.MaximumSize = new System.Drawing.Size(140, 25);
            this.orderUpToLabel.MinimumSize = new System.Drawing.Size(140, 25);
            this.orderUpToLabel.Name = "orderUpToLabel";
            this.orderUpToLabel.Size = new System.Drawing.Size(140, 25);
            this.orderUpToLabel.TabIndex = 1;
            this.orderUpToLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reviewPeriodLabel
            // 
            this.reviewPeriodLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reviewPeriodLabel.Location = new System.Drawing.Point(226, 105);
            this.reviewPeriodLabel.MaximumSize = new System.Drawing.Size(140, 25);
            this.reviewPeriodLabel.MinimumSize = new System.Drawing.Size(140, 25);
            this.reviewPeriodLabel.Name = "reviewPeriodLabel";
            this.reviewPeriodLabel.Size = new System.Drawing.Size(140, 25);
            this.reviewPeriodLabel.TabIndex = 3;
            this.reviewPeriodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(32, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Review Period";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // startOrderQuantityLabel
            // 
            this.startOrderQuantityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startOrderQuantityLabel.Location = new System.Drawing.Point(226, 260);
            this.startOrderQuantityLabel.MaximumSize = new System.Drawing.Size(140, 25);
            this.startOrderQuantityLabel.MinimumSize = new System.Drawing.Size(140, 25);
            this.startOrderQuantityLabel.Name = "startOrderQuantityLabel";
            this.startOrderQuantityLabel.Size = new System.Drawing.Size(140, 25);
            this.startOrderQuantityLabel.TabIndex = 7;
            this.startOrderQuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(32, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start Order Quantity";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // startInventoryQuantityLabel
            // 
            this.startInventoryQuantityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startInventoryQuantityLabel.Location = new System.Drawing.Point(226, 208);
            this.startInventoryQuantityLabel.MaximumSize = new System.Drawing.Size(140, 25);
            this.startInventoryQuantityLabel.MinimumSize = new System.Drawing.Size(140, 25);
            this.startInventoryQuantityLabel.Name = "startInventoryQuantityLabel";
            this.startInventoryQuantityLabel.Size = new System.Drawing.Size(140, 25);
            this.startInventoryQuantityLabel.TabIndex = 5;
            this.startInventoryQuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(32, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Start Inventory Quantity";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // startLeadDaysLabel
            // 
            this.startLeadDaysLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startLeadDaysLabel.Location = new System.Drawing.Point(226, 153);
            this.startLeadDaysLabel.MaximumSize = new System.Drawing.Size(140, 25);
            this.startLeadDaysLabel.MinimumSize = new System.Drawing.Size(140, 25);
            this.startLeadDaysLabel.Name = "startLeadDaysLabel";
            this.startLeadDaysLabel.Size = new System.Drawing.Size(140, 25);
            this.startLeadDaysLabel.TabIndex = 9;
            this.startLeadDaysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(32, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Start Lead Days";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numberOfDaysLabel
            // 
            this.numberOfDaysLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberOfDaysLabel.Location = new System.Drawing.Point(226, 311);
            this.numberOfDaysLabel.MaximumSize = new System.Drawing.Size(140, 25);
            this.numberOfDaysLabel.MinimumSize = new System.Drawing.Size(140, 25);
            this.numberOfDaysLabel.Name = "numberOfDaysLabel";
            this.numberOfDaysLabel.Size = new System.Drawing.Size(140, 25);
            this.numberOfDaysLabel.TabIndex = 11;
            this.numberOfDaysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(32, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Number of Days";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // demandDistributionTableButton
            // 
            this.demandDistributionTableButton.Location = new System.Drawing.Point(533, 44);
            this.demandDistributionTableButton.Name = "demandDistributionTableButton";
            this.demandDistributionTableButton.Size = new System.Drawing.Size(211, 60);
            this.demandDistributionTableButton.TabIndex = 12;
            this.demandDistributionTableButton.Text = "Demand Distribution Table";
            this.demandDistributionTableButton.UseVisualStyleBackColor = true;
            this.demandDistributionTableButton.Click += new System.EventHandler(this.demandDistributionTableButton_Click);
            // 
            // leadDaysDistributionTableButton
            // 
            this.leadDaysDistributionTableButton.Location = new System.Drawing.Point(533, 125);
            this.leadDaysDistributionTableButton.Name = "leadDaysDistributionTableButton";
            this.leadDaysDistributionTableButton.Size = new System.Drawing.Size(211, 60);
            this.leadDaysDistributionTableButton.TabIndex = 13;
            this.leadDaysDistributionTableButton.Text = "Lead Days Distribution Table";
            this.leadDaysDistributionTableButton.UseVisualStyleBackColor = true;
            this.leadDaysDistributionTableButton.Click += new System.EventHandler(this.leadDaysDistributionTableButton_Click);
            // 
            // performanceMeasuresTableButton
            // 
            this.performanceMeasuresTableButton.Location = new System.Drawing.Point(533, 280);
            this.performanceMeasuresTableButton.Name = "performanceMeasuresTableButton";
            this.performanceMeasuresTableButton.Size = new System.Drawing.Size(211, 60);
            this.performanceMeasuresTableButton.TabIndex = 15;
            this.performanceMeasuresTableButton.Text = "Performance Measures Table";
            this.performanceMeasuresTableButton.UseVisualStyleBackColor = true;
            this.performanceMeasuresTableButton.Click += new System.EventHandler(this.performanceMeasuresTableButton_Click);
            // 
            // simulationTableButton
            // 
            this.simulationTableButton.Location = new System.Drawing.Point(533, 199);
            this.simulationTableButton.Name = "simulationTableButton";
            this.simulationTableButton.Size = new System.Drawing.Size(211, 60);
            this.simulationTableButton.TabIndex = 14;
            this.simulationTableButton.Text = "Simulation Table";
            this.simulationTableButton.UseVisualStyleBackColor = true;
            this.simulationTableButton.Click += new System.EventHandler(this.simulationTableButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(533, 396);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(100, 42);
            this.browseButton.TabIndex = 16;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // beginButton
            // 
            this.beginButton.Location = new System.Drawing.Point(644, 396);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(100, 42);
            this.beginButton.TabIndex = 17;
            this.beginButton.Text = "Begin";
            this.beginButton.UseVisualStyleBackColor = true;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // systemNotificationLabel
            // 
            this.systemNotificationLabel.AutoSize = true;
            this.systemNotificationLabel.Location = new System.Drawing.Point(32, 409);
            this.systemNotificationLabel.MaximumSize = new System.Drawing.Size(250, 20);
            this.systemNotificationLabel.MinimumSize = new System.Drawing.Size(250, 20);
            this.systemNotificationLabel.Name = "systemNotificationLabel";
            this.systemNotificationLabel.Size = new System.Drawing.Size(250, 20);
            this.systemNotificationLabel.TabIndex = 18;
            this.systemNotificationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.systemNotificationLabel);
            this.Controls.Add(this.beginButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.performanceMeasuresTableButton);
            this.Controls.Add(this.simulationTableButton);
            this.Controls.Add(this.leadDaysDistributionTableButton);
            this.Controls.Add(this.demandDistributionTableButton);
            this.Controls.Add(this.numberOfDaysLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.startLeadDaysLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.startOrderQuantityLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startInventoryQuantityLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.reviewPeriodLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.orderUpToLabel);
            this.Controls.Add(this.label1);
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label orderUpToLabel;
        private System.Windows.Forms.Label reviewPeriodLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label startOrderQuantityLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label startInventoryQuantityLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label startLeadDaysLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label numberOfDaysLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button demandDistributionTableButton;
        private System.Windows.Forms.Button leadDaysDistributionTableButton;
        private System.Windows.Forms.Button performanceMeasuresTableButton;
        private System.Windows.Forms.Button simulationTableButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label systemNotificationLabel;
    }
}