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

namespace newBank
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double totalChecks = Convert.ToDouble(checks.Text);
            double totalBalance = Convert.ToDouble(balance.Text);

            if (totalBalance < 400)
            {
                totalBalance -= 15;
            }
            double fee;
            if (totalChecks < 20)
            {
                fee = 0.1;
            }
            else if (totalChecks >= 20 && totalChecks <= 39)
            {
                fee = 0.08;
            }
            else if (totalChecks >= 40 && totalChecks <= 59)
            {
                fee = 0.06;
            }
            else
            {
                fee = 0.04;
            }

            
            totalBalance -= fee;
            result.Text = Convert.ToString(totalBalance) + "$";
        }
    }
    
}
