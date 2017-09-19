using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ticketing
{
    public partial class TicketsForm : Form
    {
        TicketPrice mTicketPrice;
        int mSection = 2;
        int mQuantity = 0;
        bool mDiscount = false;

        public TicketsForm()
        {
            InitializeComponent();
        }

        private void TicketsForm_Load(object sender, EventArgs e)
        {

        }

        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            mQuantity = int.Parse(txtQuantity.Text);

            if (chkDiscount.Checked)
                { mDiscount = true; }

            if (radBalcony.Checked)
                { mSection = 1; }
            if (radGeneral.Checked)
                { mSection = 2; }
            if (radBox.Checked)
                { mSection = 3; }
            if (rbtnBackStall.Checked)
                { mSection = 4; }

            mTicketPrice = new TicketPrice(mSection, mQuantity, checkBoxChild.Checked);

            mTicketPrice.calculatePrice();
            lblAmount.Text = System.Convert.ToString(mTicketPrice.AmountDue);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radGeneral_CheckedChanged(object sender, EventArgs e)
        {
           // txtDiscount.Text = (String)(mTicketPrice.AmountDue - 5.0);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // oops
        }
    }
}
