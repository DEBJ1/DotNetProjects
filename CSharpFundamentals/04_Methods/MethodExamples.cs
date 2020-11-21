using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Methods
{
    [TestClass]
    public class MethodExamples
    {
        //input
        //what we do 
        //Output

        //access modifier--return type ---method signiture (Name and list of parameters)

        public int AddTwoNumbers(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        private int SubtractTwoNumbers(int a, int b)
        {
            int num = a - b;
            return num;

        }

        private int MultiplyTwoNUmbers(int x, int Z)
        {
            int prod = x * Z;
            retun prod;
        }

        private int DivideTwoNumbers(int apricot, int cherry)
        {
            int fruitSalad = apricot / cherry;
            return fruitSalad;
        }

        private int FindRemainder(int a, int numTwo)
        {
            int remainder = a % numTwo;
            return remainder;
        }


        [TestMethod]
        public void MethodTests()
        {
            int banana = AddTwoNumbers(7, 12);
            int sumTwo = AddTwoNumbers(5, 42);

            Assert.AreEqual(19, banana);

            int subtractedBanana = SubtractTwoNumbers(10, 5);
            Assert.AreEqual(5, subtractedBanana);




        }


    }
}
