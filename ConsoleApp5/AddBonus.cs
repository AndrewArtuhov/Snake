using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class AddBonus
    {
        static Random rnd = new Random();
        static List<int> bodySnace = new List<int>();
        const int size = 20;
        static int locationX = size / 2;
        static int locationY = size / 2;

        static public void Bonus(ref int locationBY,ref int locationBX)
        {
            for (; ; )
            {
                bool bonusInLocBad = true;
                locationBX = rnd.Next(0, size - 1);
                locationBY = rnd.Next(1, size - 1);
                int count = bodySnace.Count;
                for (int i = 0; i < count; ++i)
                {
                    if (locationBX == bodySnace[i] && locationBY == bodySnace[i++])
                    {
                        bonusInLocBad = false;
                        break;
                    }
                    else
                    {
                        bonusInLocBad = true;
                    }
                }

                if (bonusInLocBad == true)
                {
                    break;
                }
            }

            Console.SetCursorPosition(locationBY, locationBX);
            Console.Write('^');
            Console.SetCursorPosition(locationY, locationX);
        }
    }
}
