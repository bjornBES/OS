using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS.FileMani
{
    public class FileMan
    {
        string AppdataPath = Application.UserAppDataPath + @"\";
        string CodeFilePath = Application.UserAppDataPath + @"\" + "Code.BEsC";
        string DocsFile = Application.UserAppDataPath + @"\Code\docs.txt";
        string AbFilePath = Application.UserAppDataPath + @"\" + "BEsiA.Ab";
        string SetFilePath = Application.UserAppDataPath + @"\" + "settings.Set";
        string InfoFilePath = Application.UserAppDataPath + @"\" + "Info.txt";
        string DataFilePath = Application.UserAppDataPath + @"\private\Password\data.txt";
        string DataDir = Application.UserAppDataPath + @"\private\Password";
        string CodeDir = Application.UserAppDataPath + @"\Code";
        string CodeCPUDir = Application.UserAppDataPath + @"\Code\CPU";
        string CPUDocsFile = Application.UserAppDataPath + @"\Code\CPU\CPUdocs.txt";
        public FileMan()
        {
            if (File.Exists(CodeFilePath) != true)
                File.Create(CodeFilePath);
            if (File.Exists(AbFilePath) != true)
                File.Create(AbFilePath);
            if (File.Exists(SetFilePath) != true)
                File.Create(SetFilePath);
            if (File.Exists(InfoFilePath) != true)
                File.Create(InfoFilePath);
            if (Directory.Exists(DataDir) != true)
                Directory.CreateDirectory(DataDir);
            if (Directory.Exists(CodeDir) != true)
                Directory.CreateDirectory(CodeDir);
            if (Directory.Exists(CodeCPUDir) != true)
                Directory.CreateDirectory(CodeCPUDir);
            if (File.Exists(DataFilePath) != true)
                File.Create(DataFilePath);
            if (File.Exists(CPUDocsFile) == false)
                File.Create(CPUDocsFile);
            if (File.Exists(DocsFile) == false)
                File.Create(DocsFile);
            Write();
        }
        string infoAbText = "Info about the progarm" +
            "this progarm is not a virus this progarm is a fun little program that the CEO of BEsIa " +
            "this progarm WILL be making files in your filesystem mainly in " + Application.UserAppDataPath;
        string AbFileText = "what is BEsiA. \n" +
            "we make progarms eg. OS, a database and more " +
            "plase set the TOS to true in settings.Set file " +
            "so we have promison to do do what ever we wont to do " +
            "we will not get you any virus form the progarms themselves " +
            "the CEO of BEsIa is BjornBEs and its him who has make this progarm " +
            "";
        string DocsFileText = "System - System; \n" +
            "Get - using \n" +
            "Pu - public \n" +
            "Pr - private \n" +
            "St - static \n" +
            "Fun - void \n" +
            "class - class \n" +
            "if - if( \n" +
            "int - int \n" +
            "string - string \n" +
            "bool - bool \n" +
            "= - = \n" +
            "== - == \n" +
            "!= - != \n" +
            "<= - <= \n" +
            ">= - >= \n" +
            "< - < \n" +
            "> - > \n" +
            ": - { \n" +
            "end - } \n" +
            ") - ) \n";
        string SettingsFileText = "TOS:false";
        string CPUDocsFileText = "if-if, \n Get-using, \n Fun-void, \n Class-class,";
        void Write()
        {
            if (File.ReadAllText(AbFilePath) != AbFileText)
                File.WriteAllText(AbFilePath, AbFileText);
            if (File.ReadAllText(InfoFilePath) != infoAbText)
                File.WriteAllText(InfoFilePath, infoAbText);
            if (File.ReadAllText(SetFilePath) != SettingsFileText)
                File.WriteAllText(SetFilePath, SettingsFileText);
            if (File.ReadAllText(CPUDocsFile) != CPUDocsFileText)
                File.WriteAllText(CPUDocsFile, CPUDocsFileText);
            if (File.ReadAllText(DocsFile) != DocsFileText)
                File.WriteAllText(DocsFile, DocsFileText);
        }
        string Path;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="con"></param>
        /// <param name="Appdata">if this is false plase use SetPath()</param>
        public void WAllTexta(string con, string FileName, bool Appdata)
        {
            if (FileName == "docs.txt")
            {
                if (Appdata == true)
                    File.WriteAllText(DocsFile, con);
                else
                    File.WriteAllText(Path + @"\" + FileName, con);
            }
            else if (FileName == "CPUdocs.txt")
            {
                if (Appdata == true)
                    File.WriteAllText(CPUDocsFile, con);
                else
                    File.WriteAllText(Path + @"\" + FileName, con);
            }
            else
            {
                if (Appdata == true)
                    File.WriteAllText(AppdataPath + FileName, con);
                else
                    File.WriteAllText(Path + @"\" + FileName, con);
            }
        }
        public void SetPath(string path)
        {
            Path = path + @"\";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="AppData">if false use SetPath</param>
        /// <returns></returns>
        public string ReadText(string FileName, bool Appdata)
        {
            string Re = "";
            if (FileName == "docs.txt")
            {
                if (Appdata == true)
                    Re = File.ReadAllText(DocsFile);
                else
                    Re = File.ReadAllText(DocsFile);
            }
            else if (FileName == "CPUdocs.txt")
            {
                if (Appdata == true)
                    Re = File.ReadAllText(CPUDocsFile);
                else
                    Re = File.ReadAllText(Path + @"\" + FileName);
            }
            else
            {
                if (Appdata == true)
                    Re = File.ReadAllText(Application.UserAppDataPath + @"\" + FileName);
                else
                    Re = File.ReadAllText(Path + @"\" + FileName);
            }
            return Re;
        }
    }
}
