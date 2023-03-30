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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autodbDataSet);

        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autodbDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.autodbDataSet.Users);

        }

        private void Первая_Click(object sender, EventArgs e)
        {
            this.usersBindingSource.MoveFirst();
        }

        private void Предыдущая_Click(object sender, EventArgs e)
        {
            this.usersBindingSource.MovePrevious();
        }

        private void Следущая_Click(object sender, EventArgs e)
        {
            this.usersBindingSource.MoveNext();
        }

        private void Последняя_Click(object sender, EventArgs e)
        {
            this.usersBindingSource.MoveLast();
        }

        private void Добавить_Click(object sender, EventArgs e)
        {
            try
            {
                this.usersBindingSource.AddNew();
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
                this.usersBindingSource.RemoveCurrent();
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
                this.usersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.autodbDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}
