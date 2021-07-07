using System.Collections.Generic;

namespace FizzBuzz.Business
{
    public interface IFizzBuzzService
    {
        string Calculate(int input);

        string[] GetFizBuzzArray(int itemsCount);
    }
}