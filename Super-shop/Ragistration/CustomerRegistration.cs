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

namespace SupershopManagement.Ragistration
{
    public partial class CustomerRegistration : Form
    {
        public CustomerRegistration()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-TNA52VSF\SQLEXPRESS;Initial Catalog=SuperShop1;Integrated Security=True;");


        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void CustomerRegistration_Load(object sender, EventArgs e)
        {

        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();

        }

       

        private void contact_panel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void C_contactInfo_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //personal_next
        {
            if (c_i_name.Text == "" || c_i_gender.Text == "" || c_i_DOB.Text == "")
            {
                MessageBox.Show("please fill in all required field");
            }
            else
            {
                C_information_panel.Visible = false;
                C_contactInfo_panel.Visible = true;
            }


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SignupFor signupFor = new SignupFor();
            signupFor.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            C_contactInfo_panel.Visible = false;
            C_information_panel .Visible = true;
        }

        private void button8_Click_1(object sender, EventArgs e) //Contact information next
        {
            string num = c_i_phone.Text;
            if (c_i_phone.Text == "" || c_i_email.Text == "" || c_i_address.Text == "")
            {
                MessageBox.Show("please fill in all required field");
            }
            else
            {
                if (!c_i_phone.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Phone Number must be digit");
                    return;
                }
                
                if (num.Length != 11)
                 {
                    MessageBox.Show("Phone number must be 11 digit");
                 }
                else
                {
                    C_contactInfo_panel.Visible = false;
                    C_accountCredentialPanel.Visible = true;
                }
                 
                
            }


        }

        private void button4_Click_1(object sender, EventArgs e) //account credential next
        {
            if (c_a_uname.Text == "" || c_a_pass.Text == "" || c_a_repass.Text == "")
            {
                MessageBox.Show("please fill in all required field");
                return;
            }
            else
            {
                if (c_a_pass.Text.Length < 4)
                {
                    MessageBox.Show("Password minimum be 4 digit");
                }
                else
                {
                    if (c_a_pass.Text != c_a_repass.Text)
                    {
                        MessageBox.Show("Please enter same password");
                    }
                    else
                    {
                        string query = "select * from LOGIN_TB WHERE UNAME = '" + c_a_uname.Text + "' ";
                        SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows.Count == 1)
                        {
                            MessageBox.Show("this user name already exist please change ");
                        }
                        else
                        {
                            C_accountCredentialPanel.Visible = false;
                            C_Submit_panel.Visible = true;
                        }
                            
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)//account_back
        {
            C_accountCredentialPanel.Visible = false;
            C_contactInfo_panel .Visible = true;
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)//submit_back
        {
            C_Submit_panel.Visible = false;
            C_accountCredentialPanel.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)//submit_btn
        {
            if (c_s_uname.Text == "" || c_s_name.Text == "")
            {

            }
            else
            {
                string query1 = "INSERT INTO USERTABLE VALUES ('" + c_s_name.Text + "','" + c_s_uname.Text + "','" + c_s_phone.Text + "','" + c_s_email.Text + "','" + c_s_pass.Text + "','" + c_s_gender.Text + "','" + c_s_address.Text + "','" + c_s_DOB.Text + "')";

                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }
                SqlCommand cmd1 = new SqlCommand(query1, Con);
                if (Con.State == ConnectionState.Open)
                {
                    int result1 = cmd1.ExecuteNonQuery();
                    if (result1 > 0)
                    {
                        MessageBox.Show("User Successfully created");
                    }
                    else
                    {
                        MessageBox.Show("User is not Successfully created");
                    }
                }
                Con.Close();
                string Customer = "Customer";

                string query2 = "INSERT INTO LOGIN_TB VALUES ('" + c_s_uname.Text + "','" + c_s_pass.Text + "','" + Customer + "','0')";

                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }
                SqlCommand cmd2 = new SqlCommand(query2, Con);
                if (Con.State == ConnectionState.Open)
                {
                    int result2 = cmd2.ExecuteNonQuery();
                    if (result2 > 0)
                    {
                        MessageBox.Show("User Successfully created");
                    }
                    else
                    {
                        MessageBox.Show("User is not Successfully created");
                    }
                }
                Con.Close();


                string query3 = "INSERT INTO CUSTOMER_TB VALUES ('" + c_s_uname.Text + "')";

                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }
                SqlCommand cmd3 = new SqlCommand(query3, Con);
                if (Con.State == ConnectionState.Open)
                {
                    int result3 = cmd3.ExecuteNonQuery();
                    if (result3 > 0)
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


        }

        private void C_Submit_panel_Paint(object sender, PaintEventArgs e)
        {

            c_s_name.Text = c_i_name.Text;
            //c_s_nid.Text = e_p_nid.Text;
            c_s_gender.Text = c_i_gender.Text;
            c_s_DOB.Text = c_i_DOB.Text;
            c_s_phone.Text = c_i_phone.Text;
            c_s_email.Text = c_i_email.Text;
            c_s_address.Text = c_i_address.Text;
            c_s_uname.Text = c_a_uname.Text;
            c_s_pass.Text = c_a_pass.Text;
            c_s_repass.Text = c_a_repass.Text;
        }

        private void exit1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignupFor().Show();
        }

        private void label1_Click(object sender, EventArgs e) //back
        {
            C_Submit_panel.Visible = false;
            C_information_panel.Visible = true;
        }

        private void label7_Click(object sender, EventArgs e)//back
        {
            C_Submit_panel.Visible = false;
            C_contactInfo_panel.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)//back
        {
            C_Submit_panel.Visible = false;
            C_accountCredentialPanel.Visible = true;
        }

        private void c_s_DOB_Enter(object sender, EventArgs e)
        {
            
        }
    }
    
}
