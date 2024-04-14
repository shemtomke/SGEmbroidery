using SGEmbroidery.Cash_Sale;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGEmbroidery.Invoice
{
    public partial class InvoiceScreen : Form
    {
        FormProperties formProperties = new FormProperties();
        public InvoiceScreen()
        {
            InitializeComponent();

            formProperties.ButtonOnClick(invoiceDashboard);
            formProperties.LoadForm(new Invoice.InvoiceDashboard(), this.mainPanel);

            formProperties.ButtonReset(addInvoiceBtn);
            formProperties.ButtonReset(updateInvoiceBtn);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            formProperties.GoBackToMainPanel(this);
        }

        private void invoiceDashboard_Click(object sender, EventArgs e)
        {
            formProperties.ButtonOnClick(invoiceDashboard);
            formProperties.LoadForm(new Invoice.InvoiceDashboard(), this.mainPanel);

            formProperties.ButtonReset(addInvoiceBtn);
            formProperties.ButtonReset(updateInvoiceBtn);
        }

        private void addInvoiceBtn_Click(object sender, EventArgs e)
        {
            formProperties.ButtonOnClick(addInvoiceBtn);
            formProperties.LoadForm(new Invoice.CreateInvoice(), this.mainPanel);

            formProperties.ButtonReset(updateInvoiceBtn);
            formProperties.ButtonReset(invoiceDashboard);
        }

        private void updateInvoiceBtn_Click(object sender, EventArgs e)
        {
            formProperties.ButtonOnClick(updateInvoiceBtn);
            formProperties.LoadForm(new Invoice.UpdateInvoice(), this.mainPanel);

            formProperties.ButtonReset(addInvoiceBtn);
            formProperties.ButtonReset(invoiceDashboard);
        }
    }
}
