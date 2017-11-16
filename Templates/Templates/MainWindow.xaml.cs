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

namespace Templates
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var people = new List<Person>
            {
                new Person
                {
                    Id = 3256,
                    Firstname = "Stanislaus",
                    Lastname = "Maier"
                },
                new Customer
                {
                    Id = 235,
                    Firstname = "Lisa",
                    Lastname = "Huber",
                    CountOrders = 4
                },
                new Employee
                {
                    Id = 7654,
                    Firstname = "Max",
                    Lastname = "Mustermann",
                    Salary = 23000
                }
            };
            presenter.ItemsSource = people;
        }

        private void Button_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Button was Clicked.");
    }
}
