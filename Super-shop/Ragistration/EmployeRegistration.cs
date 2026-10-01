using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient; 
using System.Data;
using SupershopManagement.WelcomeModel;

namespace SupershopManagement.Ragistration
{
    public partial class EmployeRegistration : Form
    {
        public EmployeRegistration()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-TNA52VSF\SQLEXPRESS;Initial Catalog=SuperShop1;Integrated Security=True;");

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EmployeRegistration_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e) // personal information next
        {
            if (e_p_name.Text == "" || e_p_gender.Text == "" || e_p_nid.Text == "")
            {
                MessageBox.Show("please fill in all required field");
            }
            else
            {
                if (e_p_nid.Text.Length > 10 && e_p_nid.Text.Length < 17)
                {
                    information_panel.Visible = false;
                    contact_panel.BringToFront();
                    contact_panel.Visible = true;
                }
                else
                {
                    MessageBox.Show("NID number should be 11 to 17");
                }
            }

        }

        private void button8_Click_1(object sender, EventArgs e)//contct information next
        {
            if (e_c_phone.Text == "" || e_c_email.Text == "" || e_c_address.Text == "")
            {
                MessageBox.Show("please fill in all required field");
            }
            else
            {
                if (!e_c_phone.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Phone Number must be digit");
                    return;
                }
                if (e_c_phone.Text.Length != 11)
                {
                    MessageBox.Show("Phone number must be 11 digit");
                }
                else
                {
                    contact_panel.Visible = false;
                    E_accountCredential.BringToFront();
                    E_accountCredential.Visible = true;
                }
            }

        }

        private void button4_Click(object sender, EventArgs e) //account credential
        {
            if (e_a_uname.Text == "" || e_a_pass.Text == "" || e_a_re_pass.Text == "")
            {
                MessageBox.Show("please fill in all required field");
            }
            else
            {
                if (e_a_pass.Text.Length < 4)
                {
                    MessageBox.Show("Password must be 4 digit");
                }
                else
                {
                    if (e_a_pass.Text != e_a_re_pass.Text)
                    {
                        MessageBox.Show("Please enter same password");
                    }
                    else
                    {
                        string query = "select * from LOGIN_TB WHERE UNAME = '" + e_a_uname.Text + "' ";
                        SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows.Count == 1)
                        {
                            MessageBox.Show("this user name already exist please change ");
                            
                        }
                        else
                        {
                            E_accountCredential.Visible = false;
                            E_submit_panel.BringToFront();
                            E_submit_panel.Visible = true;
                        }
                        
                    }
                }
            }

        }

        private void button7_Click_1(object sender, EventArgs e)//personal_back
        {
            contact_panel.Visible = false;
            information_panel.BringToFront();
            information_panel.Visible = true;

        }


        private void button6_Click_2(object sender, EventArgs e) //account_back
        {
            E_accountCredential.Visible = false;
            contact_panel.BringToFront();
            contact_panel.Visible = true;
        }

        private void button3_Click_1(object sender, EventArgs e) //submit_back
        {
            E_submit_panel.Visible = false;
            E_accountCredential.BringToFront();
            E_accountCredential.Visible = true;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)// submit panel
        {
            e_s_name.Text = e_p_name.Text;
            e_s_nid.Text = e_p_nid.Text;
            e_s_gender.Text = e_p_gender.Text;
            e_s_DOB.Text = dateTimePicker1.Text;
            e_s_phone.Text = e_c_phone.Text;
            e_s_email.Text = e_c_email.Text;
            e_s_address.Text = e_c_address.Text;
            e_s_uname.Text = e_a_uname.Text;
            e_s_pass.Text = e_a_pass.Text;
            e_s_retype_pass.Text = e_a_re_pass.Text;
        }

        private void button5_Click(object sender, EventArgs e) //employe_submit_btn
        {


            string query = "insert into USERTABLE values ('" + e_s_name.Text + "','" + e_s_uname.Text + "','" + e_s_phone.Text + "','" + e_s_email.Text + "','" + e_s_pass.Text + "','" + e_s_gender.Text + "','" + e_s_address.Text + "','" + e_s_DOB.Text + "')";       

            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            SqlCommand cmd = new SqlCommand(query, Con);
            if (Con.State == ConnectionState.Open)
            {
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("User Successfully created");
                }
                else
                {
                    MessageBox.Show("User is not Successfully created");

                }
            }
            Con.Close();



            string query1 = "INSERT INTO LOGIN_TB VALUES ('" + e_s_uname.Text + "','" + e_s_pass.Text + "','" + label31.Text + "','0')";

            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            SqlCommand cmd1 = new SqlCommand(query1, Con);
            if (Con.State == ConnectionState.Open)
            {
                int result = cmd1.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("User Successfully created");
                }
                else
                {
                    MessageBox.Show("User is not Successfully created");

                }
            }
            Con.Close();

            string query2 = "INSERT INTO EMPLOYEE_TB VALUES ('" + e_s_uname.Text + "','" + e_s_nid.Text + "')";
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            SqlCommand cmd2 = new SqlCommand(query2, Con);
            if (Con.State == ConnectionState.Open)
            {
                int result = cmd2.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("User Successfully created");
                    this.Hide();
                    new FormHomePage().Show();
                }
                else
                {
                    MessageBox.Show("User is not Successfully created");

                }
            }
            Con.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignupFor().Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            E_submit_panel.Visible = false;
            information_panel.Visible = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            E_submit_panel.Visible = false;
            contact_panel.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            E_submit_panel.Visible = false;
            E_accountCredential.Visible = true;
        }
    }
}
