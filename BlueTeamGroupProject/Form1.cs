﻿using System;
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
        Room start = new Room(Room.RoomType.Normal, "Start", new List<object>(), "Its a bouncy Castle");
        
        public Form1()
        {
            InitializeComponent();
            actionList.Add("USE", getUseAction);
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
            
            PlayInv.inv.addStuff(testWeapon);
            PlayInv.inv.addStuff(testItem);
            
            InvBox.Text = string.Join(", ", PlayInv.inv.getStuff());
            
            myConsoleOut.Text = "There is a Weapon on the ground. Will you Pick it up? (type 'GRAB' to pick it up)\n";

        }
        string pastInput = "";
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
            Console.WriteLine("Wow thats a weapon!");
            Console.WriteLine("You Chose: " + selection);
            foreach(object obj in PlayInv.inv.getStuff())
            {
                if (obj is Weapon)
                {
                    Weapon wep = obj as Weapon;
                    Console.WriteLine(wep.Name);
                    if (wep.Name.ToUpper() == selection.ToUpper())
                    {
                        outputConsole.Text += "\n" + wep.Name;
                    }
                }
            }


            return (true);
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
                PlayInv.inv.addStuff(GODSTICK);
                InvBox.Text = string.Join("\n", PlayInv.inv.getStuff());

                Console.WriteLine("Enter Pressed");
                myConsoleOut.Text += myConsole.Text + '\n';
               
                myConsole.Text = "";
                e.Handled = true;

            }
            

        }
    }
}
