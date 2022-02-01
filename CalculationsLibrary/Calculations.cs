using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsLibrary
{
    /// <summary>
    /// Класс Calculations освновной класс библиотеки
    /// содержащий в себе метод CalculatingTheCredits
    /// </summary>\
    /// <param name="S">Аргумент метода  CalculatingTheCredits() 
    /// означающий сумму которую хочет взять клиент </param>
    /// <param name="N">Аргумент метода  CalculatingTheCredits() 
    /// означающий количество месяцев на которое берется сумма денег </param>
    public class Calculations
    {
        public static double CalculatingTheCredits(double S, double N)
        {
            double answer = Math.Round(S * (0.01 + ((0.01 / (Math.Pow(1.01, N) - 1)))), 2);
            return answer;
        }
    }
}

