using _21._106_10_Restoran.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для WindowOrder.xaml
    /// </summary>
    public partial class WindowOrder : Window
    {
        Entities db = GetContext.GetCnt();
        public WindowOrder()
        {
            InitializeComponent();
            var querry = db.Order;
            dtg_orders.ItemsSource = querry.ToList();
        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {
            Order selectedItem = dtg_orders.SelectedItem as Order;
            if (selectedItem == null)
            {
                MessageBox.Show("Выберите заказ!");
            }
            else if (MessageBox.Show("Вы действительно хотите удалить заказ?", "Предупреждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                DbSet<Order> items = db.Order;
                items.Remove(selectedItem);
                db.SaveChanges();
                refresh();
                
            }
        }
        public void refresh()
        {
            InitializeComponent();
            var querry = db.Order;
            dtg_orders.ItemsSource = querry.ToList();
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            AddOrder ordersWindow = new AddOrder();
            ordersWindow.Show();
            refresh();
        }

        private void btn_red_Click(object sender, RoutedEventArgs e)
        {
            Order selectedItem = dtg_orders.SelectedItem as Order;

            if (selectedItem == null)
            {
                MessageBox.Show("Выберите заказ!");
            }
            else if (MessageBox.Show("Вы действительно хотите изменить заказ?", "Предупреждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                try
                {
                    db.Entry(selectedItem).State = EntityState.Modified;
                    db.SaveChanges();
                    refresh();
                }
                catch
                {
                    MessageBox.Show("Введены некорректные данные!");
                }
            }
        }

        private void btn_back(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}


