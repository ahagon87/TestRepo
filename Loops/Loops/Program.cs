using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName;
            int myAge;
            bool job;

            Console.WriteLine("What is your name? ");
            myName = Console.ReadLine();

            myAge = MyAge(myName);
            job = MyJob(myName);

            Options(myName, myAge, job);
            
        }

        static int MyAge(string name)
        {
            Console.WriteLine(name + " how old are you?");
            int age = Convert.ToInt32(Console.ReadLine());

            return age;
        }

        static bool MyJob(string name)
        {
            bool job;

            Console.WriteLine(name + " do you have a job? [Y/N]");
            string answer = Console.ReadLine().Trim().ToLower();

            if (answer == "y")
            {
                answer = "True";
            }
            else if (answer == "n")
            {
                answer = "False";
            }
            else
            {
                answer = "null";
            }
            job = Convert.ToBoolean(answer);

            return job;
        }

        static void Options(string name, int age, bool job)
        {
            if (age >= 21)
            {
                if (job == true)
                {
                    Console.WriteLine("Good evening " + name + " here is a drink menu.");
                }else
                {
                    Console.WriteLine("Good evening" + name + " we offer free drink for an onstage solo!");
                }
            }else
            {
                Console.WriteLine("Sorry " + name + " you are not old enough to enter the bar.");
            }
        }
        


    }
}
