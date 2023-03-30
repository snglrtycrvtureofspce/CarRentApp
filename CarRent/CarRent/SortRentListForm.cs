using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRent
{
    public partial class SortRentListForm : Form
    {
        public SortRentListForm()
        {
            InitializeComponent();
        }

        private void SortRentListForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autodbDataSet.Cars". При необходимости она может быть перемещена или удалена.
            this.carsTableAdapter.Fill(this.autodbDataSet.Cars);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autodbDataSet.CarCharacteristics". При необходимости она может быть перемещена или удалена.
            this.carCharacteristicsTableAdapter.Fill(this.autodbDataSet.CarCharacteristics);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autodbDataSet.RentListView". При необходимости она может быть перемещена или удалена.
            this.rentListViewTableAdapter.Fill(this.autodbDataSet.RentListView);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataGridViewColumn dataGridViewColumn = new DataGridViewColumn();
            switch (listBox1.SelectedIndex)
            {
                case 0: { dataGridViewColumn = dataGridViewTextBoxColumn1; } break;
                case 1: { dataGridViewColumn = dataGridViewTextBoxColumn2; } break;
                case 2: { dataGridViewColumn = dataGridViewTextBoxColumn3; } break;
                case 3: { dataGridViewColumn = dataGridViewTextBoxColumn4; } break;
                case 4: { dataGridViewColumn = dataGridViewTextBoxColumn5; } break;
                case 5: { dataGridViewColumn = dataGridViewTextBoxColumn6; } break;
                case 6: { dataGridViewColumn = dataGridViewTextBoxColumn7; } break;
                case 7: { dataGridViewColumn = dataGridViewTextBoxColumn8; } break;
            }

            if (radioButton1.Checked)
            {
                rentListViewDataGridView.Sort(dataGridViewColumn, System.ComponentModel.ListSortDirection.Ascending);
            }
            if (radioButton2.Checked)
            {
                rentListViewDataGridView.Sort(dataGridViewColumn, System.ComponentModel.ListSortDirection.Descending);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Program.form.ShowForm(new RentListsForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rentListViewBindingSource.Filter = "[Mark]='" + comboBox1.Text + "'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rentListViewBindingSource.Filter = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < rentListViewDataGridView.Columns.Count; i++)
            {
                for (int j = 0; j < rentListViewDataGridView.Rows.Count; j++)
                {
                    rentListViewDataGridView[i, j].Style.BackColor = Color.White;
                    rentListViewDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }

            for (int i = 0; i < rentListViewDataGridView.Columns.Count; i++)
            {
                for (int j = 0; j < rentListViewDataGridView.Rows.Count; j++)
                {

                    if (rentListViewDataGridView[i, j].Value != null)
                        if (rentListViewDataGridView[i, j].Value.ToString().ToLower().Contains(textBox1.Text.ToLower()))
                        {
                            rentListViewDataGridView[i, j].Style.BackColor = Color.LightSeaGreen;
                            rentListViewDataGridView[i, j].Style.ForeColor = Color.White;
                        }

                }
            }
        }
    }
}
