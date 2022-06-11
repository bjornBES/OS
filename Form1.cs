using System;
using System.Windows.Forms;
using BEs.mathF.data;
using System.IO;
using OS.code;
using System.Media;

namespace OS
{
    public partial class Form1 : Form
    {
        public compilerCodeFill compiler;
        public string pass = "";
        bool Set, AN;
        public Form1()
        {
            InitializeComponent();
            UpdateOS.Start();
            lockOn.Hide();
            Password.Hide();
            TapsPanel.Hide();
            Tap1TablePanel.Hide();
            Table4Tap.Hide();
            CPUTable.Hide();
            doce.Hide();
            TapName.Hide();
            DataBase.LoadData();
            compiler = new compilerCodeFill();
            if (DataBase.LT[0] == "")
            {
                DataBase.ResetData();
                DataBase.Set("Password", "0", types.String, true);
            }
            compiler.Start();
            #region Password
            if (Convert.ToBoolean(DataBase.Get("AN")) == true)
            {
                AN = true;
                pass = "anbes";
            }
            if (DataBase.Get("Password").ToString() == "0")
            {
                Password.PlaceholderText="New Password";
            }
            pass = DataBase.Get("Password").ToString();
            #endregion
            doce.Lines=compiler.docs;
        }
        #region AN
        private void progressBar1_Click(object sender, EventArgs e)
        {
            if(DataBase.Get("Password").ToString() != pass)
            {
                AN = true;
                DataBase.Set("AN", "true", types.Bool, true);
            }
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
        /// <summary>
        /// password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LockOn(object sender, EventArgs e)
        {
            if(Password.PlaceholderText == "New Password" && Password.Text!="")
            {
                pass=Password.Text;
                DataBase.NewVal("Password", pass);
            }
            if(Password.Text == pass)
            {
                lockOn.Hide();
                TapsPanel.Show();
                Password.Hide();
                TapName.Show();
            }
        }

        private void Tap1_Click(object sender, EventArgs e)
        {
            Tap1TablePanel.Show();
            doce.Hide();
            CPUTable.Hide();
            Table4Tap.Hide();
            TapName.Text="Coding";
        }

        private void Tap2_Click(object sender, EventArgs e)
        {
            Tap1TablePanel.Hide();
            doce.Show();
            CPUTable.Hide();
            Table4Tap.Hide();
            TapName.Text="Doce";
        }

        private void Tap3_Click(object sender, EventArgs e)
        {
            Tap1TablePanel.Hide();
            doce.Hide();
            CPUTable.Show();
            Table4Tap.Hide();
            TapName.Text="CPU commit";
        }

        private void Tap4_Click(object sender, EventArgs e)
        {
            Tap1TablePanel.Hide();
            doce.Hide();
            CPUTable.Hide();
            Table4Tap.Show();
            TapName.Text="File";
        }
        //exit
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonCPU_Click(object sender, EventArgs e)
        {
            switch (CodeCPU.Text)
            {
                case "Run":
                    compiler.n_code = code.Text;
                    compiler.Compile();
                    OutputCode.Text="";
                    OutputCode.Text = compiler.GetOut();
                    break;
                case "CFFRun":
                    compiler.n_code = File.ReadAllText(Application.UserAppDataPath+@"\"+"code.CBEs");
                    compiler.Compile();
                    OutputCode.Text="";
                    OutputCode.Text = compiler.GetOut();
                    break;
                case "Exit":
                    Application.Exit();
                    break;
                case "Reset":
                    DataBase.ResetData();
                    pass="";
                    Password.Text="";
                    lockOn.Show();
                    TapsPanel.Hide();
                    Password.Show();
                    TapName.Hide();
                    Set=false;
                    break;
                case "ResetEnd":
                    DataBase.ResetData();
                    pass="";
                    Password.Text="";
                    lockOn.Show();
                    TapsPanel.Hide();
                    Password.Show();
                    TapName.Hide();
                    Set=false;
                    Application.Exit();
                    break;
            }
        }
        string path;
        private void OpenFile_Click(object sender, EventArgs e)
        {
            if(Path.Text == "")
            {
                path=Application.UserAppDataPath+@"\"+FileName.Text;
                FileOpen.Text=File.ReadAllText(path);
            }
            else
            {
                path=Path+FileName.Text;
                FileOpen.Text=File.ReadAllText(path);
            }
        }
        private void WAllText_Click(object sender, EventArgs e)
        {
            if (Path.Text == "")
            {
                path = Application.UserAppDataPath+@"\"+FileName.Text;
                File.WriteAllText(path, FileOpen.Text);
            }
            else
            {
                path=Path+FileName.Text;
                File.WriteAllText(path, FileOpen.Text);
            }
        }
        private void NewFile_Click(object sender, EventArgs e)
        {
            if (Path.Text == "")
            {
                path = Application.UserAppDataPath+@"\"+FileName.Text;
                if (File.Exists(path))
                    File.Create(path);
            }
            else
            {
                path=Path+FileName.Text;
                if (File.Exists(path))
                    File.Create(path);
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            DataBase.ResetData();
            pass="";
            Password.Text="";
            lockOn.Show();
            TapsPanel.Hide();
            Password.Show();
            TapName.Hide();
            Set=false;
        }

        private void UpdateWhatFile_Click(object sender, EventArgs e)
        {
            if (Path.Text == "")
            {
                path = Application.UserAppDataPath+@"\"+FileName.Text;
                DirectoryInfo info = new DirectoryInfo(Application.UserAppDataPath);
                for (int i = 0; i < info.GetFiles().Length; i++)
                {
                    WhatFiles.Text = info.GetFiles()[i].Name + " " + WhatFiles.Text;
                }
            }
            else
            {
                path=Path.Text+FileName.Text;
                DirectoryInfo info = new DirectoryInfo(Path.Text);
                for (int i = 0; i < info.GetFiles().Length; i++)
                {
                    WhatFiles.Text = info.GetFiles()[i].Name + " " + WhatFiles.Text;
                }
            }
        }

        private void code_TextChanged(object sender, EventArgs e)
        {
            string[ ] Dose = { "System", "Get", "Pu","Pr","St","Fun","class","if","int","string","bool",":","end",")"};
            string[ ] AfterCDose = { "System", "using", "public", "private", "static", "void", "class", "if", "int", "string", "bool", "{", "}", ")" };
            for (int i = 0; i < Dose.Length; i++)
            {
                if(sender.ToString()[0]==Dose[i][0])
                {
                    helpCode.Text=helpCode.Text+Dose[i];
                }
            }
        }
    }
}
