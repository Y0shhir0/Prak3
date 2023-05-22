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

namespace Zadanie4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            int A = Convert.ToInt32(Vvod.Text);
            int B = Convert.ToInt32(Vod.Text);
            int C = Convert.ToInt32(Vvd.Text);

            int m = (A + B * B) / C;
            int k = m % 3;
            double result;
            if (k == 1)
            {
                result = Math.Exp(m) + C;
            }
            else if (k == 0)
            {
                result = Math.Log((double)A / B);
            }
            else
            {
                result = Math.Sqrt(A + B * B) + C;
            }
            Otvet.Text = $"Результат:{result:f2}";            
        }
    }
}
