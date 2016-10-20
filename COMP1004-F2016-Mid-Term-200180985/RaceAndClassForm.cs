/// Author: Tom Tsiliopolis, Mark Chipp
/// Date: 20-Oct-2016
/// File: RaceAndClassForm.cs
/// Purpose: This form lets the user selecte race and class attributes
 
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

namespace COMP1004_F2016_Mid_Term_200180985
{
    public partial class RaceAndClassForm : Form
    {
        public AbilityGeneratorForm previousForm;
        private string _selectedRace;


        public RaceAndClassForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            character.Race = this._selectedRace;

            // Step 1 - show the parent form
            this.previousForm.Show();

            // Step 2 - close this form
            this.Close();
        }

        private void RaceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRace = (RadioButton)sender;

            this._selectedRace = selectedRace.Text;

            Program.character.Race = this._selectedRace;

            // set the race image based on selected race
            if(_selectedRace == "Human")
            {
                RacePictureBox.BackgroundImage = Properties.Resources.Human_Male;
            }
            else if(_selectedRace == "Elf")
            {
                RacePictureBox.BackgroundImage = Properties.Resources.Elf_Male;
            }
            else if (_selectedRace == "Dwarf")
            {
                RacePictureBox.BackgroundImage = Properties.Resources.Dwarf_Male;
            }
            else if (_selectedRace == "Halfling")
            {
                RacePictureBox.BackgroundImage = Properties.Resources.Halfling_Male;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.character.Race = this._selectedRace;

            FinalForm finalForm = new FinalForm();
            finalForm.previousForm = this;

            finalForm.Show();
            this.Hide();
        }

        private void RaceAndClassForm_Load(object sender, EventArgs e)
        {
            this._selectedRace = "Human";
        }
    }
}
