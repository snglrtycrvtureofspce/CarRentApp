namespace CarRent
{
    partial class RentListsForm
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
            System.Windows.Forms.Label clientidLabel;
            System.Windows.Forms.Label caridLabel;
            System.Windows.Forms.Label dateofrentLabel;
            System.Windows.Forms.Label endofrentLabel;
            System.Windows.Forms.Label renttimeLabel1;
            this.Сохранять = new System.Windows.Forms.Button();
            this.Удалить = new System.Windows.Forms.Button();
            this.Добавить = new System.Windows.Forms.Button();
            this.Последняя = new System.Windows.Forms.Button();
            this.Следущая = new System.Windows.Forms.Button();
            this.Предыдущая = new System.Windows.Forms.Button();
            this.Первая = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.autodbDataSet = new CarRent.autodbDataSet();
            this.rentListsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentListsTableAdapter = new CarRent.autodbDataSetTableAdapters.RentListsTableAdapter();
            this.tableAdapterManager = new CarRent.autodbDataSetTableAdapters.TableAdapterManager();
            this.rentListsDataGridView = new System.Windows.Forms.DataGridView();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new CarRent.autodbDataSetTableAdapters.ClientsTableAdapter();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsTableAdapter = new CarRent.autodbDataSetTableAdapters.CarsTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofrentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endofrentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.renttimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            clientidLabel = new System.Windows.Forms.Label();
            caridLabel = new System.Windows.Forms.Label();
            dateofrentLabel = new System.Windows.Forms.Label();
            endofrentLabel = new System.Windows.Forms.Label();
            renttimeLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.autodbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentListsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentListsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.renttimeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // clientidLabel
            // 
            clientidLabel.AutoSize = true;
            clientidLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            clientidLabel.ForeColor = System.Drawing.Color.Thistle;
            clientidLabel.Location = new System.Drawing.Point(167, 445);
            clientidLabel.Name = "clientidLabel";
            clientidLabel.Size = new System.Drawing.Size(54, 19);
            clientidLabel.TabIndex = 17;
            clientidLabel.Text = "clientid:";
            // 
            // caridLabel
            // 
            caridLabel.AutoSize = true;
            caridLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            caridLabel.ForeColor = System.Drawing.Color.Thistle;
            caridLabel.Location = new System.Drawing.Point(389, 443);
            caridLabel.Name = "caridLabel";
            caridLabel.Size = new System.Drawing.Size(42, 19);
            caridLabel.TabIndex = 18;
            caridLabel.Text = "carid:";
            // 
            // Сохранять
            // 
            this.Сохранять.BackColor = System.Drawing.Color.MediumPurple;
            this.Сохранять.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Сохранять.ForeColor = System.Drawing.Color.Thistle;
            this.Сохранять.Location = new System.Drawing.Point(517, 382);
            this.Сохранять.Name = "Сохранять";
            this.Сохранять.Size = new System.Drawing.Size(90, 29);
            this.Сохранять.TabIndex = 16;
            this.Сохранять.Text = "Сохранять";
            this.Сохранять.UseVisualStyleBackColor = false;
            this.Сохранять.Click += new System.EventHandler(this.Сохранять_Click);
            // 
            // Удалить
            // 
            this.Удалить.BackColor = System.Drawing.Color.MediumPurple;
            this.Удалить.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Удалить.ForeColor = System.Drawing.Color.Thistle;
            this.Удалить.Location = new System.Drawing.Point(403, 382);
            this.Удалить.Name = "Удалить";
            this.Удалить.Size = new System.Drawing.Size(108, 29);
            this.Удалить.TabIndex = 15;
            this.Удалить.Text = "Удалить";
            this.Удалить.UseVisualStyleBackColor = false;
            this.Удалить.Click += new System.EventHandler(this.Удалить_Click);
            // 
            // Добавить
            // 
            this.Добавить.BackColor = System.Drawing.Color.MediumPurple;
            this.Добавить.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Добавить.ForeColor = System.Drawing.Color.Thistle;
            this.Добавить.Location = new System.Drawing.Point(660, 347);
            this.Добавить.Name = "Добавить";
            this.Добавить.Size = new System.Drawing.Size(90, 29);
            this.Добавить.TabIndex = 14;
            this.Добавить.Text = "Добавить";
            this.Добавить.UseVisualStyleBackColor = false;
            this.Добавить.Click += new System.EventHandler(this.Добавить_Click);
            // 
            // Последняя
            // 
            this.Последняя.BackColor = System.Drawing.Color.MediumPurple;
            this.Последняя.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Последняя.ForeColor = System.Drawing.Color.Thistle;
            this.Последняя.Location = new System.Drawing.Point(564, 347);
            this.Последняя.Name = "Последняя";
            this.Последняя.Size = new System.Drawing.Size(90, 29);
            this.Последняя.TabIndex = 13;
            this.Последняя.Text = "Последняя";
            this.Последняя.UseVisualStyleBackColor = false;
            this.Последняя.Click += new System.EventHandler(this.Последняя_Click);
            // 
            // Следущая
            // 
            this.Следущая.BackColor = System.Drawing.Color.MediumPurple;
            this.Следущая.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Следущая.ForeColor = System.Drawing.Color.Thistle;
            this.Следущая.Location = new System.Drawing.Point(468, 347);
            this.Следущая.Name = "Следущая";
            this.Следущая.Size = new System.Drawing.Size(90, 29);
            this.Следущая.TabIndex = 12;
            this.Следущая.Text = "Следущая";
            this.Следущая.UseVisualStyleBackColor = false;
            this.Следущая.Click += new System.EventHandler(this.Следущая_Click);
            // 
            // Предыдущая
            // 
            this.Предыдущая.BackColor = System.Drawing.Color.MediumPurple;
            this.Предыдущая.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Предыдущая.ForeColor = System.Drawing.Color.Thistle;
            this.Предыдущая.Location = new System.Drawing.Point(354, 347);
            this.Предыдущая.Name = "Предыдущая";
            this.Предыдущая.Size = new System.Drawing.Size(108, 29);
            this.Предыдущая.TabIndex = 11;
            this.Предыдущая.Text = "Предыдущая";
            this.Предыдущая.UseVisualStyleBackColor = false;
            this.Предыдущая.Click += new System.EventHandler(this.Предыдущая_Click);
            // 
            // Первая
            // 
            this.Первая.BackColor = System.Drawing.Color.MediumPurple;
            this.Первая.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Первая.ForeColor = System.Drawing.Color.Thistle;
            this.Первая.Location = new System.Drawing.Point(258, 347);
            this.Первая.Name = "Первая";
            this.Первая.Size = new System.Drawing.Size(90, 29);
            this.Первая.TabIndex = 10;
            this.Первая.Text = "Первая";
            this.Первая.UseVisualStyleBackColor = false;
            this.Первая.Click += new System.EventHandler(this.Первая_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rentListsBindingSource, "clientid", true));
            this.comboBox1.DataSource = this.clientsBindingSource;
            this.comboBox1.DisplayMember = "passportnumber";
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(227, 440);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.ValueMember = "id";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rentListsBindingSource, "carid", true));
            this.comboBox2.DataSource = this.carsBindingSource;
            this.comboBox2.DisplayMember = "identfier";
            this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(437, 438);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 27);
            this.comboBox2.TabIndex = 22;
            this.comboBox2.ValueMember = "id";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumPurple;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Thistle;
            this.button1.Location = new System.Drawing.Point(617, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 29);
            this.button1.TabIndex = 23;
            this.button1.Text = "Сортировка";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Sort_Click);
            // 
            // autodbDataSet
            // 
            this.autodbDataSet.DataSetName = "autodbDataSet";
            this.autodbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentListsBindingSource
            // 
            this.rentListsBindingSource.DataMember = "RentLists";
            this.rentListsBindingSource.DataSource = this.autodbDataSet;
            // 
            // rentListsTableAdapter
            // 
            this.rentListsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArchiveCarsTableAdapter = null;
            this.tableAdapterManager.ArchiveRentListsTableAdapter = null;
            this.tableAdapterManager.ArchiveUsersTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarCharacteristicsTableAdapter = null;
            this.tableAdapterManager.CarsTableAdapter = this.carsTableAdapter;
            this.tableAdapterManager.ClientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.RentListsTableAdapter = this.rentListsTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarRent.autodbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // rentListsDataGridView
            // 
            this.rentListsDataGridView.AllowUserToAddRows = false;
            this.rentListsDataGridView.AllowUserToDeleteRows = false;
            this.rentListsDataGridView.AutoGenerateColumns = false;
            this.rentListsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentListsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.rentListsDataGridView.DataSource = this.rentListsBindingSource;
            this.rentListsDataGridView.Location = new System.Drawing.Point(177, 37);
            this.rentListsDataGridView.Name = "rentListsDataGridView";
            this.rentListsDataGridView.ReadOnly = true;
            this.rentListsDataGridView.Size = new System.Drawing.Size(657, 294);
            this.rentListsDataGridView.TabIndex = 24;
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
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.autodbDataSet;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "clientid";
            this.dataGridViewTextBoxColumn2.DataSource = this.clientsBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "passportnumber";
            this.dataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn2.HeaderText = "clientid";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "id";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "carid";
            this.dataGridViewTextBoxColumn3.DataSource = this.carsBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "identfier";
            this.dataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn3.HeaderText = "carid";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "id";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "renttime";
            this.dataGridViewTextBoxColumn4.HeaderText = "renttime";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "totalprice";
            this.dataGridViewTextBoxColumn5.HeaderText = "totalprice";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "dateofrent";
            this.dataGridViewTextBoxColumn6.HeaderText = "dateofrent";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "endofrent";
            this.dataGridViewTextBoxColumn7.HeaderText = "endofrent";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dateofrentLabel
            // 
            dateofrentLabel.AutoSize = true;
            dateofrentLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dateofrentLabel.ForeColor = System.Drawing.Color.Thistle;
            dateofrentLabel.Location = new System.Drawing.Point(232, 509);
            dateofrentLabel.Name = "dateofrentLabel";
            dateofrentLabel.Size = new System.Drawing.Size(73, 19);
            dateofrentLabel.TabIndex = 28;
            dateofrentLabel.Text = "dateofrent:";
            // 
            // dateofrentDateTimePicker
            // 
            this.dateofrentDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rentListsBindingSource, "dateofrent", true));
            this.dateofrentDateTimePicker.Location = new System.Drawing.Point(311, 509);
            this.dateofrentDateTimePicker.Name = "dateofrentDateTimePicker";
            this.dateofrentDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateofrentDateTimePicker.TabIndex = 29;
            // 
            // endofrentLabel
            // 
            endofrentLabel.AutoSize = true;
            endofrentLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            endofrentLabel.ForeColor = System.Drawing.Color.Thistle;
            endofrentLabel.Location = new System.Drawing.Point(532, 511);
            endofrentLabel.Name = "endofrentLabel";
            endofrentLabel.Size = new System.Drawing.Size(69, 19);
            endofrentLabel.TabIndex = 29;
            endofrentLabel.Text = "endofrent:";
            // 
            // endofrentDateTimePicker
            // 
            this.endofrentDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rentListsBindingSource, "endofrent", true));
            this.endofrentDateTimePicker.Location = new System.Drawing.Point(607, 509);
            this.endofrentDateTimePicker.Name = "endofrentDateTimePicker";
            this.endofrentDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endofrentDateTimePicker.TabIndex = 30;
            // 
            // renttimeLabel1
            // 
            renttimeLabel1.AutoSize = true;
            renttimeLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            renttimeLabel1.ForeColor = System.Drawing.Color.Thistle;
            renttimeLabel1.Location = new System.Drawing.Point(603, 441);
            renttimeLabel1.Name = "renttimeLabel1";
            renttimeLabel1.Size = new System.Drawing.Size(60, 19);
            renttimeLabel1.TabIndex = 30;
            renttimeLabel1.Text = "renttime:";
            // 
            // renttimeNumericUpDown
            // 
            this.renttimeNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rentListsBindingSource, "renttime", true));
            this.renttimeNumericUpDown.Location = new System.Drawing.Point(669, 442);
            this.renttimeNumericUpDown.Name = "renttimeNumericUpDown";
            this.renttimeNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.renttimeNumericUpDown.TabIndex = 31;
            // 
            // RentListsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1194, 619);
            this.Controls.Add(renttimeLabel1);
            this.Controls.Add(this.renttimeNumericUpDown);
            this.Controls.Add(endofrentLabel);
            this.Controls.Add(this.endofrentDateTimePicker);
            this.Controls.Add(dateofrentLabel);
            this.Controls.Add(this.dateofrentDateTimePicker);
            this.Controls.Add(this.rentListsDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(caridLabel);
            this.Controls.Add(clientidLabel);
            this.Controls.Add(this.Сохранять);
            this.Controls.Add(this.Удалить);
            this.Controls.Add(this.Добавить);
            this.Controls.Add(this.Последняя);
            this.Controls.Add(this.Следущая);
            this.Controls.Add(this.Предыдущая);
            this.Controls.Add(this.Первая);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RentListsForm";
            this.Text = "RentListsForm";
            this.Load += new System.EventHandler(this.RentListsForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.autodbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentListsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentListsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.renttimeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Сохранять;
        private System.Windows.Forms.Button Удалить;
        private System.Windows.Forms.Button Добавить;
        private System.Windows.Forms.Button Последняя;
        private System.Windows.Forms.Button Следущая;
        private System.Windows.Forms.Button Предыдущая;
        private System.Windows.Forms.Button Первая;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private autodbDataSet autodbDataSet;
        private System.Windows.Forms.BindingSource rentListsBindingSource;
        private autodbDataSetTableAdapters.RentListsTableAdapter rentListsTableAdapter;
        private autodbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private autodbDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.DataGridView rentListsDataGridView;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private autodbDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DateTimePicker dateofrentDateTimePicker;
        private System.Windows.Forms.DateTimePicker endofrentDateTimePicker;
        private System.Windows.Forms.NumericUpDown renttimeNumericUpDown;
    }
}