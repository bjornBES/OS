using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS.console
{
    [Serializable]
    public class Info
    {
        public string Ask;
        public string anser;
    }
    /// <summary>
    /// 
    /// </summary>
    public class ConsoleMan
    {
        /// <summary>
        /// staring point for an error is BS: number
        /// the number is the error eg. 00001 is } expected and more
        /// </summary>
        public Info[] infos = new Info[100];
        int infoIndex;
        public ConsoleMan()
        {

        }
    }
}
