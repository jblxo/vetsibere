namespace vetsibere
{
    partial class Settings
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
            this.nudPlyrCount = new System.Windows.Forms.NumericUpDown();
            this.lblPlyrCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlyrCount)).BeginInit();
            this.SuspendLayout();
            // 
            // nudPlyrCount
            // 
            this.nudPlyrCount.Location = new System.Drawing.Point(12, 32);
            this.nudPlyrCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPlyrCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudPlyrCount.Name = "nudPlyrCount";
            this.nudPlyrCount.Size = new System.Drawing.Size(120, 20);
            this.nudPlyrCount.TabIndex = 0;
            this.nudPlyrCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudPlyrCount.ValueChanged += new System.EventHandler(this.NudPlyrCount_ValueChanged);
            // 
            // lblPlyrCount
            // 
            this.lblPlyrCount.AutoSize = true;
            this.lblPlyrCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPlyrCount.Location = new System.Drawing.Point(12, 9);
            this.lblPlyrCount.Name = "lblPlyrCount";
            this.lblPlyrCount.Size = new System.Drawing.Size(105, 20);
            this.lblPlyrCount.TabIndex = 1;
            this.lblPlyrCount.Text = "Počet hráčů";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPlyrCount);
            this.Controls.Add(this.nudPlyrCount);
            this.Name = "Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.nudPlyrCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudPlyrCount;
        private System.Windows.Forms.Label lblPlyrCount;
    }
}