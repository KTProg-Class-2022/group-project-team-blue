
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
            this.myConsoleOut = new System.Windows.Forms.RichTextBox();
            this.myScreen = new System.Windows.Forms.PictureBox();
            this.myInventory = new System.Windows.Forms.PictureBox();
            this.InvBox = new System.Windows.Forms.RichTextBox();
            this.outputConsole = new System.Windows.Forms.RichTextBox();
            this.RoomBox = new System.Windows.Forms.RichTextBox();
            this.myConsole = new System.Windows.Forms.RichTextBox();
            this.URHere = new System.Windows.Forms.PictureBox();
            this.URWest = new System.Windows.Forms.PictureBox();
            this.URNorth = new System.Windows.Forms.PictureBox();
            this.UREast = new System.Windows.Forms.PictureBox();
            this.URSouth = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.myScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.URHere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.URWest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.URNorth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UREast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.URSouth)).BeginInit();
            this.SuspendLayout();
            // 
            // myConsoleOut
            // 
            this.myConsoleOut.BackColor = System.Drawing.SystemColors.ControlDark;
            this.myConsoleOut.HideSelection = false;
            this.myConsoleOut.Location = new System.Drawing.Point(12, 330);
            this.myConsoleOut.Name = "myConsoleOut";
            this.myConsoleOut.ReadOnly = true;
            this.myConsoleOut.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.myConsoleOut.Size = new System.Drawing.Size(515, 100);
            this.myConsoleOut.TabIndex = 0;
            this.myConsoleOut.Text = "";
            this.myConsoleOut.TextChanged += new System.EventHandler(this.myConsole_TextChanged);
            this.myConsoleOut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.myConsole_KeyDown);
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
            this.InvBox.ReadOnly = true;
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
            this.outputConsole.ReadOnly = true;
            this.outputConsole.Size = new System.Drawing.Size(275, 147);
            this.outputConsole.TabIndex = 4;
            this.outputConsole.Text = "";
            // 
            // RoomBox
            // 
            this.RoomBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.RoomBox.ForeColor = System.Drawing.Color.Red;
            this.RoomBox.Location = new System.Drawing.Point(565, 182);
            this.RoomBox.Name = "RoomBox";
            this.RoomBox.ReadOnly = true;
            this.RoomBox.Size = new System.Drawing.Size(232, 132);
            this.RoomBox.TabIndex = 5;
            this.RoomBox.Text = "";
            // 
            // myConsole
            // 
            this.myConsole.Location = new System.Drawing.Point(12, 428);
            this.myConsole.Name = "myConsole";
            this.myConsole.Size = new System.Drawing.Size(515, 49);
            this.myConsole.TabIndex = 6;
            this.myConsole.Text = "";
            this.myConsole.KeyDown += new System.Windows.Forms.KeyEventHandler(this.myConsole_KeyDown_1);
            // 
            // URHere
            // 
            this.URHere.BackColor = System.Drawing.Color.Maroon;
            this.URHere.Location = new System.Drawing.Point(442, 52);
            this.URHere.Name = "URHere";
            this.URHere.Size = new System.Drawing.Size(41, 24);
            this.URHere.TabIndex = 7;
            this.URHere.TabStop = false;
            // 
            // URWest
            // 
            this.URWest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.URWest.Location = new System.Drawing.Point(395, 52);
            this.URWest.Name = "URWest";
            this.URWest.Size = new System.Drawing.Size(41, 24);
            this.URWest.TabIndex = 8;
            this.URWest.TabStop = false;
            this.URWest.Visible = false;
            // 
            // URNorth
            // 
            this.URNorth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.URNorth.Location = new System.Drawing.Point(442, 22);
            this.URNorth.Name = "URNorth";
            this.URNorth.Size = new System.Drawing.Size(41, 24);
            this.URNorth.TabIndex = 9;
            this.URNorth.TabStop = false;
            this.URNorth.Visible = false;
            // 
            // UREast
            // 
            this.UREast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UREast.Location = new System.Drawing.Point(489, 52);
            this.UREast.Name = "UREast";
            this.UREast.Size = new System.Drawing.Size(41, 24);
            this.UREast.TabIndex = 10;
            this.UREast.TabStop = false;
            this.UREast.Visible = false;
            // 
            // URSouth
            // 
            this.URSouth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.URSouth.Location = new System.Drawing.Point(442, 82);
            this.URSouth.Name = "URSouth";
            this.URSouth.Size = new System.Drawing.Size(41, 24);
            this.URSouth.TabIndex = 11;
            this.URSouth.TabStop = false;
            this.URSouth.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::BlueTeamGroupProject.Properties.Resources.borderBeta1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 489);
            this.Controls.Add(this.URSouth);
            this.Controls.Add(this.UREast);
            this.Controls.Add(this.URNorth);
            this.Controls.Add(this.URWest);
            this.Controls.Add(this.URHere);
            this.Controls.Add(this.myConsole);
            this.Controls.Add(this.RoomBox);
            this.Controls.Add(this.outputConsole);
            this.Controls.Add(this.InvBox);
            this.Controls.Add(this.myInventory);
            this.Controls.Add(this.myScreen);
            this.Controls.Add(this.myConsoleOut);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.myScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.URHere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.URWest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.URNorth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UREast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.URSouth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox myConsoleOut;
        private System.Windows.Forms.PictureBox myScreen;
        private System.Windows.Forms.PictureBox myInventory;
        private System.Windows.Forms.RichTextBox InvBox;
        private System.Windows.Forms.RichTextBox outputConsole;
        private System.Windows.Forms.RichTextBox RoomBox;
        private System.Windows.Forms.RichTextBox myConsole;
        private System.Windows.Forms.PictureBox URHere;
        private System.Windows.Forms.PictureBox URWest;
        private System.Windows.Forms.PictureBox URNorth;
        private System.Windows.Forms.PictureBox UREast;
        private System.Windows.Forms.PictureBox URSouth;
    }
}

