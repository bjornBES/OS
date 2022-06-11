using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEs.mathF.data;
using OS.code.CPU;

namespace OS.code
{
    public class CPUcompiler
    {
        public string[ ] docs;
        public string n_code;
        string[ ] code;
        public void Compile()
        {
            code = n_code.Split(',', ':', '(', ')', ']', '[');
            for (int i = 0; i < code.Length; i++)
            {
                FindCode(code[i],i);
            }
        }
        CPU.OS OS;
        public void FindCode(string Code,int Index)
        {
            OS = new CPU.OS();
            OS.Start();
            int II = Index +1;
            int III = Index + 2;
            int VI = Index + 3;
            int IV = Index + 4;
            int IIV = Index + 5;
            int IIM = Index - 1;
            switch (Code)
            {
                #region Keykords
                case "FileSystem":
                    if(code[IIM] == "OS")
                        switch (code[II])
                        {
                            case "OpenDose":
                                OS.FileSystem.OpenDose();
                                break;
                            case "WriteAllText":
                                OS.FileSystem.WriteAllText(code[VI], code[IIV]);
                                break;
                        }
                    break;
                    #endregion
            }
        }
    }
}

