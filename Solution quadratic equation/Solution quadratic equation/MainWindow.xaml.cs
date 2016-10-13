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
        /// <summary>
        /// Стандартная инициализация компонентов.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку "Результат"(btnSolve)
        /// </summary>
        /// <param name="sender">Объект вызвавший событие</param>
        /// <param name="e">Дополнительные параметры</param>
        private void btnSolve_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                QuadraticEq KvUr = new QuadraticEq(tbA.Text, tbB.Text, tbC.Text); //Через конструктор нициализируем поля экземпляра класса. 
                tbAnswer.Text=KvUr.X1.ToString();
                tbAnswer.Text = KvUr.CalculateRoot();
                //tbAnswer.Text = KvUr.X2.ToString();

            }
            catch (Exception ex) //Возникает в случае попытки ввода неверного значения в поле. 
            {
                tbAnswer.Text=ex.Message;
            }

        }
    }
}
