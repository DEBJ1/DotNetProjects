using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_Types
{
    [TestClass]
    public class TypeExamples
    {
        [TestMethod]
        public void ValueTypes()
        {
            //--whole numbers 
            byte oneBytesworth;
            oneBytesworth = 255;
            short smallWholenumber = 16;
            int wholeNumber = 32;
            long largeWholeNumber = 64;

            //-- Decimals 
            float floatExample = 1.23456f;
            double doubleExample = 1.2234d;
            decimal decimalExample = 1.7000m;

            char letter = 'j';


            //--Operators

            int numOne = 17;
            int numTwo = 5;

            int sum = numOne + numTwo;
            int diff = numOne - numTwo;
            int prod = numOne * numTwo;
            int quot = numOne / numTwo;
            int remainder = numOne % numTwo;

        }
    }
}
