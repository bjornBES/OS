using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS.console.errors
{
    public enum Errorlevels
    {
        level0,
        level1,
        level2,
        level3,
        level4,
        level5
    }
    public class ErrorList
    {
        /// <summary>
        /// BCS: errorlevel, num(2-4)
        /// BCS: 3xxxx
        /// </summary>
        /// <param name="ErrorNum"></param>
        /// <param name="errorlevels"></param>
        /// <returns></returns>
        public string GetError(string ErrorAr, Errorlevels errorlevels)
        {
            string error = "";
            switch (errorlevels)
            {
                case Errorlevels.level0:
                    if (ErrorAr == "end")
                        error = "BCS:00010 " + "the end is not at the end of the Fun \n" +
                            "fun Name : \n" +
                            "end  <----"; ;
                    if (ErrorAr == ":")
                        error = "BCS:00011 " + "the :(start the fun) is not at the start of the Fun ex \n" +
                            "fun Name : <----";
                    if (ErrorAr == "NNV")
                        error = "BCS:00012 " + "there is no name at the val. ex \n" +
                            "var Name = TheVal <----";
                    break;
                case Errorlevels.level1:
                    if (ErrorAr == "end")
                        error = "BCS:10011 " + "WH ex \n" +
                            "EX here <----";
                    if (ErrorAr == ":")
                        error = "BCS:10011 " + "WH ex \n" +
                            "EX here <----";
                    break;
                case Errorlevels.level2:
                    if (ErrorAr == "end")
                        error = "BCS:20011 " + "WH ex \n" +
                            "EX here <----";
                    if (ErrorAr == ":")
                        error = "BCS:20011 " + "WH ex \n" +
                            "EX here <----";
                    break;
                case Errorlevels.level3:
                    if (ErrorAr == "end")
                        error = "BCS:30011 " + "WH ex \n" +
                            "EX here <----";
                    if (ErrorAr == ":")
                        error = "BCS:30011 " + "WH ex \n" +
                            "EX here <----";
                    break;
                case Errorlevels.level4:
                    if (ErrorAr == "end")
                        error = "BCS:40011 " + "WH ex \n" +
                            "EX here <----";
                    if (ErrorAr == ":")
                        error = "BCS:40011 " + "WH ex \n" +
                            "EX here <----";
                    break;
                case Errorlevels.level5:
                    if (ErrorAr == "end")
                        error = "BCS:50011 " + "WH ex \n" +
                            "EX here <----";
                    if (ErrorAr == ":")
                        error = "BCS:50011 " + "WH ex \n" +
                            "EX here <----";
                    break;
            }
            return error;
        }
    }
    public class ErrorMan
    {

    }
}
