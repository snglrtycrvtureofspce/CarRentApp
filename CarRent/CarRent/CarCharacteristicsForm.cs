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
    public partial class CarCharacteristicsForm : Form
    {
        public CarCharacteristicsForm()
        {
            InitializeComponent();
        }

        private void carCharacteristicsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carCharacteristicsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autodbDataSet);

        }

        private void CarCharacteristicsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autodbDataSet.CarCharacteristics". При необходимости она может быть перемещена или удалена.
            this.carCharacteristicsTableAdapter.Fill(this.autodbDataSet.CarCharacteristics);

        }

        private void Первая_Click(object sender, EventArgs e)
        {
            this.carCharacteristicsBindingSource.MoveFirst();
        }

        private void Предыдущая_Click(object sender, EventArgs e)
        {
            this.carCharacteristicsBindingSource.MovePrevious();
        }

        private void Следущая_Click(object sender, EventArgs e)
        {
            this.carCharacteristicsBindingSource.MoveNext();
        }

        private void Последняя_Click(object sender, EventArgs e)
        {
            this.carCharacteristicsBindingSource.MoveLast();
        }

        private void Добавить_Click(object sender, EventArgs e)
        {
            try
            {
                this.carCharacteristicsBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void Удалить_Click(object sender, EventArgs e)
        {
            try
            {
                this.carCharacteristicsBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void Сохранять_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.carCharacteristicsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.autodbDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}
