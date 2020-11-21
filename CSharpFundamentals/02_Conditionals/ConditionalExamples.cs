using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_Conditionals
{
    [TestClass]
    public class ConditionalExamples
    {
        [TestMethod]
        public void Booleans()
        {
            bool isTrue = 17 > 5;
            bool isFalse = 17 == 4;

        }

        [TestMethod]
        public void IfElseStatements()
        {
            bool isTrue = true;
            if (isTrue)
            {
                //asdf
            }

            int age = 12;

            if ( age > 17)
            {
                Console.WriteLine("cool");
            }
        }
    
    
    }

}
