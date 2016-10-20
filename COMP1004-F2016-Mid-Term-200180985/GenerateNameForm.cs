/// Author: Mark Chipp
/// Date: 20-Oct-2016
/// File: GenerateNameForm.cs
/// Purpose: This form generates the character name for our character creator

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Mid_Term_200180985
{
    public partial class GenerateNameForm : Form
    {
        // private object for generating random numbers
        private Random _random;

        public GenerateNameForm()
        {
            InitializeComponent();
        }

        // EVENT HANDLERS
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            // calls generate names function
            GenerateNames();
        }



        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            // calls generate names function
            GenerateNames();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            // instantiate a new abilityGeneratorForm
            AbilityGeneratorForm abilityGeneratorForm = new AbilityGeneratorForm();

            // show the new form
            abilityGeneratorForm.Show();

            // hide this form
            this.Hide();
        }

        // FUNCTIONS
        public void GenerateNames()
        {
            this._random = new Random();
            int randomNumber = this._random.Next(1, FirstNameListBox.Items.Count);
            FirstNameListBox.SelectedIndex = randomNumber;
            FirstNameTextBox.Text = FirstNameListBox.Text;

            randomNumber = this._random.Next(1, LastNameListBox.Items.Count);
            LastNameListBox.SelectedIndex = randomNumber;
            LastNameTextBox.Text = LastNameListBox.Text;

            Program.character.FirstName = FirstNameTextBox.Text;
            Program.character.LastName = LastNameTextBox.Text;
        }
    }
}
