using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGEmbroidery
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
        int counter;
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter >= 250)
            {
                timer1.Stop();
                Login loginForm = new Login();
                loginForm.Show();
                this.Hide();
            }
        }
    }
}
