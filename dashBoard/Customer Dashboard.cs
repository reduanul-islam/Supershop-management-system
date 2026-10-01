using SupershopManagement.login;
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

namespace SupershopManagement.dashBoard
{
    public partial class Customer_Dashboard : Form
    {
        public Customer_Dashboard()
        {
            InitializeComponent();
        }
        public Customer_Dashboard(LoginPage log)
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-TNA52VSF\SQLEXPRESS;Initial Catalog=SuperShop1;Integrated Security=True");

        public static string type { get; set; }
        public static string C_ID { get; set; }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            c_btn1.BackColor = Color.FromArgb(128, 128, 255);
            oder_history_panel.Visible = false;
            C_Details_Panel.Visible = true;
            c_search_panel.Visible = false;
            showdata();
        }
        public void showdata()
        {
            string query = "select * from USERTABLE WHERE UNAME = '" + LoginPage.RUname +"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c_btn1.BackColor = Color.FromArgb(48, 56, 79);
            this.Hide();
            new OderPlace().Show();
        }

        private void Customer_Dashboard_Load(object sender, EventArgs e)
        {
            label3.Text = LoginPage.RUname;
           

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            type = "Groceries";
            this.Hide();
            new OderPlace().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                {
                    MessageBox.Show("fill all information");
                }
                else
                {
                    string query = "UPDATE USERTABLE SET NAME = '" + textBox1.Text + "', PASSWORD = '" + textBox2.Text + "', ADDRESS = '" + textBox3.Text + " ' WHERE UNAME = '" + LoginPage.RUname + "'";
                    string query1 = "UPDATE LOGIN_TB SET PASSWORD ='" + textBox2.Text + "'WHERE L_ID = '" + LoginPage.RID + "'";

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
                            MessageBox.Show("Item Successfully updated");
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
                MessageBox.Show("Select Row First for update or delete");
            }


        }

        private void C_Paint(object sender, PaintEventArgs e)
        {

        }

        public void orderhistory()
        {
            string query = "SELECT * FROM ORDER_TB WHERE UNAME=@uname";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            sda.SelectCommand.Parameters.AddWithValue("@uname", LoginPage.RUname);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void c_btn3_Click(object sender, EventArgs e)
        {           
            oder_history_panel.Visible = true;
            C_Details_Panel.Visible = false;
            c_search_panel.Visible = false;
            orderhistory();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            type = "Vegetables";
            this.Hide();
            OderPlace oderPlace = new OderPlace();
            oderPlace.Show();   
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                if (textBox2.Text == "ID" || textBox2.Text == "")
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
                            textBox1.Text = "";
                            textBox2.Text = "";
                            textBox3.Text = "";
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            type = "Baby Product";
            this.Hide();
            new OderPlace().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            type = "Cosmetics";
            this.Hide();
            new OderPlace().Show();
        }

        private void c_btn4_Click(object sender, EventArgs e)
        {
            
            this.Show();
            new LoginPage().Show();
        }
        bool flag = false;
        string name, pass, address;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    var row = dataGridView2.Rows[e.RowIndex];
                    name = row.Cells[1].Value.ToString();
                    textBox1.Text = name;
                    pass = row.Cells[5].Value.ToString();
                    textBox2.Text = pass;
                    address = row.Cells[7].Value.ToString();
                    textBox3.Text = address;    
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
