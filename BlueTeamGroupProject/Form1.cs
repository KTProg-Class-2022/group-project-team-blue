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
       

        Room current;
        public Dictionary<string, Func<string[], System.Object>> actionList = new Dictionary<string, Func<string[], System.Object>>();
        Character Player = new Character("Player Inventory");
        Character Enemy = new Character("Enemy Inventory");
        Room start = new Room(Room.RoomType.Normal, "Start", new List<object>(), "Its a bouncy Castle");

        public Form1()
        {
            current = start;
            InitializeComponent();
            actionList.Add("USE", getUseAction);
            actionList.Add("GRAB", getGrabAction);
            actionList.Add("GO", moveHereAction);
            actionList.Add("ATTACK", startcombat);
            actionList.Add("EQUIP", Equiped);
            Room secondRoom = new Room(Room.RoomType.Normal, "Second", new List<object>(), "This is the second room");
            start.addExit(Locations.Direction.North, secondRoom);
            secondRoom.addExit(Locations.Direction.South, start);
            miniMap();
            myConsoleOut.AppendText("Welcome! Click the screen to begin." + '\n');


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
            Result Damage = new Result("Damage", Result.Targets.Enemy, Character.Stats.HP, Player.getDMG(), 1, false);
            Weapon MangoMace = new Weapon("MangoMace", new Result[] { Damage });
            start.ItemList.addStuff(BouncyBall);
            start.ItemList.addStuff(MangoMace);

            Player.inv.addStuff(testItem);
            Player.inv.addStuff(BouncyBall);
            Player.inv.addStuff(MangoMace);

            Enemy.inv.addStuff(testWeapon);

            InvBox.Text = string.Join(", ", Player.inv.getStuff());

            myConsoleOut.AppendText("You are in " + current.Name + '\n');
            myConsoleOut.AppendText(current.ItemList.Name + '\n');

            Console.WriteLine(current.ItemList.getStuff());
            myConsoleOut.AppendText("It's a bedroom." + '\n');
            myConsoleOut.AppendText("The bed is as messy as can be. There's a closet to the right of YOU, and a dresser against the wall." + '\n');
            myConsoleOut.AppendText("The door is to the NORTH." + '\n');


        }
        private void myConsole_KeyDown(object sender, KeyEventArgs e)
        {


        }
        private void sendCommand(string[] input)
        {
            string command = input[0].ToUpper();
            foreach (string Action in actionList.Keys)
            {
                Console.WriteLine("Action: " + Action);
                Console.WriteLine("Your Command: " + command);
                if (command == Action)
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

            if (weapon.Length <= 1)
            {
                return 0;
            }
            string selection = string.Join(" ", weapon.Skip(1));
            myConsoleOut.AppendText("Wow thats a weapon!");
            myConsoleOut.AppendText("You Chose: " + selection);
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
            return (true);
        }
        private System.Object startcombat(string[] input)
        {
            try
            {
                //               Weapon     Enemy
                getAttackAction(input[1], input[2]);
            }
            catch
            {
                myConsoleOut.AppendText("You need to specify what weapon and who you are attacking\n");
            }


            return null;
        }
        private System.Object getAttackAction(string weapon, string enemy)
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
            if (enemy == "")
            {
                myConsoleOut.AppendText("You Swing your " + selection + " But wait... Who are you attacking?! \n");
            }
            else
            {
                SelectEnemy(enemy);
            }
            return (true);
        }
        private System.Object getGrabAction(string[] weapon)
        {
            bool found = false;
            object ect = null;
            if (weapon.Length <= 1)
            {
                return 0;
            }
            string selection = string.Join(" ", weapon.Skip(1));
            Console.WriteLine("You grabbed: " + selection);
            foreach (object obj in current.ItemList.getStuff())
            {
                if (obj is Weapon)
                {
                    Weapon wep = obj as Weapon;
                    if (wep.Name.ToUpper() == selection.ToUpper())
                    {
                        outputConsole.AppendText("\n" + "You got the: " + wep.Name);
                        Player.inv.addStuff(wep);
                        ect = wep;
                        found = true;
                        break;
                    }
                }
                if (obj is Item)
                {
                    Item item = obj as Item;
                    if (item.Name.ToUpper() == selection.ToUpper())
                    {
                        outputConsole.AppendText("\n" + "You got the: " + item.Name);
                        Player.inv.addStuff(item);
                        ect = item;
                        found = true;
                        break;
                    }
                }
            }

            if (found)
            {
                current.ItemList.removeStuff(ect);
            }
            else
            {
                myConsoleOut.AppendText("There's no such item in this room...\n");
            }

            foreach (object obj in Player.inv.getStuff())
            {
                if (obj is Weapon)
                {
                    Weapon wep = obj as Weapon;
                    Console.WriteLine(wep.Name);
                }
                if (obj is Item)
                {
                    Item item = obj as Item;
                    Console.WriteLine(item.Name);
                }
            }


            return (true);
        }

        private System.Object moveHereAction(string[] direction)
        {
            string newdir = string.Join(" ", direction.Skip(1));
            newdir = newdir.ToUpper();

            switch (newdir)
            {
                case ("NORTH"):

                    if (current.getExit(Locations.Direction.North) != null)
                    {
                        current = current.getExit(Locations.Direction.North);

                    }
                    else
                    {
                        myConsoleOut.AppendText("There's a wall that way...\n");
                    }
                    break;

                case ("SOUTH"):
                    if (current.getExit(Locations.Direction.South) != null)
                    {
                        current = current.getExit(Locations.Direction.South);

                    }
                    else
                    {
                        myConsoleOut.AppendText("There's a wall that way...\n");
                    }
                    break;

                case ("WEST"):
                    if (current.getExit(Locations.Direction.West) != null)
                    {
                        current = current.getExit(Locations.Direction.West);

                    }
                    else
                    {
                        myConsoleOut.AppendText("There's a wall that way...\n");
                    }
                    break;

                case ("EAST"):
                    if (current.getExit(Locations.Direction.East) != null)
                    {
                        current = current.getExit(Locations.Direction.East);

                    }
                    else
                    {
                        myConsoleOut.AppendText("There's a wall that way...\n");
                    }
                    break;
            }

            miniMap();

            return (true);
        }
        private System.Object Equiped(string[] weapon)
        {
            Console.WriteLine("equip start");
            int displayedDmg = 0;
            Console.WriteLine(Player.inv.getStuff().Where(element => element is Weapon).Select(element => element = (element as Weapon).Name).FirstOrDefault());
            var chosenWep = Player.inv.getStuff().Where(element => element is Weapon).Where(element => (element as Weapon).Name == string.Join(" ", weapon.Skip(1)));
            Console.WriteLine(weapon);
            if (Player.inv.getStuff().Where(element => element is Weapon).Where(element => (element as Weapon).Name == string.Join(" ", weapon.Skip(1))) != null)
            {
                Console.WriteLine("Found Item!!!");
                Player.Equip((Weapon)(Player.inv.getStuff().Where(element => element is Weapon).Where(element => (element as Weapon).Name == string.Join(" ", weapon.Skip(1)))).FirstOrDefault());


                foreach (Result affect in Player.Equipped.Attack)
                {
                    if(affect.Affected == Character.Stats.HP && affect.Level > 0)
                    {
                        displayedDmg += affect.Level;
                        Player.setDMG(displayedDmg);
                        Console.WriteLine(weapon + "; " + Player.getDMG());
                    }
                }
            }

            return null;
        }
        private System.Object SelectEnemy(string selected)
        {
            if (selected == "Enemy")
            {
                myConsoleOut.AppendText("You swing your weapon at the " + selected + " and dealt " + Player.getDMG() + " and defeated it!!! your prize is a smile :3 \n");
                
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

        private void miniMap()
        {
            if (current.getExit(Locations.Direction.North) != current)
            {
                URNorth.Visible = true;
                mapColor(current.getExit(Locations.Direction.North).Category, URNorth);
            }
            else
            {
                URNorth.Visible = false;
            }

            if (current.getExit(Locations.Direction.South) != current)
            {
                URSouth.Visible = true;
                mapColor(current.getExit(Locations.Direction.South).Category, URSouth);

            } else
            {
                URSouth.Visible = false;    
            }

            if (current.getExit(Locations.Direction.West) != current)
            {
                URWest.Visible = true;
                mapColor(current.getExit(Locations.Direction.West).Category, URWest);

            } else
            {
                URWest.Visible = false;
            }

            if (current.getExit(Locations.Direction.East) != current)
            {
                UREast.Visible = true;
                mapColor(current.getExit(Locations.Direction.East).Category, UREast);


            } else
            {
                UREast.Visible = false;
            }
        }

        static void mapColor(Room.RoomType cat, PictureBox Box)
        {
            switch (cat)
            {
                case Room.RoomType.Static:
                    Box.BackColor = Color.Gray;
                    break;

                case Room.RoomType.Normal:
                    Box.BackColor = Color.LightCoral;
                    break;

                case Room.RoomType.Dungeon:
                    Box.BackColor = Color.DarkGray;
                    break;

                case Room.RoomType.Travel:
                    Box.BackColor = Color.LightBlue;
                    break;

                case Room.RoomType.Combat:
                    Box.BackColor = Color.Red;
                    break;

            }
        }
    }
}