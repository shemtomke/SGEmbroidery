using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGEmbroidery.Quotation
{
    public partial class QuotationForm : Form
    {
        FormProperties formProperties = new FormProperties();
        public QuotationForm()
        {
            InitializeComponent();

            formProperties.ButtonOnClick(printQuotationBtn);
            formProperties.LoadForm(new Quotation.DashboardQuotation(), this.mainPanel);

            formProperties.ButtonReset(CreateQuotationBtn);
            formProperties.ButtonReset(updateQuotationBtn);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            formProperties.GoBackToMainPanel(this);
        }

        private void printQuotationBtn_Click(object sender, EventArgs e)
        {
            formProperties.ButtonOnClick(printQuotationBtn);
            formProperties.LoadForm(new Quotation.DashboardQuotation(), this.mainPanel);

            formProperties.ButtonReset(CreateQuotationBtn);
            formProperties.ButtonReset(updateQuotationBtn);
        }

        private void updateQuotationBtn_Click(object sender, EventArgs e)
        {
            formProperties.ButtonOnClick(updateQuotationBtn);
            formProperties.LoadForm(new Quotation.UpdateQuotation(), this.mainPanel);

            formProperties.ButtonReset(CreateQuotationBtn);
            formProperties.ButtonReset(printQuotationBtn);
        }

        private void CreateQuotationBtn_Click(object sender, EventArgs e)
        {
            formProperties.ButtonOnClick(CreateQuotationBtn);
            formProperties.LoadForm(new Quotation.CreateQuotation(), this.mainPanel);

            formProperties.ButtonReset(printQuotationBtn);
            formProperties.ButtonReset(updateQuotationBtn);
        }
    }
}
