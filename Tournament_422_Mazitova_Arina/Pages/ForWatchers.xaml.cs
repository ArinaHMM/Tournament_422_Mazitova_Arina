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
    /// Логика взаимодействия для ForWatchers.xaml
    /// </summary>
    public partial class ForWatchers : Page
    {
        public ForWatchers()
        {
            InitializeComponent();
            TourDG.ItemsSource = App.db.Tournament.ToList();
            TourDG.DataContext = App.db.Tournament.ToList();
            Refresh();
        }


        private void RegTourBtn_Click(object sender, RoutedEventArgs e)
        {

            Tournament selectedTournament = (Tournament)TourDG.SelectedItem;

            if (selectedTournament != null)
            {
                if (selectedTournament.Status_Tour == "В процессе" || selectedTournament.Status_Tour == "Завершен")
                {
                    MessageBox.Show("Турнир закончен или уже начался, выберите другой!");
                }
                else
                {
                    NavigationService.Navigate(new TourRegPage(selectedTournament));
                }
            }

            else
            {
                MessageBox.Show("Пожалуйста, выберите турнир перед регистрацией.");
            }
        }

        private void SortCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }
        private void Refresh()
        {
            IEnumerable<Tournament> tour = App.db.Tournament;
            if (FilterCb.SelectedIndex == 0)
            {
                tour = tour.Where(x => x.Status_Tour == "В процессе");
            }
            if (FilterCb.SelectedIndex == 1)
            {
                tour = tour.Where(x => x.Status_Tour == "Завершен");
            }
            if (FilterCb.SelectedIndex == 2)
            {
                tour = tour.Where(x => x.Status_Tour == "Предстоит");
            }
            if (FilterCb.SelectedIndex == 3)
            {
                tour = tour.Where(x => x.Status_Tour == "Предстоит" || x.Status_Tour == "Завершен" || x.Status_Tour == "Предстоит");
            }

            if (SearchTb.Text != null)
            {
                tour = tour.Where(x => x.Game.Name.Contains(SearchTb.Text));
            }
            TourDG.ItemsSource = tour.ToList();
        }

        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new WelcomePage());
        }
    }
}