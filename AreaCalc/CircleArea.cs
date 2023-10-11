using System.ComponentModel.Design;

namespace AreaCalc
{
    /// <summary>
    /// Рассчет площади круга определенного радиуса.<br/>
    /// Радиус может передаваться в цифровом и строковом значении
    /// </summary>
    public static class CircleArea
    {
        /// <summary>
        /// Определение площади круга по радиусу
        /// </summary>
        /// <param name="r"> радиус круга</param>
        /// <returns>тип double, площадь круга, округленная математически до 8 знаков после запятой</returns>
        public static double Calc(double r)
        {
            return Calc(r, 8);
        }
        public static double Calc(double r, byte accuracy)
        {
            double res = Math.Round(Math.PI * r * r, accuracy);
            return res;
        }

        /// <summary>
        /// Определение площади круга по радиусу
        /// </summary>
        /// <param name="r"> радиус круга</param>
        /// <returns>тип double, площадь круга, округленная математически до 8 знаков после запятой</returns>
        public static double Calc(string r)
        {
            return Calc(r, "8");
        }
        public static double Calc(string r, string accuracy)
        {
            double res = default;
            r = r.Trim();
            r = r.Replace(" ", "");
            r.Replace(",", ".");
            var rIsDigit = double.TryParse(r, out double rdig);
            var accIsDigit = byte.TryParse(accuracy, out byte accDig);
            if (rIsDigit && accIsDigit)
            {
                res = Math.Round(Math.PI * rdig * rdig, accDig);
                return res;
            }
            else return 0;
        }
        public static string Help()
        {
            return "" +
                "CircleArea - Класс определения площади круга v.1\n" +
                "Доступны метод calc со следующими перегрузками:\n" +
                "calc(string radius)\n" +
                "calc(string radius, string accuracy)\n" +
                "calc(double radius)\n" +
                "calc(double radius, byte accuracy)\n"
                ;
        }
    }
}