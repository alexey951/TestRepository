using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.EntitySql;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp3.Database;

namespace WpfApp3.View.Pages
{
    public partial class AddPage : Page
    {
        public AddPage()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack(); 
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string title = txbTitle.Text.Trim();
            string price = txbPrice.Text.Trim();

            if (title.Length > 0 && price.Length > 0)
            {
                int result = Int32.Parse(price);
                products products = new products();
                products.title = title;
                products.price = result;

                ConnectOdb.db.products.Add(products);
                ConnectOdb.db.SaveChanges();
                MessageBox.Show("Элемент успешно добавлен!");
                NavigationService.GoBack();
            } 
            else
            {
                MessageBox.Show("Введите данные!");
            }
        }
    }
}
