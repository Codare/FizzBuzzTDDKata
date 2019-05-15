namespace FizzBuzz.GameEngine
{
    public class FizzBuzzGame
    {
        public string Of(int iteration)
        {
            if (iteration == 0)
            {
                return "0";
            }

            if (iteration % 3 == 0 && iteration % 5 != 0)
            {
                return "Fizz";
            }

            if (iteration % 5 == 0 && iteration % 3 != 0)
            {
                return "Buzz";
            }

            if (iteration % 3 == 0 && iteration % 5 == 0)
            {
                return "FizzBuzz";
            }

            return iteration.ToString();

            //if (iteration == 0)
            //{
            //    return "0";
            //}

            //string s = "";

            //if (iteration % 3 == 0)
            //{
            //    s = "Fizz";
            //}

            //if (iteration % 5 == 0)
            //{
            //    s = "Buzz";
            //}

            //if (iteration % 3 == 0 && iteration % 5 == 0)
            //{
            //    s = "FizzBuzz";
            //}

            //return string.IsNullOrWhiteSpace(s)
            //    ? iteration.ToString()
            //    : s;
        }
    }
}