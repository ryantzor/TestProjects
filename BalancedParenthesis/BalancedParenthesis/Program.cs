using System;
using System.Collections.Generic;

namespace BalancedParenthesis
{
    class Program
    {
        public static Dictionary<char, char> BracketsDictionary = new Dictionary<char, char>()
        {
            { '{', '}' },
            { '[', ']' },
            { '(', ')' }
        };

        static void Main(string[] args)
        {
            // expression to pass into the isBalanced function
            string expression = "{[()]}";
            Console.WriteLine(isBalanced(expression));

        }

        public static bool isBalanced(string expression)
        {
            // stack will be used to populate
            Stack<char> stack = new Stack<char>();

            //iterate through the string for each char
            foreach (char c in expression)
            {
                // if it's an open bracket we want to add it as a "live" bracket, 
                // or a bracket that will need to be closed
                if (BracketsDictionary.ContainsKey(c))
                {
                    stack.Push(c);
                } else if (stack.Count == 0 || c != BracketsDictionary[stack.Pop()])
                {
                    return false;
                }
            }

            // if our stack is not empty then
            // the brackets are not balanced
            if (stack.Count > 0)
                return false;

            return true;
        }
    }
}
