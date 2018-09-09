using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoicetotal
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        

        private void btnCalcualte_Click(object sender, EventArgs e)
        {
            decimal invoiceSubtotal = Convert.ToDecimal(txtsubtotal.Text); // to get the subtotal value.
            decimal discountPercent = 0m; // defining the discount percent variable.

            /* conditions depending on the subtotal amount the discount is given.*/
            if (invoiceSubtotal >= 500) 
            {
                discountPercent = .2m;
            }
            else if (invoiceSubtotal >= 250 && invoiceSubtotal < 500)
            {
                discountPercent = .15m;
            }
            else if (invoiceSubtotal >= 100 && invoiceSubtotal < 250)
            {
                discountPercent = .1m;
            }
            decimal discountAmount = invoiceSubtotal * discountPercent; // calculate the discount amount.
            decimal invoiceTotal = invoiceSubtotal - discountAmount; // total amount after deduction of discount amount.
            txtDiscountPrercent.Text = discountPercent.ToString("p1"); // display the amount percent.
            txtDiscountAmount.Text = discountAmount.ToString("c"); // display the discount amount.
            txtTotal.Text = invoiceTotal.ToString("c"); // display the final total payable amount.
            txtsubtotal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // to exit application.

        }
    }
}
