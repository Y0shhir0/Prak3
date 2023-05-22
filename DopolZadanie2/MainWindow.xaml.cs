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

namespace DopolZadanie2
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
            string Opisanie;
            if (a >= 1 && a <= 9)
            {
                Opisanie = "однозначное число";
            }
            else if (a >= 10 && a <= 99)
            {
                if (a % 2 == 0)

                {
                    Opisanie = "четное двухзначное ";
                }
                else
                {
                    Opisanie = "нечетное двухзначное ";
                }
            }
            else if (a >= 100 && a <= 999)
            {
                if (a % 2 == 0)

                {
                    Opisanie = "четное трехзначное ";
                }
                else
                {
                    Opisanie = "нечетное трехзначное ";
                }
            }
            else
            {
                Opisanie = "Число не входит в диапазон от 1 до 999";
            }
            Otvet.Text = (Opisanie); 

        }
    }
}
