using SimpleMathParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Expression_Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            while (true)
            {
                Console.WriteLine("Enter your math expressions:");
                string expressionText = Console.ReadLine();
                MathExpression expression;
                try
                {
                    expression = new MathExpression(expressionText);
                    Console.WriteLine(expression.createProgramInstructions());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Expression");
                }
            }
        }
    }
}
