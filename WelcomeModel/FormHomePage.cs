using SupershopManagement.login;
using SupershopManagement.Ragistration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SupershopManagement.WelcomeModel
{
    public partial class FormHomePage : Form
    {
        public FormHomePage()
        {
            InitializeComponent();
        }
        
        int len=-1;
        string text;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (len < text.Length)
            {
                label2.Text += text.ElementAt(len);
                len++;
            }
            else
                timer1.Stop();
        }
        

        private void FormHomePage_Load(object sender, EventArgs e)
        {
            text = label2.Text;
            label2.Text = "";
            len++;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)//signup
        {
            this.Hide();
            SignupFor signupFor = new SignupFor();
            signupFor.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)//login_btn
        {
            this.Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
