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
    /// Логика взаимодействия для NewStatusTournear.xaml
    /// </summary>
    public partial class NewStatusTournear : Page
    {
        Registration registration;
        public NewStatusTournear(Registration _registration)
        {
            InitializeComponent();
            DataContext = _registration;
            registration = _registration;
            edistatuscb.ItemsSource = App.db.StatusReg.ToList();
            edistatuscb.DisplayMemberPath = "Name";

        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            if (registration.ID_Status_Registration >= 0)
                App.db.Registration.Add(registration);
            App.db.SaveChanges();
            MessageBox.Show("Готово");

            NavigationService.GoBack();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
