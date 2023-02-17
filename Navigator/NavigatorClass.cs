using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Navigator
{
    public interface INavigationStrategy
    {
        void Navigate();
    }

    public class CarNavigationStrategy : INavigationStrategy
    {
        public void Navigate()
        {
            MessageBox.Show("Navigating by car");
        }
    }

    public class TrainNavigationStrategy : INavigationStrategy
    {
        public void Navigate()
        {
            MessageBox.Show("Navigating by train");
        }
    }

    public class BicycleNavigationStrategy : INavigationStrategy
    {
        public void Navigate()
        {
            MessageBox.Show("Navigating by bicycle");
        }
    }

    public class WalkNavigationStrategy : INavigationStrategy
    {
        public void Navigate()
        {
            MessageBox.Show("Navigating by walking");
        }
    }

    public class NavigatorClass
    {
        private INavigationStrategy _navigationStrategy;

        public NavigatorClass(INavigationStrategy navigationStrategy)
        {
            _navigationStrategy = navigationStrategy;
        }

        public void SetNavigationStrategy(INavigationStrategy navigationStrategy)
        {
            _navigationStrategy = navigationStrategy;
        }

        public void Navigate()
        {
            _navigationStrategy.Navigate();
        }
    }

}
