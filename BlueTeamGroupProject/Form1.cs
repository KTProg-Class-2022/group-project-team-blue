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
            actionList.Add("Use", getUseAction);

        }
        public Dictionary<string, Func<string[],  System.Object>> actionList = new Dictionary<string, Func<string[], System.Object>>();
        Inventory testInv = new Inventory("Player Inventory");
        private void myScreen_Click(object sender, EventArgs e)
        {

            Result testResult = new Result();
            Result[] groupOfResults = { testResult };
            Result[][] doubleGroupingResults = { groupOfResults };
            Console.WriteLine(testResult.Duration);
            Weapon testWeapon = new Weapon("Sword", groupOfResults);
            Item testItem = new Item("Glass", "it is a piece of glass", new string[] { "Attack" }, doubleGroupingResults);
            testInv.addStuff(testItem);
            testInv.addStuff(testWeapon);
            
        }

        private void myConsole_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                Console.WriteLine("You Pressed Enter!");
                sendCommand(myConsole.Text.Split(' '));
                myConsole.Text = "";
                e.SuppressKeyPress = true;
            }
        }
        private void sendCommand(string[] input)
        {
            string command = input[0];
            foreach(string Action in actionList.Keys)
            {
                Console.WriteLine("Action: " + Action);
                Console.WriteLine("Your Command: " + command);
                if(command == Action)
                {
                    Console.WriteLine("Command Matches Action");
                    actionList[Action](input);
                }
            }
        }
        private void myConsole_TextChanged(object sender, EventArgs e)
        {

        }
        private System.Object getUseAction(string[] weapon)
        {
            Console.WriteLine("Wow thats a weapon!");
            Console.WriteLine("You Chose: " + weapon[1]);
            foreach(object obj in testInv.getStuff())
            {
                if (obj is Weapon)
                {
                    Weapon wep = obj as Weapon;
                    Console.WriteLine(wep.Name);
                    if (wep.Name == weapon[1])
                    {
                        outputConsole.Text += "\n" + wep.Name;
                    }
                }
            }


            return (true);
        }
    }
}
