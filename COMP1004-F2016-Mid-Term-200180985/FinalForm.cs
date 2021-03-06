﻿/// Author: Tom Tsiliopolis, Mark Chipp
/// Date: 20-Oct-2016
/// File: FinalForm.cs
/// Purpose: This form shows the character that we have generated

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace COMP1004_F2016_Mid_Term_200180985
{
    public partial class FinalForm : Form
    {
        public RaceAndClassForm previousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1 - instantiate an object of the AboutBox form
            AboutBox aboutBox = new AboutBox();

            // Step 2 - use the ShowDialog method of the aboutbox
            aboutBox.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FinalForm_Load(object sender, EventArgs e)
        {
            // set the text fields on this form to match the contents of the character class
            StrengthTextBox.Text = Program.character.Strength.ToString();
            DexterityTextBox.Text = Program.character.Dexterity.ToString();
            ConstitutionTextBox.Text = Program.character.Constitution.ToString();
            IntelligenceTextBox.Text = Program.character.Intelligence.ToString();
            WisdomTextBox.Text = Program.character.Wisdom.ToString();
            CharismaTextBox.Text = Program.character.Charisma.ToString();

            FirstNameTextBox.Text = Program.character.FirstName.ToString();
            LastNameTextBox.Text = Program.character.LastName.ToString();
            RaceTextBox.Text = Program.character.Race.ToString();

            // convoluted if statement to set image based on race variable
            // must be a better way, but this makes it happen for now
            if (RaceTextBox.Text == "Human")
            {
                RacePictureBox.BackgroundImage = Properties.Resources.Human_Male;
            }
            else if (RaceTextBox.Text == "Elf")
            {
                RacePictureBox.BackgroundImage = Properties.Resources.Elf_Male;
            }
            else if (RaceTextBox.Text == "Dwarf")
            {
                RacePictureBox.BackgroundImage = Properties.Resources.Dwarf_Male;
            }
            else if (RaceTextBox.Text == "Halfling")
            {
                RacePictureBox.BackgroundImage = Properties.Resources.Halfling_Male;
            }
        }
    }
}
