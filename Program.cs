using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("Welcome, {0}", name);

            int operation;
            do
            {
                Console.WriteLine("Select type of operation:\n" +
                    "[1] Addition\n" +
                    "[2] Subtraction\n" +
                    "[3] Multiplication\n" +
                    "[4] Division\n" +
                    "[5] Square Root\n" +
                    "[6] Exit Program");
                operation = Int32.Parse(Console.ReadLine());
                if (operation == 1)
                {
                    int thirdAddNum, calculateAddition;
                    Console.WriteLine("Enter first number to add:");
                    var firstAddNum = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second number to add:");
                    var secondAddNum = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Do you want to add another number to the operation? [Y] / [N]");
                    var thirdAddNumOption = Console.ReadLine();
                    switch (thirdAddNumOption)
                    {
                        case "Y":
                            Console.WriteLine("Enter third number to add:");
                            thirdAddNum = Int32.Parse(Console.ReadLine());
                            calculateAddition = firstAddNum + secondAddNum + thirdAddNum;
                            Console.WriteLine("Calculating operation: {0} + {1} + {2}:\nANSWER: {3}\n", firstAddNum, secondAddNum, thirdAddNum, calculateAddition);
                            break;
                        case "N":
                            calculateAddition = firstAddNum + secondAddNum;
                            Console.WriteLine("Calculating operation: {0} + {1}:\nANSWER: {2}\n", firstAddNum, secondAddNum, calculateAddition);
                            break;
                        default:
                            Console.WriteLine("Please enter [Y] or [N]");
                            break;
                    }
                } else if (operation == 2)
                {
                    int thirdSubNum, calculateSubtraction;
                    Console.WriteLine("Enter first number to subtract:");
                    var firstSubNum = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second number to subtract:");
                    var secondSubNum = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Do you want to subtract another number to the operation? [Y] / [N]");
                    var thirdSubNumOption = Console.ReadLine();
                    switch (thirdSubNumOption)
                    {
                        case "Y":
                            Console.WriteLine("Enter third number to subtract:");
                            thirdSubNum = Int32.Parse(Console.ReadLine());
                            calculateSubtraction = firstSubNum + secondSubNum + thirdSubNum;
                            Console.WriteLine("Calculating operation: {0} - {1} - {2}:\nANSWER: {3}\n", firstSubNum, secondSubNum, thirdSubNum, calculateSubtraction);
                            break;
                        case "N":
                            calculateSubtraction = firstSubNum - secondSubNum;
                            Console.WriteLine("Calculating operation: {0} - {1}:\nANSWER: {2}\n", firstSubNum, secondSubNum, calculateSubtraction);
                            break;
                        default:
                            Console.WriteLine("Please enter [Y] or [N]");
                            break;
                    }
                }
                else if (operation == 3)
                {
                    int thirdMultNum, calculateMultiplication;
                    Console.WriteLine("Enter first number to multiply:");
                    var firstMultNum = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second number to multiply:");
                    var secondMultNum = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Do you want to multiply another number to the operation? [Y] / [N]");
                    var thirdMultNumOption = Console.ReadLine();
                    switch (thirdMultNumOption)
                    {
                        case "Y":
                            Console.WriteLine("Enter third number to multiply:");
                            thirdMultNum = Int32.Parse(Console.ReadLine());
                            calculateMultiplication = firstMultNum + secondMultNum + thirdMultNum;
                            Console.WriteLine("Calculating operation: {0} x {1} x {2}:\nANSWER: {3}\n", firstMultNum, secondMultNum, thirdMultNum, calculateMultiplication);
                            break;
                        case "N":
                            calculateMultiplication = firstMultNum - secondMultNum;
                            Console.WriteLine("Calculating operation: {0} x {1}:\nANSWER: {2}\n", firstMultNum, secondMultNum, calculateMultiplication);
                            break;
                        default:
                            Console.WriteLine("Please enter [Y] or [N]");
                            break;
                    }
                }
                else if (operation == 4)
                {
                    int calculateDivision;
                    Console.WriteLine("Enter first number to divide:");
                    var firstDivNum = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second number to divide:");
                    var secondDivNum = Int32.Parse(Console.ReadLine());
                    calculateDivision = firstDivNum - secondDivNum;
                    Console.WriteLine("Calculating operation: {0} x {1}:\nANSWER: {2}\n", firstDivNum, secondDivNum, calculateDivision);
                }
                else if (operation == 5)
                {
                    int calculateSquareRoot;
                    Console.WriteLine("Enter first number:");
                    var firstSqRt = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second number:");
                    var secondSqRt = Int32.Parse(Console.ReadLine());
                    calculateSquareRoot = (firstSqRt * secondSqRt) / 144;
                    Console.WriteLine("Calculating operation: ({0} x {1}) / 144:\nANSWER: {2}\n", firstSqRt, secondSqRt, calculateSquareRoot);
                }
            } while (operation < 6); // 6 = Exit Program
            


            // Exit Program
            Console.WriteLine("\n\nHappy Learning!\nPress Any Key to Close Program");
            Console.ReadLine();
        }
    }
}
