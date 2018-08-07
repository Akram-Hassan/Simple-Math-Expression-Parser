using System;
using NUnit;
using SimpleMathParser;
using System.Collections.Generic;
using NUnit.Framework;

namespace UnitTestProject
{
    [TestFixture]
    public class ExpressionTest
    {
        [Test]
        public void EmptyExpressionIsNotValid()
        {
            var expression = new MathExpression("");
            Assert.IsFalse(expression.Valid);
        }

        [Test]
        public void TestExpressionWithInValidPattern()
        {
            var expression = new MathExpression("abc");
            Assert.IsFalse(expression.Valid);
        }

        [Test]
        public void SingleValueExpressionIsValid()
        {
            var expression = new MathExpression("1");
            Assert.IsTrue(expression.Valid);
        }

        [Test]
        public void SingleValueExpressionHasTheSameValue()
        {
            double value = 500.0;
            var expression = new MathExpression("500");

            Assert.AreEqual(expression.Evaluate(), value);
        }

        [Test]
        public void EvaluatingInvalidExpressionThrowsException()
        {
            var expression = new MathExpression("10a");
            Assert.Throws<EvaluationException>(() => expression.Evaluate());
        }

        [Test]
        public void TestExpressionWithSingleValue()
        {
            var expression = new MathExpression("10");
            Assert.AreEqual(expression.Evaluate(), 10.0);
            Assert.AreEqual(expression.FirstValue, 10.0);
        }
    }
}
