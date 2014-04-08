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
using System.Reflection;
using System.Dynamic;
using System.Collections.ObjectModel;

namespace MatPassword
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            var mat = new MatMaker();
            lstMat.ItemsSource = mat.VMS;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var mat = new MatMaker();
            lstMat.ItemsSource = mat.VMS;
        }
    }
}
