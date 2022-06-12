using System;
using System.Windows.Forms;
using BEs.mathF.data;
using System.IO;
using OS.FileMani;
using OS.password;

namespace OS
{
    public partial class Form1 : Form
    {
        public calculator.calculatorMan Cal;
        public code.compilerCodeFill compiler;
        public code.CPUcompilerCodeFill CPUcompiler;
        public FileMan FileMan;
        PasswordMan PasswordMan;
        public string pass = "";
        bool Set;
        public Form1()
        {
            InitializeComponent();
            #region Start op
            UpdateOS.Start();
            TapPanel8.Hide();
            TapPanel6.Hide();
            TapPanel7.Hide();
            lockOn.Hide();
            Password.Hide();
            TapsPanel.Hide();
            Tap1TablePanel.Hide();
            Table4Tap.Hide();
            CPUTable.Hide();
            ExitButton.Hide();
            TapPanel5.Hide();
            TapPanel2.Hide();
            TapName.Hide();
            FileMan = new FileMan();
            DataBase.LoadData();
            Cal = new calculator.calculatorMan();
            compiler = new code.compilerCodeFill();
            CPUcompiler = new code.CPUcompilerCodeFill();
            PasswordMan = new PasswordMan();
            compiler.Start();
            CPUcompiler.Start();
            //0.1 + 0.2
            //Cal.SetNumber("1 + 1 - 1 * 1 / 1");
            //Cal.StartCal();
            //Cal.OutPut();
            #endregion
            #region Password
            if (DataBase.LT[0] == "")
            {
                DataBase.ResetData();
                DataBase.Set("Password", "0", types.String, true);
            }
            PasswordMan.Get();
            if (DataBase.Get("AN").ToString() == "true")
            {
                PasswordMan.Set("anbes");
            }
            if (PasswordMan.PassWord == "0")
            {
                Password.PlaceholderText="New Password";
            }
            pass = PasswordMan.PassWord;
            #endregion
        }
        #region AN
        private void progressBar1_Click(object sender, EventArgs e)
        {
            DataBase.Set("AN", "true", types.Bool, true);
        }
        #endregion
        private void OSUpdate(object sender,EventArgs e)
        {
            if (DataBase.Get("AN").ToString() == "true" && Set == false)
            {
                progressBar1.Hide();
                lockOn.Show();
                Password.Show();
                Set=true;
            }
            else
            {
                if (progressBar1.Value != progressBar1.Maximum)
                    progressBar1.Value = progressBar1.Value + 1;
                if (progressBar1.Value == progressBar1.Maximum && Set == false)
                {
                    progressBar1.Hide();
                    lockOn.Show();
                    Password.Show();
                    Set=true;
                }
            }
        }
        #region logic
        void LockOffNow()
        {
            lockOn.Show();
            TapsPanel.Hide();
            Password.Show();
            ExitButton.Hide();
            TapName.Hide();
            Tap1TablePanel.Hide();
            TapPanel2.Hide();
            CPUTable.Hide();
            Table4Tap.Hide();
            TapPanel5.Hide();
            TapPanel6.Hide();
            TapPanel7.Hide();
            Password.Text = "";
        }
        private void LockOn(object sender, EventArgs e)
        {
            if (Password.PlaceholderText == "New Password" && Password.Text != "")
            {
                pass = Password.Text;
                PasswordMan.Set(Password.Text);
                Password.PlaceholderText = "";
            }
            if (Password.Text == pass)
            {
                lockOn.Hide();
                TapsPanel.Show();
                Password.Hide();
                ExitButton.Show();
                TapName.Show();
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LockOff_Click(object sender, EventArgs e)
        {
            LockOffNow();
        }
        #endregion
        #region Tap
        private void Tap1_Click(object sender, EventArgs e)
        {
            Tap1TablePanel.Show();
            TapPanel2.Hide();
            CPUTable.Hide();
            Table4Tap.Hide();
            TapPanel5.Hide();
            TapPanel6.Hide();
            TapPanel7.Hide();
            TapPanel8.Hide();
            TapName.Text = "Coding";
        }
        private void Tap2_Click(object sender, EventArgs e)
        {
            Tap1TablePanel.Hide();
            TapPanel2.Show();
            CPUTable.Hide();
            Table4Tap.Hide();
            TapPanel5.Hide();
            TapPanel6.Hide();
            TapPanel7.Hide();
            TapPanel8.Hide();
            TapName.Text = "CPU code";
        }
        private void Tap3_Click(object sender, EventArgs e)
        {
            Tap1TablePanel.Hide();
            TapPanel2.Hide();
            CPUTable.Show();
            Table4Tap.Hide();
            TapPanel5.Hide();
            TapPanel6.Hide();
            TapPanel7.Hide();
            TapPanel8.Hide();
            TapName.Text = "CPU commit";
        }
        private void Tap4_Click(object sender, EventArgs e)
        {
            Tap1TablePanel.Hide();
            TapPanel2.Hide();
            CPUTable.Hide();
            Table4Tap.Show();
            TapPanel5.Hide();
            TapPanel6.Hide();
            TapPanel7.Hide();
            TapPanel8.Hide();
            TapName.Text = "File";
        }
        private void Tap5_Click(object sender, EventArgs e)
        {
            Tap1TablePanel.Hide();
            TapPanel2.Hide();
            CPUTable.Hide();
            Table4Tap.Hide();
            TapPanel5.Show();
            TapPanel6.Hide();
            TapPanel7.Hide();
            TapPanel8.Hide();
            TapName.Text = "Music Player";
        }
        private void Tap6_Click(object sender, EventArgs e)
        {
            Tap1TablePanel.Hide();
            TapPanel2.Hide();
            CPUTable.Hide();
            Table4Tap.Hide();
            TapPanel5.Hide();
            TapPanel6.Show();
            TapPanel7.Hide();
            TapPanel8.Hide();
            TapName.Text = "Clock";
        }
        private void tap7_Click(object sender, EventArgs e)
        {
            Tap1TablePanel.Hide();
            TapPanel2.Hide();
            CPUTable.Hide();
            Table4Tap.Hide();
            TapPanel5.Hide();
            TapPanel6.Hide();
            TapPanel7.Show();
            TapPanel8.Hide();
            TapName.Text = "cal";
        }
        private void tap8_Click(object sender, EventArgs e)
        {
            Tap1TablePanel.Hide();
            TapPanel2.Hide();
            CPUTable.Hide();
            Table4Tap.Hide();
            TapPanel5.Hide();
            TapPanel6.Hide();
            TapPanel7.Hide();
            TapPanel8.Show();
            TapName.Text = "Console";
        }
        #endregion
        #region Compilers
        private void RunCPUCode_Click(object sender, EventArgs e)
        {
            CPUcompiler.n_code = CPUCode.Text;
            CPUcompiler.Compile();
        }
        private void ButtonCPU_Click(object sender, EventArgs e)
        {
            switch (CodeCPU.Text)
            {
                case "Run":
                    compiler.n_code = code.Text;
                    compiler.Compile();
                    OutputCode.Text = "";
                    OutputCode.Text = compiler.GetOut();
                    break;
                //compile form file Run
                case "CFFRun":
                    compiler.n_code = FileMan.ReadText("Code.BEsC", true);
                    compiler.Compile();
                    OutputCode.Text = "";
                    OutputCode.Text = compiler.GetOut();
                    break;
                //Run CPU
                case "RunCPU":
                    CPUcompiler.n_code = CPUCode.Text;
                    CPUcompiler.Compile();
                    break;
            }
        }
        #endregion
        #region File
        string path;
        private void OpenFile_Click(object sender, EventArgs e)
        {
            if (Path.Text == "")
            {
                path = Application.UserAppDataPath + @"\" + FileName.Text;
                FileOpen.Text = File.ReadAllText(path);
            }
            else
            {
                path = Path + @"\" + FileName.Text;
                FileOpen.Text = File.ReadAllText(path);
            }
        }
        private void WAllText_Click(object sender, EventArgs e)
        {
            if (Path.Text == "")
                FileMan.WAllTexta(FileOpen.Text,FileName.Text, true);
            else
            {
                FileMan.SetPath(Path.Text);
                FileMan.WAllTexta(FileOpen.Text, FileName.Text, false);
            }
        }
        private void NewFile_Click(object sender, EventArgs e)
        {
            if (Path.Text == "")
            {
                path = Application.UserAppDataPath + @"\" + FileName.Text;
                if (File.Exists(path))
                    File.Create(path);
            }
            else
            {
                path = Path + FileName.Text;
                if (File.Exists(path))
                    File.Create(path);
            }
        }
        private void FindFiles_Click(object sender, EventArgs e)
        {
            if (Path.Text == "")
            {
                path = Application.UserAppDataPath + @"\" + FileName.Text;
                DirectoryInfo directoryInfo = new DirectoryInfo(path);
                for (int i = 0; i < directoryInfo.GetFiles().Length; i++)
                {
                    FindAllFiles.Text = FindAllFiles.Text + directoryInfo.GetFiles()[i].Name + " , ";
                }
            }
            else
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(path);
                path = Path + FileName.Text;
                FindAllFiles.Lines = Directory.GetFiles(path);
            }
        }
        #endregion
        #region music
        music.music music = new music.music();
        private void PlayMusic_Click(object sender, EventArgs e)
        {
            music.SetPath(FilePath.Text);
            music.Play(LoopMusic.Checked);
        }

        private void FindMusic_Click(object sender, EventArgs e)
        {
            path = Application.UserAppDataPath + @"\music";
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            for (int i = 0; i < directoryInfo.GetFiles().Length; i++)
            {
                MusicList.Text = MusicList.Text + directoryInfo.GetFiles()[i].Name + " , ";
            }
        }
        private void Stop_Click(object sender, EventArgs e)
        {
            music.Stop();
        }
        #endregion
    }
}
