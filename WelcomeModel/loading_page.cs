using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupershopManagement.WelcomeModel
{
    public partial class loading_page : Form
    {
        public loading_page()
        {
            InitializeComponent();
        }

        private void loading_page_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int s = 5;
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += s;
            label2.Text=progressBar1.Value + "%";
            if (progressBar1.Value == 100)
            {
                s = 0;
                timer1.Enabled = false;
                this.Hide();
                FormHomePage formHomePage = new FormHomePage();
                formHomePage.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
