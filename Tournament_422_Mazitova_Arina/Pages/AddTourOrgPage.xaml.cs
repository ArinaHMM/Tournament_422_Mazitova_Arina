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

namespace Tournament_422_Mazitova_Arina.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddTourOrgPage.xaml
    /// </summary>
    public partial class AddTourOrgPage : Page
    {
        public AddTourOrgPage()
        {
            InitializeComponent();
            TourDG.ItemsSource = App.db.Tournament.ToList();
            TourDG.DataContext = App.db.Tournament.ToList();
        }
                private void RegTourBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new NewTourPage());
        }
                private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            TourDG.ItemsSource = App.db.Tournament.ToList();
        }
                private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new WelcomePage());
        }

        private void Page_Loaded_1(object sender, RoutedEventArgs e)
        {
            TourDG.ItemsSource = App.db.Tournament.ToList();
            TourDG.DataContext = App.db.Tournament.ToList();
        }

        private void RequestBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationTeamOnTournament());
        }
    }
}
