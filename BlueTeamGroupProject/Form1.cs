using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueTeamGroupProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void myScreen_Click(object sender, EventArgs e)
        {
            Inventory testInv = new Inventory("TestInv");
            Weapon testWeapon = new Weapon("Sword", 99);
            testInv.addItem(testWeapon);
            myConsole.Text = testInv.getValues();
        }
    }
}
