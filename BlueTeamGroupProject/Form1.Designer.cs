﻿
namespace BlueTeamGroupProject
{
    partial class Form1
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
            this.myConsole = new System.Windows.Forms.RichTextBox();
            this.myScreen = new System.Windows.Forms.PictureBox();
            this.myInventory = new System.Windows.Forms.PictureBox();
            this.InvBox = new System.Windows.Forms.RichTextBox();
            this.outputConsole = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.myScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // myConsole
            // 
            this.myConsole.Location = new System.Drawing.Point(12, 330);
            this.myConsole.Name = "myConsole";
            this.myConsole.Size = new System.Drawing.Size(488, 147);
            this.myConsole.TabIndex = 0;
            this.myConsole.Text = "";
            this.myConsole.TextChanged += new System.EventHandler(this.myConsole_TextChanged);
            this.myConsole.KeyDown += new System.Windows.Forms.KeyEventHandler(this.myConsole_KeyDown);
            // 
            // myScreen
            // 
            this.myScreen.BackgroundImage = global::BlueTeamGroupProject.Properties.Resources.enemyMockup;
            this.myScreen.Location = new System.Drawing.Point(12, 12);
            this.myScreen.Name = "myScreen";
            this.myScreen.Size = new System.Drawing.Size(536, 312);
            this.myScreen.TabIndex = 1;
            this.myScreen.TabStop = false;
            this.myScreen.Click += new System.EventHandler(this.myScreen_Click);
            // 
            // myInventory
            // 
            this.myInventory.BackgroundImage = global::BlueTeamGroupProject.Properties.Resources.inventoryMockUp;
            this.myInventory.Location = new System.Drawing.Point(554, 12);
            this.myInventory.Name = "myInventory";
            this.myInventory.Size = new System.Drawing.Size(254, 312);
            this.myInventory.TabIndex = 2;
            this.myInventory.TabStop = false;
            // 
            // InvBox
            // 
            this.InvBox.Location = new System.Drawing.Point(554, 12);
            this.InvBox.Name = "InvBox";
            this.InvBox.Size = new System.Drawing.Size(254, 161);
            this.InvBox.TabIndex = 3;
            this.InvBox.Text = "";
            // 
            // outputConsole
            // 
            this.outputConsole.BackColor = System.Drawing.SystemColors.InfoText;
            this.outputConsole.ForeColor = System.Drawing.SystemColors.Menu;
            this.outputConsole.Location = new System.Drawing.Point(533, 330);
            this.outputConsole.Name = "outputConsole";
            this.outputConsole.Size = new System.Drawing.Size(275, 147);
            this.outputConsole.TabIndex = 4;
            this.outputConsole.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlueTeamGroupProject.Properties.Resources.borderBeta1;
            this.ClientSize = new System.Drawing.Size(820, 489);
            this.Controls.Add(this.outputConsole);
            this.Controls.Add(this.InvBox);
            this.Controls.Add(this.myInventory);
            this.Controls.Add(this.myScreen);
            this.Controls.Add(this.myConsole);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.myScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox myConsole;
        private System.Windows.Forms.PictureBox myScreen;
        private System.Windows.Forms.PictureBox myInventory;
        private System.Windows.Forms.RichTextBox InvBox;
        private System.Windows.Forms.RichTextBox outputConsole;
    }
}

