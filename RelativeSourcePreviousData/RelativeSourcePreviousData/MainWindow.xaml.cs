using System.Collections.Generic;
using System.Windows;

namespace RelativeSourcePreviousData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dataView.ItemsSource = GetData();
        }

        private IEnumerable<Messwert> GetData() => new List<Messwert>
        {
            new Messwert { Value = 40 },
            new Messwert { Value = 70 },
            new Messwert { Value = 54 },
            new Messwert { Value = 45 },
            new Messwert { Value = 240 },
            new Messwert { Value = 80 },
            new Messwert { Value = 74 },
            new Messwert { Value = 160 },
            new Messwert { Value = 38 },
            new Messwert { Value = 0 },
            new Messwert { Value = 27 }
        };
    }
}
