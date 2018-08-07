﻿using System;
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
        public void Test_Expression_With_Single_Value_And_Single_Operation()
        {
            var expression = new MathExpression("5-1");
            Assert.AreEqual(expression.FirstValue, 5);
        }
    }
}
