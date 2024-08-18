using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tropique
{
    public partial class Form1 : Form
    {
        private Cart cartForm = new Cart();
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Indoor indoor = new Indoor(cartForm); // Pass the same Cart instance
            indoor.Show();
        }

        private void label26_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l= new Login();
            l.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Outdoor outdoor = new Outdoor(cartForm);
            outdoor.Show();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            this.Hide();
            cartForm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();

       
            if (selectedItem == "Monstera Delicosa")
            {
               Indoor1 indoor1=  new Indoor1(cartForm);
                indoor1.Show();
            }
            else if (selectedItem == "Bamboo Plam Plant")
            {
                Indoor3 newForm = new Indoor3(cartForm);
                newForm.Show();  
            }
            else if (selectedItem == "Fiddle Leaf Fig")
            {
                Indoor2 newForm = new Indoor2(cartForm);
                newForm.Show();  // Show Form3
            }
            else if (selectedItem == "Philodendron Melinonii")
            {
                Outdoor1 newForm = new Outdoor1(cartForm);
                newForm.Show();
            }
            else if (selectedItem == "Oral")
            {
               Outdoor2 newForm = new Outdoor2(cartForm);
                newForm.Show();  // Show Form3
            }
            else if (selectedItem == "Rosa")
            {
                Outdoor3 newForm = new Outdoor3(cartForm);
                newForm.Show();  // Show Form3
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            care care= new care();
               care.Show();
        }
    }
    
}
