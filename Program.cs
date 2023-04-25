// 13 варіант
// Дано речення. Надрукувати слова, що починаються з літери «_», яка вводиться з клавіатури.

using System;


namespace Project_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть речення: ");
            string sentence = Console.ReadLine();

            Console.Write("Введiть лiтеру: ");
            char letter = Console.ReadKey().KeyChar;
            Console.WriteLine();

            string[] words = sentence.Split(' ');  // розділяємо речення на слова

            Console.WriteLine("Слова, що починаються з лiтери '{0}':", letter);
            foreach (string word in words)
            {
                if (word.StartsWith(letter.ToString(), StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
