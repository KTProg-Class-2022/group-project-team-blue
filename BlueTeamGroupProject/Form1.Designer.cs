
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
            this.InvBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.myScreen)).BeginInit();
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
            this.myScreen.BackgroundImage = global::BlueTeamGroupProject.Properties.Resources.UIBase;
            this.myScreen.Location = new System.Drawing.Point(12, 12);
            this.myScreen.Name = "myScreen";
            this.myScreen.Size = new System.Drawing.Size(587, 312);
            this.myScreen.TabIndex = 1;
            this.myScreen.TabStop = false;
            this.myScreen.Click += new System.EventHandler(this.myScreen_Click);
            // 
            // InvBox
            // 
            this.InvBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.InvBox.ForeColor = System.Drawing.Color.Yellow;
            this.InvBox.Location = new System.Drawing.Point(415, 87);
            this.InvBox.Name = "InvBox";
            this.InvBox.Size = new System.Drawing.Size(151, 225);
            this.InvBox.TabIndex = 2;
            this.InvBox.Text = "this is where you type stuff";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlueTeamGroupProject.Properties.Resources.borderBeta;
            this.ClientSize = new System.Drawing.Size(806, 489);
            this.Controls.Add(this.InvBox);
            this.Controls.Add(this.myScreen);
            this.Controls.Add(this.myConsole);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.myScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox myConsole;
        private System.Windows.Forms.PictureBox myScreen;
        private System.Windows.Forms.RichTextBox InvBox;
    }
}

