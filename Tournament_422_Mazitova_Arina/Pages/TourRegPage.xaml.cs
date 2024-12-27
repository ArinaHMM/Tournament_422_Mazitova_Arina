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
    /// Логика взаимодействия для TourRegPage.xaml
    /// </summary>
    public partial class TourRegPage : Page
    {
        Tournament tournament;
        public TourRegPage(Tournament _tournament)
        {
            InitializeComponent();
            DataContext = _tournament;
            tournament = _tournament;
            TourTb.Text = tournament.Name;
        }

        private void RegisterBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               
                int teamId;
                if (!int.TryParse(IdTeamTb.Text, out teamId))
                {
                    MessageBox.Show("Пожалуйста, введите корректный номер команды.");
                    return;
                }

               
                Registration newRegistration = new Registration
                {
                    ID_Tournament = tournament.ID, 
                    ID_Team = teamId,      
                    ID_Status_Registration = 1      
                };

                App.db.Registration.Add(newRegistration);
                App.db.SaveChanges(); 

                MessageBox.Show("Регистрация успешно завершена!");

                NavigationService.GoBack(); 
            }
            catch (Exception ex)
            {
                  
                MessageBox.Show($"Произошла ошибка при регистрации: {ex.Message}");
            }
        }
    }
}
