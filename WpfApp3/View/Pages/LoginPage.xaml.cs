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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp3.Database;
using WpfApp3.View.Windows;

namespace WpfApp3.View.Pages
{
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegPage());
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var currentUser = ConnectOdb.db.users.FirstOrDefault(u => u.username == txbLogin.Text && u.password == txbPass.Text);
            if (currentUser != null)
            {
                MessageBox.Show("Авторизация прошла успешно!");
                MainWindow.Frame.Navigate(new ProductsPage());
            }
            else
            {
                MessageBox.Show("Введите логин и пароль!");
            }
        }
    }
}
