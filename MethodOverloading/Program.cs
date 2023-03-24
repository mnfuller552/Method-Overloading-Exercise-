namespace MethodOverloading
{
    public class Program
    {

        static int Add(int num1, int num2)
        {
            return num1 + num2;

        }
        static double Add(double num1, double num2, double num3)
        {
            return num1 + num2 + num3;
        }
       static string Add(int num1, int num2, bool isCheck)
        {
            var sum = num1 + num2;

            if (isCheck == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isCheck == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (isCheck == true && sum < 1)
            {
                return $"{sum} dollars";
            }

            return sum.ToString();

            static void Main(string[] args)
            {



            }
        }
    }
}
