using System;
using Snake;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snake
{
    enum direction { left,down,right,up}
    class Input
    {
        static int speed = 300;
        static public int account = 0;
        static Queue<int> lengthSnace = new Queue<int>();
        static int lightBody = 0;
        static int locationX = size / 2;
        static int locationY = size / 2;
        const int size = 20;
        static List<int> bodySnace = new List<int>();
        static direction? userInput = null;
        static direction currentDirection = direction.down;


        static public void AutoMove(direction? dir)
        {
            if (dir is null)
            {
                dir = currentDirection;
            }
            else
            {
                currentDirection = dir.Value;
            }

            switch (dir.Value)
            {
                case direction.left:
                    locationX--;
                    break;
                case direction.up:
                    locationY--;
                    break;
                case direction.down:
                    locationY++;
                    break;
                case direction.right:
                    locationX++;
                    break;
            }

            if (locationX < 1)
            {
                locationX = size - 2;
            }
            else if (locationX > size - 2)
            {
                locationX = 1;
            }
            else if (locationY > size - 2)
            {
                locationY = 0;
            }
            else if (locationY < 0)
            {
                locationY = size - 2;
            }

            Console.SetCursorPosition(locationX, locationY);
            Console.Write("*");
            Console.SetCursorPosition(locationX, locationY);
            lengthSnace.Enqueue(locationX);
            lengthSnace.Enqueue(locationY);
            bodySnace.Add(locationX);
            bodySnace.Add(locationY);
            Thread.Sleep(speed);
        }


        public bool GetInput(ref int locationBY, ref int locationBX)
        {
            Console.SetCursorPosition(36, 0);
            Console.Write(account);
            ConsoleKey key = ConsoleKey.Enter;

            if (Console.KeyAvailable)
            {
                key = Console.ReadKey(true).Key;
            }

            switch (key)
            {
                case ConsoleKey.W:
                    if (userInput != direction.down)
                        userInput = direction.up;
                    break;
                case ConsoleKey.S:
                    if (userInput != direction.up)
                        userInput = direction.down;
                    break;
                case ConsoleKey.A:
                    if (userInput != direction.right)
                        userInput = direction.left;
                    break;
                case ConsoleKey.D:
                    if (userInput != direction.left)
                        userInput = direction.right;
                    break;
                case ConsoleKey.Escape:
                    return true;
                default:
                    break;
            }

            if (locationX == locationBY && locationY == locationBX)
            {
                account++;
                if (speed > 150)
                    speed = speed - (account * 3);
                else if (speed <= 150 && speed > 75)
                    speed = speed - 10;
                AddBonus.Bonus(ref locationBY, ref locationBX);
            }

            AutoMove(userInput);

            if (account >= 4)
            {
                int count = bodySnace.Count;
                for (int i = 0; i < count - 2; i = i + 2)
                {
                    if (locationX == bodySnace[i] && locationY == bodySnace[i + 1])
                    {
                        return true;
                    }
                }
            }
            if (account == lightBody)
            {
                int left = lengthSnace.Dequeue(), right = lengthSnace.Dequeue();
                Console.SetCursorPosition(left, right);
                Console.Write("\0");
                bodySnace.RemoveAt(1);
                bodySnace.RemoveAt(0);
            }
            lightBody = account;

            return false;
        }

    }
}

