using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string infix = "a+(b+c)*d/e";
            Console.WriteLine("Infix String:" + infix);
            string postfix = "";
            Class1 p = new Class1();
            p.InfixToPostFix(ref infix, out postfix);
            Console.Read();

        }
    }
    class Class1
    {
        public void InfixToPostFix(ref string infix, out string postfix)
    {
        postfix = "";
        char ch;
        Stack<char> stack = new Stack<char>();
        for (int i = 0; i < infix.Length; i++)
        {
            ch = infix[i];
            if (isOperator(ch))
            {
                if (stack.Count == 0)
                {
                    stack.Push(ch);
                }
                else
                {
                    if (ch == '(')
                    {
                        stack.Push(ch);
                    }
                    else if(ch == ')')
                                        {
                        while (stack.Peek() != '(')
                        {
                            postfix += stack.Pop();
                        }
                        stack.Pop();
                    }
                    else
                    {
                        if (priority(ch) > priority(stack.Peek()))
                        {
                            stack.Push(ch);
                        }
                        else
                        {
                            postfix += stack.Pop();
                            i--;
                        }

                    }
                }
            }
            else
            {
                postfix += ch;
            }
        }
        foreach (var item in stack)
            postfix += item;
        Console.WriteLine("Postfix String:" + postfix);
    }
    public Boolean isOperator(char ch)
    {
        if (ch == '+' || ch == '-' || ch == '*' || ch == '/' || ch == '(' || ch == ')' || ch == '^')
            return true;
        else
            return false;
    }
    public int priority(char ch)
    {
        switch (ch)
        {
            case '(':
            case ')': return 0;


            case '+':
            case '-':
                return 1;


            case '*':
            case '/':
                return 2;

            case '^': return 3;
            default: return 99;

        }
    }
}

}
