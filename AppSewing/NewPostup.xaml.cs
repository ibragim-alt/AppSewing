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
    /// Логика взаимодействия для NewPostup.xaml
    /// </summary>
    public partial class NewPostup : Window
    {
        public NewPostup()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddMaterial addMaterial = new AddMaterial();
            addMaterial.Show();
            this.Close();
        }
    }
}
