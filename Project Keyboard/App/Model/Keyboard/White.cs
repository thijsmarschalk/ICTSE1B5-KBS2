using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model.Keyboard
{
    class White : Key
    {
        enum wPitches { C1, D1, E1, F1, G1, A1, B1, C2, D2, E2, F2, G2, A2, B2, C3, D3, E3, F3, G3 };
        public int Pitch;

        public White(int x, int y, int l, int p)
        {
            X = x;
            Y = y;
            W = l;
            H = l;
            Pitch = p;
        }
    }
}
