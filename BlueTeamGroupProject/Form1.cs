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
            Item testItem = new Item("Glass", new string[]{ "Attack" }, new string[]{ "E-5HEALTH"});
            testInv.addStuff(testItem);
            testInv.addStuff(testWeapon);
            myConsole.Text = testInv.getValues();
        }
    }
}
