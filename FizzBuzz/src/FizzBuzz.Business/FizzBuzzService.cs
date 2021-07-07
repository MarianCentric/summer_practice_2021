using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.Business
{
    public class FizzBuzzService : IFizzBuzzService
    {
        /// <summary>
        /// Returns:<br/>
        ///     "FIZZ" if input is divisible by 3<br/>
        ///     "BUZZ" if input is divisible by 5<br/>
        ///     "FIZZBUZZ" if input is divisible by 15<br/>
        ///     "&lt;input&gt;" if none of previous conditions have benn meet
        /// </summary>
        /// <param name="input"></param>
        /// <returns>"FIZZ", "BUZZ", "FIZZBUZZ"</returns>
        public string Calculate(int input)
        {
            var sb = new StringBuilder();
            if (input % 3 == 0)
            {
                sb.Append("FIZZ");
            }

            if (input % 5 == 0)
            {
                sb.Append("BUZZ");
            }

            if (sb.Length == 0)
            {
                sb.Append($"{input}");
            }

            return sb.ToString();
        }

        public string[] GetFizBuzzArray(int itemsCount)
        {
            if (itemsCount <= 0)
            {
                return new string[0];
            }

            var result = new string[itemsCount + 1];
            for (var i = 1; i <= itemsCount; i++)
            {
                result[i] = $"{i}"; // - Why we should test components within our boundries together
                
                // result[i] = Calculate(i);
            }

            return result;
        }
    }
}
