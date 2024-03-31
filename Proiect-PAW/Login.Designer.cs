namespace Proiect_PAW
{
    partial class Login
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
            panel1 = new Panel();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            usernameLabel = new Label();
            passwordLabel = new Label();
            richTextBox2 = new RichTextBox();
            loginButton = new Button();
            resetLoginForm = new Label();
            closeAppButton = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(198, 570);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(526, 9);
            label1.Name = "label1";
            label1.Size = new Size(212, 39);
            label1.TabIndex = 1;
            label1.Text = "Proiect PAW";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(504, 167);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(267, 29);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(574, 145);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(128, 19);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Nume Utilizator";
            usernameLabel.Click += label2_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(610, 237);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 19);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Parola";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(504, 259);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(267, 29);
            richTextBox2.TabIndex = 4;
            richTextBox2.Text = "";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.MidnightBlue;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(587, 343);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(106, 33);
            loginButton.TabIndex = 6;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            // 
            // resetLoginForm
            // 
            resetLoginForm.AutoSize = true;
            resetLoginForm.Location = new Point(597, 405);
            resetLoginForm.Name = "resetLoginForm";
            resetLoginForm.Size = new Size(87, 19);
            resetLoginForm.TabIndex = 7;
            resetLoginForm.Text = "Reseteaza";
            // 
            // closeAppButton
            // 
            closeAppButton.AutoSize = true;
            closeAppButton.Font = new Font("Inter", 21.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            closeAppButton.Location = new Point(1093, 9);
            closeAppButton.Name = "closeAppButton";
            closeAppButton.Size = new Size(34, 35);
            closeAppButton.TabIndex = 8;
            closeAppButton.Text = "X";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1143, 570);
            Controls.Add(closeAppButton);
            Controls.Add(resetLoginForm);
            Controls.Add(loginButton);
            Controls.Add(passwordLabel);
            Controls.Add(richTextBox2);
            Controls.Add(usernameLabel);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private RichTextBox richTextBox1;
        private Label usernameLabel;
        private Label passwordLabel;
        private RichTextBox richTextBox2;
        private Button loginButton;
        private Label resetLoginForm;
        private Label closeAppButton;
    }
}
