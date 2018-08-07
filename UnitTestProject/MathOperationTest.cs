using System;
using NUnit;
using SimpleMathParser;
using System.Collections.Generic;
using NUnit.Framework;

namespace UnitTestProject
{
    [TestFixture]
    public class MathOperationTest
    {
        [Test]
        public void Create_Math_Operation()
        {
            int value = 10;
            Operator mathOperator = Operator.Add;
            var mathOperation = 
                new MathOperation(value, mathOperator);

            Assert.AreEqual(mathOperation.Value, 10);
            Assert.AreEqual(mathOperation.Operator, mathOperator);
        }
    }
}
