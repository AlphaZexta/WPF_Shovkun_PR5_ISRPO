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

namespace WPF_Shovkun_PR5_ISRPO
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void D1_Click(object sender, RoutedEventArgs e)
        {
            if (I1.Visibility == Visibility.Hidden)
            {
                I1.Visibility = Visibility.Visible;
            }
        }

        private void D2_Click(object sender, RoutedEventArgs e)
        {
            if (I2.Visibility == Visibility.Hidden)
            {
                I2.Visibility = Visibility.Visible;
            }
        }

        private void D3_Click(object sender, RoutedEventArgs e)
        {
            if(I3.Visibility == Visibility.Hidden)
            {
                I3.Visibility = Visibility.Visible;
            }
        }
    }
}
