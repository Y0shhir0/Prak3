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

namespace Zadanie5
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
            double y = Convert.ToDouble(Vod.Text);
            double x = Convert.ToDouble(Vvd.Text);
         

                if (Math.Abs(x) <= 40 && Math.Abs(y) <= 40)                    
                {
                    Otvet.Text = $"На границе ";
                }
                 else if (Math.Abs(x) == 40 && Math.Abs(y) == 40)
                {
                    Otvet.Text = $"Да ";
                }    
                 else    
                {
                    Otvet.Text = $"Нет ";
                }
            
        } 
    }
}
