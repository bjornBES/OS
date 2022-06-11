using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEs.mathF
{
    public class Vector2
    {
        public float x, y;
        public Vector2(float X,float Y)
        {
            x=X;
            y=Y;
        }
        public static Vector2 Forword()
        {
            return new Vector2(1, 0);
        }
    }
}
