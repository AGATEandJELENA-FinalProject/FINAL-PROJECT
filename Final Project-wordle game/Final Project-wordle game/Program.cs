using System;
using System.Collections.Generic;
using static System.Random;
using System.Text;

namespace Game_Wordle
{

    class Program
    {
        static void Main(string[] args)
        {

            Game wordleGame = new Game();
            wordleGame.Game_Wordle();

        }
    }
    class Game
    {
        public void Game_Wordle()
        {
            Random random = new Random();
            List<string> wordDictionary = new List<string> { "about", "above", "abuse", "actor", "acute", "admit", "adopt" }; 
            int index = random.Next(wordDictionary.Count);
            String randomWord = wordDictionary[index];
            int finito = 0;
            Console.Clear();
            Console.WriteLine("Hello! please enter 5 letters");
            while (finito < 5)
            {
                string input = "";
                Console.ResetColor();

                while (input.Length < 5)
                {
                    char keyChar = Console.ReadKey().KeyChar;

                    if (char.IsLetter(keyChar))
                    {
                        input += keyChar;
                    }
                    else
                    {
                        Console.WriteLine("You stupid. 5 letters");
                        finito++;
                        break;
                    }
                }
                Console.WriteLine();

                if (input.Length == 5)
                {
                    if (input == randomWord)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine(randomWord);
                        Console.ResetColor();
                        Console.WriteLine("You guesed the word -  " + randomWord);
                        finito = 5;
                    }
                    else
                    {
                        finito++;

                        for (int i = 0; i < randomWord.Length; i++)
                        {
                            if (randomWord[i] == input[i])
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.Write(input[i]);
                            }
                            else
                            {
                                if (randomWord.Contains(input[i]))
                                {
                                    Console.BackgroundColor = ConsoleColor.Yellow;
                                    Console.Write(input[i]);
                                }
                                else
                                {
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.Write(input[i]);
                                }
                            }
                            if (i == randomWord.Length - 1)
                            {
                                Console.WriteLine();
                            }
                        }
                        Console.ResetColor();

                    }
                }
            }

            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Word was - " + randomWord);
            Console.WriteLine("Try again. Push ENTER");
            Console.ResetColor();
            Console.ReadLine();
            Game_Wordle();
        }
    }
}


