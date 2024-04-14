using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEmbroidery
{
    internal class FormProperties
    {
        public void LoadForm(object form, Panel mainPanel)
        {
            if (mainPanel.Controls.Count > 0)
                mainPanel.Controls.RemoveAt(0);

            Form f = (Form)form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(f);
            mainPanel.Tag = f;
            f.Show();
        }
        public void ButtonOnClick(Button button)
        {
            button.ForeColor = Color.White;
            button.BackColor = Color.Gray;
        }
        public void ButtonReset(Button button)
        {
            button.ForeColor = Color.Black;
            button.BackColor = Color.White;
        }
        public void GoBackToMainPanel(Form currentForm)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            currentForm.Hide();
        }
    }
}
