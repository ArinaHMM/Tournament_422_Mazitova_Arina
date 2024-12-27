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
    /// Логика взаимодействия для NewTourPage.xaml
    /// </summary>
    public partial class NewTourPage : Page
    {
        public NewTourPage()
        {
            InitializeComponent();
            GameComboBox.ItemsSource = App.db.Game.ToList();
            GameComboBox.DisplayMemberPath = "Name";
            FormatComboBox.ItemsSource = App.db.Format.ToList();
            FormatComboBox.DisplayMemberPath = "Name";
            CategoryComboBox.ItemsSource = App.db.Category.ToList();
            CategoryComboBox.DisplayMemberPath = "Name";
            

        }

        private void CreateBtn_Click(object sender, RoutedEventArgs e)
        {
            Tournament tournament = new Tournament()
            {
                Name = NameTextBox.Text,
                Date = DatePicker.SelectedDate,
                ID_Game = (GameComboBox.SelectedItem as Game).ID,
                ID_Format = (FormatComboBox.SelectedItem as Format).ID,
                Players_Count = int.Parse(PlayersCountTextBox.Text),
                Prize = int.Parse(PrizeTextBox.Text),
                Minimum_rank = int.Parse(MinRangeTextBox.Text),
                Forbidden_things = BanComboBox.Text,
                //ID_Org = .ID,
                ID_Category = (CategoryComboBox.SelectedItem as Category).ID,
                Regional_restrictions = RegionTextBox.Text,
                Status_Tour = "Предстоит",

            };
            App.db.Tournament.Add(tournament);
            App.db.SaveChanges();
            MessageBox.Show("Турнир сохранен");

            NavigationService.GoBack();

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
