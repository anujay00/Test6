namespace Test6
{
    partial class Form2
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
            home_lbl = new Label();
            greeting_lbl = new Label();
            back_btn = new Button();
            SuspendLayout();
            // 
            // home_lbl
            // 
            home_lbl.AutoSize = true;
            home_lbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            home_lbl.Location = new Point(162, 47);
            home_lbl.Name = "home_lbl";
            home_lbl.Size = new Size(75, 31);
            home_lbl.TabIndex = 0;
            home_lbl.Text = "Home";
            home_lbl.UseMnemonic = false;
            // 
            // greeting_lbl
            // 
            greeting_lbl.AutoSize = true;
            greeting_lbl.Location = new Point(166, 101);
            greeting_lbl.Name = "greeting_lbl";
            greeting_lbl.Size = new Size(66, 20);
            greeting_lbl.TabIndex = 1;
            greeting_lbl.Text = "Greeting";
            greeting_lbl.Click += greeting_lbl_Click;
            // 
            // back_btn
            // 
            back_btn.Location = new Point(153, 166);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(94, 29);
            back_btn.TabIndex = 2;
            back_btn.Text = "Back";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 247);
            Controls.Add(back_btn);
            Controls.Add(greeting_lbl);
            Controls.Add(home_lbl);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label home_lbl;
        public Label greeting_lbl;
        private Button back_btn;
    }
}