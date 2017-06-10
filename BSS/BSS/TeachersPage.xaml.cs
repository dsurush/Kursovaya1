using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace BSS
{
    /// <summary>
    /// Логика взаимодействия для TeachersPage.xaml
    /// </summary>
    public partial class TeachersPage : Page
    {
        public TeachersPage()
        {
            InitializeComponent();
            textBox.Focus();
        }
        private void user_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Pages.StudentsPage);
        }

        private void teacher_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Pages.TeachersPage);
        }
        /// Хэширование для защиты 
        private string CalculateHash(string password)
        {
            MD5 md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.ASCII.GetBytes(password));
            return Convert.ToBase64String(hash);
        } 

        private void login_Click(object sender, RoutedEventArgs e)
        {
            var hash = CalculateHash("admin");

            if (textBox.Text == "admin" && CalculateHash(passwordBox.Password) == hash)
                NavigationService.Navigate(Pages.SystemPage);
            else
                MessageBox.Show("Неправильный логин / пароль");
        }
        private void Page_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            // Using keyboard handling on the page level
            if (e.Key == Key.Enter)
                login_Click(null, null);
        }
    }
}
