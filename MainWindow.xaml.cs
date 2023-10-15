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

namespace Prakt10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int[,] matr1;
        private void Create1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = int.Parse(n1.Text);
                int m = int.Parse(m1.Text);
                matr1 = new int[n, m];
                dataGrib1.ItemsSource = VisualArray.ToDataTable(matr1).DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int[,] matr2;
        private void Create2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = int.Parse(n2.Text);
                int m = int.Parse(m2.Text);
                matr2 = new int[n, m];
                dataGrib2.ItemsSource = VisualArray.ToDataTable(matr2).DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
