
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
            ((System.ComponentModel.ISupportInitialize)(this.myScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // myConsole
            // 
            this.myConsole.Location = new System.Drawing.Point(12, 309);
            this.myConsole.Name = "myConsole";
            this.myConsole.Size = new System.Drawing.Size(776, 129);
            this.myConsole.TabIndex = 0;
            this.myConsole.Text = "this is where you type stuff";
            // 
            // myScreen
            // 
            this.myScreen.BackgroundImage = global::BlueTeamGroupProject.Properties.Resources.UIBase;
            this.myScreen.Location = new System.Drawing.Point(12, 12);
            this.myScreen.Name = "myScreen";
            this.myScreen.Size = new System.Drawing.Size(776, 291);
            this.myScreen.TabIndex = 1;
            this.myScreen.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

