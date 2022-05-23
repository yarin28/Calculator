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

namespace Calculator
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

    private void sum(object sender,RoutedEventArgs e)
        {
            double num1 = double.Parse(num1box.Text);
            double num2 = double.Parse(num2box.Text);
            double answer = num1 + num2;
            ans.Content = answer;

            AddHistory(num1, num2, answer,"+");

        }

     

        private void sub(object sender,RoutedEventArgs e)
    {
            double num1 = double.Parse( num1box.Text);
            double num2 = double.Parse( num2box.Text);
            double answer = num1 - num2;
            ans.Content = answer;
            AddHistory(num1, num2, answer,"-");

        }
        private void mul(object sender,RoutedEventArgs e)
    {
            double num1 = double.Parse( num1box.Text);
            double num2 = double.Parse( num2box.Text);
            double answer = num1 * num2;
            ans.Content = answer;
            AddHistory(num1, num2, answer,"*");

        }
        private void div(object sender,RoutedEventArgs e)
    {
            double num1 = double.Parse( num1box.Text);
            double num2 = double.Parse( num2box.Text);
            double answer = num1 / num2;
            ans.Content = answer;
            AddHistory(num1, num2, answer,"/");

        }
        private void AddHistory(double num1, double num2, double answer,String op)
        {
            Label label = new Label();
            label.Height = 100;
            label.Width = 100;
            label.HorizontalAlignment = HorizontalAlignment.Left;
            label.VerticalAlignment = VerticalAlignment.Top;
            label.Content = $"{ num1}\n{op}\n {num2}\n--------\n{answer}";
            History.Children.Add(label);
        }
    }
}
