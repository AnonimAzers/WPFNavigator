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
    class EventHandler
    {
        private MainWindow _window;

        public EventHandler(MainWindow window)
        {
            _window = window;
            _window.MainRoot.MouseDown += WindowMouseDown_Event;

            var buttons = GetButtons(_window.TopRoot.Children);
            foreach (Button button in buttons)
            {
                button.Click += ButtonClick_Event;
            }
        }

        private IEnumerable<Button> GetButtons(UIElementCollection children)
        {
            return children.OfType<Button>();
        }

        private void ButtonClick_Event(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            string buttonName = clickedButton.Name;

            // Определяем стратегию навигации в зависимости от имени кнопки
            INavigationStrategy navigationStrategy = null;
            switch (buttonName)
            {
                case "car_button":
                    navigationStrategy = new CarNavigationStrategy();
                    break;
                case "bicycle_button":
                    navigationStrategy = new BicycleNavigationStrategy();
                    break;
                case "train_button":
                    navigationStrategy = new TrainNavigationStrategy();
                    break;
                case "walker_button":
                    navigationStrategy = new WalkNavigationStrategy();
                    break;
                default:
                    break;
            }

            // Если стратегия навигации была определена, используем ее
            if (navigationStrategy != null)
            {
                _window.navigator.SetNavigationStrategy(navigationStrategy);
                _window.navigator.Navigate();
            }
        }

        private void WindowMouseDown_Event(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                _window.DragMove();
            }
        }
    }

}
