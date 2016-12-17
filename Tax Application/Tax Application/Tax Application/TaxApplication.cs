using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tax_Application
{
    public partial class TaxApplication : Form
    {
        public TaxApplication()
        {
            InitializeComponent();
        }

        private void TaxCompute_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxPrice.Text) == true)
            {
                MessageBox.Show(" Please enter a valid number");
                textBoxPrice.Text = "";
                return;
            }
            if (string.IsDouble(textBoxPrice.Text))
            {

            }
            double price = double.Parse(textBoxPrice.Text);
            double tax_rate = double.Parse(label2.Text);
            double tax = (0.01 * tax_rate * price);
            double total = (tax + price);
            textBoxTotal.Text = total.ToString();


        }
    }
}
