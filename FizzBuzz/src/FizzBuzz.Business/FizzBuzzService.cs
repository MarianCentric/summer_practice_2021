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
        /// <returns></returns>
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
    }
}
