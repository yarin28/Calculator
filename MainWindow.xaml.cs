using System;
using System.Collections.Generic;
using System.Data;
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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        String expresion = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            expresion += btn.Content;
            tb.Text = expresion;
        }
        private void sum(object sender, RoutedEventArgs e)
        {
            expresion += "+";
            tb.Text = expresion;

        }
        private void sub(object sender, RoutedEventArgs e)
        {
            expresion += "-";
            tb.Text = expresion;
        }
        private void mul(object sender, RoutedEventArgs e)
        {
            expresion += "*";
            tb.Text = expresion;
        }
        private void div(object sender, RoutedEventArgs e)
        {
            expresion += "/";
            tb.Text = expresion;
        }
        private void clear(object sender, RoutedEventArgs e)
        {
            expresion = "";
            tb.Text = expresion;
        }
        private void EqualButtonClick(object sender, RoutedEventArgs e)
        {
            try
            {
                expresion = new DataTable().Compute(expresion, null).ToString();
                
            }
            catch (Exception ex)
            {
                expresion = ex.Message;
            }
            finally
            {
                tb.Text = expresion;
            }
        }
        //    private void AddHistory(double num1, double num2, double answer,String op)
        //    {
        //        Label label = new Label();
        //        label.Height = 100;
        //        label.Width = 100;
        //        label.HorizontalAlignment = HorizontalAlignment.Left;
        //        label.VerticalAlignment = VerticalAlignment.Top;
        //        label.Content = $"{ num1}\n+\n {num2}\n--------\n{answer}";
        //        History.Children.Add(label);
        //    }
    }
}
