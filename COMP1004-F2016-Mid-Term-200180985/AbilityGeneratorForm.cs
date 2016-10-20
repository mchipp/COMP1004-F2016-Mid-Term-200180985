/// Author: Tom Tsiliopolis, Mark Chipp
/// Date: 20-Oct-2016
/// File: FinalForm.cs
/// Purpose: This form generates the character's abilities

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
    public partial class AbilityGeneratorForm : Form
    {
        // private Instance Object
        private Random _random;



        public AbilityGeneratorForm()
        {
            InitializeComponent();
        }

        private Int32 Roll()
        {
            // create new empty list
            List<Int32> numbers = new List<Int32>();
            int result = 0;

            // roll 4 dice
            for (int count = 0; count < 4; count++)
            {
                int generatedNumber = this._random.Next(0, 6) + 1;
                numbers.Add(generatedNumber);
            }

            // drop the lowest die
            numbers.Remove(numbers.Min());

            // add the numbers to the result

            foreach (int number in numbers)
            {
                result += number;
            }

            // lambda expression equivalent
            //result = numbers.Sum(number => number);

            return result;
        }

        private void GenerateAbilities()
        {
            StrengthTextBox.Text = this.Roll().ToString();
            DexterityTextBox.Text = this.Roll().ToString();
            ConstitutionTextBox.Text = this.Roll().ToString();
            IntelligenceTextBox.Text = this.Roll().ToString();
            WisdomTextBox.Text = this.Roll().ToString();
            CharismaTextBox.Text = this.Roll().ToString();
        }


        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateAbilities();
        }

        private void GeneratorForm_Load(object sender, EventArgs e)
        {
            this._random = new Random(); // initialize random number object

            GenerateAbilities();

        }


        private void NextButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            character.Strength = StrengthTextBox.Text;
            character.Dexterity = DexterityTextBox.Text;
            character.Constitution = ConstitutionTextBox.Text;
            character.Intelligence = IntelligenceTextBox.Text;
            character.Wisdom = WisdomTextBox.Text;
            character.Charisma = CharismaTextBox.Text;

            // Step 1 - Hide the parent form
            this.Hide();

            // Step 2 - Instantiate an object for the form type
            // you are going to next
            RaceAndClassForm raceAndClassForm = new RaceAndClassForm();

            // Step 3 - create a property in the next form that 
            // we will use to point to this form
            // e.g. public AbilityGeneratorForm previousForm;

            // Step 4 - point this form to the parent Form 
            // property in the next form
            raceAndClassForm.previousForm = this;

            // Step 5 - Show the next form
            raceAndClassForm.Show();
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            // set the selected ability to the combobox text value
            String selectedAbility = ModifyAbilityComboBox.Text;

            // this switch will add one point to the selected ability
            switch (selectedAbility)
            {
                case "Strength":
                    StrengthTextBox.Text = (Convert.ToInt32(StrengthTextBox.Text) + 1).ToString();
                    break;
                case "Dexterity":
                    DexterityTextBox.Text = (Convert.ToInt32(DexterityTextBox.Text) + 1).ToString();
                    break;
                case "Constitution":
                    ConstitutionTextBox.Text = (Convert.ToInt32(ConstitutionTextBox.Text) + 1).ToString();
                    break;
                case "Intelligence":
                    IntelligenceTextBox.Text = (Convert.ToInt32(IntelligenceTextBox.Text) + 1).ToString();
                    break;
                case "Wisdom":
                    WisdomTextBox.Text = (Convert.ToInt32(WisdomTextBox.Text) + 1).ToString();
                    break;
                case "Charisma":
                    CharismaTextBox.Text = (Convert.ToInt32(CharismaTextBox.Text) + 1).ToString();
                    break;
                default:
                    Console.WriteLine("Nothing was selected");
                    break;
            }

            // disable the modify button! No godmoding here!
            ModifyButton.Enabled = false;
        }
    }
}
