using SupershopManagement.dashBoard;
using SupershopManagement.WelcomeModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SupershopManagement.login
{
    public delegate void INFORMATION();
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        string lgTb ;
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-TNA52VSF\SQLEXPRESS;Initial Catalog=SuperShop1;Integrated Security=True");
        public static string RName {  get; set; }
        public static string RPassword { get; set; }
        public static string RUserName { get; set; }
        public static string RAddress {  get; set; }
        public static string RUname { get; set; }
        public static string RID { get; set; }

        public static string name {  get; set; }
        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)//login_btn
        {
            if (Login_User_Name_textBox.Text == "" || Login_Pass_textBox.Text == "")
            {
                MessageBox.Show("Fill username and password");
            }
            else
            {
                lgTb = Login_User_Name_textBox.Text.ToString();
                string query = "select * from LOGIN_TB WHERE UNAME = '" + Login_User_Name_textBox.Text + "' and PASSWORD ='" + Login_Pass_textBox.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    RUname = dt.Rows[0][1].ToString();
                    RPassword = dt.Rows[0][2].ToString();
                    RID = dt.Rows[0][0].ToString();
                    if (dt.Rows[0][4].ToString() == "1")
                    {
                        if (dt.Rows[0][3].ToString() == "Manager")
                        {
                            info();
                            MessageBox.Show("Welcome " + name, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            new Manager_Dashboard().Show();
                        }
                        else if (dt.Rows[0][3].ToString() == "Customer")
                        {
                            info();
                            MessageBox.Show("Welcome " + name, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            new Customer_Dashboard().Show();
                        }
                        else
                        {
                            MessageBox.Show("Something is wrong " + name, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    else if (dt.Rows[0][4].ToString() == "2")
                    {

                        MessageBox.Show("Sorry Rejected by admin " + name, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                    else
                    {
                        MessageBox.Show("Account is not active!! ");
                    }
                }
                else if (lgTb == "aiub" && Login_Pass_textBox.Text == "1234")
                {
                    MessageBox.Show("Welcome to Admin " + name, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    new Admin_Dashboard().Show();
                }
                else
                {
                    MessageBox.Show("Wrong user Try again!!" + name, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        public void info()//no work
        {
            string query = "select * from USERTABLE WHERE UNAME = '" + Login_User_Name_textBox.Text + "' and PASSWORD ='" + Login_Pass_textBox.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                name = dt.Rows[0][1].ToString();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)//show_checkbox
        {
            if (Login_Show_checkBox.Checked)
                Login_Pass_textBox.UseSystemPasswordChar = false;
            else
                Login_Pass_textBox.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)//clear_btn
        {
            Login_Pass_textBox.Text = "";
            Login_User_Name_textBox.Text = "";
        }

        private void exit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormHomePage().Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
