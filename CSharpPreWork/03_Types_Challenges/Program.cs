using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Types_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isLoggedIn = true;
            Console.WriteLine(isLoggedIn);

            string firstName = "Paul";
            Console.WriteLine(firstName);
            
            string lastName = "Stone";
            Console.WriteLine(lastName);


            string fbPost;
            string reTweet = "Yes, I'll retweet that.";
            fbPost = "The Patriots are terrible!";

            Console.WriteLine(fbPost + " " + reTweet);

            int i = 0;
            Console.WriteLine(i);

            float f = 10.8f;
            Console.WriteLine(f);

            double d = 7.80000000000000;
            Console.WriteLine(d);

            decimal dd = 7.80m;
            Console.WriteLine(dd);

            Console.ReadLine();
        }
    }
}
