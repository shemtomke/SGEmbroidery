using SGEmbroidery.Invoice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGEmbroidery.Progress
{
    public partial class RevenueScreen : Form
    {
        FormProperties formProperties = new FormProperties();

        public RevenueScreen()
        {
            InitializeComponent();

            formProperties.ButtonOnClick(revenueDashboardBtn);
            formProperties.LoadForm(new RevenueDashBoard(), this.mainPanel);

            formProperties.ButtonReset(addExpensesBtn);
            formProperties.ButtonReset(addFinancesBtn);
            formProperties.ButtonReset(companyProgressBtn);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            formProperties.GoBackToMainPanel(this);
        }

        private void revenueDashboardBtn_Click(object sender, EventArgs e)
        {
            formProperties.ButtonOnClick(revenueDashboardBtn);
            formProperties.LoadForm(new RevenueDashBoard(), this.mainPanel);

            formProperties.ButtonReset(addExpensesBtn);
            formProperties.ButtonReset(addFinancesBtn);
            formProperties.ButtonReset(companyProgressBtn);
        }

        private void addFinancesBtn_Click(object sender, EventArgs e)
        {
            formProperties.ButtonOnClick(addFinancesBtn);
            formProperties.LoadForm(new AddFinance(), this.mainPanel);

            formProperties.ButtonReset(addExpensesBtn);
            formProperties.ButtonReset(revenueDashboardBtn);
            formProperties.ButtonReset(companyProgressBtn);
        }

        private void addExpensesBtn_Click(object sender, EventArgs e)
        {
            formProperties.ButtonOnClick(addExpensesBtn);
            formProperties.LoadForm(new Expenses(), this.mainPanel);

            formProperties.ButtonReset(revenueDashboardBtn);
            formProperties.ButtonReset(addFinancesBtn);
            formProperties.ButtonReset(companyProgressBtn);
        }

        private void companyProgressBtn_Click(object sender, EventArgs e)
        {
            formProperties.ButtonOnClick(companyProgressBtn);
            formProperties.LoadForm(new Revenue.Progress(), this.mainPanel);

            formProperties.ButtonReset(addExpensesBtn);
            formProperties.ButtonReset(addFinancesBtn);
            formProperties.ButtonReset(revenueDashboardBtn);
        }
    }
}
