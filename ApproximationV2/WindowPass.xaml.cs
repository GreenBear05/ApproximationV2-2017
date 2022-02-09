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
    /// Логика взаимодействия для WindowPass.xaml
    /// </summary>
    public partial class WindowPass : Window
    {
        private string pass = "050595";
        public WindowPass()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password == pass)
            {
                MainWindow _form = new MainWindow();
                this.Hide();
                _form.ShowDialog();
                this.Show();
                passwordBox.Password = "";
            }
            else
            {
                MessageBox.Show("Пароль введен неверно", "Ошибка !", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ButtonInfo_Click(object sender, RoutedEventArgs e)
        {
            string info = "Информация: продукт сдалан \n студентом  Медведев Сергей Михайлович \n группы ИС3 161 ОБЗ";
            MessageBox.Show(info, "Информация о программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
