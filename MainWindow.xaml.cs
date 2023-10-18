using Pract5;
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
                if (n > 10 && m > 10)
                    MessageBox.Show("Размер исходных массивов не должен превосходить 10х10 элементов");
                else
                {
                    matr2 = new int[n, m];
                    dataGrib2.ItemsSource = VisualArray.ToDataTable(matr2).DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Fill1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int min = int.Parse(min1.Text);
                int max = int.Parse(max1.Text);
                Random rnd = new Random();

                Pract5Funcs.FillArr(ref matr1, min, max);

                dataGrib1.ItemsSource = null;
                dataGrib1.ItemsSource = VisualArray.ToDataTable(matr1).DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Fill2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int min = int.Parse(min2.Text);
                int max = int.Parse(max2.Text);
                Random rnd = new Random();

                Pract5Funcs.FillArr(ref matr2, min, max);

                dataGrib2.ItemsSource = null;
                dataGrib2.ItemsSource = VisualArray.ToDataTable(matr2).DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetResult_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                List<int> result1 = Pract5Funcs.GetNegativesMult(matr1);
                List<int> result2 = Pract5Funcs.GetNegativesMult(matr2);
                if (result1.Count == 0 && result2.Count == 0)
                    MessageBox.Show("столбцов, произведение отрицательных " +
                        "элементов которых является положительным числом, " +
                        "нет ни для одного из массивов");
                else
                {
                    string res1 = string.Join(", ", result1);
                    string res2 = string.Join(", ", result2);
                    res1_tb.Text = res1;
                    res2_tb.Text = res2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGrib1_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            try
            {
                int colId = e.Column.DisplayIndex;
                int rowId = e.Row.GetIndex();
                matr1[colId, rowId] = int.Parse(((TextBox)e.EditingElement).Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGrib2_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            try
            {
                int colId = e.Column.DisplayIndex;
                int rowId = e.Row.GetIndex();
                matr2[colId, rowId] = int.Parse(((TextBox)e.EditingElement).Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
