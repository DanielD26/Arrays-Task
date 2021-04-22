using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Enter 5 Names");
            // Console.WriteLine("Enter First Name: ");
            // string Name1 = Console.ReadLine();
            // Console.WriteLine("Enter Second Name: ");
            // string Name2 = Console.ReadLine();
            // Console.WriteLine("Enter Third Name: ");
            // string Name3 = Console.ReadLine();
            // Console.WriteLine("Enter Fourth Name: ");
            // string Name4 = Console.ReadLine();
            // Console.WriteLine("Enter Fifth Name: ");
            // string Name5 = Console.ReadLine();
            // string[] names = {Name1, Name2, Name3, Name4, Name5};

            // Console.WriteLine("Hello " + names[0]);
            // Console.WriteLine("Hello " + names[1]);
            // Console.WriteLine("Hello " + names[2]);
            // Console.WriteLine("Hello " + names[3]);
            // Console.WriteLine("Hello " + names[4]);

            // int[] numbers = {34, 5, 67, 1, 99, 34, 44, 78, 34, 0};
            // Console.WriteLine("Adding all numbers: ");
            // int sum = numbers.Sum();
            // Console.WriteLine(sum);



            // List<int> numbers= new List<int>();
            // Console.WriteLine("Enter 5 Numbers: ");
            // Console.WriteLine("Enter First Number: ");
            // string getNum1 = Console.ReadLine();
            // int num1 = int.Parse(getNum1);
            // Console.WriteLine("Enter Second Number: ");
            // string getNum2 = Console.ReadLine();
            // int num2 = int.Parse(getNum2);
            // Console.WriteLine("Enter Third Number: ");
            // string getNum3 = Console.ReadLine();
            // int num3 = int.Parse(getNum3);
            // Console.WriteLine("Enter Fourth Number: ");
            // string getNum4 = Console.ReadLine();
            // int num4 = int.Parse(getNum4);
            // Console.WriteLine("Enter Fifth Number: ");
            // string getNum5 = Console.ReadLine();
            // int num5 = int.Parse(getNum5);
            // numbers.Add(num1);
            // numbers.Add(num2);
            // numbers.Add(num3);
            // numbers.Add(num4);
            // numbers.Add(num5);
            // Console.WriteLine("Enter another Number: ");
            // string getNum6 = Console.ReadLine();
            // int num6 = int.Parse(getNum6);
            // if (numbers.Contains(num6)) {
            //     Console.WriteLine("Number already added");
            // }

            // List<int> numbers= new List<int>();
            // Console.WriteLine("Enter 5 Numbers: ");
            // Console.WriteLine("Enter First Number: ");
            // string getNum1 = Console.ReadLine();
            // int num1 = int.Parse(getNum1);
            // Console.WriteLine("Enter Second Number: ");
            // string getNum2 = Console.ReadLine();
            // int num2 = int.Parse(getNum2);
            // Console.WriteLine("Enter Third Number: ");
            // string getNum3 = Console.ReadLine();
            // int num3 = int.Parse(getNum3);
            // Console.WriteLine("Enter Fourth Number: ");
            // string getNum4 = Console.ReadLine();
            // int num4 = int.Parse(getNum4);
            // Console.WriteLine("Enter Fifth Number: ");
            // string getNum5 = Console.ReadLine();
            // int num5 = int.Parse(getNum5);
            // numbers.Add(num1);
            // numbers.Add(num2);
            // numbers.Add(num3);
            // numbers.Add(num4);
            // numbers.Add(num5);
            // Console.WriteLine("Enter another Number: ");
            // string getNum6 = Console.ReadLine();
            // int num6 = int.Parse(getNum6);
            // if (numbers.Contains(num6)) {
            //     var repeatNum = numbers.Count(s => s == num6);
            //     Console.WriteLine (num6 + " has been repeated " + repeatNum + " times");
            // }

            List<string> words = new List<string>();
            Console.WriteLine("Add new word: ");
            string newWord = Console.ReadLine();
            words.Add(newWord);
            while (words.Contains("stop") == false) {
                Console.WriteLine("Add new word: ");
                newWord = Console.ReadLine();
                words.Add(newWord);

                if (words.Contains("stop")) {
                    break;
                }
            }
            words.Reverse();
            Console.WriteLine();
            words.ForEach(Console.WriteLine);
                
            

        }
    }
}
