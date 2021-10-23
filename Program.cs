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

            bool playing, answered = false;
            do
            {
                Console.WriteLine("Would you like to play a game? yes/no");
                var answer = Console.ReadLine();

                if (answer == "yes" || answer == "Yes")
                {
                    playing = true;
                    answered = true;
                    // proceed with game
                    Console.WriteLine("Question: What is your favorite number?");
                    var favoriteNumber = Console.ReadLine();
                    Console.WriteLine("I will remember that your favorite number is {0}", favoriteNumber);
                    Console.WriteLine("Question: What is your favorite movie?");
                    var favoriteMovie = Console.ReadLine();
                    Console.WriteLine("{0} is a great movie! Especially that part where.. well, you know.", favoriteMovie);
                }
                else if (answer == "no" || answer == "No")
                {
                    Console.WriteLine("Very well, perhaps next time!");
                    playing = true;
                    answered = false;
                }
                else
                {
                    playing = false;
                    Console.WriteLine("Please reply with 'Yes' or 'No' (Without quotations)");
                }
            } while (!playing && !answered); // if the player has not answered Yes or No
            


            // Exit Program
            Console.WriteLine("\n\nThanks for playing!\nPress Any Key to Exit");
            Console.ReadLine();
        }
    }
}
