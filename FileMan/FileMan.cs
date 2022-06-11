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
        string AbFilePath = Application.UserAppDataPath + @"\" + "BEsiA.Ab";
        string SetFilePath = Application.UserAppDataPath + @"\" + "settings.Set";
        string InfoFilePath = Application.UserAppDataPath + @"\" + "Info.txt";
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
        string SettingsFileText = "TOS:false";
        void Write()
        {
            if (File.ReadAllText(AbFilePath) != AbFileText)
                File.WriteAllText(AbFilePath, AbFileText);
            if (File.ReadAllText(InfoFilePath) != infoAbText)
                File.WriteAllText(InfoFilePath, infoAbText);
            if (File.ReadAllText(SetFilePath) != SettingsFileText)
                File.WriteAllText(SetFilePath, SettingsFileText);
        }
        string Path;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="con"></param>
        /// <param name="Appdata">if this is false plase use SetPath()</param>
        public void WAllTexta(string con, string FileName, bool Appdata)
        {
            if(Appdata == true)
                File.WriteAllText(AppdataPath + FileName, con);
            else
                File.WriteAllText(Path + @"\" + FileName, con);
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
        public string ReadText(string FileName, bool AppData)
        {
            if (AppData == true)
                return File.ReadAllText(Application.UserAppDataPath + @"\" + FileName);
            else
                return File.ReadAllText(Path + @"\" + FileName);
        }
    }
}
