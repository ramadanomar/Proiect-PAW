namespace Proiect_PAW
{
    partial class Inchirieri
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
            addInchirieriButton = new Button();
            datagridLabel = new Label();
            inchirieriDataGridView1 = new DataGridView();
            deleteInchirieriButton = new Button();
            editInchirieriButton = new Button();
            pretLabel = new Label();
            numeFilmLabel = new Label();
            logoutPanel = new Panel();
            logoutButton = new Label();
            titlePanel = new Panel();
            closeAppButton = new Label();
            titleLabel = new Label();
            incasariMenuLabel = new Label();
            inchirieriMenuLabel = new Label();
            produseMenuLabel = new Label();
            sidebarPanel = new Panel();
            clientiMenuLabel = new Label();
            graficeMenuLabel = new Label();
            numeClientComboBox = new ComboBox();
            numeFilmComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)inchirieriDataGridView1).BeginInit();
            logoutPanel.SuspendLayout();
            titlePanel.SuspendLayout();
            sidebarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // addInchirieriButton
            // 
            addInchirieriButton.BackColor = Color.MidnightBlue;
            addInchirieriButton.FlatAppearance.BorderSize = 0;
            addInchirieriButton.FlatStyle = FlatStyle.Flat;
            addInchirieriButton.ForeColor = Color.White;
            addInchirieriButton.Location = new Point(632, 185);
            addInchirieriButton.Name = "addInchirieriButton";
            addInchirieriButton.Size = new Size(106, 33);
            addInchirieriButton.TabIndex = 44;
            addInchirieriButton.Text = "Adauga";
            addInchirieriButton.UseVisualStyleBackColor = false;
            // 
            // datagridLabel
            // 
            datagridLabel.AutoSize = true;
            datagridLabel.Font = new Font("Inter", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datagridLabel.Location = new Point(621, 251);
            datagridLabel.Name = "datagridLabel";
            datagridLabel.Size = new Size(97, 25);
            datagridLabel.TabIndex = 43;
            datagridLabel.Text = "Inchirieri";
            // 
            // inchirieriDataGridView1
            // 
            inchirieriDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inchirieriDataGridView1.Location = new Point(198, 285);
            inchirieriDataGridView1.Name = "inchirieriDataGridView1";
            inchirieriDataGridView1.Size = new Size(945, 285);
            inchirieriDataGridView1.TabIndex = 42;
            // 
            // deleteInchirieriButton
            // 
            deleteInchirieriButton.BackColor = Color.Crimson;
            deleteInchirieriButton.FlatAppearance.BorderSize = 0;
            deleteInchirieriButton.FlatStyle = FlatStyle.Flat;
            deleteInchirieriButton.ForeColor = Color.White;
            deleteInchirieriButton.Location = new Point(758, 185);
            deleteInchirieriButton.Name = "deleteInchirieriButton";
            deleteInchirieriButton.Size = new Size(106, 33);
            deleteInchirieriButton.TabIndex = 41;
            deleteInchirieriButton.Text = "Sterge";
            deleteInchirieriButton.UseVisualStyleBackColor = false;
            // 
            // editInchirieriButton
            // 
            editInchirieriButton.BackColor = Color.MidnightBlue;
            editInchirieriButton.FlatAppearance.BorderSize = 0;
            editInchirieriButton.FlatStyle = FlatStyle.Flat;
            editInchirieriButton.ForeColor = Color.White;
            editInchirieriButton.Location = new Point(499, 185);
            editInchirieriButton.Name = "editInchirieriButton";
            editInchirieriButton.Size = new Size(106, 33);
            editInchirieriButton.TabIndex = 40;
            editInchirieriButton.Text = "Edit";
            editInchirieriButton.UseVisualStyleBackColor = false;
            // 
            // pretLabel
            // 
            pretLabel.AutoSize = true;
            pretLabel.Location = new Point(758, 95);
            pretLabel.Name = "pretLabel";
            pretLabel.Size = new Size(89, 19);
            pretLabel.TabIndex = 38;
            pretLabel.Text = "Nume Film";
            // 
            // numeFilmLabel
            // 
            numeFilmLabel.AutoSize = true;
            numeFilmLabel.Location = new Point(486, 95);
            numeFilmLabel.Name = "numeFilmLabel";
            numeFilmLabel.Size = new Size(102, 19);
            numeFilmLabel.TabIndex = 35;
            numeFilmLabel.Text = "Nume Client";
            // 
            // logoutPanel
            // 
            logoutPanel.Controls.Add(logoutButton);
            logoutPanel.Location = new Point(0, 524);
            logoutPanel.Name = "logoutPanel";
            logoutPanel.Size = new Size(198, 46);
            logoutPanel.TabIndex = 0;
            // 
            // logoutButton
            // 
            logoutButton.AutoSize = true;
            logoutButton.Font = new Font("Inter", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutButton.ForeColor = Color.White;
            logoutButton.Location = new Point(58, 12);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(83, 25);
            logoutButton.TabIndex = 2;
            logoutButton.Text = "Logout";
            // 
            // titlePanel
            // 
            titlePanel.BackColor = Color.MidnightBlue;
            titlePanel.Controls.Add(closeAppButton);
            titlePanel.Controls.Add(titleLabel);
            titlePanel.Dock = DockStyle.Top;
            titlePanel.Location = new Point(198, 0);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(945, 72);
            titlePanel.TabIndex = 33;
            // 
            // closeAppButton
            // 
            closeAppButton.AutoSize = true;
            closeAppButton.Font = new Font("Inter", 21.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            closeAppButton.ForeColor = Color.White;
            closeAppButton.Location = new Point(899, 9);
            closeAppButton.Name = "closeAppButton";
            closeAppButton.Size = new Size(34, 35);
            closeAppButton.TabIndex = 17;
            closeAppButton.Text = "X";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Inter", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(290, 21);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(378, 33);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Proiect PAW - Ramdan Omar";
            // 
            // incasariMenuLabel
            // 
            incasariMenuLabel.AutoSize = true;
            incasariMenuLabel.Font = new Font("Inter", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            incasariMenuLabel.ForeColor = Color.White;
            incasariMenuLabel.Location = new Point(57, 294);
            incasariMenuLabel.Name = "incasariMenuLabel";
            incasariMenuLabel.Size = new Size(90, 25);
            incasariMenuLabel.TabIndex = 5;
            incasariMenuLabel.Text = "Incasari";
            // 
            // inchirieriMenuLabel
            // 
            inchirieriMenuLabel.AutoSize = true;
            inchirieriMenuLabel.Font = new Font("Inter", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inchirieriMenuLabel.ForeColor = Color.White;
            inchirieriMenuLabel.Location = new Point(57, 165);
            inchirieriMenuLabel.Name = "inchirieriMenuLabel";
            inchirieriMenuLabel.Size = new Size(97, 25);
            inchirieriMenuLabel.TabIndex = 4;
            inchirieriMenuLabel.Text = "Inchirieri";
            // 
            // produseMenuLabel
            // 
            produseMenuLabel.AutoSize = true;
            produseMenuLabel.Font = new Font("Inter", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            produseMenuLabel.ForeColor = Color.White;
            produseMenuLabel.Location = new Point(76, 106);
            produseMenuLabel.Name = "produseMenuLabel";
            produseMenuLabel.Size = new Size(64, 25);
            produseMenuLabel.TabIndex = 3;
            produseMenuLabel.Text = "Filme";
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.MidnightBlue;
            sidebarPanel.Controls.Add(clientiMenuLabel);
            sidebarPanel.Controls.Add(graficeMenuLabel);
            sidebarPanel.Controls.Add(incasariMenuLabel);
            sidebarPanel.Controls.Add(inchirieriMenuLabel);
            sidebarPanel.Controls.Add(produseMenuLabel);
            sidebarPanel.Controls.Add(logoutPanel);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(198, 570);
            sidebarPanel.TabIndex = 32;
            // 
            // clientiMenuLabel
            // 
            clientiMenuLabel.AutoSize = true;
            clientiMenuLabel.Font = new Font("Inter", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clientiMenuLabel.ForeColor = Color.White;
            clientiMenuLabel.Location = new Point(66, 231);
            clientiMenuLabel.Name = "clientiMenuLabel";
            clientiMenuLabel.Size = new Size(74, 25);
            clientiMenuLabel.TabIndex = 8;
            clientiMenuLabel.Text = "Clienti";
            // 
            // graficeMenuLabel
            // 
            graficeMenuLabel.AutoSize = true;
            graficeMenuLabel.Font = new Font("Inter", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            graficeMenuLabel.ForeColor = Color.White;
            graficeMenuLabel.Location = new Point(61, 360);
            graficeMenuLabel.Name = "graficeMenuLabel";
            graficeMenuLabel.Size = new Size(85, 25);
            graficeMenuLabel.TabIndex = 7;
            graficeMenuLabel.Text = "Grafice";
            // 
            // numeClientComboBox
            // 
            numeClientComboBox.FormattingEnabled = true;
            numeClientComboBox.Location = new Point(485, 117);
            numeClientComboBox.Name = "numeClientComboBox";
            numeClientComboBox.Size = new Size(121, 27);
            numeClientComboBox.TabIndex = 45;
            // 
            // numeFilmComboBox
            // 
            numeFilmComboBox.FormattingEnabled = true;
            numeFilmComboBox.Location = new Point(743, 117);
            numeFilmComboBox.Name = "numeFilmComboBox";
            numeFilmComboBox.Size = new Size(121, 27);
            numeFilmComboBox.TabIndex = 46;
            // 
            // Inchirieri
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1143, 570);
            Controls.Add(numeFilmComboBox);
            Controls.Add(numeClientComboBox);
            Controls.Add(addInchirieriButton);
            Controls.Add(datagridLabel);
            Controls.Add(inchirieriDataGridView1);
            Controls.Add(deleteInchirieriButton);
            Controls.Add(editInchirieriButton);
            Controls.Add(pretLabel);
            Controls.Add(numeFilmLabel);
            Controls.Add(titlePanel);
            Controls.Add(sidebarPanel);
            Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Inchirieri";
            Text = "Inchirieri";
            ((System.ComponentModel.ISupportInitialize)inchirieriDataGridView1).EndInit();
            logoutPanel.ResumeLayout(false);
            logoutPanel.PerformLayout();
            titlePanel.ResumeLayout(false);
            titlePanel.PerformLayout();
            sidebarPanel.ResumeLayout(false);
            sidebarPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addInchirieriButton;
        private Label datagridLabel;
        private DataGridView inchirieriDataGridView1;
        private Button deleteInchirieriButton;
        private Button editInchirieriButton;
        private Label pretLabel;
        private Label numeFilmLabel;
        private Panel logoutPanel;
        private Label logoutButton;
        private Panel titlePanel;
        private Label closeAppButton;
        private Label titleLabel;
        private Label incasariMenuLabel;
        private Label inchirieriMenuLabel;
        private Label produseMenuLabel;
        private Panel sidebarPanel;
        private Label clientiMenuLabel;
        private Label graficeMenuLabel;
        private ComboBox numeClientComboBox;
        private ComboBox numeFilmComboBox;
    }
}