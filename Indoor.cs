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
    public partial class Indoor : Form
    {
        private Cart cartForm;
      

        public Indoor(Cart cartForm)
        {
            InitializeComponent();
            this.cartForm = cartForm;
        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Indoor1 indoor1 = new Indoor1(cartForm); // Pass the Cart instance
            indoor1.Show();


        }

        private void button11_Click(object sender, EventArgs e)
        {
            Indoor2 indoor2 = new Indoor2(cartForm); // Pass the Cart instance
            indoor2.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Indoor3 indoor3 = new Indoor3(cartForm); // Pass the Cart instance
            indoor3.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Outdoor outdoor = new Outdoor(cartForm);
            outdoor.Show();
        }
    }
}
