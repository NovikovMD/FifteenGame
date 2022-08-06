using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifteenGUI
{
    class CaraTaker
    {
        List<Memento> mem;

        public CaraTaker()
        {
            mem = new List<Memento>();
        }

        public void Save(int[,] field,int size, int x0,int y0)//save the field state
        {
            int[,] newField = new int[size, size];
            Memento newMem = new Memento(newField,field, x0, y0);//make state

            mem.Add(newMem);//save action
        }

        public int[,] Restore(out int x0, out int y0)//restore previous field state
        {
            int count = mem.Count - 1;
            x0 = mem[count].x0;//restore player pos
            y0 = mem[count].y0;
            int[,] field = mem[count].field;//restore field
            mem.RemoveAt(count);//remove restored state from the list

            return field;//return back restored state
        }
    }
}
