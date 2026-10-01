using SupershopManagement.login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SupershopManagement.dashBoard
{
    public partial class OderPlace : Form
    {
        public OderPlace()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-TNA52VSF\SQLEXPRESS;Initial Catalog=SuperShop1;Integrated Security=True");
        DataTable dt = new DataTable();
        public static  int C_ID { get; set; }
        public static int totalamount { get; set; }
        public int num {  get; set; }
        int price, qty, ttl, discount, P_ID, totalqty;
        string item, category;
        bool flag = false;
        private void textBox3_Click(object sender, EventArgs e)
        {
            
        }
       

       
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            Product_type.Text = add_more.Text;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            Product_type.Text = bt1.Text;
        }
        public void customerdt() // no work
        {
            string query = "SELECT * FROM CUSTOMER_TB WHERE UNAME = '"+ LoginPage.RUname +"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            C_ID = Convert.ToInt32(dt1.Rows[0][0]);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            Product_type.Text = bt4.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            Product_type.Text = bt2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            Product_type.Text = bt5.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            Product_type.Text = bt3.Text;
        }
        private void LoadProductTable()  
        {
            try
            {
                string query = "SELECT * FROM PRODUCT_TB";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                DataTable dtProduct = new DataTable();
                sda.Fill(dtProduct);
                iteam_gv.DataSource = dtProduct;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product table: " + ex.Message);
            }
        }
       
      
        private void UpdateOrderAmount()
        {
            int totalAmount = 0;
            foreach (DataRow row in dt.Rows)
            {
                totalAmount += Convert.ToInt32(row["Total"]);
            }
            label4.Text = totalAmount.ToString();
            totalamount = totalAmount;

        }
        bool delete = false;
        private void button5_Click(object sender, EventArgs e) //add_to_cart_btn
        {
            if (flag)
            {
                if (quantity_textbox.Text == "" || !quantity_textbox.Text.All(char.IsDigit))
                {
                    MessageBox.Show("enter a valid quantity");
                    return;
                }              
                if (Convert.ToInt32(quantity_textbox.Text) > 0)
                {
                    qty = Convert.ToInt32(quantity_textbox.Text);
                }
                if (totalqty > 0)
                {
                    if (qty > 0)
                    {
                        if (discount > 0 && totalqty>0)
                        {
                            int discountedPrice = Convert.ToInt32( price - price * (discount/100));                        
                            num++;
                            totalqty = totalqty - qty;
                            DataRow row = dt.NewRow();
                            row["Number"] = num;
                            row["P_ID"] = P_ID;
                            row["Item"] = item;
                            row["Category"] = category;
                            row["UnitPrice"] = price;
                            row["Discount"] = discount;
                            row["Quantity"] = qty;
                            row["Total"] = ttl;
                            dt.Rows.Add(row);
                            flag = false;
                            UpdateOrderAmount();
                        }
                        else
                        {
                            int discountedPrice = price;
                            ttl = discountedPrice * qty;                            
                            num++;                       
                            DataRow row = dt.NewRow();
                            row["Number"] = num;
                            row["P_ID"] = P_ID;
                            row["Item"] = item;
                            row["Category"] = category;
                            row["UnitPrice"] = price;
                            row["Discount"] = discount;
                            row["Quantity"] = qty;
                            row["Total"] = ttl;
                            dt.Rows.Add(row);

                            flag = false;
                            UpdateOrderAmount();

                        }
                        OID = SID;
                        try
                        {                         
                            string query = "insert into ORDER_TB values ('" + Convert.ToInt32(OID) + "','" + P_ID + "','" + item + "','" + category + "','" + price + "','" + discount + "','" + qty + "','" + ttl + "','" + LoginPage.RUname + "')";
                            if (Con.State == ConnectionState.Closed)
                            {
                                Con.Open();
                            }
                            SqlCommand cmd = new SqlCommand(query, Con);
                            if (Con.State == ConnectionState.Open)
                            {
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Order placed successfully!");
                                totalamount += 0;
                                Con.Close();
                                totalqty = totalqty - qty;
                                Con.Open();
                                string query1 = $"UPDATE PRODUCT_TB SET P_QUANTITY = '{totalqty}' WHERE P_ID = '{P_ID}'";
                                SqlCommand cmd1 = new SqlCommand(query1, Con);
                                cmd1.ExecuteNonQuery();
                                Con.Close();
                                LoadProductTable();
                                delete = true;
                            }
                            else
                            {
                                MessageBox.Show("Something is Worng!");
                            }



                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error placing order: " + ex.Message);
                        }
                        finally
                        {
                            Con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid quantity.");
                    }
                }
                else
                {
                    MessageBox.Show("Stock out!!");
                }

            }
            else
            {
                MessageBox.Show("Please select an item first.");
            }
            
            

        }

        private void quantity_textbox_Enter(object sender, EventArgs e)
        {
            if (quantity_textbox.Text == "Quantity")
            {
                quantity_textbox.Text = "";
                quantity_textbox.ForeColor = Color.Black;
            }
        }

        private void quantity_textbox_Leave(object sender, EventArgs e)
        {
            if (quantity_textbox.Text == "")
            {
                quantity_textbox.Text = "Quantity";
                quantity_textbox.ForeColor = Color.Gray;
            }
        }

        private void quantity_textbox_TextChanged(object sender, EventArgs e)
        {
            quantity_textbox.Enabled= true; 
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)//search_textbox
        {
            Search_textbox.Enabled = true;
            if (Search_textbox.Text == "")
            {
                string query = "SELECT * FROM PRODUCT_TB ";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                iteam_gv.DataSource = dt;
            }
            else
            {
                string query = "SELECT * FROM PRODUCT_TB WHERE P_NAME LIKE '" + Search_textbox.Text + "%';";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                iteam_gv.DataSource = dt;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//product_type
        {
            if (Product_type.Text == "ALL")
            {
                LoadProductTable();
            }
            else
            {
                try
                {
                    string query = "SELECT * FROM PRODUCT_TB WHERE P_TYPE='" + Product_type.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                    DataTable dtProduct = new DataTable();
                    sda.Fill(dtProduct);
                    iteam_gv.DataSource = dtProduct;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading product table: " + ex.Message);
                }
            }

            
        }

        private static Random random = new Random();//exception
        public static int GenerateOID()
        {
            return random.Next(1, 9999);
        }
        public int SID;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Customer_Dashboard().Show();
        }

        private void exit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void c_btn4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginPage().Show();
        }

        private void button9_Click(object sender, EventArgs e)//cancell_btn
        {
            if(delete== true)
            {
                string query = "DELETE FROM ORDER_TB WHERE O_ID = '" + OID + "'";

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
                        MessageBox.Show("Order successfully Cancelled");
                        delete = false;
                        UpdateOrderAmount();
                        label4.Text = "0";
                        totalamount = 0;
                    }
                    else
                    {
                        MessageBox.Show("Delete failed. Please try again.");
                    }
                }
                dt.Clear();
            }
            else
            {
                MessageBox.Show("Doesnt have any order");
            }
           
        }

        public static int OID;

        private void button1_Click(object sender, EventArgs e)//Buy_now_btn
        {
           
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No items in the cart. Please add items before placing an order.");
                return;
            }
            else
            {
                
                this.Hide();
                new Payment().Show();
            }
           
            

        }

        private void textBox3_Enter_1(object sender, EventArgs e)
        {
            if (Search_textbox.Text == "Search") 
            {
                Search_textbox.Text = ""; 
                Search_textbox.ForeColor = System.Drawing.Color.Black; 
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (Search_textbox.Text == "")
            {
                Search_textbox.Text = "Search";
                Search_textbox.ForeColor = System.Drawing.Color.Gray;
            }
        }
       

        private void OderPlace_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Number", typeof(int));
            dt.Columns.Add("P_ID", typeof(int));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("UnitPrice", typeof(int));
            dt.Columns.Add("Discount", typeof(int));
            dt.Columns.Add("Quantity", typeof(int));
            dt.Columns.Add("Total", typeof(int));
            Product_type.Text = Customer_Dashboard.type;
            dataGridView2.DataSource = dt;
            LoadProductTable();
            SID = GenerateOID();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)//product_gridview
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
                    var row = iteam_gv.Rows[e.RowIndex];

                    P_ID = Convert.ToInt32(row.Cells[0].Value);
                    item = row.Cells[2].Value.ToString();
                    category = row.Cells[3].Value.ToString();
                    price = Convert.ToInt32(row.Cells[5].Value);
                    discount = Convert.ToInt32(row.Cells[4].Value);
                    totalqty = Convert.ToInt32(row.Cells[6].Value);
                    product_name.Text = item.ToString();

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
