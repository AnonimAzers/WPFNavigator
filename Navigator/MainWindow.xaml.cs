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

namespace Navigator
{

    public partial class MainWindow : Window // Главный класс
    {
        public NavigatorClass navigator;
        public MainWindow()
        {
            InitializeComponent();

            navigator = new NavigatorClass(new CarNavigationStrategy()); // Создание объекта класса навигатора
            new EventHandler(this); // Создание объекта класса обработки событий

        }
    }
}
