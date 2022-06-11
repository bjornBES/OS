using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEs.mathF
{
    public class Vector3
    {
        public float x, y, z;
        public Vector3(float X,float Y, float Z)
        {
            x=X;
            y=Y;
            z=Z;
        }
        public static Vector3 Forword()
        {
            return new Vector3(1, 0, 0);
        }
    }
}
