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
 Description: This is the Select form, It shows all the computers with their details.                     
 </summary> */

namespace Assignment5_DollarComputers.Views
{
    public partial class Select : Form
    {
        public Select()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is an event handler for select load event.
        /// </summary>
        /// <mm name="sender"></mm>
        /// <mm name="e"></mm>
        private void Select_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// This is the event handler for Backbutton click event 
        /// </summary>
        /// <mm name="sender"></mm>
        /// <mm name="e"></mm>
        private void button1_Click(object sender, EventArgs e)
        {
            
            Program.startForm.Show();
            this.Hide();
        }
        /// <summary>
        /// This is the event handler for Nextbutton click event 
        /// </summary>
        /// <mm name="sender"></mm>
        /// <mm name="e"></mm>
        private void NextButton_Click(object sender, EventArgs e)
        {
            
            
            Program.productInfo.Show();
            this.Hide();
        }
    }
}
