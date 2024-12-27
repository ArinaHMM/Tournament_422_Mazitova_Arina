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
    /// Логика взаимодействия для RegistrationTeamOnTournament.xaml
    /// </summary>
    public partial class RegistrationTeamOnTournament : Page
    {
        public Registration registration;
        public RegistrationTeamOnTournament()
        {
            InitializeComponent();
            StatusDG.ItemsSource = App.db.Registration.ToList();
            StatusDG.DataContext = App.db.Registration.ToList();
            //Refresh();
        }

        private void EditStatusBtn_Click(object sender, RoutedEventArgs e)
        {
            Registration selectedRegistration = (Registration)StatusDG.SelectedItem;
            {
                if(selectedRegistration != null)
                {
                    NavigationService.Navigate(new NewStatusTournear(StatusDG.SelectedItem as Registration));
                }
            }
            }
        }
    }

