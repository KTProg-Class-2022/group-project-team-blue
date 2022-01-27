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
            InvBox.Text = testInv.getValues();
            myConsole.Text = "There is a Weapon on the ground. Will you Pick it up? (type 'GRAB' to pick it up)\n";
            string grab = myConsole.Text;
            if (myConsole.Text.Contains("yes"))
            {
                Weapon GODSTICK = new Weapon("Holy Stick of Sticks!!!!", 1);
                testInv.addStuff(GODSTICK);
            }
            else
            {

            }
        }

        private void itemPickup(KeyEventArgs e)
        {

        }

        private void myConsole_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
