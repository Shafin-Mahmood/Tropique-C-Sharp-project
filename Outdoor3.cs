using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tropique
{
    public partial class Outdoor3 : Form
    {
        private Cart cartForm;
        private int count = 1;
        public Outdoor3(Cart cartForm)
        {
            InitializeComponent();
            this.cartForm = cartForm;
            amount.Text = count.ToString();
        }

        private void minbtn_Click(object sender, EventArgs e)
        {
            count--;
            amount.Text = count.ToString();
        }

        private void Plusbtn_Click(object sender, EventArgs e)
        {
            count++;
            amount.Text = count.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            decimal price;
            int quantity;


            if (!decimal.TryParse(lblPrice.Text, out price))
            {
                MessageBox.Show("Invalid price format.");
                return;
            }


            if (!int.TryParse(amount.Text, out quantity))
            {
                MessageBox.Show("Invalid quantity format. Please enter a whole number.");
                return;
            }


            decimal totalPrice = price * quantity;


            Payment paymentForm = new Payment(totalPrice);

            paymentForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string treeName = label17.Text; // Get tree name
            string treePrice = lblPrice.Text; // Get tree price

            cartForm.AddToCart(treeName, treePrice);
            // cartForm.AddToCart("", ""); // Add to Cart
            MessageBox.Show("Your item has been added to the cart.");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            cartForm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Outdoor outdoor = new Outdoor(cartForm);
            outdoor.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
