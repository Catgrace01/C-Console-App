using System;
using System.Text;
using System.Collections;
using static System.Console;

namespace ConsoleProgram{
    class Menu{
        static void Main(){
            bool printMenu = true;
            while(printMenu){
               printMenu = MainMenu(); 
            }
        }
        private static bool MainMenu(){
            string confirm;

            WriteLine("Welcome to my C# Console Program!");
            WriteLine("---------------------------------");
            WriteLine("Type in one of the following numbers for a program.");
            WriteLine("1 for a greeting program.");
            WriteLine("2 for a rectangle area calculator.");
            WriteLine("3 for a miles-per-gallon calculator.");
            WriteLine("4 for a string finder.");
            WriteLine("5 to exit the menu.");

            WriteLine("Type here:");
            confirm = ReadLine();
            
            switch(confirm){
                case "1":
                    Greetings();
                    return true;
                    break;
                case "2":
                    AreaCalculator();
                    return true;
                    break;
                case "3":
                    MilesPerGallon();
                    return true;
                    break;
                case "4":
                    AliceString();
                    return true;
                    break;
                case "5":
                    return false;
                    break;
                default:
                    WriteLine("Please try again");
                    return true;
                    break;
            }
        }
        private static void Greetings(){
            Clear();
            string fullName;

            WriteLine("Please enter your full name: ");
            fullName = ReadLine();
            WriteLine("Hello, " + fullName + "!");
        }
        private static void AreaCalculator(){
            Clear();
            double width = 0;
            double length = 0;
            double area = width * length;
            string inputW;
            string inputL;

            WriteLine("What is your rectangle's width?: ");
            inputW = ReadLine();
            width = Convert.ToDouble(inputW);
            WriteLine("What is your rectangle's length?: ");
            inputL = ReadLine();
            length = Convert.ToDouble(inputL);
            area = width * length;

            WriteLine("The rectangle's area is " + area);
        }
        private static void MilesPerGallon(){
            Clear();
            int milesDriven;
            int gallonsUsed;
            int MPG;
            string inputMiles;
            string inputGallons;

            WriteLine("How many miles have you driven?: ");
            inputMiles = ReadLine();
            milesDriven = Convert.ToInt32(inputMiles);
            WriteLine("How many gallons of gas were used?: ");
            inputGallons = ReadLine();
            gallonsUsed = Convert.ToInt32(inputGallons);
            MPG = milesDriven / gallonsUsed;
            
            WriteLine("Your MPG is: " + MPG);
        }
        private static void AliceString(){
            Clear();
            string aliceQuote = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            string inputString;

            WriteLine(aliceQuote);
            WriteLine("-------------------------------------");
            WriteLine("What word are you looking for?: ");
            inputString = ReadLine();
            int index = aliceQuote.IndexOf(inputString, StringComparison.CurrentCultureIgnoreCase);
            
            if(index == 0){
              WriteLine("True! That string is in the quote.");
            }
            else if(index == -1){
              WriteLine("False! That string is not in the quote.");
            }
        }
    }
}