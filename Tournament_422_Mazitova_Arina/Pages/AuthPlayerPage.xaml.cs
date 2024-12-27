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
using Tournament_422_Mazitova_Arina.Databases;

namespace Tournament_422_Mazitova_Arina.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPlayerPage.xaml
    /// </summary>
    public partial class AuthPlayerPage : Page
    {
        public AuthPlayerPage()
        {
            InitializeComponent();
        }
        private void AuthBtn_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTb.Text.Trim();
            string password = PasswordTb.Text.Trim();
            Player user = App.db.Player.FirstOrDefault(x => x.Login == login && x.Password == password);

            if (App.db.Player.FirstOrDefault(x => x.Login == login && x.Password == password) != null)
            {
                MessageBox.Show("Добро пожаловать!");
                NavigationService.Navigate(new WelcomePage());
                
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }
        }
    }
}
