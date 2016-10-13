using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    /// <summary>
    /// Класс QuadraticEq представляет метод для вычисления корней уравнения второй степени
    /// </summary>
    public class QuadraticEq
    {
        #region Поля
        private double a;
        private double b;
        private double c;
        private double x1;
        private double x2;
        #endregion

        #region Свойства

        /// <summary>
        /// Получает строковое представление переменной "а". Проверяет на возможность конвертации входящего значения в тип "double".
        /// При успешной конвертации - присваивает полю "а" входящее значение.
        /// При не успешной конвертации - выбрасывает исключение Exception("Неверное значение "a"").
        /// </summary>
        public string A
        {
            set
            {
                if ((Double.TryParse(value, out a) == false)) throw new Exception("Неверное значение \"a\"");
            }
        }

        /// <summary>
        /// Получает строковое представление переменной "b". Проверяет на возможность конвертации входящего значения в тип "double".
        /// При успешной конвертации - присваивает полю "b" входящее значение.
        /// При не успешной конвертации - выбрасывает исключение Exception("Неверное значение "b"").
        /// </summary>
        public string B
        {
            set
            {
                if ((Double.TryParse(value, out b) == false)) throw new Exception("Неверное значение \"b\"");
            }
        }

        /// <summary>
        /// Получает строковое представление переменной "c". Проверяет на возможность конвертации входящего значения в тип "double".
        /// При успешной конвертации - присваивает полю "c" входящее значение.
        /// При не успешной конвертации - выбрасывает исключение Exception("Неверное значение "c""). 
        /// </summary>
        public string C
        {
            set
            {
                if ((Double.TryParse(value, out c) == false)) throw new Exception("Неверное значение \"c\"");
            }
        }

        /// <summary>
        ///   /// get - Возвращает строковое представление корня уравнения Х1.
        /// private set - Принимает строковое представление корня уравнения Х1. (Доступен только внутри класса).
        /// </summary>
        public double X1
        {
            get
            {
                if (Double.IsPositiveInfinity(x1))
                {
                    throw new Exception("Ошибка! \nЗначение x1 не подсчитано");
                }
                if (Double.IsNegativeInfinity(x1))
                {
                    throw new Exception("Решений нет.");
                }
                else return x1;
            }
            private set
            {
                x1 = value;
            }
        }

        /// <summary>
        /// get - Возвращает строковое представление корня уравнения Х2.
        /// private set - Принимает строковое представление корня уравнения Х2. (Доступен только внутри класса).
        /// </summary>
        public double X2
        {
            get
            {
                if (Double.IsPositiveInfinity(x2))
                {
                    throw new Exception("Ошибка! \nЗначение x2 не подсчитано");
                }
                if (Double.IsNegativeInfinity(x2))
                {
                    throw new Exception("Решений нет.");
                }
                else return x2;
            }
            private set
            {
                x2 = value;
            }
        }
        #endregion

        #region Конструкторы

        /// <summary>
        /// Инициализирует поля класса QuadraticEq.
        /// </summary>
        /// <param name="a">параметр "а"</param>
        /// <param name="b">параметр "b"</param>
        /// <param name="c">параметр "с"</param>
        public QuadraticEq(string a, string b, string c)
        {
            A = a;
            B = b;
            C = c;
            X1 = Double.PositiveInfinity;
            X2 = Double.PositiveInfinity;

        }

        /// <summary>
        /// Инициализирует поля класса QuadraticEq.
        /// </summary>
        /// <param name="a">параметр "а"</param>
        /// <param name="b">параметр "b"</param>
        /// <param name="c">параметр "с"</param>
        public QuadraticEq(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            X1 = Double.PositiveInfinity;
            X2 = Double.PositiveInfinity;
        }
        #endregion

        #region Методы

        /// <summary>
        /// Вычисляет корни уравнения второй степени.
        /// </summary>
        /// <returns>Строковое представление результата вычислений.</returns>
        public string CalculateRoot()
        {
            if ((a == 0) && (b == 0) && (c == 0))
            {
                X1 = 0;
                X2 = 0;
                return "X - любое число";
            }
            if ((a == 0) && (b == 0))
            {
                X1 = Double.NegativeInfinity;
                X2 = Double.NegativeInfinity;
                return "Решений нет";
            }
            if (a == 0)
            {
                return String.Format("X={0}", X1 = (-c / b)); //Возвращаем форматированный результат, предварительно записав его в автосвойство Answer.
            }
            double Discriminant = b * b - 4 * a * c;
            if (Discriminant > 0) return String.Format("Х1={0} \nХ2={1}", X1 = ((-b + Math.Sqrt(Discriminant)) / (2 * a)), X2 = ((-b - Math.Sqrt(Discriminant)) / (2 * a))); //Параметры метода "Format": 1 параметр - шаблон форматирования, 2 параметр - первый корень уравнения, 3 параметр - второй корень уравнения.
            else
            {
                if (Discriminant == 0) return String.Format("Х1={0}", X1 = X2 = (-b / (2 * a)));
                else return "Решений нет";
            }
        }
        #endregion
    }
}
