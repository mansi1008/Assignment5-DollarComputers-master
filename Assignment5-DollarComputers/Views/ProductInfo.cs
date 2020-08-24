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
 Description: This is the Product Info form, It shows the Detailed Information of the selected Computer.      
 </summary> */


namespace Assignment5_DollarComputers.Views
{
    public partial class ProductInfo : Form
    {
        public ProductInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for Nextbutton click event 
        /// </summary>
        /// <mm name="sender"></mm>
        /// <mm name="e"></mm>

        private void NextButton_Click(object sender, EventArgs e)
        {
            
            Program.orderForm.Show();
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
