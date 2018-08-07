using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleMathParser;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class ExpressionTest
    {
        [TestMethod]
        public void EmptyExpressionIsNotValid()
        {
            var expression = new MathExpression("");
            Assert.IsFalse(expression.Valid);
        }

        [TestMethod]
        public void TestExpressionWithInValidPattern()
        {
            var expression = new MathExpression("abc");
            Assert.IsFalse(expression.Valid);
        }

        [TestMethod]
        public void SingleValueExpressionIsValid()
        {
            var expression = new MathExpression("1");
            Assert.IsTrue(expression.Valid);
        }
    }
}
