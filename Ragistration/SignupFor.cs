using SupershopManagement.WelcomeModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupershopManagement.Ragistration
{
    public partial class SignupFor : Form
    {
        public SignupFor()
        {
            InitializeComponent();
        }

       

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void SignupFor_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton.Checked == true)
            {
                this.Hide();
                CustomerRegistration customerRegistration = new CustomerRegistration();
                customerRegistration.Show();
            }
            else
            {
                this.Hide();
                EmployeRegistration employeRegistration = new EmployeRegistration();
                employeRegistration.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormHomePage().Show();
        }
    }
}
