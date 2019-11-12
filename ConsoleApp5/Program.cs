using ConsoleApp5;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;


namespace Snake
{
    class Program
    {
        static int locationBX;
        static int locationBY;

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.OutputEncoding = Encoding.UTF8;
            for (; ; )
            {
                bool exit = StartMenu();
                if (exit == false)
                    break;
                evertimeField field = new evertimeField();
                field.DrawField(ref locationBY, ref locationBX);
                Input input = new Input();
                bool shouldExit;
                do
                {
                    shouldExit = input.GetInput(ref locationBY, ref locationBX);
                } while (!shouldExit);
                GameOver();
                Console.ReadKey();
                Console.Clear();
            }

        }

        static bool StartMenu()
        {
            int n = 13;
            Console.SetCursorPosition(58, n);
            Console.WriteLine("Начать");
            Console.SetCursorPosition(58, n+1);
            Console.Write("Выход");
            bool out_to_algoritm = true;
            while (out_to_algoritm) { 
                Console.SetCursorPosition(65, n);
                Console.Write('\u2190');
                Console.SetCursorPosition(65, n);
                ConsoleKey key= ConsoleKey.Escape;
                if (Console.KeyAvailable)
                {
                    key = Console.ReadKey(true).Key;
                }
                switch (key)
                {
                    case ConsoleKey.S:
                        n++;
                        Console.Write('\0');
                        break;
                    case ConsoleKey.W:
                        n--;
                        Console.Write('\0');
                        break;
                    case ConsoleKey.Enter:
                        out_to_algoritm = false;
                        break;
                    default:
                        break;
                }               
                if (n < 13)
                    n = 13;
                else if (n > 14)
                    n = 14;                               
            }
            Console.Clear();
            if (n == 13)
                return true;
            else
                return false;
        }

        static void GameOver()
        {
            Console.Clear();
            char symbol = '\u23F9';
            int n = 40;
            char[,] writeGameOver = new char[30, 81];
            writeGameOver[10, 1 + n] = symbol;
            writeGameOver[10, 2 + n] = symbol;
            writeGameOver[10, 3 + n] = symbol;
            writeGameOver[10, 6 + n] = symbol;
            writeGameOver[10, 7 + n] = symbol;
            writeGameOver[10, 10 + n] = symbol;
            writeGameOver[10, 14 + n] = symbol;
            writeGameOver[10, 16 + n] = symbol;
            writeGameOver[10, 17 + n] = symbol;
            writeGameOver[10, 18 + n] = symbol;
            writeGameOver[10, 19 + n] = symbol;
            writeGameOver[10, 22 + n] = symbol;
            writeGameOver[10, 23 + n] = symbol;
            writeGameOver[10, 26 + n] = symbol;
            writeGameOver[10, 30 + n] = symbol;
            writeGameOver[10, 32 + n] = symbol;
            writeGameOver[10, 33 + n] = symbol;
            writeGameOver[10, 34 + n] = symbol;
            writeGameOver[10, 35 + n] = symbol;
            writeGameOver[10, 37 + n] = symbol;
            writeGameOver[10, 38 + n] = symbol;
            writeGameOver[10, 39 + n] = symbol;
            writeGameOver[11, 0 + n] = symbol;
            writeGameOver[11, 5 + n] = symbol;
            writeGameOver[11, 8 + n] = symbol;
            writeGameOver[11, 10 + n] = symbol;
            writeGameOver[11, 11 + n] = symbol;
            writeGameOver[11, 13 + n] = symbol;
            writeGameOver[11, 14 + n] = symbol;
            writeGameOver[11, 16 + n] = symbol;
            writeGameOver[11, 21 + n] = symbol;
            writeGameOver[11, 24 + n] = symbol;
            writeGameOver[11, 26 + n] = symbol;
            writeGameOver[11, 30 + n] = symbol;
            writeGameOver[11, 32 + n] = symbol;
            writeGameOver[11, 37 + n] = symbol;
            writeGameOver[11, 40 + n] = symbol;
            writeGameOver[12, 0 + n] = symbol;
            writeGameOver[12, 2 + n] = symbol;
            writeGameOver[12, 3 + n] = symbol;
            writeGameOver[12, 5 + n] = symbol;
            writeGameOver[12, 6 + n] = symbol;
            writeGameOver[12, 7 + n] = symbol;
            writeGameOver[12, 8 + n] = symbol;
            writeGameOver[12, 10 + n] = symbol;
            writeGameOver[12, 12 + n] = symbol;
            writeGameOver[12, 14 + n] = symbol;
            writeGameOver[12, 16 + n] = symbol;
            writeGameOver[12, 17 + n] = symbol;
            writeGameOver[12, 18 + n] = symbol;
            writeGameOver[12, 21 + n] = symbol;
            writeGameOver[12, 24 + n] = symbol;
            writeGameOver[12, 26 + n] = symbol;
            writeGameOver[12, 30 + n] = symbol;
            writeGameOver[12, 32 + n] = symbol;
            writeGameOver[12, 33 + n] = symbol;
            writeGameOver[12, 34 + n] = symbol;
            writeGameOver[12, 37 + n] = symbol;
            writeGameOver[12, 38 + n] = symbol;
            writeGameOver[12, 39 + n] = symbol;
            writeGameOver[12, 40 + n] = symbol;
            writeGameOver[13, 0 + n] = symbol;
            writeGameOver[13, 3 + n] = symbol;
            writeGameOver[13, 5 + n] = symbol;
            writeGameOver[13, 8 + n] = symbol;
            writeGameOver[13, 10 + n] = symbol;
            writeGameOver[13, 14 + n] = symbol;
            writeGameOver[13, 16 + n] = symbol;
            writeGameOver[13, 21 + n] = symbol;
            writeGameOver[13, 24 + n] = symbol;
            writeGameOver[13, 27 + n] = symbol;
            writeGameOver[13, 29 + n] = symbol;
            writeGameOver[13, 32 + n] = symbol;
            writeGameOver[13, 37 + n] = symbol;
            writeGameOver[13, 39 + n] = symbol;
            writeGameOver[14, 1 + n] = symbol;
            writeGameOver[14, 2 + n] = symbol;
            writeGameOver[14, 3 + n] = symbol;
            writeGameOver[14, 5 + n] = symbol;
            writeGameOver[14, 8 + n] = symbol;
            writeGameOver[14, 10 + n] = symbol;
            writeGameOver[14, 14 + n] = symbol;
            writeGameOver[14, 16 + n] = symbol;
            writeGameOver[14, 17 + n] = symbol;
            writeGameOver[14, 18 + n] = symbol;
            writeGameOver[14, 19 + n] = symbol;
            writeGameOver[14, 22 + n] = symbol;
            writeGameOver[14, 23 + n] = symbol;
            writeGameOver[14, 28 + n] = symbol;
            writeGameOver[14, 32 + n] = symbol;
            writeGameOver[14, 33 + n] = symbol;
            writeGameOver[14, 34 + n] = symbol;
            writeGameOver[14, 35 + n] = symbol;
            writeGameOver[14, 37 + n] = symbol;
            writeGameOver[14, 40 + n] = symbol;
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 81; j++)
                {
                    Console.Write(writeGameOver[i, j]);
                }
                Console.WriteLine();
            }
            Console.SetCursorPosition(58, 16);
            Console.WriteLine("Ваш счет: " + Input.account);
            Console.SetCursorPosition(58, 17);
            Console.WriteLine("Рекорд: " + File.ReadAllText("score.txt"));
            string score = File.ReadAllText("score.txt");
            if (Input.account > Convert.ToInt32(score))
            {
                Console.SetCursorPosition(58, 17);
                Console.WriteLine("ваш старый рекорд: " + File.ReadAllText("score.txt"));
                using (var f = new StreamWriter("score.txt"))
                {
                    f.Write(Input.account);
                }
                
            }
            Input.account = 0;
        }
    }
}
