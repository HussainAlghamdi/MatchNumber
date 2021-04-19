using System;
using System.Collections.Generic;
namespace MatchNumber
{
    class Program
    {
        static bool match(string source)
        {
            Stack<int> stack = new Stack<int>();
            foreach (char ch in source)
            {
                if (stack.Count == 0 || ch != stack.Peek())
                {
                    stack.Push(ch);
                }
                else
                {
                    stack.Pop();
                }
                
            }
            if (stack.Count == 0)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(match("89339998"));
        }
    }
}