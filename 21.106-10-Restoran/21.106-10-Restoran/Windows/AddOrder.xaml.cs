using _21._106_10_Restoran.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _21._106_10_Restoran.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddOrder.xaml
    /// </summary>
    public partial class AddOrder : Window
    {
        Entities db = GetContext.GetCnt();
        public AddOrder()
        {
            InitializeComponent();
        }

        private void btn_config_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime date_start = DateTime.Parse(tb_time_start.Text.ToString());
                DateTime date_finish = DateTime.Parse(tb_time_finish.Text.ToString());
                Order newOrder = new Order();
                newOrder.TimeOfOrder = date_start;
                newOrder.EndTime = date_finish;
                newOrder.IdEmployee = int.Parse(tb_Employee.Text);
                newOrder.IdTable = int.Parse(tb_Table.Text);
                Create(newOrder);
                MessageBox.Show("Сохранение успешно!");
                Close();

            }
            catch
            {
                MessageBox.Show("Введены некорректные данные!");
            }
        }
        public void Create(Order orders)
        {
            db.Order.Add(orders);
            db.SaveChanges();
        }


        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
