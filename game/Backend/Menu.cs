using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace game.Backend
{
    internal class Menu
    {
        internal void Splash()
        {
            Console.WriteLine("Welcome to The Legend of Zerua");
            Console.WriteLine("Press any key to continue...");
            Console.Read();
            MainMenu();
        }

        private void MainMenu()
        {
            Console.WriteLine("T H E   L E G E N D   O F   Z E R U A");
            Console.WriteLine("Make a selection:\n" +
                "1. New Game\n" +
                "2. Continue\n" +
                "3. Load\n" +
                "4. Options\n" +
                "5. Quit\n");
            var choice = Console.ReadKey().Key;
            var successfulInput = MenuSelection(choice);
            do
            {
                Console.WriteLine("Input not recognized.  Please make a valid selection.");
                choice = Console.ReadKey().Key;
                successfulInput = MenuSelection(choice);
            } while (!successfulInput);
        }

        private bool MenuSelection(ConsoleKey choiceKey)
        {
            if (choiceKey == ConsoleKey.D1 || choiceKey == ConsoleKey.NumPad1)
            {
                NewGame();
            } else if(choiceKey == ConsoleKey.D2 || choiceKey == ConsoleKey.NumPad2)
            {
                ContinueGame();
            } else if(choiceKey == ConsoleKey.D3 || choiceKey == ConsoleKey.NumPad3)
            {
                LoadGame();
            } else if(choiceKey == ConsoleKey.D4 || choiceKey == ConsoleKey.NumPad4)
            {
                OptionsMenu();
            } else if(choiceKey == ConsoleKey.D5 || choiceKey == ConsoleKey.NumPad5)
            {
                Quit();
            }
            else
            {
                return false;
            }
            return true;
        }

        private void NewGame()
        {

        }

        private void ContinueGame()
        {

        }

        private void LoadGame()
        {

        }

        private void OptionsMenu()
        {

        }

        private void Quit()
        {
            Console.WriteLine("Do you want to exit? (y/n)");
            var choice = Console.ReadKey().Key;
            if(choice == ConsoleKey.Y)
            {
                Environment.Exit(0);
            } else if (choice == ConsoleKey.N)
            {
                MainMenu();
            }
            else
            {
                Console.WriteLine("Input not recognized.  Returning to main menu...");
                Thread.Sleep(3000);
                MainMenu();
            }
        }
    }
}
