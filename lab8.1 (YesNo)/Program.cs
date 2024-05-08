using System;

namespace lab8._1__YesNo_
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Random random = new Random();
            double yesProb = 0.5;
            Console.WriteLine("Нажмите Enter чтобы получить ДА или НЕТ.");
            Console.WriteLine("Нажмите \"p\" чтобы задать вероятность ответа ДА. По умолчанию 0.5");
            Console.WriteLine("Нажмите ESC для закрытия программы.");
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.Enter:
                        // Генерация случайного числа для определения ответа "ДА" или "НЕТ"
                        double randomNumber = random.NextDouble(); // Случайное число 0 или 1
                        string answer = (yesProb > randomNumber) ? "ДА" : "НЕТ"; // Определение ответа
                        Console.WriteLine($"\n{answer}\n"); // Вывод ответа
                        break;

                    case ConsoleKey.P:
                        Console.WriteLine("Введите вероятность ответа ДА: ");
                        while (!double.TryParse(Console.ReadLine(), out yesProb) || yesProb > 1 || yesProb < 0)
                        {
                            Console.WriteLine("Некорректно введённое значение.");
                        }
                        Console.WriteLine($"Установлено значение: {yesProb}");
                        break;
                            
                    case ConsoleKey.Escape:
                        // Закрытие программы при нажатии клавиши ESC
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
