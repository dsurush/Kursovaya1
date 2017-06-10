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

namespace BSS
{
    /// <summary>
    /// Логика взаимодействия для RedactorPage.xaml
    /// </summary>
    public partial class RedactorPage : Page
    {
        public RedactorPage()
        {
            InitializeComponent();
        }
        private void user_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Pages.StudentsPage);
        }

        private void teacher_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Pages.TeachersPage);
        }

        private void logout_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Pages.StartPage);
        }

        private void redactor_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Pages.RedactorPage);
        }
    }
}
