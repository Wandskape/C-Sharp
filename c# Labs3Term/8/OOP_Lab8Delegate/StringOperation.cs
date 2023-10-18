using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab8Delegate
{
    internal class StringOperation
    {
        public static string RemovePunctuation(string input)
        {
            char[] punctuation = { '.', ',', '!', '?' };
            return new string(input.Where(c => !punctuation.Contains(c)).ToArray());
        }

        public static string AddSymbol(string input, char symbol)
        {
            return input + symbol;
        }

        public static string ConvertToUppercase(string input)
        {
            return input.ToUpper();
        }

        public static string RemoveExtraSpaces(string input)
        {
            return string.Join(" ", input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        }

        public static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static void ProcessString(string input, Action<string> processingAction)
        {
            processingAction(input);
        }

        public static string ProcessStringFunc(string input, Func<string, string> processingFunc)
        {
            return processingFunc(input);
        }

        public static bool CheckString(string input, Predicate<string> checkPredicate)
        {
            return checkPredicate(input);
        }
    }
}
