using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* <summary>
 Student Name: MANSI MEHINDRU
 Student Number: 301108725
 Description: This is the Splash form, It shows the Splash Screen for the Dollar Computer                        
 </summary> */

namespace Assignment5_DollarComputers.Views
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is event handler for splash form load event
        /// </summary>
        /// <mm name="sender"></mm>
        /// <mm name="e"></mm>
        private void SplashForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }
        /// <summary>
        /// this is the event handler for the splash timer tick event.
        /// </summary>
        /// <mm name="sender"></mm>
        /// <mm name="e"></mm>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            //SplashTimer.Enabled = false;
            //Program.Views.StartForm.Show();
            //this.Hide();
            
            StartForm startForm = new StartForm();
            startForm.Show();
            SplashTimer.Enabled = false;
            this.Hide();
        }

        private void WelcomeImageLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
