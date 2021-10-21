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

namespace AppSewing
{
    /// <summary>
    /// Логика взаимодействия для Kladov.xaml
    /// </summary>
    public partial class Kladov : Window
    {
        public Kladov()
        {
            InitializeComponent();
        }

        private void SpisokButton_Click(object sender, RoutedEventArgs e)
        {
            Spisokcloth spisokcloth = new Spisokcloth();
            spisokcloth.Show();
            this.Close();
        }

        private void PostupButton_Click(object sender, RoutedEventArgs e)
        {
            Postuplenie postuplenie = new Postuplenie();
            postuplenie.Show();
            this.Close();
        }
    }
}
