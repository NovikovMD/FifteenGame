using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifteenGUI
{
    class Memento//stores field state
    {
        public int[,] field;
        public int x0;
        public int y0;

        public Memento(int[,] newField, int[,] field, int x0, int y0)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.field = newField;
            Array.Copy(field, this.field, field.Length);
        }
    }
}
