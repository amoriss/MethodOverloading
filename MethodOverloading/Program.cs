using System;

namespace MethodOverloading
{
    class Program
    {

        /* 
Create an Add method:
This Add method takes 2 integer parameters
Create an overload of the Add method:
This Add method needs to have 2 decimal parameters

Create another overload of the Add method:
This Add method  returns a string
And this Add method takes 3 parameters
 2 integer parameters
 1 boolean parameters
If the boolean parameter is equal to true:
This Add method will return the sum of the 2 numbers
This Add method adds the word “dollar” at the end of the string if the total is equal to 1 dollar
This Add method adds the word “dollars” at the end of the string if the total is equal to any other amount 
If the boolean parameter is not equal to true:
This Add method will just return the sum of the 2 numbers
*/
        public static int Add( int num1, int num2)
        {
            return num1 + num2; 
        }
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2; 
        }

        public static string Add(int num1, int num2, bool answer)
        {

            if (answer == true)
            {
                if (num1 + num2 == 1)
                {
                    return ($"{num1 + num2} dollar");
                }

                if (num1 + num2 > 1)
                {
                    return ($" {num1 + num2} dollars");
                }

                if (num1 + num2 < 1)
                {
                    return ($"{num1 + num2} dollars");
                }

            }
            // else statement for false condition
            //---
            //else
           // {
             //   return ($"{num1 + num2}");
           // }

            return ($"{num1 + num2}"); // this needed to be added to avoid "not all code paths return a value error"

        }
        
        static void Main()
        {
            Console.WriteLine("This tests an overload function: ");
            var firstAnswer = Add(5, 5);
            var secondAnswer = Add(10.5432m, 30.203m);
            var thirdAnswer =  Add(5, 5, true);
            var thirdAnswer2 = Add(10, 10, false); 
            var thirdAnswer3 = Add(0, 0, true); 
            Console.WriteLine($"5 + 5 = {firstAnswer} \n" +
                $"10.5432 + 30.203 = {secondAnswer} \n" +
                $"5 + 5 + true = {thirdAnswer} \n" +
                $"10 + 10 + false = {thirdAnswer2} \n" +
                $"0 + 0 + true = {thirdAnswer3} ");
        }
    }
}
