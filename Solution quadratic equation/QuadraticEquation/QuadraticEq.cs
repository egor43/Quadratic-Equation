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
        /// get - Возвращает строковое представление результата вычислений.
        /// private set - Принимает строковое представление результата вычислений. (Доступен только внутри класса).
        /// </summary>
        public string Answer { get; private set; }
        #endregion


        #region Конструкторы

        /// <summary>
        /// Инициализирует поля класса QuadraticEq.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public QuadraticEq(string a, string b, string c)
        {
            A = a;
            B = b;
            C = c;
        }
        #endregion

        #region Методы

        /// <summary>
        /// Вычисляет корни квадратного уравнения.
        /// </summary>
        /// <returns>Строковое представление результата вычислений.</returns>
        public string CalculateRoot()
        {
            if ((a==0)&&(b==0)&&(c==0)) return Answer = "X - любое число";
            if((a==0)&&(b==0)) return Answer = "Решений нет";
            if (a == 0) return Answer = String.Format("X={0:0.####}", -c / b); //Возвращаем форматированный результат, предварительно записав его в автосвойство Answer.
            double Discriminant = Math.Pow(b, 2) - 4 * a * c;
            if (Discriminant > 0) return Answer = String.Format("Х1={0:0.####} Х2={1:0.####}", ((-b + Math.Sqrt(Discriminant)) / (2 * a)), ((-b - Math.Sqrt(Discriminant)) / (2 * a))); //Параметры метода "Format": 1 параметр - шаблон форматирования, 2 параметр - первый корень уравнения, 3 параметр - второй корень уравнения.
            else
            {
                if (Discriminant == 0) return Answer = String.Format("Х1={0:0.####}", ((-b + Math.Sqrt(Discriminant)) / (2 * a)));
                else return Answer = "Решений нет";
            }
        }
        #endregion
    }
}
