using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace Snake
{
    
    class evertimeField
    {
        const int size = 20;
        private static char[,] field = new char[size, size];
        


        public void DrawField(ref int locationBY, ref int locationBX)
        {
            for (int j = 0; j < size; j++)
            {
                field[j, size - 1] = '\u2503';
                field[j, 0] = '\u2503';
                field[size - 1, j] = '\u2501';
            }
            field[size - 1, 0] = '\u2517';
            field[size - 1, size - 1] = '\u251b';

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(field[i, j]);
                }
                Console.Write("\n");
            }
            Console.SetCursorPosition(31, 0);
            Console.Write("Счет:");
            Console.SetCursorPosition(0, 29);
            Console.Write("Управление на WASD, выход ESC");
            AddBonus.Bonus(ref locationBY, ref locationBX);
        }
    }
}