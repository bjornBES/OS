using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEs.mathF
{
    public class Vector1
    {
        public float x;
        public Vector1(float X)
        {
            x=X;
        }
        public static Vector1 Forword()
        {
            return new Vector1(1);
        }
    }
}
