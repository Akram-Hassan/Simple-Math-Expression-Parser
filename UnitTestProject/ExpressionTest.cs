using System;
using NUnit;
using SimpleMathParser;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;

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
            var operation = new MathOperation(3, Operator.Subtract);
            Assert.AreEqual(expression.Operations.FirstOrDefault(), operation);
        }

    }
}
