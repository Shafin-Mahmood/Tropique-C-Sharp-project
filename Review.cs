using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tropique
{
    public partial class Review : Form
    {
        public Review()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Review Submitted");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
           Form1 form = new Form1();
            form.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();  
            login.Show();
            MessageBox.Show("Log Out Successful");
        }
    }
}
