using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEs.mathF.data;

namespace OS.password
{
    public class PasswordMan
    {
        public string PassWord { get; set; }

        public void Get()
        {
            PassWord = DataBase.Get("Password").ToString();
        }
        public void Set(string Pass)
        {
            DataBase.NewVal("Password", Pass, types.String);
            PassWord = Pass;
        }
    }
}
