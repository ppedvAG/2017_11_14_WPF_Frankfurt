
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace RoutedEventsExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ObservableCollection<LogItem> logItems;

        public MainWindow()
        {
            InitializeComponent();

            logItems = new ObservableCollection<LogItem>();
            EventsDataGrid.ItemsSource = logItems;
        }

        private void PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var element = sender as FrameworkElement;

            if(element == BlueRectangle)
            {
                e.Handled = true;
            }

            logItems.Add(new LogItem { EventName = "PreviewMouseDown", Sender = element?.Name });
        }

        private void MouseDown(object sender, MouseButtonEventArgs e)
        {
            var element = sender as FrameworkElement;
            logItems.Add(new LogItem { EventName = "MouseDown", Sender = element?.Name });
        }

        private void MouseUp(object sender, MouseButtonEventArgs e)
        {
            var element = sender as FrameworkElement;
            logItems.Add(new LogItem { EventName = "MouseUp", Sender = element?.Name });
        }

        private void PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            var element = sender as FrameworkElement;
            logItems.Add(new LogItem { EventName = "PreviewMouseUp", Sender = element?.Name });
        }
    }
}
