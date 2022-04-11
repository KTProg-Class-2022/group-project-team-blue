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
        Character Player = new Character("Player Inventory");
        Character Enemy = new Character("Enemy Inventory");
        Room start = new Room(Room.RoomType.Normal, "Start", new List<object>(), "Its a bouncy Castle");
        
        public Form1()
        {
            InitializeComponent();
            actionList.Add("USE", getUseAction);
            actionList.Add("ATTACK", startcombat);
            actionList.Add("SELECT", SelectEnemy);
            Room secondRoom = new Room(Room.RoomType.Normal, "Second", new List<object>(), "This is the second room");
            start.addExit(Locations.Direction.North, secondRoom);
            

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

            Player.inv.addStuff(testItem);
            Player.inv.addStuff(BouncyBall);
            Player.inv.addStuff(MangoMace);

            Enemy.inv.addStuff(testWeapon);

            InvBox.Text = string.Join(", ", Player.inv.getStuff());
            
            myConsoleOut.AppendText("There is a Weapon on the ground. Will you Pick it up? (type 'GRAB' to pick it up)\n");

        }
        private void myConsole_KeyDown(object sender, KeyEventArgs e)
        {

           
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
            
            if(weapon.Length <= 1)
            {
                return 0;
            }
            string selection = string.Join(" ", weapon.Skip(1));
            myConsoleOut.AppendText("Wow thats a weapon!");
            myConsoleOut.AppendText("You Chose: " + selection);
            foreach(object obj in Player.inv.getStuff())
            {
                if (obj is Weapon)
                {
                    Weapon wep = obj as Weapon;
                    Console.WriteLine(wep.Name);
                    if (wep.Name.ToUpper() == selection.ToUpper())
                    {
                        outputConsole.AppendText("\n" + wep.Name);
                    }
                }
                if(obj is Item)
                {
                    Item item = obj as Item;
                    Console.WriteLine(item.Name);
                    if (item.Name.ToUpper() == selection.ToUpper())
                    {
                        outputConsole.AppendText("\n" + item.Name);
                    }
                }
            }
            return (true);
        }
        private System.Object startcombat(string[] weapon, string[] enemy)
        {




            return null;
        }
        private System.Object getAttackAction(string[] weapon)
        {

            if (weapon.Length <= 1)
            {
                return 0;
            }
            string selection = string.Join(" ", weapon.Skip(1));
            foreach (object obj in Player.inv.getStuff())
            {
                if (obj is Weapon)
                {
                    Weapon wep = obj as Weapon;
                    Console.WriteLine(wep.Name);
                    if (wep.Name.ToUpper() == selection.ToUpper())
                    {
                        outputConsole.AppendText("\n" + wep.Name);
                    }
                }
                if (obj is Item)
                {
                    Item item = obj as Item;
                    Console.WriteLine(item.Name);
                    if (item.Name.ToUpper() == selection.ToUpper())
                    {
                        outputConsole.AppendText("\n" + item.Name);
                    }
                }
            }
            if (enemy[1] == "")
            {
                myConsoleOut.AppendText("You Swing your " + selection + " But wait... Who are you attacking?! \n");
            }
            else
            {
                SelectEnemy(enemy);
            }
            return (true);
        }

        private System.Object SelectEnemy(string[] selected)
        {
            if (selected[1] == "Enemy")
            {
                myConsoleOut.AppendText("You swing your weapon at the " + selected[1] + " and defeat it!!! your prize is a smile :3 \n");
            }
            else
            {
                myConsoleOut.AppendText("im sorry, WHO did you select? \n");
            }

            return null;
        }
            private void myConsole_KeyDown_1(object sender, KeyEventArgs e)
        {
            Result testResult = new Result();
            Result[] groupOfResults = { testResult };
            Result[][] doubleGroupingResults = { groupOfResults };
            if (e.KeyData == Keys.Enter && myConsole.Text != "")
            {
               
                sendCommand(myConsole.Text.Split(' '));
                Weapon GODSTICK = new Weapon("Holy Stick of Sticks!!!!", groupOfResults);
                Player.inv.addStuff(GODSTICK);
                InvBox.Text = string.Join("\n", Player.inv.getStuff());

                Console.WriteLine("Enter Pressed");
                myConsoleOut.AppendText(myConsole.Text + '\n');
               
                myConsole.Text = "";
                e.Handled = true;

            }
            

        }
    }
}
