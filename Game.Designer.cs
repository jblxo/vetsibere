namespace vetsibere
{
    partial class Game
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
            this.gameField = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnRound = new System.Windows.Forms.Button();
            this.playerUCPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.chckAutoPlay = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // gameField
            // 
            this.gameField.Location = new System.Drawing.Point(2, 1);
            this.gameField.Margin = new System.Windows.Forms.Padding(2);
            this.gameField.Name = "gameField";
            this.gameField.Size = new System.Drawing.Size(1691, 230);
            this.gameField.TabIndex = 0;
            // 
            // BtnRound
            // 
            this.BtnRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnRound.Location = new System.Drawing.Point(360, 388);
            this.BtnRound.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRound.Name = "BtnRound";
            this.BtnRound.Size = new System.Drawing.Size(111, 33);
            this.BtnRound.TabIndex = 1;
            this.BtnRound.Text = "Zahraj kolo";
            this.BtnRound.UseVisualStyleBackColor = true;
            this.BtnRound.Click += new System.EventHandler(this.BtnRound_Click);
            // 
            // playerUCPanel
            // 
            this.playerUCPanel.Location = new System.Drawing.Point(2, 235);
            this.playerUCPanel.Margin = new System.Windows.Forms.Padding(2);
            this.playerUCPanel.Name = "playerUCPanel";
            this.playerUCPanel.Size = new System.Drawing.Size(1691, 70);
            this.playerUCPanel.TabIndex = 1;
            // 
            // chckAutoPlay
            // 
            this.chckAutoPlay.AutoSize = true;
            this.chckAutoPlay.Location = new System.Drawing.Point(476, 398);
            this.chckAutoPlay.Name = "chckAutoPlay";
            this.chckAutoPlay.Size = new System.Drawing.Size(67, 17);
            this.chckAutoPlay.TabIndex = 2;
            this.chckAutoPlay.Text = "Autoplay";
            this.chckAutoPlay.UseVisualStyleBackColor = true;
            this.chckAutoPlay.CheckedChanged += new System.EventHandler(this.ChckAutoPlay_CheckedChanged);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1695, 465);
            this.Controls.Add(this.chckAutoPlay);
            this.Controls.Add(this.playerUCPanel);
            this.Controls.Add(this.BtnRound);
            this.Controls.Add(this.gameField);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel gameField;
        private System.Windows.Forms.Button BtnRound;
        private System.Windows.Forms.FlowLayoutPanel playerUCPanel;
        private System.Windows.Forms.CheckBox chckAutoPlay;
    }
}