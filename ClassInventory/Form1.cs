﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassInventory
{
    public partial class Form1 : Form
    {
        // TODO - create a List to store all inventory objects
        List<TeamData> data = new List<TeamData>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // TODO - gather all information from screen 
            string name = nameInput.Text;
            int age = Convert.ToInt32(ageInput.Text);
            string team = teamInput.Text;
            string position = positionInput.Text;
            // TODO - create object with gathered information
            TeamData tempData = new TeamData(age, name, team, position);
            // TODO - add object to global list
            data.Add(tempData);
            // TODO - display message to indicate addition made
            outputLabel.Text = $"{name} Added To The Database Of Champions";

            nameInput.Text = "";
            ageInput.Text = "";
            teamInput.Text = "";
            positionInput.Text = "";
            
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // This is to be completed in Part II. You will use 
            // Lambda Expressions.
            //---------------------------

            // TODO - if object is in list remove it

            // TODO - display message to indicate deletion made
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // This is to be completed in Part II. You will use 
            // Lambda Expressions.
            //---------------------------
            // TODO - if object entered exists in list show it
            // TODO - else show not found message

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // TODO - show all objects in list. Use a foreach loop.
            outputLabel.Text = "";
            foreach (TeamData d in data)
            {
                outputLabel.Text += $"{d.name}, {d.age}, {d.team}, {d.position}\n";
            }
        }
    }
}
