using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BarabashMI.Sprint3.Task2.V15.Lib
{
    public class DataService : ISprint3Task2V15
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double s = new double();
            int i = startValue;
            do
            {
                s += (Math.Pow(value, i) + 1 / 2) * Math.Cos(i);
                i++;
            } while (i <= stopValue);
            s = Math.Round(s, 3);
            return s;
        }
    }
}
