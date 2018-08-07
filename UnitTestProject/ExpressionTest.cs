using System;
using NUnit;
using SimpleMathParser;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;
using System.Text;

namespace UnitTestProject
{
    [TestFixture]
    public class ExpressionTest
    {
        [Test]
        public void Test_Expression_With_Single_Value()
        {
            var expression = new MathExpression("10");
            Assert.AreEqual(expression.FirstValue, 10.0);
        }

        [Test]
        public void Creating_Invalid_Expression_Generates_Exception() {
            Assert.Throws<ExpressionEvaluationException>(
                    () => new MathExpression("1abc")
            );
        }

        [Test]
        public void Test_Expression_First_Value()
        {
            var expression = new MathExpression("16-1+9-10");
            Assert.AreEqual(expression.FirstValue, 16);
        }

        [Test]
        public void Test_Expression_With_Empty_Operations()
        {
            var expression = new MathExpression("5");
            Assert.AreEqual(expression.FirstValue, 5);
            Assert.AreEqual(expression.Operations.Count, 0);
        }

        [Test]
        public void Test_Expression_With_One_Operation()
        {
            var expression = new MathExpression("10-3");
            Assert.AreEqual(expression.FirstValue, 10);
            var operation = new MathOperation(Operator.Subtract, 3);
            Assert.AreEqual(expression.Operations.FirstOrDefault(), operation);
        }

        [Test]
        public void Test_Expression_With_Multiple_Operations()
        {
            var expression = new MathExpression("5+3/8-2+9*300");
            Assert.AreEqual(expression.FirstValue, 5);

            var operations =new MathOperation[] {
                new MathOperation(Operator.Add, 3),
                new MathOperation(Operator.Divide, 8),
                new MathOperation(Operator.Subtract, 2),
                new MathOperation(Operator.Add, 9),
                new MathOperation(Operator.Multiply, 300)
            };
            CollectionAssert.AreEquivalent(expression.Operations, operations);
        }

        [Test]
        public void Test_Printing_Instructions_For_Single_Value() {
            var expression = new MathExpression("13");
            var instructions = new StringBuilder();
            instructions.AppendLine("PUSH 13");
            instructions.AppendLine("PRINT");

            StringAssert.AreEqualIgnoringCase(
                expression.createProgramInstructions().ToString(), 
                instructions.ToString()
            );
        }

        [Test]
        public void Test_Printing_Instructions_For_Long_Expressions()
        {
            var expression = new MathExpression("7/2+14*9-5-15*500");
            var instructions = new StringBuilder();
            instructions.AppendLine("PUSH 7");
            instructions.AppendLine("PUSH 2");
            instructions.AppendLine("DIVIDE");
            instructions.AppendLine("PUSH 14");
            instructions.AppendLine("ADD");
            instructions.AppendLine("PUSH 9");
            instructions.AppendLine("MULTIPLY");
            instructions.AppendLine("PUSH 5");
            instructions.AppendLine("SUBTRACT");
            instructions.AppendLine("PUSH 15");
            instructions.AppendLine("SUBTRACT");
            instructions.AppendLine("PUSH 500");
            instructions.AppendLine("MULTIPLY");
            instructions.AppendLine("PRINT");

            StringAssert.AreEqualIgnoringCase(
                expression.createProgramInstructions().ToString(),
                instructions.ToString()
            );
        }
    }
}
