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
    /// Логика взаимодействия для Postuplenie.xaml
    /// </summary>
    public partial class Postuplenie : Window
    {
        public Postuplenie()
        {
            InitializeComponent();
        }

        private void NewPostupButton_Click(object sender, RoutedEventArgs e)
        {
            NewPostup newPostup = new NewPostup();
            newPostup.Show();
            this.Close();
        }
    }
}
