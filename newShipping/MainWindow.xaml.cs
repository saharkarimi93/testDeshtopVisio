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

namespace newShipping
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
            double weight = Convert.ToDouble(num1.Text);
            double mile = Convert.ToDouble(num2.Text);


            double twoKg = 1.10;
            double overTwoKg = 2.20;
            double overSixKg = 3.70;
            double overTenKg = 4.80;


            if (weight <= 2)
            {
                if (mile <= 500)
                {
                    result.Text = Convert.ToString(twoKg) + "$";

                }
                else
                {
                    result.Text =  Convert.ToString(overTwoKg) + "$";

                }
            }
            else if (weight > 2 && weight <= 6)
            {
                if (mile <= 500)
                {
                    result.Text = Convert.ToString(overTwoKg) + "$";

                }
                else
                {
                    result.Text =  Convert.ToString(overSixKg) + "$";

                }
            }
            else if (weight > 6 && weight <= 10)
            {
                if (mile <= 500)
                {
                    result.Text = Convert.ToString(overSixKg) + "$";

                }
                else
                {
                    result.Text = Convert.ToString(overTenKg) + "$";

                }
            }
            else
            {
                result.Text = Convert.ToString(overTenKg) + "%$";

            }
        }
    }
}
