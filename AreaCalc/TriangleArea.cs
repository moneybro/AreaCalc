using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc
{
    public class TriangleArea
    {
        /// <summary>
        /// Расчет площади треугольника по 3 сторонам
        /// </summary>
        /// <param name="a">Сторона 1</param>
        /// <param name="b">Сторона 2</param>
        /// <param name="c">Сторона 3</param>
        /// <returns>Тип double, площадь треугольника</returns>
        public static double Calc(double a, double b, double c)
        {
            double p = (a + b + c) /2;
            double res = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            res = Math.Round(res, 5); // отбрасываем (не округляем!) дробную часть с заданной точностью (после знака, указанного в параметре округления)
            return res;
        }
    }
}
