using SupershopManagement.login;
using SupershopManagement.Ragistration;
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

namespace SupershopManagement.dashBoard
{
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-TNA52VSF\SQLEXPRESS;Initial Catalog=SuperShop1;Integrated Security=True");

        public static int UID {  get; set; }

        private void c_btn2_Click(object sender, EventArgs e) //user_req_btn
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel1.Visible = true;
            usereq();
            login_tb();
        }

        private void button4_Click(object sender, EventArgs e)//manage user btn
        {
            panel1.Visible = false;
            panel3.Visible = false;
            panel2.Visible = true;
            user_tb();
        }

        public void login_tb()
        {
            string query = "select * from LOGIN_TB WHERE STATUS = '0'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Admin_dataGridView.DataSource = dt;
        }
        public void user_tb()
        {
            string query = "select * from LOGIN_TB WHERE STATUS = '1'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)//total_sell_btn
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
        }

        private void Delete_btn_Click_1(object sender, EventArgs e)//delete_btn
        {
            if (flag)
            {
                if (textBox2.Text == "ID" || textBox2.Text == "")
                {
                    MessageBox.Show("Select UserId to delete");
                }
                else
                {
                    string query = "DELETE FROM USERTABLE WHERE UNAME = '" + uname + "'";
                    string query1 = "DELETE FROM LOGIN_TB WHERE UNAME = '" + uname + "'";
                    string query2 = "DELETE FROM CUSTOMER_TB WHERE UNAME = '" + uname + "'";
                    string query3 = "DELETE FROM EMPLOYEE_TB WHERE UNAME = '" + uname + "'";

                    if (Con.State == ConnectionState.Closed)
                    {
                        Con.Open();
                    }

                    SqlCommand cmd = new SqlCommand(query, Con);
                    SqlCommand cmd1 = new SqlCommand(query1, Con);
                    SqlCommand cmd2 = new SqlCommand(query2, Con);
                    SqlCommand cmd3 = new SqlCommand(query3, Con);

                    if (Con.State == ConnectionState.Open)
                    {
                        int result = cmd.ExecuteNonQuery();
                        int result1 = cmd1.ExecuteNonQuery();
                        int result2 = cmd2.ExecuteNonQuery();
                        int result3 = cmd3.ExecuteNonQuery();

                        if (result > 0 && result1 > 0)
                        {
                            MessageBox.Show("User successfully deleted");
                            textBox2.Text = "";
                            active_user_count();
                            usereq();
                            user_tb();
                        }
                        else
                        {
                            MessageBox.Show("Delete failed. Please try again.");
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Select id to delete.");
            }
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            active_user_count();
            total_sell();
            
        }

        private void button1_Click(object sender, EventArgs e)//submit_btn
        {
            if (flag)
            {
                if (Acceptbtn.Checked == true)
                {
                    string query = "UPDATE LOGIN_TB SET STATUS = '1' WHERE L_ID = '" + lid + "'";
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
                            MessageBox.Show("Successfully updated");
                            textBox3.Text = "";
                            login_tb();
                            usereq();
                            active_user_count();

                        }
                        else
                        {
                            MessageBox.Show("Update failed. Please try again.");
                        }
                    }
                    Con.Close();

                }
                else if (Rejectbtn.Checked == true)
                {
                    string query = "UPDATE LOGIN_TB SET STATUS = '2' WHERE L_ID = '" + lid + "'";
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
                            MessageBox.Show("Successfully updated");
                            login_tb();
                            usereq();
                            active_user_count();
                            textBox3.Text = "";

                        }
                        else
                        {
                            MessageBox.Show("Update failed. Please try again.");
                        }
                    }
                    Con.Close();

                }
                else
                {
                    MessageBox.Show("Please Select Accept or Reject.");
                }
            }
            else
            {
                MessageBox.Show("Plese Select Id Accept or Reject");
            }
        }

        public void total_sell()
        {
            string query = "SELECT SUM(AMOUNT) FROM PAYMENT_TB";
            SqlCommand cmd = new SqlCommand(query, Con);
            Con.Open();
            var result = cmd.ExecuteScalar();

            if (result != DBNull.Value && result != null)
            {
                total_sell_btn.Text = result.ToString();
            }
            else
            {
                total_sell_btn.Text = "0";
            }

            Con.Close();

        }
        public void active_user_count()
        {
            string query = "SELECT COUNT(L_ID) FROM LOGIN_TB Where STATUS = '1'";
            if(Con.State == ConnectionState.Closed)
            {
                Con.Open(); 
            }
            SqlCommand cmd = new SqlCommand(query, Con);
            if (Con.State == ConnectionState.Open)
            {
                var result = cmd.ExecuteScalar();

                if (result != DBNull.Value && result != null)
                {
                    total_user_show_btn.Text = result.ToString();
                }
                else
                {
                    total_user_show_btn.Text = "0";
                }
                Con.Close();
            }

            

        }
        public void usereq()
        {
            string query = "SELECT COUNT(L_ID) FROM LOGIN_TB Where STATUS = '0'";
            if(Con.State == ConnectionState.Closed) { Con.Open(); }
            SqlCommand cmd = new SqlCommand(query, Con);
            if (Con.State == ConnectionState.Open)
            {
                var result = cmd.ExecuteScalar();

                if (result != DBNull.Value && result != null)
                {
                    total_req_btn.Text = result.ToString();
                }
                else
                {
                    total_req_btn.Text = "0";
                }

                Con.Close();
            }
        }
        bool flag = false;
        int lid;
        private void Admin_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Please select a valid Row.");
                return;
            }
            else
            {

                try
                {
                    var row = Admin_dataGridView.Rows[e.RowIndex];
                    lid = Convert.ToInt32(row.Cells[0].Value);
                    textBox3.Text = lid.ToString();

                    flag = true;
                }
                catch
                {
                    MessageBox.Show("Invalid row.");
                    flag = false;
                }
            }
        }

        private void exit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Admin_Logut_Btn_Click(object sender, EventArgs e)
        {
            new LoginPage().Show();
            this.Hide();
        }
        string uname;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) 
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Please select a valid item row.");
                return;
            }
            else
            {

                try
                {
                    var row = dataGridView1.Rows[e.RowIndex];

                    UID = Convert.ToInt32(row.Cells[0].Value);
                    uname = row.Cells[1].Value.ToString();
                    textBox2.Text = uname;
                    flag = true;    
                }
                catch
                {
                    MessageBox.Show("Invalid row data.");
                    flag= false;
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            search_textbox.Visible= false;
            string query = "SELECT * FROM ORDER_TB ";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            string query = "SELECT * FROM PAYMENT_TB ";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)//search_box
        {
            string query = "select * from PAYMENT_TB WHERE UNAME LIKE '" + search_textbox.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from USERTABLE WHERE UNAME LIKE '"+ textBox1.Text+ "%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button7_Enter(object sender, EventArgs e)
        {
            search_textbox.Visible = true;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Select From table");
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Select From table");
        }

        private void button8_Click(object sender, EventArgs e)//Deactive_btn
        {
            if (flag)
            {
                string query = "UPDATE LOGIN_TB SET STATUS = '0' WHERE L_ID = '" + UID + "'";
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
                        MessageBox.Show("Successfully Deactivate");
                        textBox2.Text = "";
                        login_tb();
                        usereq();
                        user_tb();
                        active_user_count();

                    }
                    else
                    {
                        MessageBox.Show("Update failed. Please try again.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Select User from Table to Deactivate Account");
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
