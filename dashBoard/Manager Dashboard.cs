using SupershopManagement.login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SupershopManagement.dashBoard
{
    public partial class Manager_Dashboard : Form
    {
        public Manager_Dashboard()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-TNA52VSF\SQLEXPRESS;Initial Catalog=SuperShop1;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void c_btn1_Click(object sender, EventArgs e)
        {
            Manager_Details_Panel.Visible = true;
            Manager_Search_Panel.Visible = false;
            showdata();

        }
        public void showdata()
        {
            string query = "select * from USERTABLE WHERE UNAME = '" + LoginPage.RUname + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Manager_Details_dataGridView.DataSource = dt;

        }

        private void c_btn3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Product_Dashboard().Show();

        }

        private void c_btn2_Click(object sender, EventArgs e)
        {
            Manager_Details_Panel.Visible = false;
            Manager_Search_Panel.Visible = true;
            string query = "select * from PRODUCT_TB";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Manager_Search_dataGridView.DataSource = dt;
            
        }

        private void panel3_Enter(object sender, EventArgs e)
        {

        }

        private void Manager_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void Manager_Upade_Btn_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                if (Manager_Name_textBox.Text == "" || Manager_Pass_textBox.Text == "" || Manager_Address_textBox.Text == "")
                {
                    MessageBox.Show("fill all information");
                }
                else
                {
                    string query = "UPDATE USERTABLE SET NAME = '" + name + "', PASSWORD = '" + pass + "', ADDRESS = '" + Manager_Address_textBox.Text + " ' WHERE UNAME = '" + username + "'";
                    string query1 = "UPDATE LOGIN_TB SET PASSWORD ='" + pass + "'WHERE UNAME = '" + username + "'";

                    if (Con.State == ConnectionState.Closed)
                    {
                        Con.Open();
                    }
                    SqlCommand cmd = new SqlCommand(query, Con);
                    SqlCommand cmd1 = new SqlCommand(query1, Con);

                    if (Con.State == ConnectionState.Open)
                    {
                        int result = cmd.ExecuteNonQuery();
                        int result1 = cmd1.ExecuteNonQuery();

                        if (result > 0 && result1 > 0)
                        {
                            MessageBox.Show(" Successfully updated");
                            showdata();

                        }
                        else
                        {
                            MessageBox.Show("Update failed. Please try again.");
                        }
                    }
                    Con.Close();
                }
            }
            else
            {
                MessageBox.Show("select from table");
            }
        }

        private void Manager_Logut_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginPage().Show();
        }

        private void Manager_Search_Box_TextChanged(object sender, EventArgs e)
        {
                       
                string query = "SELECT * FROM PRODUCT_TB WHERE P_NAME LIKE '" + Manager_Search_Box.Text + "%';";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Manager_Search_dataGridView.DataSource = dt;
           
        }

        private void Manager_Search_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        string name, pass, address;

        private void Manager_Delete_Btn_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                if (Manager_Name_textBox.Text == "ID" || Manager_Pass_textBox.Text == "")
                {
                    MessageBox.Show("Select UserId to delete");
                }
                else
                {
                    string query = "DELETE FROM USERTABLE WHERE UNAME = '" + LoginPage.RUserName + "'";
                    string query1 = "DELETE FROM LOGIN_TB WHERE UNAME = '" + LoginPage.RUserName + "'";
                    string query2 = "DELETE FROM CUSTOMER_TB WHERE UNAME = '" + LoginPage.RUserName + "'";
                    string query3 = "DELETE FROM EMPLOYEE_TB WHERE UNAME = '" + LoginPage.RUserName + "'";

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
                            Manager_Name_textBox.Text = "";
                            Manager_Pass_textBox.Text = "";
                            Manager_Address_textBox.Text = "";
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

        bool flag;
        string username;
        private void Manager_Details_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    var row = Manager_Details_dataGridView.Rows[e.RowIndex];
                    name = row.Cells[1].Value.ToString();
                    Manager_Name_textBox.Text = name;
                    pass = row.Cells[5].Value.ToString();
                    Manager_Pass_textBox.Text = pass;
                    address = row.Cells[7].Value.ToString();
                    Manager_Address_textBox.Text = address;
                    username = row.Cells[2].Value.ToString();
                    flag = true;
                }
                catch
                {
                    MessageBox.Show("Invalid row data.");
                    flag = false;
                }
            }
        }
    }
}
