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

namespace AUHTPS_Coursework_WPF
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            mainTank.Minimum = 0;
            mainTank.Maximum = 100;
            mainTank.Value = 50;

            sliderForMainTank.Minimum = 0;
            sliderForMainTank.Maximum = 100;
            sliderForMainTank.Value = mainTank.Value;
        }
    }
}
