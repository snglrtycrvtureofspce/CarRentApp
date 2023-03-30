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
    public partial class CarsForm : Form
    {
        public CarsForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.carsBindingSource1.AddNew();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void deleleButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.carsBindingSource1.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.carsBindingSource1.EndEdit();
                this.tableAdapterManager1.UpdateAll(this.autodbDataSet1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            this.carsBindingSource1.MovePrevious();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.carsBindingSource1.MoveNext();
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            this.carsBindingSource1.MoveFirst();
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            this.carsBindingSource1.MoveLast();
        }

        private void CarsForm_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autodbDataSet1.CarCharacteristics". При необходимости она может быть перемещена или удалена.
            this.carCharacteristicsTableAdapter.Fill(this.autodbDataSet1.CarCharacteristics);
            this.carsTableAdapter1.Fill(this.autodbDataSet1.Cars);

        }

        private void carsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
