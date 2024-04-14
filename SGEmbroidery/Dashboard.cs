using SGEmbroidery.Cash_Sale;
using SGEmbroidery.DeliveryNote;
using SGEmbroidery.Invoice;
using SGEmbroidery.Progress;
using SGEmbroidery.Quotation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGEmbroidery
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TheInventory inventory = new TheInventory();
            inventory.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DeliveryScreen deliveryScreen = new DeliveryScreen();
            deliveryScreen.Show();
            this.Hide();
        }

        private void revenueBtn_Click(object sender, EventArgs e)
        {
            RevenueScreen revenueScreen = new RevenueScreen();
            revenueScreen.Show();
            this.Hide();
        }

        private void cashSaleBtn_Click(object sender, EventArgs e)
        {
            CashSaleScreen cashSaleScreen = new CashSaleScreen();
            cashSaleScreen.Show();
            this.Hide();
        }

        private void invoiceBtn_Click(object sender, EventArgs e)
        {
            InvoiceScreen invoiceScreen = new InvoiceScreen();
            invoiceScreen.Show();
            this.Hide();
        }

        private void quotationBtn_Click(object sender, EventArgs e)
        {
            QuotationForm quotationForm = new QuotationForm();
            quotationForm.Show();
            this.Hide();
        }
    }
}
