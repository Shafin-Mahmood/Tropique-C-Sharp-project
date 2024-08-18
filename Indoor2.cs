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
    public partial class Indoor2 : Form
    {
       // public event Action<Indoor2> TreeSelected;
        public Cart cartForm;
        private int count = 1;
        public Indoor2(Cart cartForm)
        {
            InitializeComponent();
            amount.Text = count.ToString();
            this.cartForm = cartForm;
        }

        private void amount_Click(object sender, EventArgs e)
        {

        }

        private void Plusbtn_Click(object sender, EventArgs e)
        {
            count++; 
            amount.Text = count.ToString();
        }

        private void minbtn_Click(object sender, EventArgs e)
        {
            count--; 
            amount.Text = count.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Indoor indoor = new Indoor(cartForm);
            indoor.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            decimal price;
            int quantity;

           
            if (!decimal.TryParse(label13.Text, out price)) 
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
            string treeName = fiddle.Text;
            string treePrice = label13.Text;

            cartForm.AddToCart(treeName, treePrice);
            //ListBox.Items.Add(treeName + " - " + treePrice);
            MessageBox.Show("Your item has been added to the cart.");

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            cartForm.Show();
        }
    }
}
