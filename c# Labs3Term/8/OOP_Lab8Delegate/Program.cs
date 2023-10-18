using System;
using OOP_Lab8Delegate;
using static OOP_Lab8Delegate.Servise;
using static OOP_Lab8Delegate.StringOperation;

namespace OOP_Lab8Delegate
{
    public class Program
    {
        public static void Main()
        {
            int answer;
            bool flag = true;
            while (flag)
            {
                answer = Convert.ToInt32(Console.ReadLine());

                switch (answer)
                {
                    case 1:
                        {
                            Console.Clear();
                            Game game = new Game();

                            GameObject player1 = new GameObject("Player 1", 100);
                            GameObject player2 = new GameObject("Player 2", 120);

                            game.Attack += damage => player1.HandleAttack(damage);
                            game.Attack += damage => player2.HandleAttack(damage);
                            game.Heal += healing => player1.HandleHeal(healing);
                            game.Heal += healing => player2.HandleHeal(healing);

                            game.TriggerAttack(20);
                            game.TriggerHeal(10);

                            Console.WriteLine($"{player1.Name}: Health = {player1.Health}");
                            Console.WriteLine($"{player2.Name}: Health = {player2.Health}");
                            break;
                        }
                        case 2:
                        {
                            Console.Clear();
                            string inputString = "Hello, World!";
                            Console.WriteLine("Original String: " + inputString);

                            ProcessString(inputString, s => Console.WriteLine("Without Punctuation: " + RemovePunctuation(s)));

                            ProcessString(inputString, s => Console.WriteLine("With Added Symbol: " + AddSymbol(s, '*')));

                            Console.WriteLine("Uppercase: " + ProcessStringFunc(inputString, ConvertToUppercase));

                            Console.WriteLine("Without Extra Spaces: " + ProcessStringFunc(inputString, RemoveExtraSpaces));

                            Console.WriteLine("Reversed String: " + ProcessStringFunc(inputString, ReverseString));

                            bool containsHello = CheckString(inputString, s => s.Contains("Hello"));
                            Console.WriteLine("Contains 'Hello': " + containsHello);
                            break;
                        }
                    case 3:
                        {
                            flag = false;
                            break;
                        }
                }
            }
            


        }
    }
}

