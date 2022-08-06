using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifteenGUI
{
    class Game
    {
        int[,] field;    // /* 
        int size;        // Field properties
        int x0, y0;      // */


        CaraTaker cara;  // object to store all field states

        static Random rand = new Random();

        public int countSteps = 0;
        public int history = 0;

        public Game(int size)
        {
            field = new int[size, size];
            this.size = size;
            cara = new CaraTaker();
        }
        public void ShiftRandom()
        {
            int a = rand.Next(4);
            int x =x0, y = y0;
            switch (a)
            {
                case 0:
                    if (x - 1 >= 0)
                        Shift(x - 1, y);
                    break;
                case 1:
                    if (y + 1 < size)
                        Shift(x, y + 1);
                    break;
                case 2:
                    if (x + 1 < size)
                        Shift(x + 1, y);
                    break;
                case 3:
                    if (y - 1 >= 0)
                        Shift(x, y - 1);
                    break;
            }
        }


        private int CoordinateToIndex(int x, int y)
        {
            int index = size*y+x;
            return index;
        }
        private void IndexToCoordinate(int index, out int x, out int y)
        {
            y = index / size;
            x = index % size;
        }

        public void Start()
        {
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    field[i, j] = CoordinateToIndex(i, j);
            x0 = size - 1;
            y0 = size - 1;
            field[x0, y0] = -1;
        }
        public int GetNumber(int position)
        {
            int x, y;
            IndexToCoordinate(position, out x, out y);
            return field[x, y]+1;
        }

        private void Shift(int x, int y)
        {
            field[x0, y0] = field[x, y];
            field[x, y] = -1;
            x0 = x;
            y0 = y;
        }
        public void Shift(int position, out int prevPosition)
        {
            int x, y;
            prevPosition = -1;
            IndexToCoordinate(position, out x, out y);
            if (Math.Abs(x0 - x) <= 1 && Math.Abs(y0 - y) == 0
                || Math.Abs(x0 - x) ==0 && Math.Abs(y0 - y) <= 1)
            {
                history++;
                cara.Save(field,size, x0, y0);
                
                countSteps++;
                prevPosition = CoordinateToIndex(x0, y0);
                field[x0, y0] = field[x, y];
                field[x, y] = -1;
                x0 = x;
                y0 = y;


            }
        }

        public bool Check()
        {
            if (field[size - 1, size - 1] != -1)
                return false;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size && (j!=size-1 && i!=size-1); j++)
                {
                    if (field[i, j] != CoordinateToIndex(i, j))
                        return false;
                }
            }
            return true;
        }

        public void StepBack(out int prevPosition)
        {
            prevPosition = -1;
            if (history > 0)
            {
                int x = x0, y = y0;
                prevPosition = CoordinateToIndex(x, y);
                countSteps--;
                field = cara.Restore(out x0, out y0);
                history--;
            }
        }

    }
}
