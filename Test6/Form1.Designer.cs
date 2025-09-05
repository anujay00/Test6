namespace Test6
{
    partial class Form1
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
            Loginpage_lbl = new Label();
            name_lbl = new Label();
            password_lbl = new Label();
            name_tb = new TextBox();
            password_tb = new TextBox();
            login_btn = new Button();
            SuspendLayout();
            // 
            // Loginpage_lbl
            // 
            Loginpage_lbl.AutoSize = true;
            Loginpage_lbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Loginpage_lbl.Location = new Point(159, 44);
            Loginpage_lbl.Name = "Loginpage_lbl";
            Loginpage_lbl.Size = new Size(127, 31);
            Loginpage_lbl.TabIndex = 0;
            Loginpage_lbl.Text = "Login Page";
            // 
            // name_lbl
            // 
            name_lbl.AutoSize = true;
            name_lbl.Location = new Point(33, 126);
            name_lbl.Name = "name_lbl";
            name_lbl.Size = new Size(49, 20);
            name_lbl.TabIndex = 1;
            name_lbl.Text = "Name";
            // 
            // password_lbl
            // 
            password_lbl.AutoSize = true;
            password_lbl.Location = new Point(32, 169);
            password_lbl.Name = "password_lbl";
            password_lbl.Size = new Size(70, 20);
            password_lbl.TabIndex = 2;
            password_lbl.Text = "Password";
            // 
            // name_tb
            // 
            name_tb.BorderStyle = BorderStyle.FixedSingle;
            name_tb.Location = new Point(150, 124);
            name_tb.Name = "name_tb";
            name_tb.PlaceholderText = "Enter name";
            name_tb.Size = new Size(239, 27);
            name_tb.TabIndex = 3;
            // 
            // password_tb
            // 
            password_tb.BorderStyle = BorderStyle.FixedSingle;
            password_tb.Location = new Point(150, 165);
            password_tb.Name = "password_tb";
            password_tb.PlaceholderText = "Enter password";
            password_tb.Size = new Size(239, 27);
            password_tb.TabIndex = 4;
            // 
            // login_btn
            // 
            login_btn.Location = new Point(175, 239);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(94, 29);
            login_btn.TabIndex = 5;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += login_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 309);
            Controls.Add(login_btn);
            Controls.Add(password_tb);
            Controls.Add(name_tb);
            Controls.Add(password_lbl);
            Controls.Add(name_lbl);
            Controls.Add(Loginpage_lbl);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Loginpage_lbl;
        private Label name_lbl;
        private Label password_lbl;
        private TextBox name_tb;
        private TextBox password_tb;
        private Button login_btn;
    }
}
