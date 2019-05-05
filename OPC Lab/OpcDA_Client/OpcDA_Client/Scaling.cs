namespace OpcDA_Client
{
    public class Scaling
    {
        public static double CtoF(double celsius)
        {
            return celsius * 9 / 5 + 32;
        }
        public static double FtoC(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}