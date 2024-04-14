using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGEmbroidery.Cash_Sale
{
    public partial class CashSaleScreen : Form
    {
        FormProperties formProperties = new FormProperties();
        public CashSaleScreen()
        {
            InitializeComponent();

            formProperties.ButtonOnClick(cashSaleDashboard);
            formProperties.LoadForm(new Cash_Sale.CashSaleDashboard(), this.mainPanel);

            formProperties.ButtonReset(createCashSale);
            formProperties.ButtonReset(updateCashSale);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            formProperties.GoBackToMainPanel(this);
        }

        private void createCashSale_Click(object sender, EventArgs e)
        {
            formProperties.ButtonOnClick(createCashSale);
            formProperties.LoadForm(new Cash_Sale.CreateCashSale(), this.mainPanel);

            formProperties.ButtonReset(cashSaleDashboard);
            formProperties.ButtonReset(updateCashSale);
        }

        private void cashSaleDashboard_Click(object sender, EventArgs e)
        {
            formProperties.ButtonOnClick(cashSaleDashboard);
            formProperties.LoadForm(new Cash_Sale.CashSaleDashboard(), this.mainPanel);

            formProperties.ButtonReset(createCashSale);
            formProperties.ButtonReset(updateCashSale);
        }

        private void updateCashSale_Click(object sender, EventArgs e)
        {
            formProperties.ButtonOnClick(updateCashSale);
            formProperties.LoadForm(new Cash_Sale.UpdateCashSale(), this.mainPanel);

            formProperties.ButtonReset(createCashSale);
            formProperties.ButtonReset(cashSaleDashboard);
        }
    }
}
