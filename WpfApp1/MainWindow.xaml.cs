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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Button myButton = new Button();
            myButton.Width = 200;
            myButton.Height = 30;
            myButton.Content = "Кнопка";
            grid1.Children.Add(myButton);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string text = textBox1.Text;
            if (text != "") MessageBox.Show(text);
        }
    }
}
