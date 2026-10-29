using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BedenkoAN.Sprint3.Task2.V6.Lib
{
    public class DataService : ISprint3Task2V6
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double p = 1;
            do
            {
                p = p * ((Math.Pow(value, startValue) + 1) * Math.Cos(4));
                startValue++;
            }
            while (startValue <= stopValue);
            return Math.Round(p, 3);
        }
    }
}
