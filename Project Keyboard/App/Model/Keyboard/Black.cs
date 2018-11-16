using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model.Keyboard
{
    class Black : Key
    {
        enum bPitches {Cis1, Dis1, Fis1, Gis1, Ais1, Cis2, Dis2, Fis2, Gis2, Ais2, Cis3, Dis3, Fis3 };
        public int Pitch;

        public Black(int x, int y, int l, int p)
        {
            X = x;
            Y = y;
            W = l;
            H = l;
            Pitch = p;
        }
    }
}
