using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowForm(new CarsForm());
        }


        public void ShowForm(Form form)
        {
            MainPanel.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = true;
            form.WindowState = FormWindowState.Maximized;
            MainPanel.Controls.Add(form);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e) // Характеристики
        {
            ShowForm(new CarCharacteristicsForm());
        }

        private void button2_Click(object sender, EventArgs e) // Машины
        {
            ShowForm(new CarsForm());
        }

        private void button3_Click(object sender, EventArgs e) // Клиенты
        {
            ShowForm(new ClientsForm());
        }

        private void button4_Click(object sender, EventArgs e) // Пользователи
        {
            ShowForm(new UsersForm());
        }

        private void button5_Click(object sender, EventArgs e) // Аренды
        {
            ShowForm(new RentListsForm());
        }

        private void Отчет_Click(object sender, EventArgs e)
        {
            ShowForm(new ReportForm());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start(Directory.GetCurrentDirectory() + @"\Spravka.chm");
        }
    }
}
