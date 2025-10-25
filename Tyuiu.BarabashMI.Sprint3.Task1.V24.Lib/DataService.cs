using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BarabashMI.Sprint3.Task1.V24.Lib
{
    public class DataService : ISprint3Task1V24
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double s = new double();
            int i = startValue;
            while (i <= stopValue)
            {
                s += Math.Pow(2 / (6 + Math.Pow(value, i)), i);
                i++;
            }
            s = Math.Round(s, 3);
            return s;
        }
    }
}
