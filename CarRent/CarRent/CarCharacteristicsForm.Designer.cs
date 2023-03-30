namespace CarRent
{
    partial class CarCharacteristicsForm
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
            System.Windows.Forms.Label markLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label enginecapacityLabel;
            System.Windows.Forms.Label driveunitLabel;
            System.Windows.Forms.Label transmissiontypeLabel;
            System.Windows.Forms.Label fueltypeLabel;
            this.autodbDataSet = new CarRent.autodbDataSet();
            this.carCharacteristicsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carCharacteristicsTableAdapter = new CarRent.autodbDataSetTableAdapters.CarCharacteristicsTableAdapter();
            this.tableAdapterManager = new CarRent.autodbDataSetTableAdapters.TableAdapterManager();
            this.carCharacteristicsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Сохранять = new System.Windows.Forms.Button();
            this.Удалить = new System.Windows.Forms.Button();
            this.Добавить = new System.Windows.Forms.Button();
            this.Последняя = new System.Windows.Forms.Button();
            this.Следущая = new System.Windows.Forms.Button();
            this.Предыдущая = new System.Windows.Forms.Button();
            this.Первая = new System.Windows.Forms.Button();
            this.markTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.enginecapacityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.driveunitTextBox = new System.Windows.Forms.TextBox();
            this.transmissiontypeTextBox = new System.Windows.Forms.TextBox();
            this.fueltypeTextBox = new System.Windows.Forms.TextBox();
            markLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            enginecapacityLabel = new System.Windows.Forms.Label();
            driveunitLabel = new System.Windows.Forms.Label();
            transmissiontypeLabel = new System.Windows.Forms.Label();
            fueltypeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.autodbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carCharacteristicsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carCharacteristicsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enginecapacityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // markLabel
            // 
            markLabel.AutoSize = true;
            markLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            markLabel.ForeColor = System.Drawing.Color.Thistle;
            markLabel.Location = new System.Drawing.Point(153, 407);
            markLabel.Name = "markLabel";
            markLabel.Size = new System.Drawing.Size(43, 19);
            markLabel.TabIndex = 17;
            markLabel.Text = "mark:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            modelLabel.ForeColor = System.Drawing.Color.Thistle;
            modelLabel.Location = new System.Drawing.Point(338, 407);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(49, 19);
            modelLabel.TabIndex = 18;
            modelLabel.Text = "model:";
            // 
            // enginecapacityLabel
            // 
            enginecapacityLabel.AutoSize = true;
            enginecapacityLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            enginecapacityLabel.ForeColor = System.Drawing.Color.Thistle;
            enginecapacityLabel.Location = new System.Drawing.Point(506, 407);
            enginecapacityLabel.Name = "enginecapacityLabel";
            enginecapacityLabel.Size = new System.Drawing.Size(100, 19);
            enginecapacityLabel.TabIndex = 19;
            enginecapacityLabel.Text = "enginecapacity:";
            // 
            // driveunitLabel
            // 
            driveunitLabel.AutoSize = true;
            driveunitLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            driveunitLabel.ForeColor = System.Drawing.Color.Thistle;
            driveunitLabel.Location = new System.Drawing.Point(758, 407);
            driveunitLabel.Name = "driveunitLabel";
            driveunitLabel.Size = new System.Drawing.Size(63, 19);
            driveunitLabel.TabIndex = 20;
            driveunitLabel.Text = "driveunit:";
            // 
            // transmissiontypeLabel
            // 
            transmissiontypeLabel.AutoSize = true;
            transmissiontypeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            transmissiontypeLabel.ForeColor = System.Drawing.Color.Thistle;
            transmissiontypeLabel.Location = new System.Drawing.Point(306, 443);
            transmissiontypeLabel.Name = "transmissiontypeLabel";
            transmissiontypeLabel.Size = new System.Drawing.Size(111, 19);
            transmissiontypeLabel.TabIndex = 21;
            transmissiontypeLabel.Text = "transmissiontype:";
            // 
            // fueltypeLabel
            // 
            fueltypeLabel.AutoSize = true;
            fueltypeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            fueltypeLabel.ForeColor = System.Drawing.Color.Thistle;
            fueltypeLabel.Location = new System.Drawing.Point(547, 444);
            fueltypeLabel.Name = "fueltypeLabel";
            fueltypeLabel.Size = new System.Drawing.Size(59, 19);
            fueltypeLabel.TabIndex = 22;
            fueltypeLabel.Text = "fueltype:";
            // 
            // autodbDataSet
            // 
            this.autodbDataSet.DataSetName = "autodbDataSet";
            this.autodbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carCharacteristicsBindingSource
            // 
            this.carCharacteristicsBindingSource.DataMember = "CarCharacteristics";
            this.carCharacteristicsBindingSource.DataSource = this.autodbDataSet;
            // 
            // carCharacteristicsTableAdapter
            // 
            this.carCharacteristicsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArchiveCarsTableAdapter = null;
            this.tableAdapterManager.ArchiveRentListsTableAdapter = null;
            this.tableAdapterManager.ArchiveUsersTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarCharacteristicsTableAdapter = this.carCharacteristicsTableAdapter;
            this.tableAdapterManager.CarsTableAdapter = null;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.RentListsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CarRent.autodbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // carCharacteristicsDataGridView
            // 
            this.carCharacteristicsDataGridView.AllowUserToAddRows = false;
            this.carCharacteristicsDataGridView.AllowUserToDeleteRows = false;
            this.carCharacteristicsDataGridView.AutoGenerateColumns = false;
            this.carCharacteristicsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carCharacteristicsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.carCharacteristicsDataGridView.DataSource = this.carCharacteristicsBindingSource;
            this.carCharacteristicsDataGridView.Location = new System.Drawing.Point(184, 26);
            this.carCharacteristicsDataGridView.Name = "carCharacteristicsDataGridView";
            this.carCharacteristicsDataGridView.ReadOnly = true;
            this.carCharacteristicsDataGridView.Size = new System.Drawing.Size(654, 268);
            this.carCharacteristicsDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "mark";
            this.dataGridViewTextBoxColumn2.HeaderText = "mark";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "model";
            this.dataGridViewTextBoxColumn3.HeaderText = "model";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "enginecapacity";
            this.dataGridViewTextBoxColumn4.HeaderText = "enginecapacity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "driveunit";
            this.dataGridViewTextBoxColumn5.HeaderText = "driveunit";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "transmissiontype";
            this.dataGridViewTextBoxColumn6.HeaderText = "transmissiontype";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "fueltype";
            this.dataGridViewTextBoxColumn7.HeaderText = "fueltype";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // Сохранять
            // 
            this.Сохранять.BackColor = System.Drawing.Color.MediumPurple;
            this.Сохранять.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Сохранять.ForeColor = System.Drawing.Color.Thistle;
            this.Сохранять.Location = new System.Drawing.Point(551, 349);
            this.Сохранять.Name = "Сохранять";
            this.Сохранять.Size = new System.Drawing.Size(95, 32);
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
            this.Удалить.Location = new System.Drawing.Point(418, 349);
            this.Удалить.Name = "Удалить";
            this.Удалить.Size = new System.Drawing.Size(113, 32);
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
            this.Добавить.Location = new System.Drawing.Point(724, 300);
            this.Добавить.Name = "Добавить";
            this.Добавить.Size = new System.Drawing.Size(95, 32);
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
            this.Последняя.Location = new System.Drawing.Point(612, 300);
            this.Последняя.Name = "Последняя";
            this.Последняя.Size = new System.Drawing.Size(95, 32);
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
            this.Следущая.Location = new System.Drawing.Point(496, 300);
            this.Следущая.Name = "Следущая";
            this.Следущая.Size = new System.Drawing.Size(95, 32);
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
            this.Предыдущая.Location = new System.Drawing.Point(363, 300);
            this.Предыдущая.Name = "Предыдущая";
            this.Предыдущая.Size = new System.Drawing.Size(113, 32);
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
            this.Первая.Location = new System.Drawing.Point(250, 300);
            this.Первая.Name = "Первая";
            this.Первая.Size = new System.Drawing.Size(95, 32);
            this.Первая.TabIndex = 10;
            this.Первая.Text = "Первая";
            this.Первая.UseVisualStyleBackColor = false;
            this.Первая.Click += new System.EventHandler(this.Первая_Click);
            // 
            // markTextBox
            // 
            this.markTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carCharacteristicsBindingSource, "mark", true));
            this.markTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markTextBox.Location = new System.Drawing.Point(202, 404);
            this.markTextBox.Name = "markTextBox";
            this.markTextBox.Size = new System.Drawing.Size(100, 26);
            this.markTextBox.TabIndex = 18;
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carCharacteristicsBindingSource, "model", true));
            this.modelTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modelTextBox.Location = new System.Drawing.Point(393, 404);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 26);
            this.modelTextBox.TabIndex = 19;
            // 
            // enginecapacityNumericUpDown
            // 
            this.enginecapacityNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.carCharacteristicsBindingSource, "enginecapacity", true));
            this.enginecapacityNumericUpDown.DecimalPlaces = 1;
            this.enginecapacityNumericUpDown.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enginecapacityNumericUpDown.Location = new System.Drawing.Point(612, 404);
            this.enginecapacityNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.enginecapacityNumericUpDown.Name = "enginecapacityNumericUpDown";
            this.enginecapacityNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.enginecapacityNumericUpDown.TabIndex = 20;
            // 
            // driveunitTextBox
            // 
            this.driveunitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carCharacteristicsBindingSource, "driveunit", true));
            this.driveunitTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.driveunitTextBox.Location = new System.Drawing.Point(827, 405);
            this.driveunitTextBox.Name = "driveunitTextBox";
            this.driveunitTextBox.Size = new System.Drawing.Size(100, 26);
            this.driveunitTextBox.TabIndex = 21;
            // 
            // transmissiontypeTextBox
            // 
            this.transmissiontypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carCharacteristicsBindingSource, "transmissiontype", true));
            this.transmissiontypeTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transmissiontypeTextBox.Location = new System.Drawing.Point(428, 441);
            this.transmissiontypeTextBox.Name = "transmissiontypeTextBox";
            this.transmissiontypeTextBox.Size = new System.Drawing.Size(100, 26);
            this.transmissiontypeTextBox.TabIndex = 22;
            // 
            // fueltypeTextBox
            // 
            this.fueltypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carCharacteristicsBindingSource, "fueltype", true));
            this.fueltypeTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fueltypeTextBox.Location = new System.Drawing.Point(612, 441);
            this.fueltypeTextBox.Name = "fueltypeTextBox";
            this.fueltypeTextBox.Size = new System.Drawing.Size(100, 26);
            this.fueltypeTextBox.TabIndex = 23;
            // 
            // CarCharacteristicsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1047, 619);
            this.Controls.Add(fueltypeLabel);
            this.Controls.Add(this.fueltypeTextBox);
            this.Controls.Add(transmissiontypeLabel);
            this.Controls.Add(this.transmissiontypeTextBox);
            this.Controls.Add(driveunitLabel);
            this.Controls.Add(this.driveunitTextBox);
            this.Controls.Add(enginecapacityLabel);
            this.Controls.Add(this.enginecapacityNumericUpDown);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(markLabel);
            this.Controls.Add(this.markTextBox);
            this.Controls.Add(this.Сохранять);
            this.Controls.Add(this.Удалить);
            this.Controls.Add(this.Добавить);
            this.Controls.Add(this.Последняя);
            this.Controls.Add(this.Следущая);
            this.Controls.Add(this.Предыдущая);
            this.Controls.Add(this.Первая);
            this.Controls.Add(this.carCharacteristicsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarCharacteristicsForm";
            this.Text = "CarCharacteristicsForm";
            this.Load += new System.EventHandler(this.CarCharacteristicsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autodbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carCharacteristicsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carCharacteristicsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enginecapacityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private autodbDataSet autodbDataSet;
        private System.Windows.Forms.BindingSource carCharacteristicsBindingSource;
        private autodbDataSetTableAdapters.CarCharacteristicsTableAdapter carCharacteristicsTableAdapter;
        private autodbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView carCharacteristicsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button Сохранять;
        private System.Windows.Forms.Button Удалить;
        private System.Windows.Forms.Button Добавить;
        private System.Windows.Forms.Button Последняя;
        private System.Windows.Forms.Button Следущая;
        private System.Windows.Forms.Button Предыдущая;
        private System.Windows.Forms.Button Первая;
        private System.Windows.Forms.TextBox markTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.NumericUpDown enginecapacityNumericUpDown;
        private System.Windows.Forms.TextBox driveunitTextBox;
        private System.Windows.Forms.TextBox transmissiontypeTextBox;
        private System.Windows.Forms.TextBox fueltypeTextBox;
    }
}