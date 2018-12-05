using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinchAPI;

namespace CapstoneProject
{
    class Program
    {

        // Title: Finch Light, Movement, and Sound Show
        // Application Type: (framework - Console)
        // Description: Finch light, movement, and sound show
        // Author: Connor Rieck
        // Date Created: 11/30/18
        // Last Modified: 12/5/18

        static void Main(string[] args)
        {
            // calling my welcome screen
            // clearing the screen
            // displaying my menu
                  
            DisplayWelcomeScreen();
            Console.Clear();
            DisplayMenu();

        }

        // Displaying menu
        static void DisplayMenu()
        {
            string decision;
            Console.WriteLine();
            Console.WriteLine("MENU");
            Console.WriteLine();
            Console.WriteLine("Type USA for a patriotic light and movement show");
            Console.WriteLine("Type RAINBOW for a rainbow light and movement show");
            Console.WriteLine("Type SURPRISE for a surprise light and movement show");
            Console.WriteLine("Type 'QUIT' to quit");
            Console.WriteLine();
            decision = Console.ReadLine().ToUpper();

            // users type the show they want or quit
            // once the users type this, the switch statement will call the required method

            Finch cappy = new Finch();
            cappy.connect();

            switch (decision)
            {
               
                case "USA":

                    DisplayPatrioticShow(cappy);

                    break;

                case "RAINBOW":

                    DisplayRainbowShow(cappy);

                    break;

                case "SURPRISE":

                    DisplaySurpriseShow(cappy);

                    break;

                case "QUIT":

                    DisplayClosingScreen();
                    cappy.disConnect();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Please enter a correct value.");                   
                    DisplayMenu();
                    break;

                    // if the users type something the code will not accept, it will clear the screen and tell the user to enter a correct value
            }
        }

        static void DisplaySurpriseShow(Finch cappy)
        {
            Console.WriteLine("You Chose the Surprise Show!");

            Console.WriteLine("Press any key to begin the show!");
            Console.ReadKey();

            cappy.noteOn(500);
            cappy.wait(500);
            cappy.noteOff();

            // finch is moving backwards and forward

            cappy.setLED(0, 255, 0);
            cappy.setMotors(255, 0);
            cappy.wait(1000);
            cappy.setMotors(255, 255);
            cappy.setMotors(0, 255);
            cappy.wait(1000);
            cappy.setMotors(255, 255);
            cappy.setMotors(255, 0);
            cappy.wait(1000);
            cappy.setMotors(0, 0);

            cappy.setLED(255, 0, 0);
            cappy.setMotors(-255, 0);
            cappy.wait(1000);
            cappy.setMotors(-255, -255);
            cappy.wait(1000);
            cappy.setMotors(0, -255);
            cappy.wait(1000);
            cappy.setMotors(-255, -255);
            cappy.setMotors(-255, 0);
            cappy.wait(1000);
            cappy.setMotors(0, 0);

            Console.Clear();
            DisplayMenu();

        }

        static void DisplayColors(Finch cappy)
        {
            // rainbow

            cappy.setLED(255, 0, 0);
            cappy.wait(50);
            cappy.setLED(0, 255, 0);
            cappy.wait(50);
            cappy.setLED(0, 0, 255);
            cappy.wait(50);
            cappy.setLED(255, 0, 0);
            cappy.wait(50);
            cappy.setLED(0, 255, 0);
            cappy.wait(50);
            cappy.setLED(0, 0, 255);
            cappy.wait(50);
            cappy.setLED(255, 0, 0);
            cappy.wait(50);
            cappy.setLED(0, 255, 0);
            cappy.wait(50);
            cappy.setLED(0, 0, 255);
            cappy.wait(50);
            cappy.setLED(255, 0, 0);
            cappy.wait(50);
            cappy.setLED(0, 255, 0);
            cappy.wait(50);
            cappy.setLED(0, 0, 255);
            cappy.wait(50);
            cappy.setLED(255, 0, 0);
            cappy.wait(50);
            cappy.setLED(0, 255, 0);
            cappy.wait(50);
            cappy.setLED(0, 0, 255);
            cappy.wait(50);
            cappy.setLED(255, 0, 0);
            cappy.wait(50);
            cappy.setLED(0, 255, 0);
            cappy.wait(50);
            cappy.setLED(0, 0, 255);
            cappy.wait(50);
            cappy.setLED(255, 0, 0);
            cappy.wait(50);
            cappy.setLED(0, 255, 0);
            cappy.wait(50);
            cappy.setLED(0, 0, 255);
            cappy.wait(50);
            cappy.setLED(255, 0, 0);
            cappy.wait(50);
            cappy.setLED(0, 255, 0);
            cappy.wait(50);
            cappy.setLED(0, 0, 255);
            cappy.wait(50);
            cappy.setLED(255, 0, 0);
            cappy.wait(50);
            cappy.setLED(0, 255, 0);
            cappy.wait(50);
            cappy.setLED(0, 0, 255);
            cappy.wait(50);
            cappy.setLED(255, 0, 0);
            cappy.wait(50);
            cappy.setLED(0, 255, 0);
            cappy.wait(50);
            cappy.setLED(0, 0, 255);
            cappy.wait(50);
            cappy.setLED(255, 0, 0);
            cappy.wait(50);
            cappy.setLED(0, 255, 0);
            cappy.wait(50);
            cappy.setLED(0, 0, 255);
            cappy.wait(50);
            cappy.setLED(255, 0, 0);
            cappy.wait(50);
            cappy.setLED(0, 255, 0);
            cappy.wait(50);
            cappy.setLED(0, 0, 255);
            cappy.wait(50);
            cappy.setLED(255, 0, 0);
            cappy.wait(50);
            cappy.setLED(0, 255, 0);
            cappy.wait(50);
            cappy.setLED(0, 0, 255);
            cappy.wait(50);
            cappy.setLED(255, 0, 0);
            cappy.wait(50);
            cappy.setLED(0, 255, 0);
            cappy.wait(50);
            cappy.setLED(0, 0, 255);
            cappy.wait(50);
            cappy.setLED(255, 0, 0);
            cappy.wait(50);
            cappy.setLED(0, 255, 0);
            cappy.wait(50);
            cappy.setLED(0, 0, 255);
            cappy.wait(50);
            cappy.setLED(255, 0, 0);
            cappy.wait(50);
            cappy.setLED(0, 255, 0);
            cappy.wait(50);
            cappy.setLED(0, 0, 255);
            cappy.wait(50);

        }

        static void DisplayRainbowShow(Finch cappy)
        {
            Console.WriteLine("You Chose the Rainbow Show!");

            Console.WriteLine("Press any key to begin the show!");
            Console.ReadKey();

            cappy.noteOn(1000);
            cappy.wait(500);
            cappy.noteOff();

            DisplayColors(cappy);

            // finch is moving in a square shape

            cappy.setMotors(255, 255);      
            cappy.wait(3000);
            cappy.setMotors(255, 0);
            cappy.wait(500);
            cappy.setMotors(255, 255);           
            cappy.wait(3000);
            cappy.setMotors(255, 0);            
            cappy.wait(500);
            cappy.setMotors(255, 255);    
            cappy.wait(3000);
            cappy.setMotors(255, 0);        
            cappy.wait(500);
            cappy.setMotors(255, 255);
            cappy.wait(3000);

            DisplayColors(cappy);

            // rainbow

            Console.Clear();
            DisplayMenu();
        }

        static void DisplayPatrioticShow(Finch cappy)
        {
            Console.WriteLine("You Chose the Patriotic Show!");

            Console.WriteLine("Press any key to begin the show!");
            Console.ReadKey();

            cappy.noteOn(1500);
            cappy.wait(500);

            // star spangled banner (really bad)

            cappy.noteOn(784);
            cappy.wait(1200);
            cappy.noteOn(659);            
            cappy.wait(1000);
            cappy.wait(600);
            cappy.noteOn(523);
            cappy.wait(1200);
            cappy.noteOn(659);
            cappy.wait(1200);
            cappy.noteOn(784);
            cappy.wait(1200);
            cappy.noteOn(523);
            cappy.wait(2400);
            cappy.noteOn(659);
            cappy.wait(1200);
            cappy.noteOn(587);
            cappy.wait(600);
            cappy.noteOn(523);
            cappy.wait(1200);
            cappy.noteOn(659);
            cappy.wait(1200);
            cappy.noteOn(698);
            cappy.wait(1200);
            cappy.noteOn(784);
            cappy.wait(1500);
            cappy.noteOff();
            Console.WriteLine("You no longer have to listen to my sad attempt on the Star Spangled Banner! Yay! Onto the lights... ");
            Console.WriteLine("I'm pretty sure you know what colors they are.");

            // red, white, and blue

            cappy.setLED(255, 0, 0);
            cappy.wait(1000);
            cappy.setLED(255, 255, 255);
            cappy.wait(1000);
            cappy.setLED(0, 0, 255);           
            cappy.wait(1000);
            cappy.setLED(255, 0, 0);
            cappy.wait(1000);
            cappy.setLED(255, 255, 255);
            cappy.wait(1000);
            cappy.setLED(0, 0, 255);
            cappy.wait(1000);
            cappy.setLED(255, 0, 0);
            cappy.wait(1000);
            cappy.setLED(255, 255, 255);
            cappy.wait(1000);
            cappy.setLED(0, 0, 255);
            cappy.wait(1000);
            cappy.setLED(0, 0, 0);

            Console.Clear();
            DisplayMenu();
        }

        static void DisplayWelcomeScreen()
        {
            Console.Clear();
            Console.WriteLine("tWelcome to my Capstone Project using the Finch!");
            DisplayContinuePrompt();
        }

        static void DisplayClosingScreen()
        {
            Console.Clear();
            Console.WriteLine("Thank you for using my program");
            DisplayContinuePrompt();
        }

        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
