using SupershopManagement.login;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SupershopManagement.dashBoard
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-TNA52VSF\SQLEXPRESS;Initial Catalog=SuperShop1;Integrated Security=True");
        public static int B_ID {  get; set; }
        public static string date;
        public static string paytype;
        public static string accountnum;
        public static int amount;
        
        private void Payment_Load(object sender, EventArgs e)
        {
            Nagad_TotalAmount_textBox.Text = OderPlace.totalamount.ToString();
            Bkash_TotalAmount_textBox.Text = OderPlace.totalamount.ToString();
            Card_TotalAmount_textBox.Text = OderPlace.totalamount.ToString();
        }

        private void c_btn2_Click(object sender, EventArgs e)
        {
            Payment_Bkash_Btn.BackColor = Color.FromArgb(48, 56, 79);
            Pay_Card_Panel .Visible = false;
            Pay_nagad_Panel.Visible = false;
            Pay_bkash_Panel.Visible = true;                   
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pay_bkash_Panel.Visible=false;
            Pay_Card_Panel.Visible=false;
            Pay_nagad_Panel.Visible=true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pay_bkash_Panel.Visible = false;
            Pay_Card_Panel.Visible = true;
            Pay_nagad_Panel.Visible = false;
            
        }
        //private void InsertPayment()
        //{
        //    string query = "insert into PAYMENT_TB values ('" + B_ID + "','" + OderPlace.C_ID + "','" + dateTimePicker1.Text.ToString() + "','" + paytype.ToString() + "','" + accountnum + "','" + OderPlace.totalamount + "')";

        //    if (Con.State == ConnectionState.Closed)
        //    {
        //        Con.Open();
        //    }
        //    SqlCommand cmd = new SqlCommand(query, Con);
        //    if (Con.State == ConnectionState.Open)
        //    {
        //        int result = cmd.ExecuteNonQuery();
        //        if (result > 0)
        //        {
        //            MessageBox.Show("User Successfully created");
        //        }
        //        else
        //        {
        //            MessageBox.Show("User is not Successfully created");

        //        }
        //    }
        //    Con.Close();
        //}

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void Pay_nagad_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Nagad_PayNow_Btn_Click(object sender, EventArgs e)
        {
            if (Nagad_Numbe_textBox.Text == "" || Nagad_Pass_textBox.Text == "")
            {
                MessageBox.Show("Give Number and Password");
            }
            else
            {
                string query = "insert into PAYMENT_TB values ('" + OderPlace.OID + "','" + LoginPage.RUname + "','" + dateTimePicker1.Text + "','" + Payment_Nagad_Btn.Text + "','" + Nagad_Numbe_textBox.Text + "','" + OderPlace.totalamount + "')";

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
                        MessageBox.Show("payment successfull");
                        this.Hide();
                        new Customer_Dashboard().Show();
                    }
                    else
                    {
                        MessageBox.Show("User is not Successfully created");

                    }
                }
                Con.Close();
            }
        }

        private void Payment_Methods_Panel_Paint(object sender, PaintEventArgs e)
        {
            Nagad_TotalAmount_textBox.Text = OderPlace.totalamount.ToString();
        }

        private void Card_PayNow_Btn_Click(object sender, EventArgs e)
        {
            if (Card_Number_textBox.Text == "" || Card_Pass_textBox.Text == "")
            {
                MessageBox.Show("Give Number and Password");
            }
            else
            {
                string query = "insert into PAYMENT_TB values ('" + OderPlace.OID + "','" + LoginPage.RUname + "','" + dateTimePicker1.Text + "','" + Payment_Card_Btn.Text + "','" + Card_Number_textBox.Text + "','" + OderPlace.totalamount + "')";

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
                        MessageBox.Show("Payment successfull");
                        this.Hide();
                        new Customer_Dashboard().Show();
                    }
                    else
                    {
                        MessageBox.Show("User is not Successfully created");

                    }
                }
                Con.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)//pay_bkash
        {
            if (Bkash_Number_textBox.Text == "" || Bkash_Pass_textBox.Text == "")
            {
                MessageBox.Show("Give Number and Password");
            }
            else
            {
                string query = "insert into PAYMENT_TB values ('" + OderPlace.OID + "','" + LoginPage.RUname + "','" + dateTimePicker1.Text + "','" + Payment_Bkash_Btn.Text + "','" + Bkash_Number_textBox.Text + "','" + OderPlace.totalamount + "')";

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
                        MessageBox.Show("payment successfull");
                        this.Hide();
                        new Customer_Dashboard().Show();
                    }
                    else
                    {
                        MessageBox.Show("User is not Successfully created");

                    }
                }
                Con.Close();
            }

        }

        private void Manager_Logut_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginPage().Show();     
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
