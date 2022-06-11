using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS.code.CPU
{
    public class OS
    {
        public FileSystem FileSystem;
        public void Start()
        {
            FileSystem = new FileSystem();
            FileSystem.Form1 = new Form1();
        }
    }
}
