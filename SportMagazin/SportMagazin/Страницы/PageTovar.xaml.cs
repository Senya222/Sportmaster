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

namespace SportMagazin.Страницы
{
    /// <summary>
    /// Логика взаимодействия для PageTovar.xaml
    /// </summary>
    public partial class PageTovar : Page
    {
        MainWindow mainWindow;
        public List<Tovar> tovars;
        public List<Tovar> zakaz = new List<Tovar>();
        public PageTovar(MainWindow main)
        {
            InitializeComponent();
            mainWindow = main;
            tovars = DataBase.GetContext().Tovar.ToList();
            lbTovar.ItemsSource = tovars;
        }

        private void btDobavlenieVZakaz_Click(object sender, RoutedEventArgs e)
        {
            var tovar = (sender as Button).DataContext as Tovar;
            zakaz.Add(tovar);
            if(zakaz.Count != 0)
            {
                btZakaz.Visibility = Visibility.Visible;
            }

        }

        private void btZakaz_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Container.Navigate(new PageZakaz(mainWindow, zakaz));
        }
    }
}
