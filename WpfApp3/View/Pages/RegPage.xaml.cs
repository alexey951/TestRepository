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

namespace WpfApp3.View.Pages
{
    public partial class RegPage : Page
    {
        public RegPage()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            string email = txbEmail.Text.Trim();
            string username = txbLogin.Text.Trim();
            string password = txbPass.Text.Trim();

            if (email.Length > 0 && username.Length > 0 && password.Length > 0)
            {
                users users = new users();

                users.email = email;
                users.username = username;
                users.password = password;
                users.roleId = 2;

                ConnectOdb.db.users.Add(users);
                ConnectOdb.db.SaveChanges();
                MessageBox.Show("Регистрация прошла успешно!", "Уведомление");
                NavigationService.GoBack();
            }
        }
    }
}
