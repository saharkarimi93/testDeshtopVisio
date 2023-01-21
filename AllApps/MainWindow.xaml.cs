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

namespace AllApps
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            TestScores testScores= new TestScores();
            testScores.Show();
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            Shipping shipping = new Shipping();
            shipping.Show();

        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            Distance distance = new Distance();
            distance.Show();
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            Bank bank = new Bank();
            bank.Show();
        }
    }
}
