using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS.code
{
    public class compilerCodeFill : compiler
    {
        string path = "C:/Users/bjorn/Source/Repos/OS/code/docs.txt";
        public void Start()
        {
            start();
            GetDocs();
        }
        void GetDocs()
        {
            docs = File.ReadAllText(path).Split(',', '-', ' ');
        }
        public string GetOut()
        {
            return Out;
        }
    }
}
