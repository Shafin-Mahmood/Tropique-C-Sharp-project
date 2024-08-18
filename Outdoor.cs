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
    public partial class Outdoor : Form
    {
        private Cart cartForm;
        public Outdoor(Cart cartForm)
        {
            InitializeComponent();
            this.cartForm = cartForm;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Outdoor1 outdoor1 = new Outdoor1(cartForm); 
            outdoor1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Outdoor2 outdoor2 = new Outdoor2(cartForm);
            outdoor2.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Outdoor3 outdoor3 = new Outdoor3(cartForm);
            outdoor3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Indoor indoor = new Indoor(cartForm);
            indoor.Show();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            cartForm.Show();
        }
    }
}
