using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS.code.CPU
{
    public class FileSystem
    {
        public Form1 Form1;
        public void OpenDose()
        {
            Form1.FileName.Text = "dose.txt";
        }
        public void WriteAllText(string Path, string content)
        {
            Form1.FileName.Text = Path;
            Form1.FileMan.WAllTexta(content,Path,true);
        }
    }
}
