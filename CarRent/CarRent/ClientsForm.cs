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
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autodbDataSet);

        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autodbDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.autodbDataSet.Clients);

        }

        private void Первая_Click(object sender, EventArgs e)
        {
            this.clientsBindingSource.MoveFirst();
        }

        private void Предыдущая_Click(object sender, EventArgs e)
        {
            this.clientsBindingSource.MovePrevious();
        }

        private void Следущая_Click(object sender, EventArgs e)
        {
            this.clientsBindingSource.MoveNext();
        }

        private void Последняя_Click(object sender, EventArgs e)
        {
            this.clientsBindingSource.MoveLast();
        }

        private void Добавить_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientsBindingSource.AddNew();
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
                this.clientsBindingSource.RemoveCurrent();
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
                this.clientsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.autodbDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}
