namespace vetsibere
{
    partial class PlayerUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblPlayerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblPlayerName
            // 
            this.LblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblPlayerName.Location = new System.Drawing.Point(3, 0);
            this.LblPlayerName.Name = "LblPlayerName";
            this.LblPlayerName.Size = new System.Drawing.Size(244, 41);
            this.LblPlayerName.TabIndex = 0;
            this.LblPlayerName.Text = "Jméno hráče";
            this.LblPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblPlayerName);
            this.Name = "PlayerUC";
            this.Size = new System.Drawing.Size(250, 350);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblPlayerName;
    }
}
