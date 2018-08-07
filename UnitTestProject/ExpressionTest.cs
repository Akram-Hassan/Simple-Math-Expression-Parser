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
            var expression = new MathExpression("123");
            Assert.IsFalse(expression.Valid);
        }
    }
}
