using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

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
               private void Clear(object sender, RoutedEventArgs e)
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
                AddHistory(expresion);
            }
        }
        private void AddHistory(string result )
        {
            Label label = new Label
            {
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                Content = result
            };
            History.Children.Add(label);
        }
    }
}
