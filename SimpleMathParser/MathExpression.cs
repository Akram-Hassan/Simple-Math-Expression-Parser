﻿using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System;

namespace SimpleMathParser
{
    public class MathExpression
    {
        private string text;
        private string pattern = @"^(\d+)([/*+-]\d+)*$";

        public MathExpression(string text)
        {
            if (!Regex.IsMatch(text, pattern))
            {
                throw new ExpressionEvaluationException($"{text} is invalid expression");
            }
            this.text = text;
        }

        public int FirstValue {
            get {
                Match firstMatch = Regex.Matches(text, pattern)[0];
                Group firstNumberGroup = firstMatch.Groups[1];

                int result;
                int.TryParse(firstNumberGroup.ToString(), out result);
                return result;
            }
        }

        public IList<MathOperation>  Operations {
            get
            {
                Match firstMatch = Regex.Matches(text, pattern)[0];
                Group operationsGroup = firstMatch.Groups[2];
                var operationCaptures = ((Group)operationsGroup).Captures;
                var operations = new List<MathOperation>();

                foreach (var operationCapture in ((Group)operationsGroup).Captures)
                {
                    string mathOperatorString = operationCapture.ToString().Substring(0, 1);
                    string value = operationCapture.ToString().Substring(0);

                    Operator mathOperator = getOperator(mathOperatorString);
                    int operand;
                    int.TryParse(value, out operand);
                    MathOperation operation = 
                        new MathOperation(Math.Abs(operand), mathOperator);

                    operations.Add(operation);
                }

                return operations;
            }
        }

        private Operator getOperator(string mathOperatorString )
        {
            Operator mathOperator = Operator.Add;
            switch (mathOperatorString)
            {
                case "+":
                    mathOperator = Operator.Add;
                    break;
                case "-":
                    mathOperator = Operator.Subtract;
                    break;
                case "*":
                    mathOperator = Operator.Multiple;
                    break;
                case "/":
                    mathOperator = Operator.Divide;
                    break;
            }
            return mathOperator;
        }
    }
}