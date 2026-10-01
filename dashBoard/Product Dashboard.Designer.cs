namespace SupershopManagement.dashBoard
{
    partial class Product_Dashboard
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
            this.Product_Add_Quantity = new System.Windows.Forms.TextBox();
            this.Product_Add_Gridview = new System.Windows.Forms.DataGridView();
            this.Product_Add_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Product_Add_Discount = new System.Windows.Forms.TextBox();
            this.Product_Add_Price = new System.Windows.Forms.TextBox();
            this.Product_Add_Name = new System.Windows.Forms.TextBox();
            this.Product_Add_Category = new System.Windows.Forms.ComboBox();
            this.Product_Update_Btn = new System.Windows.Forms.Button();
            this.Product_Delete_Btn = new System.Windows.Forms.Button();
            this.Product_Dashboard_Logut_Btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Product_Update_Id = new System.Windows.Forms.TextBox();
            this.Product_Update_Quantity = new System.Windows.Forms.TextBox();
            this.Product_Update_dataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Product_Update_Discount = new System.Windows.Forms.TextBox();
            this.Product_Update_Price = new System.Windows.Forms.TextBox();
            this.Product_Update_Name = new System.Windows.Forms.TextBox();
            this.Product_Update_Category = new System.Windows.Forms.ComboBox();
            this.Product_Delete_panel = new System.Windows.Forms.Panel();
            this.Product_Delete_Id_textBox = new System.Windows.Forms.TextBox();
            this.C = new System.Windows.Forms.DataGridView();
            this.Product_Details_Name = new System.Windows.Forms.Label();
            this.Product_Dashboard_Delete_Btn = new System.Windows.Forms.Button();
            this.Product_Dashboard_Add_Btn = new System.Windows.Forms.Button();
            this.Product_Dashboard_Update_Btn = new System.Windows.Forms.Button();
            this.exit1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Product_Add_Gridview)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Product_Update_dataGridView)).BeginInit();
            this.Product_Delete_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Product_Add_Quantity);
            this.panel1.Controls.Add(this.Product_Add_Gridview);
            this.panel1.Controls.Add(this.Product_Add_Btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Product_Add_Discount);
            this.panel1.Controls.Add(this.Product_Add_Price);
            this.panel1.Controls.Add(this.Product_Add_Name);
            this.panel1.Controls.Add(this.Product_Add_Category);
            this.panel1.Location = new System.Drawing.Point(212, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 471);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // Product_Add_Quantity
            // 
            this.Product_Add_Quantity.BackColor = System.Drawing.Color.Silver;
            this.Product_Add_Quantity.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.Product_Add_Quantity.Location = new System.Drawing.Point(67, 325);
            this.Product_Add_Quantity.Name = "Product_Add_Quantity";
            this.Product_Add_Quantity.Size = new System.Drawing.Size(192, 36);
            this.Product_Add_Quantity.TabIndex = 30;
            this.Product_Add_Quantity.Text = "Quantity";
            // 
            // Product_Add_Gridview
            // 
            this.Product_Add_Gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Product_Add_Gridview.Location = new System.Drawing.Point(295, 88);
            this.Product_Add_Gridview.Name = "Product_Add_Gridview";
            this.Product_Add_Gridview.RowHeadersWidth = 51;
            this.Product_Add_Gridview.RowTemplate.Height = 24;
            this.Product_Add_Gridview.Size = new System.Drawing.Size(514, 333);
            this.Product_Add_Gridview.TabIndex = 29;
            this.Product_Add_Gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Product_Add_Btn
            // 
            this.Product_Add_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Product_Add_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Add_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Product_Add_Btn.Location = new System.Drawing.Point(85, 382);
            this.Product_Add_Btn.Name = "Product_Add_Btn";
            this.Product_Add_Btn.Size = new System.Drawing.Size(117, 39);
            this.Product_Add_Btn.TabIndex = 28;
            this.Product_Add_Btn.Text = "ADD";
            this.Product_Add_Btn.UseVisualStyleBackColor = false;
            this.Product_Add_Btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(355, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 34);
            this.label1.TabIndex = 25;
            this.label1.Text = "Product Details";
            // 
            // Product_Add_Discount
            // 
            this.Product_Add_Discount.BackColor = System.Drawing.Color.Silver;
            this.Product_Add_Discount.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.Product_Add_Discount.Location = new System.Drawing.Point(67, 264);
            this.Product_Add_Discount.Name = "Product_Add_Discount";
            this.Product_Add_Discount.Size = new System.Drawing.Size(192, 36);
            this.Product_Add_Discount.TabIndex = 24;
            this.Product_Add_Discount.Text = "Discount";
            // 
            // Product_Add_Price
            // 
            this.Product_Add_Price.BackColor = System.Drawing.Color.Silver;
            this.Product_Add_Price.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.Product_Add_Price.Location = new System.Drawing.Point(67, 209);
            this.Product_Add_Price.Name = "Product_Add_Price";
            this.Product_Add_Price.Size = new System.Drawing.Size(192, 36);
            this.Product_Add_Price.TabIndex = 23;
            this.Product_Add_Price.Text = "Price";
            // 
            // Product_Add_Name
            // 
            this.Product_Add_Name.BackColor = System.Drawing.Color.Silver;
            this.Product_Add_Name.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.Product_Add_Name.Location = new System.Drawing.Point(67, 87);
            this.Product_Add_Name.Name = "Product_Add_Name";
            this.Product_Add_Name.Size = new System.Drawing.Size(192, 36);
            this.Product_Add_Name.TabIndex = 22;
            this.Product_Add_Name.Text = "Name";
            // 
            // Product_Add_Category
            // 
            this.Product_Add_Category.BackColor = System.Drawing.Color.Silver;
            this.Product_Add_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Product_Add_Category.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.Product_Add_Category.FormattingEnabled = true;
            this.Product_Add_Category.Items.AddRange(new object[] {
            "Groceries",
            "Vegetables",
            "Cosmetics",
            "Baby Product"});
            this.Product_Add_Category.Location = new System.Drawing.Point(67, 151);
            this.Product_Add_Category.Name = "Product_Add_Category";
            this.Product_Add_Category.Size = new System.Drawing.Size(192, 35);
            this.Product_Add_Category.TabIndex = 21;
            // 
            // Product_Update_Btn
            // 
            this.Product_Update_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Product_Update_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Update_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Product_Update_Btn.Location = new System.Drawing.Point(17, 407);
            this.Product_Update_Btn.Name = "Product_Update_Btn";
            this.Product_Update_Btn.Size = new System.Drawing.Size(117, 39);
            this.Product_Update_Btn.TabIndex = 27;
            this.Product_Update_Btn.Text = "Update";
            this.Product_Update_Btn.UseVisualStyleBackColor = false;
            this.Product_Update_Btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Product_Delete_Btn
            // 
            this.Product_Delete_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Product_Delete_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Delete_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Product_Delete_Btn.Location = new System.Drawing.Point(86, 197);
            this.Product_Delete_Btn.Name = "Product_Delete_Btn";
            this.Product_Delete_Btn.Size = new System.Drawing.Size(117, 39);
            this.Product_Delete_Btn.TabIndex = 26;
            this.Product_Delete_Btn.Text = "Delete";
            this.Product_Delete_Btn.UseVisualStyleBackColor = false;
            this.Product_Delete_Btn.Click += new System.EventHandler(this.button6_Click);
            // 
            // Product_Dashboard_Logut_Btn
            // 
            this.Product_Dashboard_Logut_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Product_Dashboard_Logut_Btn.FlatAppearance.BorderSize = 0;
            this.Product_Dashboard_Logut_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Product_Dashboard_Logut_Btn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Dashboard_Logut_Btn.ForeColor = System.Drawing.Color.White;
            this.Product_Dashboard_Logut_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Product_Dashboard_Logut_Btn.Location = new System.Drawing.Point(12, 494);
            this.Product_Dashboard_Logut_Btn.Name = "Product_Dashboard_Logut_Btn";
            this.Product_Dashboard_Logut_Btn.Size = new System.Drawing.Size(141, 45);
            this.Product_Dashboard_Logut_Btn.TabIndex = 4;
            this.Product_Dashboard_Logut_Btn.Text = "Logout";
            this.Product_Dashboard_Logut_Btn.UseVisualStyleBackColor = false;
            this.Product_Dashboard_Logut_Btn.Click += new System.EventHandler(this.Product_Dashboard_Logut_Btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Product_Update_Id);
            this.panel2.Controls.Add(this.Product_Update_Quantity);
            this.panel2.Controls.Add(this.Product_Update_Btn);
            this.panel2.Controls.Add(this.Product_Update_dataGridView);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Product_Update_Discount);
            this.panel2.Controls.Add(this.Product_Update_Price);
            this.panel2.Controls.Add(this.Product_Update_Name);
            this.panel2.Controls.Add(this.Product_Update_Category);
            this.panel2.Location = new System.Drawing.Point(209, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 482);
            this.panel2.TabIndex = 5;
            this.panel2.Visible = false;
            // 
            // Product_Update_Id
            // 
            this.Product_Update_Id.BackColor = System.Drawing.Color.Silver;
            this.Product_Update_Id.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.Product_Update_Id.Location = new System.Drawing.Point(69, 87);
            this.Product_Update_Id.Name = "Product_Update_Id";
            this.Product_Update_Id.ReadOnly = true;
            this.Product_Update_Id.Size = new System.Drawing.Size(192, 36);
            this.Product_Update_Id.TabIndex = 31;
            this.Product_Update_Id.Text = "ID";
            this.Product_Update_Id.Enter += new System.EventHandler(this.id_Enter);
            this.Product_Update_Id.Leave += new System.EventHandler(this.id_Leave);
            // 
            // Product_Update_Quantity
            // 
            this.Product_Update_Quantity.BackColor = System.Drawing.Color.Silver;
            this.Product_Update_Quantity.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.Product_Update_Quantity.Location = new System.Drawing.Point(67, 352);
            this.Product_Update_Quantity.Name = "Product_Update_Quantity";
            this.Product_Update_Quantity.Size = new System.Drawing.Size(192, 36);
            this.Product_Update_Quantity.TabIndex = 30;
            this.Product_Update_Quantity.Text = "Quantity";
            // 
            // Product_Update_dataGridView
            // 
            this.Product_Update_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Product_Update_dataGridView.Location = new System.Drawing.Point(274, 82);
            this.Product_Update_dataGridView.Name = "Product_Update_dataGridView";
            this.Product_Update_dataGridView.RowHeadersWidth = 51;
            this.Product_Update_dataGridView.RowTemplate.Height = 24;
            this.Product_Update_dataGridView.Size = new System.Drawing.Size(508, 302);
            this.Product_Update_dataGridView.TabIndex = 29;
            this.Product_Update_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.Product_Update_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Product_Update_dataGridView_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(355, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 34);
            this.label2.TabIndex = 25;
            this.label2.Text = "Product Details";
            // 
            // Product_Update_Discount
            // 
            this.Product_Update_Discount.BackColor = System.Drawing.Color.Silver;
            this.Product_Update_Discount.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.Product_Update_Discount.Location = new System.Drawing.Point(67, 295);
            this.Product_Update_Discount.Name = "Product_Update_Discount";
            this.Product_Update_Discount.Size = new System.Drawing.Size(192, 36);
            this.Product_Update_Discount.TabIndex = 24;
            this.Product_Update_Discount.Text = "discount";
            // 
            // Product_Update_Price
            // 
            this.Product_Update_Price.BackColor = System.Drawing.Color.Silver;
            this.Product_Update_Price.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.Product_Update_Price.Location = new System.Drawing.Point(69, 239);
            this.Product_Update_Price.Name = "Product_Update_Price";
            this.Product_Update_Price.Size = new System.Drawing.Size(192, 36);
            this.Product_Update_Price.TabIndex = 23;
            this.Product_Update_Price.Text = "Price";
            // 
            // Product_Update_Name
            // 
            this.Product_Update_Name.BackColor = System.Drawing.Color.Silver;
            this.Product_Update_Name.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.Product_Update_Name.Location = new System.Drawing.Point(69, 138);
            this.Product_Update_Name.Name = "Product_Update_Name";
            this.Product_Update_Name.Size = new System.Drawing.Size(192, 36);
            this.Product_Update_Name.TabIndex = 22;
            this.Product_Update_Name.Text = "Name";
            // 
            // Product_Update_Category
            // 
            this.Product_Update_Category.BackColor = System.Drawing.Color.Gainsboro;
            this.Product_Update_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Product_Update_Category.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.Product_Update_Category.FormattingEnabled = true;
            this.Product_Update_Category.Items.AddRange(new object[] {
            "Groceries",
            "Vegetables ",
            "Cosmetics",
            "Baby Product"});
            this.Product_Update_Category.Location = new System.Drawing.Point(69, 193);
            this.Product_Update_Category.Name = "Product_Update_Category";
            this.Product_Update_Category.Size = new System.Drawing.Size(192, 35);
            this.Product_Update_Category.TabIndex = 21;
            // 
            // Product_Delete_panel
            // 
            this.Product_Delete_panel.BackColor = System.Drawing.Color.White;
            this.Product_Delete_panel.Controls.Add(this.Product_Delete_Id_textBox);
            this.Product_Delete_panel.Controls.Add(this.C);
            this.Product_Delete_panel.Controls.Add(this.Product_Details_Name);
            this.Product_Delete_panel.Controls.Add(this.Product_Delete_Btn);
            this.Product_Delete_panel.Location = new System.Drawing.Point(212, 41);
            this.Product_Delete_panel.Name = "Product_Delete_panel";
            this.Product_Delete_panel.Size = new System.Drawing.Size(824, 435);
            this.Product_Delete_panel.TabIndex = 6;
            this.Product_Delete_panel.Visible = false;
            this.Product_Delete_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Product_Delete_Id_textBox
            // 
            this.Product_Delete_Id_textBox.BackColor = System.Drawing.Color.Silver;
            this.Product_Delete_Id_textBox.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.Product_Delete_Id_textBox.Location = new System.Drawing.Point(64, 137);
            this.Product_Delete_Id_textBox.Name = "Product_Delete_Id_textBox";
            this.Product_Delete_Id_textBox.ReadOnly = true;
            this.Product_Delete_Id_textBox.Size = new System.Drawing.Size(192, 36);
            this.Product_Delete_Id_textBox.TabIndex = 31;
            this.Product_Delete_Id_textBox.Text = "ID";
            this.Product_Delete_Id_textBox.TextChanged += new System.EventHandler(this.p_id_TextChanged);
            // 
            // C
            // 
            this.C.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.C.Location = new System.Drawing.Point(272, 71);
            this.C.Name = "C";
            this.C.RowHeadersWidth = 51;
            this.C.RowTemplate.Height = 24;
            this.C.Size = new System.Drawing.Size(475, 353);
            this.C.TabIndex = 29;
            this.C.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // Product_Details_Name
            // 
            this.Product_Details_Name.AutoSize = true;
            this.Product_Details_Name.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Details_Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Product_Details_Name.Location = new System.Drawing.Point(355, 17);
            this.Product_Details_Name.Name = "Product_Details_Name";
            this.Product_Details_Name.Size = new System.Drawing.Size(217, 34);
            this.Product_Details_Name.TabIndex = 25;
            this.Product_Details_Name.Text = "Product Details";
            this.Product_Details_Name.Click += new System.EventHandler(this.Product_Details_Name_Click);
            // 
            // Product_Dashboard_Delete_Btn
            // 
            this.Product_Dashboard_Delete_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Product_Dashboard_Delete_Btn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Dashboard_Delete_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Product_Dashboard_Delete_Btn.Location = new System.Drawing.Point(12, 206);
            this.Product_Dashboard_Delete_Btn.Name = "Product_Dashboard_Delete_Btn";
            this.Product_Dashboard_Delete_Btn.Size = new System.Drawing.Size(141, 39);
            this.Product_Dashboard_Delete_Btn.TabIndex = 27;
            this.Product_Dashboard_Delete_Btn.Text = "Delete item";
            this.Product_Dashboard_Delete_Btn.UseVisualStyleBackColor = false;
            this.Product_Dashboard_Delete_Btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // Product_Dashboard_Add_Btn
            // 
            this.Product_Dashboard_Add_Btn.BackColor = System.Drawing.Color.Green;
            this.Product_Dashboard_Add_Btn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Dashboard_Add_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Product_Dashboard_Add_Btn.Location = new System.Drawing.Point(12, 86);
            this.Product_Dashboard_Add_Btn.Name = "Product_Dashboard_Add_Btn";
            this.Product_Dashboard_Add_Btn.Size = new System.Drawing.Size(141, 39);
            this.Product_Dashboard_Add_Btn.TabIndex = 28;
            this.Product_Dashboard_Add_Btn.Text = "add item";
            this.Product_Dashboard_Add_Btn.UseVisualStyleBackColor = false;
            this.Product_Dashboard_Add_Btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // Product_Dashboard_Update_Btn
            // 
            this.Product_Dashboard_Update_Btn.BackColor = System.Drawing.Color.Navy;
            this.Product_Dashboard_Update_Btn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Dashboard_Update_Btn.ForeColor = System.Drawing.Color.White;
            this.Product_Dashboard_Update_Btn.Location = new System.Drawing.Point(12, 143);
            this.Product_Dashboard_Update_Btn.Name = "Product_Dashboard_Update_Btn";
            this.Product_Dashboard_Update_Btn.Size = new System.Drawing.Size(141, 39);
            this.Product_Dashboard_Update_Btn.TabIndex = 29;
            this.Product_Dashboard_Update_Btn.Text = "update";
            this.Product_Dashboard_Update_Btn.UseVisualStyleBackColor = false;
            this.Product_Dashboard_Update_Btn.Click += new System.EventHandler(this.button5_Click);
            // 
            // exit1
            // 
            this.exit1.AutoSize = true;
            this.exit1.BackColor = System.Drawing.Color.White;
            this.exit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit1.ForeColor = System.Drawing.Color.Black;
            this.exit1.Location = new System.Drawing.Point(1026, 0);
            this.exit1.Name = "exit1";
            this.exit1.Size = new System.Drawing.Size(27, 25);
            this.exit1.TabIndex = 30;
            this.exit1.Text = "X";
            this.exit1.Click += new System.EventHandler(this.exit1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SupershopManagement.Properties.Resources.left_arrow1;
            this.pictureBox1.Location = new System.Drawing.Point(992, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Product_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1055, 584);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exit1);
            this.Controls.Add(this.Product_Dashboard_Update_Btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Product_Dashboard_Add_Btn);
            this.Controls.Add(this.Product_Delete_panel);
            this.Controls.Add(this.Product_Dashboard_Delete_Btn);
            this.Controls.Add(this.Product_Dashboard_Logut_Btn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product_Dashboard";
            this.Load += new System.EventHandler(this.Product_Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Product_Add_Gridview)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Product_Update_dataGridView)).EndInit();
            this.Product_Delete_panel.ResumeLayout(false);
            this.Product_Delete_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Product_Add_Category;
        private System.Windows.Forms.TextBox Product_Add_Name;
        private System.Windows.Forms.TextBox Product_Add_Discount;
        private System.Windows.Forms.TextBox Product_Add_Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Product_Add_Btn;
        private System.Windows.Forms.Button Product_Update_Btn;
        private System.Windows.Forms.Button Product_Delete_Btn;
        private System.Windows.Forms.Button Product_Dashboard_Logut_Btn;
        private System.Windows.Forms.DataGridView Product_Add_Gridview;
        private System.Windows.Forms.TextBox Product_Add_Quantity;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Product_Update_Quantity;
        private System.Windows.Forms.DataGridView Product_Update_dataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Product_Update_Discount;
        private System.Windows.Forms.TextBox Product_Update_Price;
        private System.Windows.Forms.ComboBox Product_Update_Category;
        private System.Windows.Forms.Panel Product_Delete_panel;
        private System.Windows.Forms.TextBox Product_Delete_Id_textBox;
        private System.Windows.Forms.DataGridView C;
        private System.Windows.Forms.Label Product_Details_Name;
        private System.Windows.Forms.Button Product_Dashboard_Delete_Btn;
        private System.Windows.Forms.Button Product_Dashboard_Add_Btn;
        private System.Windows.Forms.Button Product_Dashboard_Update_Btn;
        private System.Windows.Forms.Label exit1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Product_Update_Id;
        private System.Windows.Forms.TextBox Product_Update_Name;
    }
}