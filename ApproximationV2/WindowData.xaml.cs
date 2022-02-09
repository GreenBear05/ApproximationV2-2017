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

namespace ApproximationV2
{
    /// <summary>
    /// Логика взаимодействия для WindowData.xaml
    /// </summary>
    public partial class WindowData : Window
    {
        public WindowData()
        {
            
            InitializeComponent();
            labelData.Content = Mathematics.Matdata();
        }

        private void ButtonGraf_Click(object sender, RoutedEventArgs e)
        {
            
            FormGraf _form = new FormGraf();
            this.Hide();
            _form.ShowDialog();
            this.Show();
        }
    }
}
