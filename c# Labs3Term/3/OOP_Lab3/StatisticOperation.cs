using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3Lab
{
    internal static class StatisticOperation
    {
        public static int Sum(this SetString set)
        {
            int sum = 0;
            foreach (string element in set.GetElements())
            {
                if (!string.IsNullOrEmpty(element))
                {
                    sum += element.Length;
                }
            }
            return sum;
        }

        public static int Difference(this SetString set)
        {
            string[] elements = set.GetElements().Where(e => !string.IsNullOrEmpty(e)).ToArray();
            if (elements.Length == 0)
            {
                return 0;
            }

            int maxLength = elements.Max(e => e.Length);
            int minLength = elements.Min(e => e.Length);

            return maxLength - minLength;
        }

        public static int Count(this SetString set)
        {   
            int count = 0;
            foreach (string element in set.GetElements())
                if (!string.IsNullOrEmpty(element))
                    count++;

            return count;
        }

        public static void SmallestWord(this SetString set)
        {
            string buff = set.GetElementsNumb(0);

            foreach (string element in set.GetElements())
                if (element != null && element.Length < buff.Length)
                    buff = element;
            Console.WriteLine("Самое короткое слово: " + buff);
        }

        public static void sortWord(this SetString set)
        {
            var sortedNames = set.GetElements().OrderBy(name => name);

            foreach (var name in sortedNames)
            {
                Console.WriteLine(name);
            }

        }
    }
}
