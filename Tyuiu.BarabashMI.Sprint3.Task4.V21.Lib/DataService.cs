using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BarabashMI.Sprint3.Task4.V21.Lib
{
    public class DataService : ISprint3Task4V21
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1;
            for (startValue = -5;  startValue < stopValue; startValue++)
            {
                if (startValue == 0)
                {
                    continue;
                }
                res *= (Math.Cos(startValue) - startValue) / startValue;
            }
            res = Math.Round(res,3);
            return res;
        }
    }
}
