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

namespace Prak3
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
            int sum = (B / 10) + (B % 10);
            if (sum % A == 0)
            {
                Otvet.Text = $"Сумма цифр числа {B}\n кратна числу {A}";
            }
            else
            {
                Otvet.Text = $"Сумма цифр числа{B}\n не кратна числу {A}";
            }
        }
    }
}
