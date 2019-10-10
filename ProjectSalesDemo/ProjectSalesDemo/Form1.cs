//Interface, Delagetes, Lambda, String Manipuation 
//Projected Sales GUI code
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSalesDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProjectedSales aProjectedSales = new ProjectedSales();// instantiated class
        bool inputError = false;
        private void CheckInput()
        {
            inputError = false; //initialize
            try
            {
                aProjectedSales.Sales = double.Parse(txtSales.Text);
                aProjectedSales.Percent = double.Parse(txtPercent.Text);
            }
            catch
            {
                MessageBox.Show("Input error", "Error");
                inputError = true;
            }
        }

        private void btnDelegate_Click(object sender, EventArgs e)
        {
            CheckInput();
            if (!inputError)
            {
               txtOutput.Text = aProjectedSales.ToString();
            }
        }

        private void btnLamMethd_Click(object sender, EventArgs e)
        {
            CheckInput();
            if (!inputError)
            {
                txtOutput.Text = aProjectedSales.message();
            }

        }

        private void btnLambda_Click(object sender, EventArgs e)
        {
            CheckInput();
            if (!inputError)
            {
              txtOutput.Text = aProjectedSales.IncreaseResults();
            }

        }

          
        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == string.Empty)
            {
                MessageBox.Show("Input error", "Error");
            }
            else
            {
                txtOutput.Text = aProjectedSales.validateInput(txtNumber.Text);
            }
        }

        private void btnInterface_Click(object sender, EventArgs e)
        {
            double sales = double.Parse(txtSales.Text);
            double percent = double.Parse(txtPercent.Text);
            double increase = aProjectedSales.salesIncrease(sales, percent);
            txtOutput.Text = $"Projected sales {increase:c}";
        }
    }
}
