using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleMathParser;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void EmptyExpressionHasZeroTokens()
        {
            var expression = new MathExpression("");
            int length = expression.tokens.Length;
            Assert.AreEqual(length, 0); 
        }
    }
}
