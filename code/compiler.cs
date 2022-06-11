using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEs.mathF.data;

namespace OS.code
{
    public class compiler
    {
        public string[ ] docs;
        public string n_code;
        string[ ] code;
        public string Out;
        public void start()
        {
        }
        public void Compile()
        {
            Out="";
            code = n_code.Split(' ');
            for (int i = 0; i < code.Length; i++)
            {
                FindCode(code[i],i);
            }
        }
        public void FindCode(string Code,int Index)
        {
            int II = Index +1;
            int III = Index +2;
            int VI = Index +3;
            switch (Code)
            {
                default:
                    if (DataBase.Get(Code).ToString() == Code)
                        Out=Out+Code;
                    break;
                #region NameSpace
                case "System":
                    Out=Out+"System;";
                    break;
                #endregion
                #region Keykords
                case "Get":
                    Out=Out+"using ";
                    break;
                case "Pu":
                    Out=Out+"public ";
                    if (code[II]=="class" && DataBase.Get(code[III]) == null)
                        DataBase.SetClass(code[III], true, ModTypes.Public);
                    else if (code[III]=="class")
                        DataBase.SetClass(code[VI], true, ModTypes.Public);
                    else if (code[II]=="St")
                        DataBase.SetClass(code[VI], true, ModTypes.PUS);
                    break;
                case "Pr":
                    Out=Out+"private ";
                    if (code[II]=="class")
                        DataBase.SetClass(code[III], true, ModTypes.Private);
                    else if(code[III]=="class")
                        DataBase.SetClass(code[VI], true, ModTypes.Private);
                    else if(code[II]=="St")
                        DataBase.SetClass(code[VI], true, ModTypes.PRS);
                    break;
                case "St":
                    Out=Out+"static ";
                    break;
                case "Fun":
                    Out=Out+"void " + code[II];
                    DataBase.SetFun(code[II], "", types.none, true, ModTypes.PUS);
                    break;
                case "class":
                    Out=Out+"class " + code[II];
                    break;
                case "if":
                    Out=Out+"if(";
                    break;
                #region Val Types
                case "int":
                    Out=Out+"int " + code[II];
                    DataBase.Set(code[II], code[VI], types.Ints, true);
                    break;
                case "string":
                    Out=Out+"string " + code[II];
                    DataBase.Set(code[II], code[VI], types.String, true);
                    break;
                case "bool":
                    Out=Out+"bool " + code[II];
                    DataBase.Set(code[II], code[VI], types.Bool, true);
                    break;
                #endregion
                #endregion
                #region Operators
                case "=":
                    Out=Out+"=";
                    break;
                case "==":
                    Out=Out+"==";
                    break;
                case "!=":
                    Out=Out+"!=";
                    break;
                case "<=":
                    Out=Out+"<=";
                    break;
                case ">=":
                    Out=Out+">=";
                    break;
                case "<":
                    Out=Out+"<";
                    break;
                case ">":
                    Out=Out+">";
                    break;

                #endregion
                #region Other
                case ":":
                    Out=Out+"{";
                    break;
                case "end":
                    Out=Out+"}";
                    break;
                case ")":
                    Out=Out+")";
                    break;
                    #endregion
            }
        }
    }
}
