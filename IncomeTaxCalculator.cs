﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculator
{
    public partial class IncomeTaxCalculator : Form
    {
        public IncomeTaxCalculator()
        {
            InitializeComponent();
            
        }
     
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal income = Convert.ToDecimal(txtIncome.Text);
            decimal tax = 0m;
            tax = CalculateTax(income);
            txtTax.Text = tax.ToString(); 
        }

        private decimal CalculateTax(decimal income)
        {
            decimal tax = 0m;
            if (income <= 9225)
                tax = (int)(income * .10m);
            else if (income > 9225 && income <= 37450)
                tax = 922.50m + (int)((income - 9225) * .15m);
            else if (income > 37450 && income <= 90750)
                tax = 5156.25m + (int)((income - 37450) * .25m);
            else if (income > 90750 && income <= 189300)
                tax = 18481.25m + (int)((income - 90750) * .28m);
            else if (income > 189300 && income <= 411500)
                tax = 46075.25m + (int)((income - 189300) * .33m);
            else if (income > 411500 && income <= 413200)
                tax = 119401.25m + (int)((income - 411500) * .35m);
            else if (income > 413200)
                tax = 119996.25m + (int)((income - 413200) * .396m);
            return tax;

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearIncomeTaxOwed(object sender, EventArgs e)
        {
            txtIncome.Text = "";

        }
    }
}
