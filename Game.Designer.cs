﻿namespace vetsibere
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
            this.SuspendLayout();
            // 
            // gameField
            // 
            this.gameField.Location = new System.Drawing.Point(2, 1);
            this.gameField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gameField.Name = "gameField";
            this.gameField.Size = new System.Drawing.Size(815, 382);
            this.gameField.TabIndex = 0;
            // 
            // BtnRound
            // 
            this.BtnRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnRound.Location = new System.Drawing.Point(360, 388);
            this.BtnRound.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnRound.Name = "BtnRound";
            this.BtnRound.Size = new System.Drawing.Size(111, 33);
            this.BtnRound.TabIndex = 1;
            this.BtnRound.Text = "Zahraj kolo";
            this.BtnRound.UseVisualStyleBackColor = true;
            this.BtnRound.Click += new System.EventHandler(this.BtnRound_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 465);
            this.Controls.Add(this.BtnRound);
            this.Controls.Add(this.gameField);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel gameField;
        private System.Windows.Forms.Button BtnRound;
    }
}