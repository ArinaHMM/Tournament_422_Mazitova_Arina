using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Tournament_422_Mazitova_Arina.Databases;

namespace Tournament_422_Mazitova_Arina
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static TournamentDB_422_Mazitova_ArinaEntities db = new TournamentDB_422_Mazitova_ArinaEntities();
    }
}
