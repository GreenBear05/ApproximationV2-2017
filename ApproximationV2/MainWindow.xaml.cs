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
using System.IO;



namespace ApproximationV2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private string 
        /// <summary>
        /// вход в форму програмыы
        /// </summary>
        public static List<DotInfo> Points = new List<DotInfo>();
        public MainWindow()
        {

            //List<Point> Points = new List<Point>();
            Points.Add(new DotInfo(-0.1f, 0.2f));
            Points.Add(new DotInfo(-0.9f, 0.4f));
            Points.Add(new DotInfo(-0.3f, 0.6f));
            Points.Add(new DotInfo(-0.6f, 0.9f));





            

            InitializeComponent();
            Mathematics _mat = new Mathematics(Points);
            FormGraf f = new FormGraf(Points);
            ListBox_Points.ItemsSource = Points;
            this.ListBox_Points.DataContext = this;
        }

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            // конфигурации сохранения

            Microsoft.Win32.SaveFileDialog _saveFileDialog = new Microsoft.Win32.SaveFileDialog();
            _saveFileDialog.FileName = "Document"; // название документа
            _saveFileDialog.DefaultExt = ".text"; // расширение документа
            _saveFileDialog.Filter = "Text documents (.txt)|*.txt"; // Фильтрация файлов по расширению 


            // Показать диалоге сохранения файла окно
            Nullable<bool> result = _saveFileDialog.ShowDialog();


            StreamWriter streamWriter = new StreamWriter(_saveFileDialog.FileName);
            foreach (var item in Points)
            {
                streamWriter.Write("координата Х " + item.X);
                streamWriter.WriteLine(" координата Y " + item.Y);
            }
            streamWriter.Close();

            WindowData _form = new WindowData();
            this.Hide();
            _form.ShowDialog();
            this.Show();





        }
        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            DotInfo dot = (DotInfo)((Button)sender).Tag;
            Points.Insert(Points.IndexOf(dot), new DotInfo(dot));
            ListBox_Points.ItemsSource = null;
            ListBox_Points.ItemsSource = Points;
            ListBox_Points.UpdateLayout();
        }
        private void buttonRemove_Click(object sender, RoutedEventArgs e)
        {
            if (Points.Count > 2)
            {
                DotInfo dot = (DotInfo)((Button)sender).Tag;

                Points.Remove(dot);
                ListBox_Points.ItemsSource = null;
                ListBox_Points.ItemsSource = Points;
                ListBox_Points.UpdateLayout();
            }
        }
   
    }
}
