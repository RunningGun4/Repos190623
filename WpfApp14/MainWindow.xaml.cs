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

namespace WpfApp14
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
        private void knopka(object sender, RoutedEventArgs e)
        {
            if(parol.Password == parol2.Password)
            {
                MessageBox.Show("Харош, регнулся, давай оформимся");
            }
            else
            {
                MessageBox.Show("Ошибка,пароли не совподают ну ты и вторячок слюнявчик");
            }
            
        }
    }
}
