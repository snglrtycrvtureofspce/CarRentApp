namespace CarRent
{
    partial class CarsForm
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
            System.Windows.Forms.Label mileageLabel;
            System.Windows.Forms.Label creationYearLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label priceforhourLabel;
            System.Windows.Forms.Label characteristicsidLabel;
            System.Windows.Forms.Label identfierLabel;
            this.carsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.carCharacteristicsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autodbDataSet1 = new CarRent.autodbDataSet();
            this.identfier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Первая = new System.Windows.Forms.Button();
            this.Предыдущая = new System.Windows.Forms.Button();
            this.Следущая = new System.Windows.Forms.Button();
            this.Последняя = new System.Windows.Forms.Button();
            this.Добавить = new System.Windows.Forms.Button();
            this.Удалить = new System.Windows.Forms.Button();
            this.Сохранять = new System.Windows.Forms.Button();
            this.mileageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.creationYearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.priceforhourNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.carsTableAdapter1 = new CarRent.autodbDataSetTableAdapters.CarsTableAdapter();
            this.tableAdapterManager1 = new CarRent.autodbDataSetTableAdapters.TableAdapterManager();
            this.carCharacteristicsTableAdapter = new CarRent.autodbDataSetTableAdapters.CarCharacteristicsTableAdapter();
            this.identfierTextBox = new System.Windows.Forms.TextBox();
            mileageLabel = new System.Windows.Forms.Label();
            creationYearLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            priceforhourLabel = new System.Windows.Forms.Label();
            characteristicsidLabel = new System.Windows.Forms.Label();
            identfierLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carCharacteristicsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autodbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mileageNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creationYearNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceforhourNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // mileageLabel
            // 
            mileageLabel.AutoSize = true;
            mileageLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            mileageLabel.ForeColor = System.Drawing.Color.Thistle;
            mileageLabel.Location = new System.Drawing.Point(98, 476);
            mileageLabel.Name = "mileageLabel";
            mileageLabel.Size = new System.Drawing.Size(57, 19);
            mileageLabel.TabIndex = 9;
            mileageLabel.Text = "mileage:";
            // 
            // creationYearLabel
            // 
            creationYearLabel.AutoSize = true;
            creationYearLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            creationYearLabel.ForeColor = System.Drawing.Color.Thistle;
            creationYearLabel.Location = new System.Drawing.Point(311, 476);
            creationYearLabel.Name = "creationYearLabel";
            creationYearLabel.Size = new System.Drawing.Size(91, 19);
            creationYearLabel.TabIndex = 11;
            creationYearLabel.Text = "creation Year:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            colorLabel.ForeColor = System.Drawing.Color.Thistle;
            colorLabel.Location = new System.Drawing.Point(571, 476);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(43, 19);
            colorLabel.TabIndex = 13;
            colorLabel.Text = "color:";
            // 
            // priceforhourLabel
            // 
            priceforhourLabel.AutoSize = true;
            priceforhourLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            priceforhourLabel.ForeColor = System.Drawing.Color.Thistle;
            priceforhourLabel.Location = new System.Drawing.Point(742, 476);
            priceforhourLabel.Name = "priceforhourLabel";
            priceforhourLabel.Size = new System.Drawing.Size(86, 19);
            priceforhourLabel.TabIndex = 15;
            priceforhourLabel.Text = "priceforhour:";
            // 
            // characteristicsidLabel
            // 
            characteristicsidLabel.AutoSize = true;
            characteristicsidLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            characteristicsidLabel.ForeColor = System.Drawing.Color.Thistle;
            characteristicsidLabel.Location = new System.Drawing.Point(294, 445);
            characteristicsidLabel.Name = "characteristicsidLabel";
            characteristicsidLabel.Size = new System.Drawing.Size(108, 19);
            characteristicsidLabel.TabIndex = 17;
            characteristicsidLabel.Text = "characteristicsid:";
            // 
            // identfierLabel
            // 
            identfierLabel.AutoSize = true;
            identfierLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            identfierLabel.ForeColor = System.Drawing.Color.Thistle;
            identfierLabel.Location = new System.Drawing.Point(554, 445);
            identfierLabel.Name = "identfierLabel";
            identfierLabel.Size = new System.Drawing.Size(60, 19);
            identfierLabel.TabIndex = 19;
            identfierLabel.Text = "identfier:";
            // 
            // carsDataGridView
            // 
            this.carsDataGridView.AllowUserToAddRows = false;
            this.carsDataGridView.AllowUserToDeleteRows = false;
            this.carsDataGridView.AutoGenerateColumns = false;
            this.carsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.identfier,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.carsDataGridView.DataSource = this.carsBindingSource1;
            this.carsDataGridView.Location = new System.Drawing.Point(185, 32);
            this.carsDataGridView.Name = "carsDataGridView";
            this.carsDataGridView.ReadOnly = true;
            this.carsDataGridView.Size = new System.Drawing.Size(656, 285);
            this.carsDataGridView.TabIndex = 1;
            this.carsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.carsDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "characteristicsid";
            this.dataGridViewTextBoxColumn2.DataSource = this.carCharacteristicsBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "mark";
            this.dataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn2.HeaderText = "characteristicsid";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "id";
            // 
            // carCharacteristicsBindingSource
            // 
            this.carCharacteristicsBindingSource.DataMember = "CarCharacteristics";
            this.carCharacteristicsBindingSource.DataSource = this.autodbDataSet1;
            // 
            // autodbDataSet1
            // 
            this.autodbDataSet1.DataSetName = "autodbDataSet";
            this.autodbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // identfier
            // 
            this.identfier.DataPropertyName = "identfier";
            this.identfier.HeaderText = "identfier";
            this.identfier.Name = "identfier";
            this.identfier.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "mileage";
            this.dataGridViewTextBoxColumn3.HeaderText = "mileage";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "creationYear";
            this.dataGridViewTextBoxColumn4.HeaderText = "creationYear";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "color";
            this.dataGridViewTextBoxColumn5.HeaderText = "color";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "priceforhour";
            this.dataGridViewTextBoxColumn6.HeaderText = "priceforhour";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // carsBindingSource1
            // 
            this.carsBindingSource1.DataMember = "Cars";
            this.carsBindingSource1.DataSource = this.autodbDataSet1;
            // 
            // Первая
            // 
            this.Первая.BackColor = System.Drawing.Color.MediumPurple;
            this.Первая.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Первая.ForeColor = System.Drawing.Color.Thistle;
            this.Первая.Location = new System.Drawing.Point(284, 339);
            this.Первая.Name = "Первая";
            this.Первая.Size = new System.Drawing.Size(91, 31);
            this.Первая.TabIndex = 2;
            this.Первая.Text = "Первая";
            this.Первая.UseVisualStyleBackColor = false;
            this.Первая.Click += new System.EventHandler(this.firstButton_Click);
            // 
            // Предыдущая
            // 
            this.Предыдущая.BackColor = System.Drawing.Color.MediumPurple;
            this.Предыдущая.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Предыдущая.ForeColor = System.Drawing.Color.Thistle;
            this.Предыдущая.Location = new System.Drawing.Point(381, 339);
            this.Предыдущая.Name = "Предыдущая";
            this.Предыдущая.Size = new System.Drawing.Size(109, 31);
            this.Предыдущая.TabIndex = 3;
            this.Предыдущая.Text = "Предыдущая";
            this.Предыдущая.UseVisualStyleBackColor = false;
            this.Предыдущая.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // Следущая
            // 
            this.Следущая.BackColor = System.Drawing.Color.MediumPurple;
            this.Следущая.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Следущая.ForeColor = System.Drawing.Color.Thistle;
            this.Следущая.Location = new System.Drawing.Point(496, 339);
            this.Следущая.Name = "Следущая";
            this.Следущая.Size = new System.Drawing.Size(91, 31);
            this.Следущая.TabIndex = 4;
            this.Следущая.Text = "Следущая";
            this.Следущая.UseVisualStyleBackColor = false;
            this.Следущая.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // Последняя
            // 
            this.Последняя.BackColor = System.Drawing.Color.MediumPurple;
            this.Последняя.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Последняя.ForeColor = System.Drawing.Color.Thistle;
            this.Последняя.Location = new System.Drawing.Point(593, 339);
            this.Последняя.Name = "Последняя";
            this.Последняя.Size = new System.Drawing.Size(91, 31);
            this.Последняя.TabIndex = 5;
            this.Последняя.Text = "Последняя";
            this.Последняя.UseVisualStyleBackColor = false;
            this.Последняя.Click += new System.EventHandler(this.endButton_Click);
            // 
            // Добавить
            // 
            this.Добавить.BackColor = System.Drawing.Color.MediumPurple;
            this.Добавить.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Добавить.ForeColor = System.Drawing.Color.Thistle;
            this.Добавить.Location = new System.Drawing.Point(690, 339);
            this.Добавить.Name = "Добавить";
            this.Добавить.Size = new System.Drawing.Size(91, 31);
            this.Добавить.TabIndex = 6;
            this.Добавить.Text = "Добавить";
            this.Добавить.UseVisualStyleBackColor = false;
            this.Добавить.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Удалить
            // 
            this.Удалить.BackColor = System.Drawing.Color.MediumPurple;
            this.Удалить.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Удалить.ForeColor = System.Drawing.Color.Thistle;
            this.Удалить.Location = new System.Drawing.Point(425, 385);
            this.Удалить.Name = "Удалить";
            this.Удалить.Size = new System.Drawing.Size(109, 31);
            this.Удалить.TabIndex = 7;
            this.Удалить.Text = "Удалить";
            this.Удалить.UseVisualStyleBackColor = false;
            this.Удалить.Click += new System.EventHandler(this.deleleButton_Click);
            // 
            // Сохранять
            // 
            this.Сохранять.BackColor = System.Drawing.Color.MediumPurple;
            this.Сохранять.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Сохранять.ForeColor = System.Drawing.Color.Thistle;
            this.Сохранять.Location = new System.Drawing.Point(540, 385);
            this.Сохранять.Name = "Сохранять";
            this.Сохранять.Size = new System.Drawing.Size(91, 31);
            this.Сохранять.TabIndex = 8;
            this.Сохранять.Text = "Сохранять";
            this.Сохранять.UseVisualStyleBackColor = false;
            this.Сохранять.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // mileageNumericUpDown
            // 
            this.mileageNumericUpDown.BackColor = System.Drawing.SystemColors.Window;
            this.mileageNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.carsBindingSource1, "mileage", true));
            this.mileageNumericUpDown.DecimalPlaces = 2;
            this.mileageNumericUpDown.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mileageNumericUpDown.Location = new System.Drawing.Point(161, 474);
            this.mileageNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.mileageNumericUpDown.Name = "mileageNumericUpDown";
            this.mileageNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.mileageNumericUpDown.TabIndex = 10;
            // 
            // creationYearNumericUpDown
            // 
            this.creationYearNumericUpDown.BackColor = System.Drawing.SystemColors.Window;
            this.creationYearNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.carsBindingSource1, "creationYear", true));
            this.creationYearNumericUpDown.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.creationYearNumericUpDown.Location = new System.Drawing.Point(408, 473);
            this.creationYearNumericUpDown.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.creationYearNumericUpDown.Name = "creationYearNumericUpDown";
            this.creationYearNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.creationYearNumericUpDown.TabIndex = 12;
            // 
            // colorTextBox
            // 
            this.colorTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.colorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource1, "color", true));
            this.colorTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorTextBox.Location = new System.Drawing.Point(620, 474);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(100, 26);
            this.colorTextBox.TabIndex = 14;
            // 
            // priceforhourNumericUpDown
            // 
            this.priceforhourNumericUpDown.BackColor = System.Drawing.SystemColors.Window;
            this.priceforhourNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.carsBindingSource1, "priceforhour", true));
            this.priceforhourNumericUpDown.DecimalPlaces = 2;
            this.priceforhourNumericUpDown.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceforhourNumericUpDown.Location = new System.Drawing.Point(834, 473);
            this.priceforhourNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.priceforhourNumericUpDown.Name = "priceforhourNumericUpDown";
            this.priceforhourNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.priceforhourNumericUpDown.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.carsBindingSource1, "characteristicsid", true));
            this.comboBox1.DataSource = this.carCharacteristicsBindingSource;
            this.comboBox1.DisplayMember = "mark";
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(407, 442);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.ValueMember = "id";
            // 
            // carsTableAdapter1
            // 
            this.carsTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.ArchiveCarsTableAdapter = null;
            this.tableAdapterManager1.ArchiveRentListsTableAdapter = null;
            this.tableAdapterManager1.ArchiveUsersTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CarCharacteristicsTableAdapter = null;
            this.tableAdapterManager1.CarsTableAdapter = this.carsTableAdapter1;
            this.tableAdapterManager1.ClientsTableAdapter = null;
            this.tableAdapterManager1.RentListsTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = CarRent.autodbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UsersTableAdapter = null;
            // 
            // carCharacteristicsTableAdapter
            // 
            this.carCharacteristicsTableAdapter.ClearBeforeFill = true;
            // 
            // identfierTextBox
            // 
            this.identfierTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.identfierTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource1, "identfier", true));
            this.identfierTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.identfierTextBox.Location = new System.Drawing.Point(620, 443);
            this.identfierTextBox.Name = "identfierTextBox";
            this.identfierTextBox.Size = new System.Drawing.Size(100, 26);
            this.identfierTextBox.TabIndex = 20;
            // 
            // CarsForm
            // 
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1043, 619);
            this.Controls.Add(identfierLabel);
            this.Controls.Add(this.identfierTextBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(characteristicsidLabel);
            this.Controls.Add(priceforhourLabel);
            this.Controls.Add(this.priceforhourNumericUpDown);
            this.Controls.Add(colorLabel);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(creationYearLabel);
            this.Controls.Add(this.creationYearNumericUpDown);
            this.Controls.Add(mileageLabel);
            this.Controls.Add(this.mileageNumericUpDown);
            this.Controls.Add(this.Сохранять);
            this.Controls.Add(this.Удалить);
            this.Controls.Add(this.Добавить);
            this.Controls.Add(this.Последняя);
            this.Controls.Add(this.Следущая);
            this.Controls.Add(this.Предыдущая);
            this.Controls.Add(this.Первая);
            this.Controls.Add(this.carsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarsForm";
            this.Load += new System.EventHandler(this.CarsForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carCharacteristicsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autodbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mileageNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creationYearNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceforhourNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private autodbDataSet autodbDataSet;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private autodbDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
        private autodbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator carsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton carsBindingNavigatorSaveItem;
        private autodbDataSet autodbDataSet1;
        private System.Windows.Forms.BindingSource carsBindingSource1;
        private autodbDataSetTableAdapters.CarsTableAdapter carsTableAdapter1;
        private autodbDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView carsDataGridView;
        private System.Windows.Forms.Button Первая;
        private System.Windows.Forms.Button Предыдущая;
        private System.Windows.Forms.Button Следущая;
        private System.Windows.Forms.Button Последняя;
        private System.Windows.Forms.Button Добавить;
        private System.Windows.Forms.Button Удалить;
        private System.Windows.Forms.Button Сохранять;
        private System.Windows.Forms.NumericUpDown mileageNumericUpDown;
        private System.Windows.Forms.NumericUpDown creationYearNumericUpDown;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.NumericUpDown priceforhourNumericUpDown;
        private System.Windows.Forms.BindingSource carCharacteristicsBindingSource;
        private autodbDataSetTableAdapters.CarCharacteristicsTableAdapter carCharacteristicsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn identfier;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox identfierTextBox;
    }
}