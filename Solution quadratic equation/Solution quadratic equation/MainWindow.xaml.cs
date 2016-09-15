using System.Windows;
using QuadraticEquation;
using System;

namespace Solution_quadratic_equation
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //TODO: Доделать интерфейс.
        //TODO: Документация и комментарии.
        private void btnSolve_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                QuadraticEq KvUr = new QuadraticEq(tbA.Text, tbB.Text, tbC.Text);
                MessageBox.Show(KvUr.CalculateRoot());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
