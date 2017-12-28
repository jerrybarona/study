using System;
using Study.Models.LinkedLists;

namespace Study.Services
{
    public class StackService : IStackService
    {
        public bool GenerateStackFromArray(object[] arr)
        {
            try
            {
                Stack stack = new Stack(arr.Length + 10, arr);
                for (int i = arr.Length - 1; i >= 0; --i)
                {
                    if (stack.Pop() != arr[i]) return false;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CheckForBalancedBraces(object[] arr)
        {
            var stack = new Stack(arr.Length, arr);
            var i = 0;
            while (i < stack.StackCount())
            {
                var c = (char) arr[i];
                if (IsOpeningBrace(c))
                {
                    while (stack.StackCount() >= i)
                    {
                        var lastChar = (char)stack.Pop();
                        if (IsMatchingClosingBrace(c, lastChar))
                        {
                            if (stack.StackCount() == i) return true; 
                            break;
                        }
                        if (IsOpeningBrace(lastChar) || IsClosingBrace(lastChar))
                        {
                            return false;
                        }
                    }
                }
                else if (IsClosingBrace((char) arr[i]))
                {
                    return false;
                }
                ++i;
            }
            return true;
        }

        private static bool IsOpeningBrace(char character)
        {
            return character == 40 || character == 91 || character == 123;
        }
        private static bool IsClosingBrace(char character)
        {
            return character == 41 || character == 93 || character == 125;
        }

        private static bool IsMatchingClosingBrace(char open, char close)
        {
            if (open == 40) return close == 41;
            if (open == 91) return close == 93;
            if (open == 123) return close == 125;
            return false;
        }
    }
}
