
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
            ((System.ComponentModel.ISupportInitialize)(this.myScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // myConsole
            // 
            this.myConsole.Location = new System.Drawing.Point(12, 330);
            this.myConsole.Name = "myConsole";
            this.myConsole.Size = new System.Drawing.Size(792, 147);
            this.myConsole.TabIndex = 0;
            this.myConsole.Text = "this is where you type stuff";
            this.myConsole.TextChanged += new System.EventHandler(this.myConsole_TextChanged);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlueTeamGroupProject.Properties.Resources.borderBeta1;
            this.ClientSize = new System.Drawing.Size(820, 489);
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
    }
}

