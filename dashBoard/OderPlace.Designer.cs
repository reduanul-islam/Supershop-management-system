namespace SupershopManagement.dashBoard
{
    partial class OderPlace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.product_name = new System.Windows.Forms.TextBox();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Product_type = new System.Windows.Forms.ComboBox();
            this.Search_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.iteam_gv = new System.Windows.Forms.DataGridView();
            this.buy_btn = new System.Windows.Forms.Button();
            this.add_to_cart = new System.Windows.Forms.Button();
            this.quantity_textbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt3 = new System.Windows.Forms.Label();
            this.bt4 = new System.Windows.Forms.Label();
            this.bt5 = new System.Windows.Forms.Label();
            this.bt2 = new System.Windows.Forms.Label();
            this.bt1 = new System.Windows.Forms.Label();
            this.add_more = new System.Windows.Forms.Button();
            this.c_btn4 = new System.Windows.Forms.Button();
            this.exit1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.all_product_btn = new System.Windows.Forms.Button();
            this.Vegetables_btn = new System.Windows.Forms.Button();
            this.Cosmetics_btn = new System.Windows.Forms.Button();
            this.baby_product_btn = new System.Windows.Forms.Button();
            this.groceries_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iteam_gv)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.product_name);
            this.panel1.Controls.Add(this.cancel_btn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Product_type);
            this.panel1.Controls.Add(this.Search_textbox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.iteam_gv);
            this.panel1.Controls.Add(this.buy_btn);
            this.panel1.Controls.Add(this.add_to_cart);
            this.panel1.Controls.Add(this.quantity_textbox);
            this.panel1.Location = new System.Drawing.Point(173, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 587);
            this.panel1.TabIndex = 0;
            // 
            // product_name
            // 
            this.product_name.BackColor = System.Drawing.Color.Silver;
            this.product_name.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.product_name.ForeColor = System.Drawing.Color.Gray;
            this.product_name.Location = new System.Drawing.Point(73, 106);
            this.product_name.Name = "product_name";
            this.product_name.Size = new System.Drawing.Size(230, 36);
            this.product_name.TabIndex = 22;
            this.product_name.TabStop = false;
            this.product_name.Text = "Name";
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.Maroon;
            this.cancel_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancel_btn.Location = new System.Drawing.Point(83, 322);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(189, 39);
            this.cancel_btn.TabIndex = 21;
            this.cancel_btn.Text = "Cancel Order";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.button9_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label4.Location = new System.Drawing.Point(673, 559);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 27);
            this.label4.TabIndex = 19;
            this.label4.Text = "0 $";
            // 
            // Product_type
            // 
            this.Product_type.BackColor = System.Drawing.Color.Silver;
            this.Product_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Product_type.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.Product_type.FormattingEnabled = true;
            this.Product_type.Items.AddRange(new object[] {
            "Groceries",
            "Vegetables ",
            "Cosmetics",
            "Baby Product",
            "ALL"});
            this.Product_type.Location = new System.Drawing.Point(73, 157);
            this.Product_type.Name = "Product_type";
            this.Product_type.Size = new System.Drawing.Size(230, 35);
            this.Product_type.TabIndex = 20;
            this.Product_type.TabStop = false;
            this.Product_type.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Search_textbox
            // 
            this.Search_textbox.BackColor = System.Drawing.Color.Silver;
            this.Search_textbox.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.Search_textbox.ForeColor = System.Drawing.Color.Gray;
            this.Search_textbox.Location = new System.Drawing.Point(73, 52);
            this.Search_textbox.Name = "Search_textbox";
            this.Search_textbox.Size = new System.Drawing.Size(230, 36);
            this.Search_textbox.TabIndex = 19;
            this.Search_textbox.Text = "Search";
            this.Search_textbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            this.Search_textbox.Enter += new System.EventHandler(this.textBox3_Enter_1);
            this.Search_textbox.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label3.Location = new System.Drawing.Point(492, 555);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 27);
            this.label3.TabIndex = 16;
            this.label3.Text = "Total Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label1.Location = new System.Drawing.Point(492, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 27);
            this.label1.TabIndex = 15;
            this.label1.Text = "My Order";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(115, 395);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(865, 150);
            this.dataGridView2.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.label2.Location = new System.Drawing.Point(585, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "Select Item";
            // 
            // iteam_gv
            // 
            this.iteam_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iteam_gv.Location = new System.Drawing.Point(326, 61);
            this.iteam_gv.Name = "iteam_gv";
            this.iteam_gv.RowHeadersWidth = 51;
            this.iteam_gv.RowTemplate.Height = 24;
            this.iteam_gv.Size = new System.Drawing.Size(693, 276);
            this.iteam_gv.TabIndex = 12;
            this.iteam_gv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // buy_btn
            // 
            this.buy_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buy_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buy_btn.Location = new System.Drawing.Point(805, 551);
            this.buy_btn.Name = "buy_btn";
            this.buy_btn.Size = new System.Drawing.Size(175, 39);
            this.buy_btn.TabIndex = 9;
            this.buy_btn.Text = "BUY NOW";
            this.buy_btn.UseVisualStyleBackColor = false;
            this.buy_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // add_to_cart
            // 
            this.add_to_cart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.add_to_cart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_to_cart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_to_cart.Location = new System.Drawing.Point(83, 273);
            this.add_to_cart.Name = "add_to_cart";
            this.add_to_cart.Size = new System.Drawing.Size(189, 39);
            this.add_to_cart.TabIndex = 9;
            this.add_to_cart.Text = "Add to Cart";
            this.add_to_cart.UseVisualStyleBackColor = false;
            this.add_to_cart.Click += new System.EventHandler(this.button5_Click);
            // 
            // quantity_textbox
            // 
            this.quantity_textbox.BackColor = System.Drawing.Color.Silver;
            this.quantity_textbox.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.quantity_textbox.ForeColor = System.Drawing.Color.Gray;
            this.quantity_textbox.Location = new System.Drawing.Point(73, 216);
            this.quantity_textbox.Name = "quantity_textbox";
            this.quantity_textbox.Size = new System.Drawing.Size(230, 36);
            this.quantity_textbox.TabIndex = 7;
            this.quantity_textbox.TabStop = false;
            this.quantity_textbox.Text = "Quantity";
            this.quantity_textbox.Enter += new System.EventHandler(this.quantity_textbox_Enter);
            this.quantity_textbox.Leave += new System.EventHandler(this.quantity_textbox_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.bt3);
            this.panel2.Controls.Add(this.all_product_btn);
            this.panel2.Controls.Add(this.Vegetables_btn);
            this.panel2.Controls.Add(this.Cosmetics_btn);
            this.panel2.Controls.Add(this.baby_product_btn);
            this.panel2.Controls.Add(this.bt4);
            this.panel2.Controls.Add(this.bt5);
            this.panel2.Controls.Add(this.bt2);
            this.panel2.Controls.Add(this.bt1);
            this.panel2.Controls.Add(this.groceries_btn);
            this.panel2.Location = new System.Drawing.Point(165, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1062, 17);
            this.panel2.TabIndex = 18;
            this.panel2.Visible = false;
            // 
            // bt3
            // 
            this.bt3.AutoSize = true;
            this.bt3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.Location = new System.Drawing.Point(435, 367);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(115, 23);
            this.bt3.TabIndex = 6;
            this.bt3.Text = "All Product";
            // 
            // bt4
            // 
            this.bt4.AutoSize = true;
            this.bt4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.Location = new System.Drawing.Point(128, 505);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(122, 23);
            this.bt4.TabIndex = 1;
            this.bt4.Text = "Vegetables";
            // 
            // bt5
            // 
            this.bt5.AutoSize = true;
            this.bt5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.Location = new System.Drawing.Point(707, 505);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(113, 23);
            this.bt5.TabIndex = 1;
            this.bt5.Text = "Cosmetics";
            // 
            // bt2
            // 
            this.bt2.AutoSize = true;
            this.bt2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.Location = new System.Drawing.Point(707, 223);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(140, 23);
            this.bt2.TabIndex = 1;
            this.bt2.Text = "Baby Product";
            // 
            // bt1
            // 
            this.bt1.AutoSize = true;
            this.bt1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(145, 229);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(105, 23);
            this.bt1.TabIndex = 1;
            this.bt1.Text = "Groceries";
            // 
            // add_more
            // 
            this.add_more.BackColor = System.Drawing.Color.White;
            this.add_more.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_more.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add_more.Location = new System.Drawing.Point(12, 92);
            this.add_more.Name = "add_more";
            this.add_more.Size = new System.Drawing.Size(147, 39);
            this.add_more.TabIndex = 10;
            this.add_more.Text = "Add More";
            this.add_more.UseVisualStyleBackColor = false;
            this.add_more.Click += new System.EventHandler(this.button6_Click);
            // 
            // c_btn4
            // 
            this.c_btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.c_btn4.FlatAppearance.BorderSize = 0;
            this.c_btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c_btn4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_btn4.ForeColor = System.Drawing.Color.White;
            this.c_btn4.Location = new System.Drawing.Point(4, 589);
            this.c_btn4.Name = "c_btn4";
            this.c_btn4.Size = new System.Drawing.Size(155, 47);
            this.c_btn4.TabIndex = 11;
            this.c_btn4.Text = "Logout";
            this.c_btn4.UseVisualStyleBackColor = false;
            this.c_btn4.Click += new System.EventHandler(this.c_btn4_Click);
            // 
            // exit1
            // 
            this.exit1.AutoSize = true;
            this.exit1.BackColor = System.Drawing.Color.White;
            this.exit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit1.ForeColor = System.Drawing.Color.Black;
            this.exit1.Location = new System.Drawing.Point(1187, -1);
            this.exit1.Name = "exit1";
            this.exit1.Size = new System.Drawing.Size(27, 25);
            this.exit1.TabIndex = 51;
            this.exit1.Text = "X";
            this.exit1.Click += new System.EventHandler(this.exit1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SupershopManagement.Properties.Resources.left_arrow1;
            this.pictureBox1.Location = new System.Drawing.Point(1143, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // all_product_btn
            // 
            this.all_product_btn.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.all_product_btn.Image = global::SupershopManagement.Properties.Resources.market1;
            this.all_product_btn.Location = new System.Drawing.Point(382, 223);
            this.all_product_btn.Name = "all_product_btn";
            this.all_product_btn.Size = new System.Drawing.Size(197, 135);
            this.all_product_btn.TabIndex = 5;
            this.all_product_btn.UseVisualStyleBackColor = true;
            this.all_product_btn.Click += new System.EventHandler(this.button8_Click);
            // 
            // Vegetables_btn
            // 
            this.Vegetables_btn.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.Vegetables_btn.Image = global::SupershopManagement.Properties.Resources.vegetables1;
            this.Vegetables_btn.Location = new System.Drawing.Point(92, 367);
            this.Vegetables_btn.Name = "Vegetables_btn";
            this.Vegetables_btn.Size = new System.Drawing.Size(197, 135);
            this.Vegetables_btn.TabIndex = 4;
            this.Vegetables_btn.UseVisualStyleBackColor = true;
            this.Vegetables_btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // Cosmetics_btn
            // 
            this.Cosmetics_btn.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.Cosmetics_btn.Image = global::SupershopManagement.Properties.Resources.cosmetics;
            this.Cosmetics_btn.Location = new System.Drawing.Point(663, 367);
            this.Cosmetics_btn.Name = "Cosmetics_btn";
            this.Cosmetics_btn.Size = new System.Drawing.Size(197, 135);
            this.Cosmetics_btn.TabIndex = 3;
            this.Cosmetics_btn.UseVisualStyleBackColor = true;
            this.Cosmetics_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // baby_product_btn
            // 
            this.baby_product_btn.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.baby_product_btn.Image = global::SupershopManagement.Properties.Resources.baby_products1;
            this.baby_product_btn.Location = new System.Drawing.Point(663, 85);
            this.baby_product_btn.Name = "baby_product_btn";
            this.baby_product_btn.Size = new System.Drawing.Size(197, 135);
            this.baby_product_btn.TabIndex = 2;
            this.baby_product_btn.UseVisualStyleBackColor = true;
            this.baby_product_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // groceries_btn
            // 
            this.groceries_btn.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.groceries_btn.Image = global::SupershopManagement.Properties.Resources.grocery_cart1;
            this.groceries_btn.Location = new System.Drawing.Point(101, 93);
            this.groceries_btn.Name = "groceries_btn";
            this.groceries_btn.Size = new System.Drawing.Size(197, 135);
            this.groceries_btn.TabIndex = 0;
            this.groceries_btn.UseVisualStyleBackColor = true;
            this.groceries_btn.Click += new System.EventHandler(this.button7_Click);
            // 
            // OderPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1239, 668);
            this.Controls.Add(this.exit1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.c_btn4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.add_more);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OderPlace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OderPlace";
            this.Load += new System.EventHandler(this.OderPlace_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iteam_gv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button add_more;
        private System.Windows.Forms.Button add_to_cart;
        private System.Windows.Forms.TextBox quantity_textbox;
        private System.Windows.Forms.DataGridView iteam_gv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buy_btn;
        private System.Windows.Forms.Button c_btn4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Vegetables_btn;
        private System.Windows.Forms.Button Cosmetics_btn;
        private System.Windows.Forms.Button baby_product_btn;
        private System.Windows.Forms.Label bt4;
        private System.Windows.Forms.Label bt5;
        private System.Windows.Forms.Label bt2;
        private System.Windows.Forms.Label bt1;
        private System.Windows.Forms.Button groceries_btn;
        private System.Windows.Forms.TextBox Search_textbox;
        private System.Windows.Forms.Label bt3;
        private System.Windows.Forms.Button all_product_btn;
        private System.Windows.Forms.ComboBox Product_type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label exit1;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.TextBox product_name;
    }
}