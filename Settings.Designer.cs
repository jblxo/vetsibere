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
            this.lblPlyrCount = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAutoplayTimer = new System.Windows.Forms.Label();
            this.numUpDownAutTimer = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAutTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlyrCount
            // 
            this.lblPlyrCount.AutoSize = true;
            this.lblPlyrCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPlyrCount.Location = new System.Drawing.Point(16, 11);
            this.lblPlyrCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlyrCount.Name = "lblPlyrCount";
            this.lblPlyrCount.Size = new System.Drawing.Size(127, 25);
            this.lblPlyrCount.TabIndex = 1;
            this.lblPlyrCount.Text = "Počet hráčů";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(21, 71);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(356, 468);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 36);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Přidat hráče";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAutoplayTimer
            // 
            this.lblAutoplayTimer.AutoSize = true;
            this.lblAutoplayTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAutoplayTimer.Location = new System.Drawing.Point(253, 11);
            this.lblAutoplayTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAutoplayTimer.Name = "lblAutoplayTimer";
            this.lblAutoplayTimer.Size = new System.Drawing.Size(137, 25);
            this.lblAutoplayTimer.TabIndex = 4;
            this.lblAutoplayTimer.Text = "Autoplay čas";
            // 
            // numUpDownAutTimer
            // 
            this.numUpDownAutTimer.Location = new System.Drawing.Point(302, 39);
            this.numUpDownAutTimer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownAutTimer.Name = "numUpDownAutTimer";
            this.numUpDownAutTimer.Size = new System.Drawing.Size(58, 22);
            this.numUpDownAutTimer.TabIndex = 5;
            this.numUpDownAutTimer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownAutTimer.ValueChanged += new System.EventHandler(this.numUpDownAutTimer_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(359, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "s";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUpDownAutTimer);
            this.Controls.Add(this.lblAutoplayTimer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblPlyrCount);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAutTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPlyrCount;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblAutoplayTimer;
        private System.Windows.Forms.NumericUpDown numUpDownAutTimer;
        private System.Windows.Forms.Label label1;
    }
}