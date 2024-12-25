
namespace InventorySimulation
{
    partial class PerformanceMeasuresTableForm
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
            this.endingInventoryAverageLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shortageQuantityAverageLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // endingInventoryAverageLabel
            // 
            this.endingInventoryAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endingInventoryAverageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endingInventoryAverageLabel.Location = new System.Drawing.Point(105, 125);
            this.endingInventoryAverageLabel.Name = "endingInventoryAverageLabel";
            this.endingInventoryAverageLabel.Size = new System.Drawing.Size(183, 25);
            this.endingInventoryAverageLabel.TabIndex = 3;
            this.endingInventoryAverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 62);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ending Inventory Average";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shortageQuantityAverageLabel
            // 
            this.shortageQuantityAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shortageQuantityAverageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shortageQuantityAverageLabel.Location = new System.Drawing.Point(506, 125);
            this.shortageQuantityAverageLabel.Name = "shortageQuantityAverageLabel";
            this.shortageQuantityAverageLabel.Size = new System.Drawing.Size(183, 25);
            this.shortageQuantityAverageLabel.TabIndex = 5;
            this.shortageQuantityAverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(501, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 62);
            this.label3.TabIndex = 4;
            this.label3.Text = "Shortage Quantity Average";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PerformanceMeasuresTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 379);
            this.Controls.Add(this.shortageQuantityAverageLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endingInventoryAverageLabel);
            this.Controls.Add(this.label1);
            this.Name = "PerformanceMeasuresTableForm";
            this.Text = "PerformanceMeasuresTableForm";
            this.Load += new System.EventHandler(this.PerformanceMeasuresTableForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label endingInventoryAverageLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label shortageQuantityAverageLabel;
        private System.Windows.Forms.Label label3;
    }
}