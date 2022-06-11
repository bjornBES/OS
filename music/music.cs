using AudioSwitcher.AudioApi.CoreAudio;
using System.Media;
using System.Windows.Forms;

namespace OS.music
{
    public class music
    {
        SoundPlayer MusicPlayer;
        string Path;
        /// <summary>
        /// sets the path with C:\Users\user\AppData\Roaming\BEsIA\OS\1.0.0\music
        /// </summary>
        /// <param name="FileName">get a file ending with .wav eg MusicName.wav</param>
        /// <returns>a int if the int is 1 is done but if is -1 it's not done</returns>
        public int SetPath(string FileName)
        {
            Path = Application.UserAppDataPath + @"\music\" + FileName;
            return 1;
        }
        public void Play(bool loop)
        {
            MusicPlayer = new SoundPlayer(Path);
            if(loop == true)
                MusicPlayer.PlayLooping();
            else
                MusicPlayer.Play();
        }
        public void Stop()
        {
            MusicPlayer.Stop();
        }
    }
}
