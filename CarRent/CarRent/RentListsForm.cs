using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRent
{
    public partial class RentListsForm : Form
    {
        public RentListsForm()
        {
            InitializeComponent();
        }

        private void RentListsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autodbDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.autodbDataSet.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autodbDataSet.Cars". При необходимости она может быть перемещена или удалена.
            this.carsTableAdapter.Fill(this.autodbDataSet.Cars);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autodbDataSet.RentLists". При необходимости она может быть перемещена или удалена.
            this.rentListsTableAdapter.Fill(this.autodbDataSet.RentLists);
        }

        private void Первая_Click(object sender, EventArgs e)
        {
            this.rentListsBindingSource.MoveFirst();
        }

        private void Предыдущая_Click(object sender, EventArgs e)
        {
            this.rentListsBindingSource.MovePrevious();
        }

        private void Следущая_Click(object sender, EventArgs e)
        {
            this.rentListsBindingSource.MoveNext();
        }

        private void Последняя_Click(object sender, EventArgs e)
        {
            this.rentListsBindingSource.MoveLast();
        }

        private void Добавить_Click(object sender, EventArgs e)
        {
            try
            {
                this.rentListsBindingSource.AddNew();
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
                this.rentListsBindingSource.RemoveCurrent();
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
            this.rentListsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autodbDataSet);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Данный автомобиль уже арендован или данный клиент уже арендовал другой автомобиль", "Ошибка");
            }
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            Program.form.ShowForm(new SortRentListForm());
        }

        private void rentListsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rentListsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autodbDataSet);

        }

        private void RentListsForm_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autodbDataSet.Cars". При необходимости она может быть перемещена или удалена.
            this.carsTableAdapter.Fill(this.autodbDataSet.Cars);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autodbDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.autodbDataSet.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autodbDataSet.RentLists". При необходимости она может быть перемещена или удалена.
            this.rentListsTableAdapter.Fill(this.autodbDataSet.RentLists);

        }
    }
}
