using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BarabashMI.Sprint3.Task7.V25.Lib
{
    public class DataService : ISprint3Task7V25
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] mass = new double[len];
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                mass[count] = Math.Round(Math.Cos(i) + 2 * i - Math.Sin(i) * 3 * i, 2);
                count++;
            }
            return mass;

        }
    }
}
