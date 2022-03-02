using System;

namespace RecursionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4 };

            //are the numbers increasing?

            bool result = is_increasing(numbers);

            Console.WriteLine(result);

            bool is_increasing(List<int> lst)
            {
                //Base Case
                if (lst.Count == 0)
                {
                    return false;
                }
                else if (lst[0] > lst[1])
                {
                    return false;
                }
                else //Recursive Case 
                {
                    return is_increasing(lst.GetRange(1, lst.Count - 1 ));
                }
            }

        }
    }
}