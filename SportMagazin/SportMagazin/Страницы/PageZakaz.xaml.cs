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
    /// Логика взаимодействия для PageZakaz.xaml
    /// </summary>
    public partial class PageZakaz : Page
    {
        MainWindow mainWindow;
        public PageZakaz(MainWindow main, List<Tovar> tovars)
        {
            InitializeComponent();
            mainWindow = main;
            lbTovar.ItemsSource = tovars;
        }
        /// <summary>
        /// Функционал кнопки "Назад"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNazad_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Container.Navigate(new PageTovar(mainWindow));
        }
        /// <summary>
        /// Функционал кнопки "Сохранить"
        /// </summary>
        /// <param name="sender">парметр</param>
        /// <param name="e">параметр</param>
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Заказ успешно добавлен!");
            mainWindow.Container.Navigate(new PageTovar(mainWindow));
        }
    }
}
