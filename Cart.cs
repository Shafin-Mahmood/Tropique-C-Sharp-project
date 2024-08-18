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
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }
     
        public void AddToCart(string treeName,string treePrice)
        {
            
            ListBoxCart.Items.Add( treeName + "      -     " + treePrice+"");
           

        }

        private void Cart_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
    }
}
