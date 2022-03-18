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
        public Dictionary<string, Func<string[], System.Object>> actionList = new Dictionary<string, Func<string[], System.Object>>();
        Character PlayInv = new Character("Player Inventory");
        Room basic = new Room(Room.RoomType.Normal, "Basic", new List<object>(), "Its just a room");
        Room start = new Room(Room.RoomType.Normal, "Start", new List<object>(), "Its a bouncy Castle");
        Room secondRoom = new Room(Room.RoomType.Normal, "Second", new List<object>(), "This is the second room");


        public Form1()
        {
            InitializeComponent();
            actionList.Add("USE", getUseAction);
            basic.addExit(Locations.Direction.North, secondRoom);
            secondRoom.addExit(Locations.Direction.South, start);

        }
        
        private void myScreen_Click(object sender, EventArgs e)
        {
            start.ItemList = new Inventory("Start Items");
            


            Result testResult = new Result();
            Result[] groupOfResults = { testResult };
            Result[][] doubleGroupingResults = { groupOfResults };
            Console.WriteLine(testResult.Duration);
            Weapon testWeapon = new Weapon("Sword", groupOfResults);
            Item testItem = new Item("Glass", "a piece of glass", new string[] { "Attack" }, doubleGroupingResults);
            Item BouncyBall = new Item("Bouncy Ball", "A ball that bounces...", new string[] { "Attack" }, doubleGroupingResults);
            Weapon MangoMace = new Weapon("MangoMace", groupOfResults);
            start.ItemList.addStuff(BouncyBall);
            start.ItemList.addStuff(MangoMace);
            
            PlayInv.inv.addStuff(testWeapon);
            PlayInv.inv.addStuff(testItem);
            
            InvBox.Text = string.Join(", ", PlayInv.inv.getStuff());
            
            myConsole.Text = "There is a Weapon on the ground. Will you Pick it up? (type 'GRAB' to pick it up)\n";

        }
        string pastInput = "";
        private void myConsole_KeyDown(object sender, KeyEventArgs e)
        {
            Result testResult = new Result();
            Result[] groupOfResults = { testResult };
            Result[][] doubleGroupingResults = { groupOfResults };
            if (e.KeyData == Keys.Enter)
            {
                pastInput += myConsole.Text.Last();
                sendCommand(pastInput.Split(' '));
                Weapon GODSTICK = new Weapon("Holy Stick of Sticks!!!!", groupOfResults);
                PlayInv.inv.addStuff(GODSTICK);
                InvBox.Text = string.Join("\n", PlayInv.inv.getStuff());

                Console.WriteLine("Enter Pressed");

                pastInput = "";
                e.Handled = true;

            }
            else if (e.KeyData == Keys.R)
            {
                outputConsole.Text += basic.Name;
            }
            else if (e.KeyData == Keys.U)
            {
                basic = start;
            }
            else if (e.KeyData == Keys.K)
            {
                basic = secondRoom;
            }
            else
            {
                if (myConsole.Text != "")
                {
                    pastInput += myConsole.Text.Last();
                }
            }
        }
        private void sendCommand(string[] input)
        {
            string command = input[0].ToUpper();
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
            foreach(object obj in PlayInv.inv.getStuff())
            {
                if (obj is Weapon)
                {
                    Weapon wep = obj as Weapon;
                    Console.WriteLine(wep.Name);
                    if (wep.Name.ToUpper() == weapon[1].ToUpper())
                    {
                        outputConsole.Text += "\n" + wep.Name;
                    }
                }
            }
            return (true);
        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
