using System.Windows;
using System.Windows.Media;

namespace Resources
{
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        private void ChangeColor(object sender, RoutedEventArgs e)
        {
            if (FindResource("defaultBackgroundColor") is SolidColorBrush brush)
                brush.Color = Colors.DarkOliveGreen;
        }

        private void ChangeInstance(object sender, RoutedEventArgs e) => Resources["defaultBackgroundColor"] = new SolidColorBrush(Colors.Indigo);

        private void ChangeType(object sender, RoutedEventArgs e) => Resources["defaultBackgroundColor"] = new RadialGradientBrush(
            Colors.YellowGreen,
            Colors.Blue);
    }
}
