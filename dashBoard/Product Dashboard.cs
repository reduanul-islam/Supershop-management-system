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

namespace SupershopManagement.dashBoard
{
    public partial class Product_Dashboard : Form
    {
        public Product_Dashboard()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-TNA52VSF\SQLEXPRESS;Initial Catalog=SuperShop1;Integrated Security=True");

        public static int quantity {  get; set; }

        private void button2_Click(object sender, EventArgs e)//add_btn
        {
            if (!Product_Add_Price.Text.All(char.IsDigit))
            {
                MessageBox.Show("enter valid price");
            }
            else if (!Product_Add_Quantity.Text.All(char.IsDigit))
            {
                MessageBox.Show("enter valid quantity");
            }
            else if (!Product_Add_Discount.Text.All(char.IsDigit) && Product_Add_Discount.Text!="")
            {
                MessageBox.Show("enter valid Discount");
            }
            else if(Product_Add_Category.Text == "")
            {
                MessageBox.Show("Select type");
            }
            else
            {
                string query = "insert into PRODUCT_TB values ('" + LoginPage.RUname + "','" + Product_Add_Name.Text + "','" + Product_Add_Category.Text + "','" + Product_Add_Discount.Text + "','" + Product_Add_Price.Text + "','" + Product_Add_Quantity.Text + "')";

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
                        MessageBox.Show("item Successfully added");
                        showtbl();
                    }
                    else
                    {
                        MessageBox.Show("item is not Successfully added");

                    }
                }
                Con.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e) //update_btn
        {
            if (flag)
            {
                if (Product_Update_Id.Text == "" || Product_Update_Name.Text == "" || Product_Update_Category.Text == "" || Product_Update_Price.Text == "" || Product_Update_Discount.Text == "" || Product_Update_Quantity.Text == "")
                {
                    MessageBox.Show("Fill All data");
                }
                else
                {
                    if (!Product_Update_Price.Text.All(char.IsDigit))
                    {
                        MessageBox.Show("Enter valid price");
                    }
                    else if (!Product_Update_Quantity.Text.All(char.IsDigit))
                    {
                        MessageBox.Show("Enter valid quantity");
                    }
                    else if (!Product_Update_Id.Text.All(char.IsDigit))
                    {
                        MessageBox.Show("please Enter valid id");
                    }
                    else if (!Product_Update_Discount.Text.All(char.IsDigit))
                    {
                        MessageBox.Show("please Enter valid id");
                    }
                    else
                    {
                        string query = "UPDATE PRODUCT_TB SET P_NAME = '" + Product_Update_Name.Text + "', P_TYPE = '" + Product_Update_Category.Text + "',P_PRICE = '" + Product_Update_Price.Text + "', P_DISCOUNT = '" + Product_Update_Discount.Text + "', P_QUANTITY = '" + Product_Update_Quantity.Text + "' WHERE p_id = '" + Product_Update_Id.Text + "'";

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
                                MessageBox.Show("Item Successfully updated");
                                showtbl();

                            }
                            else
                            {
                                MessageBox.Show("Update failed. Please try again.");
                            }
                        }
                        Con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Select product.");
            }

        }
        void showtbl()
        {
            string query = "select * from PRODUCT_TB";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Product_Add_Gridview.DataSource = dt;
            C.DataSource = dt;
            Product_Update_dataGridView.DataSource = dt;
        }

        private void Product_Dashboard_Load(object sender, EventArgs e)
        {
            showtbl();
        }

        private void button6_Click(object sender, EventArgs e)//delete_btn
        {
            if (!Product_Delete_Id_textBox.Text.All(char.IsDigit))
            {
                MessageBox.Show("Enter a valid product ID");
            }
            else
            {
                string query = "DELETE FROM PRODUCT_TB WHERE P_ID = '" + Product_Delete_Id_textBox.Text + "'";

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
                        MessageBox.Show("Item successfully deleted");
                        showtbl();
                    }
                    else
                    {
                        MessageBox.Show("Delete failed. Please try again.");
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = false;
            Product_Delete_panel.Visible = true;          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Product_Delete_panel.Visible = false;
            panel2.Visible = true;           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            Product_Delete_panel.Visible = false;
            panel1.Visible = true;           
        }
        
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    var row = C.Rows[e.RowIndex];
                    Product_Delete_Id_textBox.Text = row.Cells[0].Value.ToString();
                    flag = true;
                }
                catch
                {
                    MessageBox.Show("Invalid row data.");
                    flag = false;
                }
            }
        }

        bool flag = false;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)//cell_click for update
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
                    var row = Product_Update_dataGridView.Rows[e.RowIndex];
                    Product_Update_Id.Text = Convert.ToInt32(row.Cells[0].Value).ToString();
                    Product_Update_Name.Text = row.Cells[2].Value.ToString();
                    Product_Update_Category.Text = row.Cells[3].Value.ToString();
                    Product_Update_Price.Text = Convert.ToInt32( row.Cells[5].Value).ToString();
                    Product_Update_Discount.Text = Convert.ToInt32(row.Cells[4].Value).ToString(); ;
                    Product_Update_Quantity.Text = Convert.ToInt32(row.Cells[6].Value).ToString(); ;
                    flag = true;
                }
                catch
                {
                    MessageBox.Show("Invalid row data.");
                    flag = false;
                }
            }
        }

        private void id_Enter(object sender, EventArgs e)
        {
            
        }

        private void id_Leave(object sender, EventArgs e)
        {
              
        }

        private void p_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Product_Details_Name_Click(object sender, EventArgs e)
        {

        }

        private void Product_Dashboard_Logut_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginPage().Show();
        }

        private void Product_Update_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void exit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Manager_Dashboard().Show();
        }
    }
}
