using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    public class QuadraticEq
    {
        #region Поля
        private double a;
        private double b;
        private double c;
        #endregion

        #region Свойства
        public string A
        {
            set
            {
                if ((Double.TryParse(value, out a) == false)) throw new Exception("Неверное значение \"a\"");
            }
        }
        public string B
        {
            set
            {
                if ((Double.TryParse(value, out b) == false)) throw new Exception("Неверное значение \"b\"");
            }
        }
        public string C
        {
            set
            {
                if ((Double.TryParse(value, out c) == false)) throw new Exception("Неверное значение \"c\"");
            }
        }
        public string Answer { get; private set; }
        #endregion


        #region Конструкторы
        public QuadraticEq(string a, string b, string c)
        {
            A = a;
            B = b;
            C = c;
        }
        #endregion

        #region Методы
        public string CalculateRoot()
        {

            if ((a==0)&&(b==0)&&(c==0)) return Answer = "X - любое число";
            if((a==0)&&(b==0)) return Answer = "Решений нет";
            if (a == 0) return Answer = String.Format("X={0:0.####}", -c / b);
            double Discriminant = Math.Pow(b, 2) - 4 * a * c;
            if (Discriminant > 0) return Answer = String.Format("Х1={0:0.####} Х2={1:0.####}", ((-b + Math.Sqrt(Discriminant)) / (2 * a)), ((-b - Math.Sqrt(Discriminant)) / (2 * a)));
            else
            {
                if (Discriminant == 0) return Answer = String.Format("Х1={0:0.####}", ((-b + Math.Sqrt(Discriminant)) / (2 * a)));
                else return Answer = "Решений нет";
            }
        }
        #endregion
    }
}
