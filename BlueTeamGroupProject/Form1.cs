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
        
        Player PlayInv = new Player("TestInv");
        
        public Form1()
        {
            InitializeComponent();
            
        }

        public void myScreen_Click(object sender, EventArgs e)
        {
            Weapon testWeapon = new Weapon("Sword", 99);
            Item testItem = new Item("Glass","a piece of glass", new string[]{ "Attack" }, new string[]{ "E-5HEALTH"});
            PlayInv.playerAdd(testWeapon);
            PlayInv.playerAdd(testItem);
            InvBox.Text = PlayInv.playerValue();
            myConsole.Text = "There is a Weapon on the ground. Will you Pick it up? (type 'GRAB' to pick it up)\n";
        }

        private void myConsole_TextChanged(object sender, EventArgs e)
        {

        }

        public void myConsole_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Weapon GODSTICK = new Weapon("Holy Stick of Sticks!!!!", 1);
                PlayInv.playerAdd(GODSTICK);
                InvBox.Text = PlayInv.playerValue();
                myConsole.Text = "You picked up the God Stick!!!";
                Console.WriteLine("Enter Presed");
            }
            else
            {
                Console.WriteLine("Enter Not Presed");
            }
        }
    }
}
