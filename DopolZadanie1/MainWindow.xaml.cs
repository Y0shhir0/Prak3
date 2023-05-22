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

namespace DopolZadanie1
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
            int a = Convert.ToInt16(Vvd.Text);
            if (a<0)
            {
                if(a%2==0)
                {
                    Otvet.Text = $"Отрицательное четное число ";
                }
                else
                {
                    Otvet.Text = $"Отрицательное нечетное число ";
                }
            }
            else
            {
                if(a%2==0)
                {
                    Otvet.Text = $"Положительное четное число ";
                }
                else
                {
                    Otvet.Text = $"Положительное нечетное число ";
                }
            }
        }      
    }
}
