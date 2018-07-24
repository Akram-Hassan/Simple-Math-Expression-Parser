using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleMathParser;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void EmptyExpressionHasZeroTokens()
        {
            var expression = new MathExpression("");
            int length = expression.tokens.Capacity;
            Assert.AreEqual(length, 0); 
        }

        [TestMethod]
        public void SingleDigitExpressionHasSingleTokenWithSameValue()
        {
            var expression = new MathExpression("1");
            var tokens = new List<String> { "1" };
            CollectionAssert.AreEquivalent(expression.tokens, tokens);
        }

        [TestMethod]
        public void SingleNumberExpressionHasSingleTokenWithSameValue()
        {
            var expression = new MathExpression("123");
            var tokens = new List<String> { "123" };
            CollectionAssert.AreEquivalent(expression.tokens, tokens);
        }
    }
}
