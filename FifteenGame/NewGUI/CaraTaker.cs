using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGUI
{
    class CaraTaker
    {
        List<Memento> mem = new List<Memento>();

        public void Save(int[,] field, int size, int x0, int y0)
        {
            int[,] newField = new int[size, size];
            Memento newMem = new Memento(newField, field, x0, y0);
            mem.Add(newMem);
        }

        public int[,] Restore(out int x0, out int y0)
        {
            int count = mem.Count - 1;
            x0 = mem[count].x0;
            y0 = mem[count].y0;
            int[,] field = mem[count].field;
            mem.RemoveAt(count);
            return field;
        }
    }
}
