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

namespace SGEmbroidery.DeliveryNote
{
    public partial class DeliveryScreen : Form
    {
        FormProperties formProperties = new FormProperties();
        public DeliveryScreen()
        {
            InitializeComponent();

            formProperties.ButtonOnClick(deliveryDashboard);
            formProperties.LoadForm(new Invoice.InvoiceDashboard(), this.mainPanel);

            formProperties.ButtonReset(AddDeliveryBtn);
            formProperties.ButtonReset(updateDeliveryBtn);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            formProperties.GoBackToMainPanel(this);
        }

        private void deliveryDashboard_Click(object sender, EventArgs e)
        {
            formProperties.ButtonOnClick(deliveryDashboard);
            formProperties.LoadForm(new Invoice.InvoiceDashboard(), this.mainPanel);

            formProperties.ButtonReset(AddDeliveryBtn);
            formProperties.ButtonReset(updateDeliveryBtn);
        }

        private void AddDeliveryBtn_Click(object sender, EventArgs e)
        {
            formProperties.ButtonOnClick(AddDeliveryBtn);
            formProperties.LoadForm(new Invoice.CreateInvoice(), this.mainPanel);

            formProperties.ButtonReset(deliveryDashboard);
            formProperties.ButtonReset(updateDeliveryBtn);
        }

        private void updateDeliveryBtn_Click(object sender, EventArgs e)
        {
            formProperties.ButtonOnClick(updateDeliveryBtn);
            formProperties.LoadForm(new Invoice.UpdateInvoice(), this.mainPanel);

            formProperties.ButtonReset(AddDeliveryBtn);
            formProperties.ButtonReset(deliveryDashboard);
        }
    }
}
