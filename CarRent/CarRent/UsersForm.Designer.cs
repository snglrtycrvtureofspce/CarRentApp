namespace CarRent
{
    partial class UsersForm
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label passwordLabel;
            this.autodbDataSet = new CarRent.autodbDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new CarRent.autodbDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new CarRent.autodbDataSetTableAdapters.TableAdapterManager();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Отчет = new System.Windows.Forms.Button();
            this.Сохранять = new System.Windows.Forms.Button();
            this.Удалить = new System.Windows.Forms.Button();
            this.Добавить = new System.Windows.Forms.Button();
            this.Последняя = new System.Windows.Forms.Button();
            this.Следущая = new System.Windows.Forms.Button();
            this.Предыдущая = new System.Windows.Forms.Button();
            this.Первая = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.autodbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.ForeColor = System.Drawing.Color.Thistle;
            nameLabel.Location = new System.Drawing.Point(170, 424);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(44, 19);
            nameLabel.TabIndex = 33;
            nameLabel.Text = "name:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            usernameLabel.ForeColor = System.Drawing.Color.Thistle;
            usernameLabel.Location = new System.Drawing.Point(337, 425);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(69, 19);
            usernameLabel.TabIndex = 34;
            usernameLabel.Text = "username:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            emailLabel.ForeColor = System.Drawing.Color.Thistle;
            emailLabel.Location = new System.Drawing.Point(529, 423);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(43, 19);
            emailLabel.TabIndex = 35;
            emailLabel.Text = "email:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            passwordLabel.ForeColor = System.Drawing.Color.Thistle;
            passwordLabel.Location = new System.Drawing.Point(795, 423);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(71, 19);
            passwordLabel.TabIndex = 36;
            passwordLabel.Text = "password:";
            // 
            // autodbDataSet
            // 
            this.autodbDataSet.DataSetName = "autodbDataSet";
            this.autodbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.autodbDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArchiveCarsTableAdapter = null;
            this.tableAdapterManager.ArchiveRentListsTableAdapter = null;
            this.tableAdapterManager.ArchiveUsersTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarCharacteristicsTableAdapter = null;
            this.tableAdapterManager.CarsTableAdapter = null;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.RentListsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CarRent.autodbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AllowUserToAddRows = false;
            this.usersDataGridView.AllowUserToDeleteRows = false;
            this.usersDataGridView.AutoGenerateColumns = false;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.usersDataGridView.DataSource = this.usersBindingSource;
            this.usersDataGridView.Location = new System.Drawing.Point(262, 49);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.ReadOnly = true;
            this.usersDataGridView.Size = new System.Drawing.Size(464, 220);
            this.usersDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "username";
            this.dataGridViewTextBoxColumn3.HeaderText = "username";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn4.HeaderText = "email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn5.HeaderText = "password";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Отчет
            // 
            this.Отчет.BackColor = System.Drawing.Color.MediumPurple;
            this.Отчет.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Отчет.ForeColor = System.Drawing.Color.Thistle;
            this.Отчет.Location = new System.Drawing.Point(578, 356);
            this.Отчет.Name = "Отчет";
            this.Отчет.Size = new System.Drawing.Size(100, 31);
            this.Отчет.TabIndex = 33;
            this.Отчет.Text = "Отчет";
            this.Отчет.UseVisualStyleBackColor = false;
            // 
            // Сохранять
            // 
            this.Сохранять.BackColor = System.Drawing.Color.MediumPurple;
            this.Сохранять.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Сохранять.ForeColor = System.Drawing.Color.Thistle;
            this.Сохранять.Location = new System.Drawing.Point(472, 356);
            this.Сохранять.Name = "Сохранять";
            this.Сохранять.Size = new System.Drawing.Size(100, 31);
            this.Сохранять.TabIndex = 32;
            this.Сохранять.Text = "Сохранять";
            this.Сохранять.UseVisualStyleBackColor = false;
            this.Сохранять.Click += new System.EventHandler(this.Сохранять_Click);
            // 
            // Удалить
            // 
            this.Удалить.BackColor = System.Drawing.Color.MediumPurple;
            this.Удалить.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Удалить.ForeColor = System.Drawing.Color.Thistle;
            this.Удалить.Location = new System.Drawing.Point(348, 356);
            this.Удалить.Name = "Удалить";
            this.Удалить.Size = new System.Drawing.Size(116, 31);
            this.Удалить.TabIndex = 31;
            this.Удалить.Text = "Удалить";
            this.Удалить.UseVisualStyleBackColor = false;
            this.Удалить.Click += new System.EventHandler(this.Удалить_Click);
            // 
            // Добавить
            // 
            this.Добавить.BackColor = System.Drawing.Color.MediumPurple;
            this.Добавить.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Добавить.ForeColor = System.Drawing.Color.Thistle;
            this.Добавить.Location = new System.Drawing.Point(684, 305);
            this.Добавить.Name = "Добавить";
            this.Добавить.Size = new System.Drawing.Size(100, 31);
            this.Добавить.TabIndex = 30;
            this.Добавить.Text = "Добавить";
            this.Добавить.UseVisualStyleBackColor = false;
            this.Добавить.Click += new System.EventHandler(this.Добавить_Click);
            // 
            // Последняя
            // 
            this.Последняя.BackColor = System.Drawing.Color.MediumPurple;
            this.Последняя.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Последняя.ForeColor = System.Drawing.Color.Thistle;
            this.Последняя.Location = new System.Drawing.Point(578, 305);
            this.Последняя.Name = "Последняя";
            this.Последняя.Size = new System.Drawing.Size(100, 31);
            this.Последняя.TabIndex = 29;
            this.Последняя.Text = "Последняя";
            this.Последняя.UseVisualStyleBackColor = false;
            this.Последняя.Click += new System.EventHandler(this.Последняя_Click);
            // 
            // Следущая
            // 
            this.Следущая.BackColor = System.Drawing.Color.MediumPurple;
            this.Следущая.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Следущая.ForeColor = System.Drawing.Color.Thistle;
            this.Следущая.Location = new System.Drawing.Point(472, 305);
            this.Следущая.Name = "Следущая";
            this.Следущая.Size = new System.Drawing.Size(100, 31);
            this.Следущая.TabIndex = 28;
            this.Следущая.Text = "Следущая";
            this.Следущая.UseVisualStyleBackColor = false;
            this.Следущая.Click += new System.EventHandler(this.Следущая_Click);
            // 
            // Предыдущая
            // 
            this.Предыдущая.BackColor = System.Drawing.Color.MediumPurple;
            this.Предыдущая.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Предыдущая.ForeColor = System.Drawing.Color.Thistle;
            this.Предыдущая.Location = new System.Drawing.Point(348, 305);
            this.Предыдущая.Name = "Предыдущая";
            this.Предыдущая.Size = new System.Drawing.Size(118, 31);
            this.Предыдущая.TabIndex = 27;
            this.Предыдущая.Text = "Предыдущая";
            this.Предыдущая.UseVisualStyleBackColor = false;
            this.Предыдущая.Click += new System.EventHandler(this.Предыдущая_Click);
            // 
            // Первая
            // 
            this.Первая.BackColor = System.Drawing.Color.MediumPurple;
            this.Первая.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Первая.ForeColor = System.Drawing.Color.Thistle;
            this.Первая.Location = new System.Drawing.Point(242, 305);
            this.Первая.Name = "Первая";
            this.Первая.Size = new System.Drawing.Size(100, 31);
            this.Первая.TabIndex = 26;
            this.Первая.Text = "Первая";
            this.Первая.UseVisualStyleBackColor = false;
            this.Первая.Click += new System.EventHandler(this.Первая_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(220, 421);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 26);
            this.nameTextBox.TabIndex = 34;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "username", true));
            this.usernameTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameTextBox.Location = new System.Drawing.Point(412, 421);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 26);
            this.usernameTextBox.TabIndex = 35;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBox.Location = new System.Drawing.Point(578, 421);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(189, 26);
            this.emailTextBox.TabIndex = 36;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "password", true));
            this.passwordTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(872, 421);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 26);
            this.passwordTextBox.TabIndex = 37;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1071, 619);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.Отчет);
            this.Controls.Add(this.Сохранять);
            this.Controls.Add(this.Удалить);
            this.Controls.Add(this.Добавить);
            this.Controls.Add(this.Последняя);
            this.Controls.Add(this.Следущая);
            this.Controls.Add(this.Предыдущая);
            this.Controls.Add(this.Первая);
            this.Controls.Add(this.usersDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersForm";
            this.Text = "UsersForm";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autodbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private autodbDataSet autodbDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private autodbDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private autodbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button Отчет;
        private System.Windows.Forms.Button Сохранять;
        private System.Windows.Forms.Button Удалить;
        private System.Windows.Forms.Button Добавить;
        private System.Windows.Forms.Button Последняя;
        private System.Windows.Forms.Button Следущая;
        private System.Windows.Forms.Button Предыдущая;
        private System.Windows.Forms.Button Первая;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
    }
}