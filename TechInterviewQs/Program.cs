using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechInterviewQs
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a program for practicing  basic c# coding questions

            //Main Menu
            int menuChoice = 10;
            while (menuChoice > 0)
            {
                Console.WriteLine("\n\n-----------MENU------------");
                Console.WriteLine("1 - FizzBuzz any number");
                Console.WriteLine("2 - FizzBuzz x to y");
                Console.WriteLine("3 - Reverse any string");
                Console.WriteLine("4 - Prime Numbers x to y");
                Console.WriteLine("5 - Largest Number in array");
                Console.WriteLine("6 - Palindrome any word");
                Console.WriteLine("7 - Nested For Loops");
                Console.WriteLine("0 - Exit");

                Console.WriteLine("Which program would you like to run?");
                menuChoice = int.Parse(Console.ReadLine());
                Console.WriteLine("\n\n");
                switch (menuChoice)
                {
                    case 0:
                        break;
                    case 1:
                        FizzBuzzNumber();
                        break;
                    case 2:
                        FizzBuzzXtoY();
                        break;
                    case 3:
                        ReverseTheString();
                        break;
                    case 4:
                        PrimeNumbersXtoY();
                        break;
                    case 5:
                        LargestNumInArray();
                        break;
                    case 6:
                        IsItAPalindrome();
                        break;
                    case 7:
                        NestedLoops();
                        break;
                    default:
                        menuChoice = 10;
                        break;
                }


            }
        }

        ///////////////////////////////////////////END OF MAIN ///////////////////////////////////////

        //Method FizzBuzzNumber
        //Write an application that asks the user for an integer.
        //If the number is divisible by 3 "fizz". by 5 "buzz"; by both "fizzbuzz"
        public static void FizzBuzzNumber()
        {

            Console.WriteLine("Please enter an integer");
            int userNum = int.Parse(Console.ReadLine());

            if (userNum % 5 == 0 && userNum % 3 == 0)
            {
                Console.WriteLine("FIZZBUZZ");
            }
            else if (userNum % 3 == 0)
            {
                Console.WriteLine("FIZZ");

            }
            else if (userNum % 5 == 0)
            {
                Console.WriteLine("BUZZ");
            }

            else
            {
                Console.WriteLine("Sorry, not divisible by 3 or 5 - better luck next time!");
            }
        }
        //-------------------------------------------------------------------------------------------
        //Method FizzBuzzXtoY()
        public static void FizzBuzzXtoY()
        {
            bool endGreaterThanStart = false;
            int startNum = 0;
            int endNum = 100;

            while (endGreaterThanStart == false)
            {
                Console.WriteLine("Please enter a starting number");
                startNum = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter an ending number");
                endNum = int.Parse(Console.ReadLine());
                if (endNum <= startNum)
                { Console.WriteLine("Ending number must be greater than starting number. Please try again."); }
                else
                {
                    endGreaterThanStart = true;
                }
            }//end while loop that checks for usable starting and ending numbers

            for (int i = startNum; i <= endNum; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("FIZZBUZZ");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("FIZZ");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("BUZZ");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        //-------------------------------------------------------------------------------------------
        //create a method to reverse a string (9/13-2)
        public static void ReverseTheString()
        {
            string aString = "test this string";
            string reversedString = "";

            Console.WriteLine("Please enter a string:");
            aString = Console.ReadLine();

            //method1 - reverse by creating a new string that is concatenated in reverse order
            for (int i = aString.Length - 1; i >= 0; i--)
            {
                reversedString += aString[i];
            }
            Console.WriteLine("The reversed string is :" + reversedString);

            //method2 - reverse the string in place
            //method3 - use .Reverse

        }
        //-------------------------------------------------------------------------------------------
        //Tech interview question (9/12)
        //print out all prime numbers that are less than 100 to the console 
        //0 and 1 are not prime numbers
        public static void PrimeNumbersXtoY()
        {
            int beginNumber = 2;
            int endNumber = 100;
            bool isPrime = true;

            Console.WriteLine("What number would you like to start with?");
            beginNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("What number would you like to end with?");
            endNumber = int.Parse(Console.ReadLine());


            for (int i = beginNumber; i <= endNumber; i++) //outer loop
            { }//end outer loop
        }//end method

        //-------------------------------------------------------------------------------------------
        //create a method that finds the largest number in an integer array (9/13-1)
        public static void LargestNumInArray()
        {
            int[] numArray = { 34, -2, 2, 490, -490, 0 };
            //set initial value to first value of array 
            int biggestNum = numArray[0];

            for (int i = 0; i < numArray.Length - 1; i++)
            {
                if (numArray[i] > biggestNum)
                {
                    biggestNum = numArray[i];
                }
            }
            Console.WriteLine("Largest number in the array is: " + biggestNum);
        }

        //-------------------------------------------------------------------------------------------
        public static void IsItAPalindrome()
        {
            Console.WriteLine("This program checks whether a word is a palindrome.");
            Console.WriteLine("Please enter a word with no spaces or punctuation.");
            string startingString = Console.ReadLine();
            char[] charArrayToCheck = startingString.ToLower().ToCharArray();
            bool isPalindrome = true;

            //checks the first letter with the last and moves forward/backward each iteration

            for (int i = 0; i <= 0.5 * (charArrayToCheck.Length - 1); i++)
            {
                Console.WriteLine(charArrayToCheck[i]);
                Console.WriteLine(charArrayToCheck[charArrayToCheck.Length - 1 - i]);
                if (charArrayToCheck[i] != charArrayToCheck[charArrayToCheck.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }
            if (isPalindrome == true)
            { Console.WriteLine(startingString +" is a palindrome."); }
            else { Console.WriteLine(startingString +" is NOT a palindrome."); }

            ////CHECKING STRINGS WITH SPACES AND PUNCTUATIONconvert string to char array

            //char[] charArrayToCheck = startingString.ToLower().ToCharArray();

            //char forward = charArrayToCheck[0];
            //char backward = charArrayToCheck[charArrayToCheck.Length - 1];

            //for (int i=0; i<=charArrayToCheck.Length - 1;i++)
            //{
            //    //check whether the element is a letter

            //}

        }
        //-------------------------------------------------------------------------------------------
public static void NestedLoops()
        {
            int i = 0;
            int j = 0;

            for(i=0;i<=10;i++)
            {
                for(j=0;j<=5;j++)
                {
                    int k = i * j;
                    Console.WriteLine("i = "+i+"  j = "+j+"   i*j = "+k);
                }
            }
        }
        //-------------------------------------------------------------------------------------------

        //Tech interview question
        //what is the difference between an Array and a List?

        //-------------------------------------------------------------------------------------------
        //Tech interview question
        //difference between reference types and value types
        //stacks vs heaps
        //reference types are pointers to data located on the heap
        //C# does the garbage collection for us - other languauges you have to reallocate space

        //-------------------------------------------------------------------------------------------
        //Tech interview question
        //stringbuilder - how does it work?

        //-------------------------------------------------------------------------------------------

        ///////////////////////////////////do not erase curly brackets below this /////////////
    }
}
