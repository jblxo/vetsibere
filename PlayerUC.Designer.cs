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
            this.lblCardsLeft = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblPlayerName
            // 
            this.LblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblPlayerName.Location = new System.Drawing.Point(0, 0);
            this.LblPlayerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPlayerName.Name = "LblPlayerName";
            this.LblPlayerName.Size = new System.Drawing.Size(150, 27);
            this.LblPlayerName.TabIndex = 0;
            this.LblPlayerName.Text = "Jméno hráče";
            this.LblPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCardsLeft
            // 
            this.lblCardsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCardsLeft.Location = new System.Drawing.Point(-2, 43);
            this.lblCardsLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCardsLeft.Name = "lblCardsLeft";
            this.lblCardsLeft.Size = new System.Drawing.Size(150, 27);
            this.lblCardsLeft.TabIndex = 1;
            this.lblCardsLeft.Text = "cardsLeft";
            this.lblCardsLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCardsLeft);
            this.Controls.Add(this.LblPlayerName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PlayerUC";
            this.Size = new System.Drawing.Size(150, 70);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblPlayerName;
        private System.Windows.Forms.Label lblCardsLeft;
    }
}
