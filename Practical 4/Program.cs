/*
 * Convert infix string to postfix string
 */
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
            string infix = "a+(b*c)/d-e";
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
            //Check is current symbol is operator
            if (Operator(ch))
            {
                //If stack is empty push current operator to stack
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
                         //Pop all operator in postfix until (
                        while (stack.Peek() != '(')
                        {
                            postfix += stack.Pop();
                        }
                        //Pop operator (
                        stack.Pop();
                    }
                    else
                    {
                            //If new operator has higher priority than top of the stack then push it to the stack
                            if (priority(ch) > priority(stack.Peek()))
                        {
                            stack.Push(ch);
                        }
                        else
                        {
                            //Pop top of stack into postfix
                            postfix += stack.Pop();
                            //Decrease i to operate same input in the next iteration
                            i--;
                        }

                    }
                }
            }
            else
            {
                //Add every operand into postfix
                postfix += ch;
            }
        }
        //Pop all remaining operators from stack to postfix expression
         foreach (var item in stack)
            postfix += item;
        Console.WriteLine("Postfix String:" + postfix);
    }
    public Boolean Operator(char ch)
    {
        if (ch == '+' || ch == '-' || ch == '*' || ch == '/' || ch == '(' || ch == ')' || ch == '^')
            return true;
        else
            return false;
    }
    public int priority(char ch)
    {
        //Returns priority for all operator
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
