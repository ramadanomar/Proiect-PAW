namespace Proiect_PAW
{
    partial class Clienti
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
            components = new System.ComponentModel.Container();
            closeAppButton = new Label();
            addClientButton = new Button();
            datagridLabel = new Label();
            clientCollectionBindingSource = new BindingSource(components);
            deleteClientButton = new Button();
            editClientButton = new Button();
            sexComboBox = new ComboBox();
            pretLabel = new Label();
            telefonClientTextBox = new TextBox();
            categorieInputLabel = new Label();
            numeFilmLabel = new Label();
            titleLabel = new Label();
            titlePanel = new Panel();
            logoutButton = new Label();
            clientiMenuLabel = new Label();
            graficeMenuLabel = new Label();
            incasariMenuLabel = new Label();
            inchirieriMenuLabel = new Label();
            produseMenuLabel = new Label();
            logoutPanel = new Panel();
            numeClientTextBox = new TextBox();
            sidebarPanel = new Panel();
            dataGridView1 = new DataGridView();
            clientCollectionBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)clientCollectionBindingSource).BeginInit();
            titlePanel.SuspendLayout();
            logoutPanel.SuspendLayout();
            sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientCollectionBindingSource1).BeginInit();
            SuspendLayout();
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
            // addClientButton
            // 
            addClientButton.BackColor = Color.MidnightBlue;
            addClientButton.FlatAppearance.BorderSize = 0;
            addClientButton.FlatStyle = FlatStyle.Flat;
            addClientButton.ForeColor = Color.White;
            addClientButton.Location = new Point(632, 185);
            addClientButton.Name = "addClientButton";
            addClientButton.Size = new Size(106, 33);
            addClientButton.TabIndex = 31;
            addClientButton.Text = "Adauga";
            addClientButton.UseVisualStyleBackColor = false;
            addClientButton.Click += addClientButton_Click;
            // 
            // datagridLabel
            // 
            datagridLabel.AutoSize = true;
            datagridLabel.Font = new Font("Inter", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datagridLabel.Location = new Point(621, 251);
            datagridLabel.Name = "datagridLabel";
            datagridLabel.Size = new Size(74, 25);
            datagridLabel.TabIndex = 30;
            datagridLabel.Text = "Clienti";
            // 
            // clientCollectionBindingSource
            // 
            clientCollectionBindingSource.DataSource = typeof(Data.ClientCollection);
            // 
            // deleteClientButton
            // 
            deleteClientButton.BackColor = Color.Crimson;
            deleteClientButton.FlatAppearance.BorderSize = 0;
            deleteClientButton.FlatStyle = FlatStyle.Flat;
            deleteClientButton.ForeColor = Color.White;
            deleteClientButton.Location = new Point(758, 185);
            deleteClientButton.Name = "deleteClientButton";
            deleteClientButton.Size = new Size(106, 33);
            deleteClientButton.TabIndex = 28;
            deleteClientButton.Text = "Sterge";
            deleteClientButton.UseVisualStyleBackColor = false;
            // 
            // editClientButton
            // 
            editClientButton.BackColor = Color.MidnightBlue;
            editClientButton.FlatAppearance.BorderSize = 0;
            editClientButton.FlatStyle = FlatStyle.Flat;
            editClientButton.ForeColor = Color.White;
            editClientButton.Location = new Point(499, 185);
            editClientButton.Name = "editClientButton";
            editClientButton.Size = new Size(106, 33);
            editClientButton.TabIndex = 27;
            editClientButton.Text = "Edit";
            editClientButton.UseVisualStyleBackColor = false;
            // 
            // sexComboBox
            // 
            sexComboBox.FormattingEnabled = true;
            sexComboBox.Items.AddRange(new object[] { "Masculin", "Feminin" });
            sexComboBox.Location = new Point(593, 119);
            sexComboBox.Name = "sexComboBox";
            sexComboBox.Size = new Size(167, 27);
            sexComboBox.TabIndex = 26;
            // 
            // pretLabel
            // 
            pretLabel.AutoSize = true;
            pretLabel.Location = new Point(807, 95);
            pretLabel.Name = "pretLabel";
            pretLabel.Size = new Size(65, 19);
            pretLabel.TabIndex = 23;
            pretLabel.Text = "Telefon";
            // 
            // telefonClientTextBox
            // 
            telefonClientTextBox.Location = new Point(807, 117);
            telefonClientTextBox.Name = "telefonClientTextBox";
            telefonClientTextBox.Size = new Size(177, 27);
            telefonClientTextBox.TabIndex = 22;
            // 
            // categorieInputLabel
            // 
            categorieInputLabel.AutoSize = true;
            categorieInputLabel.Location = new Point(593, 95);
            categorieInputLabel.Name = "categorieInputLabel";
            categorieInputLabel.Size = new Size(37, 19);
            categorieInputLabel.TabIndex = 21;
            categorieInputLabel.Text = "Sex";
            // 
            // numeFilmLabel
            // 
            numeFilmLabel.AutoSize = true;
            numeFilmLabel.Location = new Point(389, 95);
            numeFilmLabel.Name = "numeFilmLabel";
            numeFilmLabel.Size = new Size(102, 19);
            numeFilmLabel.TabIndex = 20;
            numeFilmLabel.Text = "Nume Client";
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
            // titlePanel
            // 
            titlePanel.BackColor = Color.MidnightBlue;
            titlePanel.Controls.Add(closeAppButton);
            titlePanel.Controls.Add(titleLabel);
            titlePanel.Dock = DockStyle.Top;
            titlePanel.Location = new Point(198, 0);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(945, 72);
            titlePanel.TabIndex = 18;
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
            // logoutPanel
            // 
            logoutPanel.Controls.Add(logoutButton);
            logoutPanel.Location = new Point(0, 524);
            logoutPanel.Name = "logoutPanel";
            logoutPanel.Size = new Size(198, 46);
            logoutPanel.TabIndex = 0;
            // 
            // numeClientTextBox
            // 
            numeClientTextBox.Location = new Point(389, 117);
            numeClientTextBox.Name = "numeClientTextBox";
            numeClientTextBox.Size = new Size(177, 27);
            numeClientTextBox.TabIndex = 19;
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
            sidebarPanel.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.DataSource = clientCollectionBindingSource1;
            dataGridView1.Location = new Point(289, 311);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(794, 212);
            dataGridView1.TabIndex = 32;
            // 
            // clientCollectionBindingSource1
            // 
            clientCollectionBindingSource1.DataSource = typeof(Data.ClientCollection);
            // 
            // Clienti
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1143, 570);
            Controls.Add(dataGridView1);
            Controls.Add(addClientButton);
            Controls.Add(datagridLabel);
            Controls.Add(deleteClientButton);
            Controls.Add(editClientButton);
            Controls.Add(sexComboBox);
            Controls.Add(pretLabel);
            Controls.Add(telefonClientTextBox);
            Controls.Add(categorieInputLabel);
            Controls.Add(numeFilmLabel);
            Controls.Add(titlePanel);
            Controls.Add(numeClientTextBox);
            Controls.Add(sidebarPanel);
            Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Clienti";
            Text = "Clienti";
            Load += Clienti_Load;
            ((System.ComponentModel.ISupportInitialize)clientCollectionBindingSource).EndInit();
            titlePanel.ResumeLayout(false);
            titlePanel.PerformLayout();
            logoutPanel.ResumeLayout(false);
            logoutPanel.PerformLayout();
            sidebarPanel.ResumeLayout(false);
            sidebarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientCollectionBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label closeAppButton;
        private Button addClientButton;
        private Label datagridLabel;
        private Button deleteClientButton;
        private Button editClientButton;
        private ComboBox sexComboBox;
        private Label pretLabel;
        private TextBox telefonClientTextBox;
        private Label categorieInputLabel;
        private Label numeFilmLabel;
        private Label titleLabel;
        private Panel titlePanel;
        private Label logoutButton;
        private Label clientiMenuLabel;
        private Label graficeMenuLabel;
        private Label incasariMenuLabel;
        private Label inchirieriMenuLabel;
        private Label produseMenuLabel;
        private Panel logoutPanel;
        private TextBox numeClientTextBox;
        private Panel sidebarPanel;
        private BindingSource clientCollectionBindingSource;
        private DataGridView dataGridView1;
        private BindingSource clientCollectionBindingSource1;
    }
}