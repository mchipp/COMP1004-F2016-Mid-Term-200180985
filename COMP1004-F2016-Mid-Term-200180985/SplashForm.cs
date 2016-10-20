/// Author: Mark Chipp
/// Date: 20-Oct-2016
/// File: FinalForm.cs
/// Purpose: This form is a basic splash screen

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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashScreenTimer_tick(object sender, EventArgs e)
        {
            // disable the timer (stop it!)
            SplashScreenTimer.Enabled = false;

            // instantiate a new GenerateNameForm
            GenerateNameForm generateNameform = new GenerateNameForm();

            // show the newly instantiated form
            generateNameform.Show();

            // hide this form
            this.Hide();
        }
    }
}
