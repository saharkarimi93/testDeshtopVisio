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
using System.Windows.Shapes;

namespace AllApps
{
    /// <summary>
    /// Interaction logic for Distance.xaml
    /// </summary>
    public partial class Distance : Window
    {
        public Distance()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double speed = Convert.ToDouble(spd.Text);
            double hour = Convert.ToDouble(hours.Text);

            double distance = 0;
            distance = speed * hour;

            result.Text = Convert.ToString(distance);
        }
    }
}
