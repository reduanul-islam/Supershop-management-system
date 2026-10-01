namespace SupershopManagement.WelcomeModel
{
    partial class FormHomePage
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.exit1 = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.Signup_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(231, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(666, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to our Supershop";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(363, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(457, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enhance your Shopping Experience.....";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // exit1
            // 
            this.exit1.AutoSize = true;
            this.exit1.BackColor = System.Drawing.Color.White;
            this.exit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit1.ForeColor = System.Drawing.Color.Black;
            this.exit1.Location = new System.Drawing.Point(1028, 9);
            this.exit1.Name = "exit1";
            this.exit1.Size = new System.Drawing.Size(27, 25);
            this.exit1.TabIndex = 4;
            this.exit1.Text = "X";
            this.exit1.Click += new System.EventHandler(this.label3_Click);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Gray;
            this.login_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 13.2F, System.Drawing.FontStyle.Bold);
            this.login_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login_btn.Location = new System.Drawing.Point(815, 419);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(230, 45);
            this.login_btn.TabIndex = 0;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Signup_btn
            // 
            this.Signup_btn.BackColor = System.Drawing.Color.Gray;
            this.Signup_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Signup_btn.Location = new System.Drawing.Point(815, 351);
            this.Signup_btn.Name = "Signup_btn";
            this.Signup_btn.Size = new System.Drawing.Size(230, 49);
            this.Signup_btn.TabIndex = 1;
            this.Signup_btn.Text = "Sign up";
            this.Signup_btn.UseVisualStyleBackColor = false;
            this.Signup_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1067, 547);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.Signup_btn);
            this.Controls.Add(this.exit1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Purple;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHomePage";
            this.Load += new System.EventHandler(this.FormHomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label exit1;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button Signup_btn;
    }
}