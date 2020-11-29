namespace WindowsFormsFirstApp
{
    partial class Publisher
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.qa_username_label = new System.Windows.Forms.Label();
            this.qa_username_tb = new System.Windows.Forms.TextBox();
            this.qa_password_label = new System.Windows.Forms.Label();
            this.qa_password_tb = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.prod_password_label = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.prod_username_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.qa_cred_btn = new System.Windows.Forms.Button();
            this.prod_cred_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.qa_current_username = new System.Windows.Forms.Label();
            this.qa_current_password = new System.Windows.Forms.Label();
            this.prod_current_username = new System.Windows.Forms.Label();
            this.prod_current_password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // qa_username_label
            // 
            this.qa_username_label.AutoSize = true;
            this.qa_username_label.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.qa_username_label.Location = new System.Drawing.Point(50, 67);
            this.qa_username_label.Name = "qa_username_label";
            this.qa_username_label.Size = new System.Drawing.Size(150, 18);
            this.qa_username_label.TabIndex = 0;
            this.qa_username_label.Text = "Enter QA Username";
            this.qa_username_label.Click += new System.EventHandler(this.qa_username_label_Click);
            // 
            // qa_username_tb
            // 
            this.qa_username_tb.Location = new System.Drawing.Point(226, 62);
            this.qa_username_tb.Name = "qa_username_tb";
            this.qa_username_tb.Size = new System.Drawing.Size(171, 23);
            this.qa_username_tb.TabIndex = 1;
            // 
            // qa_password_label
            // 
            this.qa_password_label.AutoSize = true;
            this.qa_password_label.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.qa_password_label.Location = new System.Drawing.Point(50, 117);
            this.qa_password_label.Name = "qa_password_label";
            this.qa_password_label.Size = new System.Drawing.Size(147, 18);
            this.qa_password_label.TabIndex = 0;
            this.qa_password_label.Text = "Enter QA Password";
            this.qa_password_label.Click += new System.EventHandler(this.qa_username_label_Click);
            // 
            // qa_password_tb
            // 
            this.qa_password_tb.Location = new System.Drawing.Point(226, 117);
            this.qa_password_tb.Name = "qa_password_tb";
            this.qa_password_tb.Size = new System.Drawing.Size(171, 23);
            this.qa_password_tb.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(229, 287);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 23);
            this.textBox1.TabIndex = 1;
            // 
            // prod_password_label
            // 
            this.prod_password_label.AutoSize = true;
            this.prod_password_label.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prod_password_label.Location = new System.Drawing.Point(53, 287);
            this.prod_password_label.Name = "prod_password_label";
            this.prod_password_label.Size = new System.Drawing.Size(160, 18);
            this.prod_password_label.TabIndex = 0;
            this.prod_password_label.Text = "Enter Prod Password";
            this.prod_password_label.Click += new System.EventHandler(this.qa_username_label_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(229, 232);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 23);
            this.textBox2.TabIndex = 1;
            // 
            // prod_username_label
            // 
            this.prod_username_label.AutoSize = true;
            this.prod_username_label.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prod_username_label.Location = new System.Drawing.Point(50, 237);
            this.prod_username_label.Name = "prod_username_label";
            this.prod_username_label.Size = new System.Drawing.Size(163, 18);
            this.prod_username_label.TabIndex = 0;
            this.prod_username_label.Text = "Enter Prod Username";
            this.prod_username_label.Click += new System.EventHandler(this.qa_username_label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "QA Cradencials";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(50, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Production Cradencials";
            // 
            // qa_cred_btn
            // 
            this.qa_cred_btn.Location = new System.Drawing.Point(421, 76);
            this.qa_cred_btn.Name = "qa_cred_btn";
            this.qa_cred_btn.Size = new System.Drawing.Size(120, 47);
            this.qa_cred_btn.TabIndex = 3;
            this.qa_cred_btn.Text = "Save";
            this.qa_cred_btn.UseVisualStyleBackColor = true;
            this.qa_cred_btn.Click += new System.EventHandler(this.qa_cred_btn_Click);
            // 
            // prod_cred_btn
            // 
            this.prod_cred_btn.Location = new System.Drawing.Point(421, 246);
            this.prod_cred_btn.Name = "prod_cred_btn";
            this.prod_cred_btn.Size = new System.Drawing.Size(120, 47);
            this.prod_cred_btn.TabIndex = 3;
            this.prod_cred_btn.Text = "Save";
            this.prod_cred_btn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(622, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "QA Cradencials";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(593, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Production Cradencials";
            // 
            // qa_current_username
            // 
            this.qa_current_username.AutoSize = true;
            this.qa_current_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.qa_current_username.Location = new System.Drawing.Point(657, 67);
            this.qa_current_username.Name = "qa_current_username";
            this.qa_current_username.Size = new System.Drawing.Size(39, 21);
            this.qa_current_username.TabIndex = 4;
            this.qa_current_username.Text = "elad";
            // 
            // qa_current_password
            // 
            this.qa_current_password.AutoSize = true;
            this.qa_current_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.qa_current_password.Location = new System.Drawing.Point(657, 108);
            this.qa_current_password.Name = "qa_current_password";
            this.qa_current_password.Size = new System.Drawing.Size(52, 21);
            this.qa_current_password.TabIndex = 4;
            this.qa_current_password.Text = "label6";
            // 
            // prod_current_username
            // 
            this.prod_current_username.AutoSize = true;
            this.prod_current_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prod_current_username.Location = new System.Drawing.Point(657, 235);
            this.prod_current_username.Name = "prod_current_username";
            this.prod_current_username.Size = new System.Drawing.Size(52, 21);
            this.prod_current_username.TabIndex = 4;
            this.prod_current_username.Text = "label7";
            // 
            // prod_current_password
            // 
            this.prod_current_password.AutoSize = true;
            this.prod_current_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prod_current_password.Location = new System.Drawing.Point(657, 278);
            this.prod_current_password.Name = "prod_current_password";
            this.prod_current_password.Size = new System.Drawing.Size(52, 21);
            this.prod_current_password.TabIndex = 4;
            this.prod_current_password.Text = "label8";
            // 
            // Publisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.qa_current_username);
            this.Controls.Add(this.prod_current_password);
            this.Controls.Add(this.prod_current_username);
            this.Controls.Add(this.qa_current_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prod_cred_btn);
            this.Controls.Add(this.qa_cred_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prod_username_label);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.prod_password_label);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.qa_password_tb);
            this.Controls.Add(this.qa_password_label);
            this.Controls.Add(this.qa_username_tb);
            this.Controls.Add(this.qa_username_label);
            this.Name = "Publisher";
            this.Text = "Publisher";
            this.Load += new System.EventHandler(this.Publisher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label qa_username_label;
        private System.Windows.Forms.TextBox qa_username_tb;
        private System.Windows.Forms.Label qa_password_label;
        private System.Windows.Forms.TextBox qa_password_tb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label prod_password_label;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label prod_username_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button qa_cred_btn;
        private System.Windows.Forms.Button prod_cred_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label qa_current_username;
        private System.Windows.Forms.Label qa_current_password;
        private System.Windows.Forms.Label prod_current_username;
        private System.Windows.Forms.Label prod_current_password;
    }
}

