using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BedenkoAN.Sprint3.Task7.V2.Lib
{
    public class DataService : ISprint3Task7V2
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int size = stopValue - startValue + 1;

            double[] res = new double[size];
            int index = 0;

            double y;
            int x;
             
            for (x = startValue; x <= stopValue; x++)
            {
                if (x - 0.7 == 0)

                {
                    res[index] = 0; 
                }
                else
                {
                    y = Math.Cos(x) / (x - 0.7) - Math.Sin(x) * 12 * x + 2;
                    res[index] = Math.Round(y, 2);


                }
                index++;   
            }
            return res;

            
        }
    }
}
