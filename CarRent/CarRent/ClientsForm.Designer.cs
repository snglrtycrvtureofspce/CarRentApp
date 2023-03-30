namespace CarRent
{
    partial class ClientsForm
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
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phonenumberLabel;
            System.Windows.Forms.Label passportnumberLabel;
            this.autodbDataSet = new CarRent.autodbDataSet();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new CarRent.autodbDataSetTableAdapters.ClientsTableAdapter();
            this.tableAdapterManager = new CarRent.autodbDataSetTableAdapters.TableAdapterManager();
            this.clientsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Сохранять = new System.Windows.Forms.Button();
            this.Удалить = new System.Windows.Forms.Button();
            this.Добавить = new System.Windows.Forms.Button();
            this.Последняя = new System.Windows.Forms.Button();
            this.Следущая = new System.Windows.Forms.Button();
            this.Предыдущая = new System.Windows.Forms.Button();
            this.Первая = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phonenumberTextBox = new System.Windows.Forms.TextBox();
            this.passportnumberTextBox = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phonenumberLabel = new System.Windows.Forms.Label();
            passportnumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.autodbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.ForeColor = System.Drawing.Color.Thistle;
            nameLabel.Location = new System.Drawing.Point(116, 391);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(44, 19);
            nameLabel.TabIndex = 25;
            nameLabel.Text = "name:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            emailLabel.ForeColor = System.Drawing.Color.Thistle;
            emailLabel.Location = new System.Drawing.Point(286, 391);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(43, 19);
            emailLabel.TabIndex = 26;
            emailLabel.Text = "email:";
            // 
            // phonenumberLabel
            // 
            phonenumberLabel.AutoSize = true;
            phonenumberLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            phonenumberLabel.ForeColor = System.Drawing.Color.Thistle;
            phonenumberLabel.Location = new System.Drawing.Point(512, 391);
            phonenumberLabel.Name = "phonenumberLabel";
            phonenumberLabel.Size = new System.Drawing.Size(94, 19);
            phonenumberLabel.TabIndex = 27;
            phonenumberLabel.Text = "phonenumber:";
            // 
            // passportnumberLabel
            // 
            passportnumberLabel.AutoSize = true;
            passportnumberLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            passportnumberLabel.ForeColor = System.Drawing.Color.Thistle;
            passportnumberLabel.Location = new System.Drawing.Point(733, 391);
            passportnumberLabel.Name = "passportnumberLabel";
            passportnumberLabel.Size = new System.Drawing.Size(109, 19);
            passportnumberLabel.TabIndex = 28;
            passportnumberLabel.Text = "passportnumber:";
            // 
            // autodbDataSet
            // 
            this.autodbDataSet.DataSetName = "autodbDataSet";
            this.autodbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.autodbDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArchiveCarsTableAdapter = null;
            this.tableAdapterManager.ArchiveRentListsTableAdapter = null;
            this.tableAdapterManager.ArchiveUsersTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarCharacteristicsTableAdapter = null;
            this.tableAdapterManager.CarsTableAdapter = null;
            this.tableAdapterManager.ClientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.RentListsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CarRent.autodbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // clientsDataGridView
            // 
            this.clientsDataGridView.AllowUserToAddRows = false;
            this.clientsDataGridView.AllowUserToDeleteRows = false;
            this.clientsDataGridView.AutoGenerateColumns = false;
            this.clientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.clientsDataGridView.DataSource = this.clientsBindingSource;
            this.clientsDataGridView.Location = new System.Drawing.Point(254, 12);
            this.clientsDataGridView.Name = "clientsDataGridView";
            this.clientsDataGridView.ReadOnly = true;
            this.clientsDataGridView.Size = new System.Drawing.Size(491, 262);
            this.clientsDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn3.HeaderText = "email";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "phonenumber";
            this.dataGridViewTextBoxColumn4.HeaderText = "phonenumber";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "passportnumber";
            this.dataGridViewTextBoxColumn5.HeaderText = "passportnumber";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Сохранять
            // 
            this.Сохранять.BackColor = System.Drawing.Color.MediumPurple;
            this.Сохранять.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Сохранять.ForeColor = System.Drawing.Color.Thistle;
            this.Сохранять.Location = new System.Drawing.Point(516, 331);
            this.Сохранять.Name = "Сохранять";
            this.Сохранять.Size = new System.Drawing.Size(109, 30);
            this.Сохранять.TabIndex = 24;
            this.Сохранять.Text = "Сохранять";
            this.Сохранять.UseVisualStyleBackColor = false;
            this.Сохранять.Click += new System.EventHandler(this.Сохранять_Click);
            // 
            // Удалить
            // 
            this.Удалить.BackColor = System.Drawing.Color.MediumPurple;
            this.Удалить.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Удалить.ForeColor = System.Drawing.Color.Thistle;
            this.Удалить.Location = new System.Drawing.Point(399, 331);
            this.Удалить.Name = "Удалить";
            this.Удалить.Size = new System.Drawing.Size(111, 30);
            this.Удалить.TabIndex = 23;
            this.Удалить.Text = "Удалить";
            this.Удалить.UseVisualStyleBackColor = false;
            this.Удалить.Click += new System.EventHandler(this.Удалить_Click);
            // 
            // Добавить
            // 
            this.Добавить.BackColor = System.Drawing.Color.MediumPurple;
            this.Добавить.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Добавить.ForeColor = System.Drawing.Color.Thistle;
            this.Добавить.Location = new System.Drawing.Point(666, 295);
            this.Добавить.Name = "Добавить";
            this.Добавить.Size = new System.Drawing.Size(93, 30);
            this.Добавить.TabIndex = 22;
            this.Добавить.Text = "Добавить";
            this.Добавить.UseVisualStyleBackColor = false;
            this.Добавить.Click += new System.EventHandler(this.Добавить_Click);
            // 
            // Последняя
            // 
            this.Последняя.BackColor = System.Drawing.Color.MediumPurple;
            this.Последняя.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Последняя.ForeColor = System.Drawing.Color.Thistle;
            this.Последняя.Location = new System.Drawing.Point(567, 295);
            this.Последняя.Name = "Последняя";
            this.Последняя.Size = new System.Drawing.Size(93, 30);
            this.Последняя.TabIndex = 21;
            this.Последняя.Text = "Последняя";
            this.Последняя.UseVisualStyleBackColor = false;
            this.Последняя.Click += new System.EventHandler(this.Последняя_Click);
            // 
            // Следущая
            // 
            this.Следущая.BackColor = System.Drawing.Color.MediumPurple;
            this.Следущая.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Следущая.ForeColor = System.Drawing.Color.Thistle;
            this.Следущая.Location = new System.Drawing.Point(452, 295);
            this.Следущая.Name = "Следущая";
            this.Следущая.Size = new System.Drawing.Size(109, 30);
            this.Следущая.TabIndex = 20;
            this.Следущая.Text = "Следущая";
            this.Следущая.UseVisualStyleBackColor = false;
            this.Следущая.Click += new System.EventHandler(this.Следущая_Click);
            // 
            // Предыдущая
            // 
            this.Предыдущая.BackColor = System.Drawing.Color.MediumPurple;
            this.Предыдущая.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Предыдущая.ForeColor = System.Drawing.Color.Thistle;
            this.Предыдущая.Location = new System.Drawing.Point(335, 295);
            this.Предыдущая.Name = "Предыдущая";
            this.Предыдущая.Size = new System.Drawing.Size(111, 30);
            this.Предыдущая.TabIndex = 19;
            this.Предыдущая.Text = "Предыдущая";
            this.Предыдущая.UseVisualStyleBackColor = false;
            this.Предыдущая.Click += new System.EventHandler(this.Предыдущая_Click);
            // 
            // Первая
            // 
            this.Первая.BackColor = System.Drawing.Color.MediumPurple;
            this.Первая.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Первая.ForeColor = System.Drawing.Color.Thistle;
            this.Первая.Location = new System.Drawing.Point(236, 295);
            this.Первая.Name = "Первая";
            this.Первая.Size = new System.Drawing.Size(93, 30);
            this.Первая.TabIndex = 18;
            this.Первая.Text = "Первая";
            this.Первая.UseVisualStyleBackColor = false;
            this.Первая.Click += new System.EventHandler(this.Первая_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(166, 388);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 26);
            this.nameTextBox.TabIndex = 26;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBox.Location = new System.Drawing.Point(335, 388);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(171, 26);
            this.emailTextBox.TabIndex = 27;
            // 
            // phonenumberTextBox
            // 
            this.phonenumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "phonenumber", true));
            this.phonenumberTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phonenumberTextBox.Location = new System.Drawing.Point(612, 388);
            this.phonenumberTextBox.Name = "phonenumberTextBox";
            this.phonenumberTextBox.Size = new System.Drawing.Size(100, 26);
            this.phonenumberTextBox.TabIndex = 28;
            // 
            // passportnumberTextBox
            // 
            this.passportnumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "passportnumber", true));
            this.passportnumberTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passportnumberTextBox.Location = new System.Drawing.Point(848, 388);
            this.passportnumberTextBox.Name = "passportnumberTextBox";
            this.passportnumberTextBox.Size = new System.Drawing.Size(100, 26);
            this.passportnumberTextBox.TabIndex = 29;
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1047, 619);
            this.Controls.Add(passportnumberLabel);
            this.Controls.Add(this.passportnumberTextBox);
            this.Controls.Add(phonenumberLabel);
            this.Controls.Add(this.phonenumberTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.Сохранять);
            this.Controls.Add(this.Удалить);
            this.Controls.Add(this.Добавить);
            this.Controls.Add(this.Последняя);
            this.Controls.Add(this.Следущая);
            this.Controls.Add(this.Предыдущая);
            this.Controls.Add(this.Первая);
            this.Controls.Add(this.clientsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientsForm";
            this.Text = "ClientsForm";
            this.Load += new System.EventHandler(this.ClientsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autodbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private autodbDataSet autodbDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private autodbDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private autodbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView clientsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button Сохранять;
        private System.Windows.Forms.Button Удалить;
        private System.Windows.Forms.Button Добавить;
        private System.Windows.Forms.Button Последняя;
        private System.Windows.Forms.Button Следущая;
        private System.Windows.Forms.Button Предыдущая;
        private System.Windows.Forms.Button Первая;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phonenumberTextBox;
        private System.Windows.Forms.TextBox passportnumberTextBox;
    }
}