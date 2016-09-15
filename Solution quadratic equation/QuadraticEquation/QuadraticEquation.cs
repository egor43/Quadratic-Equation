using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    public class QuadraticEquation
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
        public QuadraticEquation(string a, string b, string c)
        {
            A = a;
            B = b;
            C = c;
        }
        #endregion

        #region Методы
        public string CalculateRoot()
        {
            if(a==0)
            {
                if(b==0) Answer = "Решений нет";
                else Answer = String.Format("Х={0}", (-c/b));
            }
            else
            {

            }

            //double Discriminant = Math.Pow(b, 2) - 4 * a * c;
            //if (Discriminant > 0) Answer = String.Format("Х1={0} Х2={1}", ((-b + Math.Sqrt(Discriminant)) / 2 * a), ((-b - Math.Sqrt(Discriminant)) / 2 * a));
            //else
            //{
            //    if ((Discriminant == 0)&&(a!=0)) Answer = String.Format("Х1={0}", ((-b + Math.Sqrt(Discriminant)) / 2 * a));
            //    else
            //    {
            //        Answer = "Решений нет";
            //    }
            //}
            return Answer;
        }
        #endregion
    }
}
