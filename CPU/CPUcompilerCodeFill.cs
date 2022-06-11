using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS.code
{
    public class CPUcompilerCodeFill : CPUcompiler
    {
        string path = Application.UserAppDataPath + @"\CPUdocs.txt";
        public void Start()
        {
            if (File.Exists(path) == false)
                File.Create(path);
            File.WriteAllText(path, "﻿if-if, \n Get-using, \n Fun-void, \n Class-class,");
        }
        public void N_Compile()
        {
            Compile();
        }
    }
}

