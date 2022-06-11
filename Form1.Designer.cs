namespace OS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.UpdateOS = new System.Windows.Forms.Timer(this.components);
            this.lockOn = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.ButtonTap1 = new System.Windows.Forms.Button();
            this.ButtonTap2 = new System.Windows.Forms.Button();
            this.ButtonTap3 = new System.Windows.Forms.Button();
            this.ButtonTap4 = new System.Windows.Forms.Button();
            this.TapsPanel = new System.Windows.Forms.Panel();
            this.LockOff = new System.Windows.Forms.Button();
            this.tap7 = new System.Windows.Forms.Button();
            this.Tap6 = new System.Windows.Forms.Button();
            this.ButtonTap5 = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Tap1TablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.code = new System.Windows.Forms.TextBox();
            this.TableUnderCode = new System.Windows.Forms.TableLayoutPanel();
            this.CodeHelp = new System.Windows.Forms.Button();
            this.OutputCode = new System.Windows.Forms.TextBox();
            this.helpCode = new System.Windows.Forms.TextBox();
            this.CPUTable = new System.Windows.Forms.TableLayoutPanel();
            this.CodeCPU = new System.Windows.Forms.TextBox();
            this.CPUDose = new System.Windows.Forms.TextBox();
            this.TableUnderCPU = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonCPU = new System.Windows.Forms.Button();
            this.TapName = new System.Windows.Forms.TextBox();
            this.Table4Tap = new System.Windows.Forms.TableLayoutPanel();
            this.FileOp = new System.Windows.Forms.TableLayoutPanel();
            this.FileName = new System.Windows.Forms.TextBox();
            this.Path = new System.Windows.Forms.TextBox();
            this.FileOpen = new System.Windows.Forms.TextBox();
            this.FileOPt = new System.Windows.Forms.TableLayoutPanel();
            this.WAllText = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.Button();
            this.NewFile = new System.Windows.Forms.Button();
            this.FindFiles = new System.Windows.Forms.Button();
            this.FindAllFiles = new System.Windows.Forms.TextBox();
            this.TapPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.UnderTapPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.RunCPUCode = new System.Windows.Forms.Button();
            this.CPUCode = new System.Windows.Forms.TextBox();
            this.CodeCPUdose = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TapPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.MusicList = new System.Windows.Forms.TextBox();
            this.UnderTap5 = new System.Windows.Forms.TableLayoutPanel();
            this.PlayMusic = new System.Windows.Forms.Button();
            this.FindMusic = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.LoopMusic = new System.Windows.Forms.CheckBox();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TapPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.TapPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.TapsPanel.SuspendLayout();
            this.Tap1TablePanel.SuspendLayout();
            this.TableUnderCode.SuspendLayout();
            this.CPUTable.SuspendLayout();
            this.TableUnderCPU.SuspendLayout();
            this.Table4Tap.SuspendLayout();
            this.FileOp.SuspendLayout();
            this.FileOPt.SuspendLayout();
            this.TapPanel2.SuspendLayout();
            this.UnderTapPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.TapPanel5.SuspendLayout();
            this.UnderTap5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(-5, 399);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(800, 50);
            this.progressBar1.Step = 100;
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // UpdateOS
            // 
            this.UpdateOS.Tick += new System.EventHandler(this.OSUpdate);
            // 
            // lockOn
            // 
            this.lockOn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lockOn.Location = new System.Drawing.Point(300, 399);
            this.lockOn.Name = "lockOn";
            this.lockOn.Size = new System.Drawing.Size(200, 50);
            this.lockOn.TabIndex = 1;
            this.lockOn.Text = "lockon";
            this.lockOn.UseVisualStyleBackColor = true;
            this.lockOn.Click += new System.EventHandler(this.LockOn);
            // 
            // Password
            // 
            this.Password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Password.Location = new System.Drawing.Point(300, 15);
            this.Password.Name = "Password";
            this.Password.PlaceholderText = "Password";
            this.Password.Size = new System.Drawing.Size(200, 31);
            this.Password.TabIndex = 2;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ButtonTap1
            // 
            this.ButtonTap1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonTap1.Location = new System.Drawing.Point(1, 0);
            this.ButtonTap1.Name = "ButtonTap1";
            this.ButtonTap1.Size = new System.Drawing.Size(40, 34);
            this.ButtonTap1.TabIndex = 3;
            this.ButtonTap1.UseVisualStyleBackColor = true;
            this.ButtonTap1.Click += new System.EventHandler(this.Tap1_Click);
            // 
            // ButtonTap2
            // 
            this.ButtonTap2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonTap2.Location = new System.Drawing.Point(47, 0);
            this.ButtonTap2.Name = "ButtonTap2";
            this.ButtonTap2.Size = new System.Drawing.Size(40, 34);
            this.ButtonTap2.TabIndex = 4;
            this.ButtonTap2.UseVisualStyleBackColor = true;
            this.ButtonTap2.Click += new System.EventHandler(this.Tap2_Click);
            // 
            // ButtonTap3
            // 
            this.ButtonTap3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonTap3.Location = new System.Drawing.Point(47, 40);
            this.ButtonTap3.Name = "ButtonTap3";
            this.ButtonTap3.Size = new System.Drawing.Size(39, 34);
            this.ButtonTap3.TabIndex = 5;
            this.ButtonTap3.UseVisualStyleBackColor = true;
            this.ButtonTap3.Click += new System.EventHandler(this.Tap3_Click);
            // 
            // ButtonTap4
            // 
            this.ButtonTap4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonTap4.Location = new System.Drawing.Point(1, 40);
            this.ButtonTap4.Name = "ButtonTap4";
            this.ButtonTap4.Size = new System.Drawing.Size(40, 34);
            this.ButtonTap4.TabIndex = 6;
            this.ButtonTap4.UseVisualStyleBackColor = true;
            this.ButtonTap4.Click += new System.EventHandler(this.Tap4_Click);
            // 
            // TapsPanel
            // 
            this.TapsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TapsPanel.Controls.Add(this.LockOff);
            this.TapsPanel.Controls.Add(this.tap7);
            this.TapsPanel.Controls.Add(this.Tap6);
            this.TapsPanel.Controls.Add(this.ButtonTap5);
            this.TapsPanel.Controls.Add(this.ExitButton);
            this.TapsPanel.Controls.Add(this.ButtonTap1);
            this.TapsPanel.Controls.Add(this.ButtonTap4);
            this.TapsPanel.Controls.Add(this.ButtonTap2);
            this.TapsPanel.Controls.Add(this.ButtonTap3);
            this.TapsPanel.Location = new System.Drawing.Point(12, 12);
            this.TapsPanel.Name = "TapsPanel";
            this.TapsPanel.Size = new System.Drawing.Size(88, 366);
            this.TapsPanel.TabIndex = 7;
            // 
            // LockOff
            // 
            this.LockOff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LockOff.BackColor = System.Drawing.Color.Orange;
            this.LockOff.Location = new System.Drawing.Point(0, 242);
            this.LockOff.Name = "LockOff";
            this.LockOff.Size = new System.Drawing.Size(88, 59);
            this.LockOff.TabIndex = 11;
            this.LockOff.Text = "LockOff";
            this.LockOff.UseVisualStyleBackColor = false;
            this.LockOff.Click += new System.EventHandler(this.LockOff_Click);
            // 
            // tap7
            // 
            this.tap7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tap7.Location = new System.Drawing.Point(1, 120);
            this.tap7.Name = "tap7";
            this.tap7.Size = new System.Drawing.Size(40, 34);
            this.tap7.TabIndex = 10;
            this.tap7.UseVisualStyleBackColor = true;
            this.tap7.Click += new System.EventHandler(this.tap7_Click);
            // 
            // Tap6
            // 
            this.Tap6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tap6.Location = new System.Drawing.Point(47, 80);
            this.Tap6.Name = "Tap6";
            this.Tap6.Size = new System.Drawing.Size(38, 34);
            this.Tap6.TabIndex = 9;
            this.Tap6.UseVisualStyleBackColor = true;
            this.Tap6.Click += new System.EventHandler(this.Tap6_Click);
            // 
            // ButtonTap5
            // 
            this.ButtonTap5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonTap5.Location = new System.Drawing.Point(1, 80);
            this.ButtonTap5.Name = "ButtonTap5";
            this.ButtonTap5.Size = new System.Drawing.Size(40, 34);
            this.ButtonTap5.TabIndex = 8;
            this.ButtonTap5.UseVisualStyleBackColor = true;
            this.ButtonTap5.Click += new System.EventHandler(this.Tap5_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.Location = new System.Drawing.Point(0, 307);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(88, 59);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Tap1TablePanel
            // 
            this.Tap1TablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tap1TablePanel.ColumnCount = 2;
            this.Tap1TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tap1TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tap1TablePanel.Controls.Add(this.code, 0, 0);
            this.Tap1TablePanel.Controls.Add(this.TableUnderCode, 0, 1);
            this.Tap1TablePanel.Controls.Add(this.OutputCode, 1, 1);
            this.Tap1TablePanel.Controls.Add(this.helpCode, 1, 0);
            this.Tap1TablePanel.Location = new System.Drawing.Point(105, 52);
            this.Tap1TablePanel.Name = "Tap1TablePanel";
            this.Tap1TablePanel.RowCount = 2;
            this.Tap1TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tap1TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tap1TablePanel.Size = new System.Drawing.Size(684, 326);
            this.Tap1TablePanel.TabIndex = 14;
            this.Tap1TablePanel.Visible = false;
            // 
            // code
            // 
            this.code.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.code.Location = new System.Drawing.Point(3, 3);
            this.code.Multiline = true;
            this.code.Name = "code";
            this.code.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.code.Size = new System.Drawing.Size(336, 157);
            this.code.TabIndex = 0;
            // 
            // TableUnderCode
            // 
            this.TableUnderCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableUnderCode.ColumnCount = 3;
            this.TableUnderCode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableUnderCode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableUnderCode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableUnderCode.Controls.Add(this.CodeHelp, 2, 1);
            this.TableUnderCode.Location = new System.Drawing.Point(3, 166);
            this.TableUnderCode.Name = "TableUnderCode";
            this.TableUnderCode.RowCount = 2;
            this.TableUnderCode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableUnderCode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableUnderCode.Size = new System.Drawing.Size(336, 157);
            this.TableUnderCode.TabIndex = 2;
            // 
            // CodeHelp
            // 
            this.CodeHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CodeHelp.Location = new System.Drawing.Point(227, 81);
            this.CodeHelp.Name = "CodeHelp";
            this.CodeHelp.Size = new System.Drawing.Size(106, 73);
            this.CodeHelp.TabIndex = 0;
            this.CodeHelp.Text = "CodeHelp";
            this.CodeHelp.UseVisualStyleBackColor = true;
            // 
            // OutputCode
            // 
            this.OutputCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputCode.Location = new System.Drawing.Point(345, 166);
            this.OutputCode.Multiline = true;
            this.OutputCode.Name = "OutputCode";
            this.OutputCode.ReadOnly = true;
            this.OutputCode.Size = new System.Drawing.Size(336, 157);
            this.OutputCode.TabIndex = 3;
            // 
            // helpCode
            // 
            this.helpCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpCode.Location = new System.Drawing.Point(345, 3);
            this.helpCode.Multiline = true;
            this.helpCode.Name = "helpCode";
            this.helpCode.Size = new System.Drawing.Size(336, 157);
            this.helpCode.TabIndex = 1;
            // 
            // CPUTable
            // 
            this.CPUTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUTable.ColumnCount = 2;
            this.CPUTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CPUTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CPUTable.Controls.Add(this.CodeCPU, 0, 0);
            this.CPUTable.Controls.Add(this.CPUDose, 1, 0);
            this.CPUTable.Controls.Add(this.TableUnderCPU, 0, 1);
            this.CPUTable.Location = new System.Drawing.Point(105, 52);
            this.CPUTable.Name = "CPUTable";
            this.CPUTable.RowCount = 2;
            this.CPUTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CPUTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CPUTable.Size = new System.Drawing.Size(690, 326);
            this.CPUTable.TabIndex = 16;
            this.CPUTable.Visible = false;
            // 
            // CodeCPU
            // 
            this.CodeCPU.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CodeCPU.Location = new System.Drawing.Point(3, 3);
            this.CodeCPU.Multiline = true;
            this.CodeCPU.Name = "CodeCPU";
            this.CodeCPU.Size = new System.Drawing.Size(339, 157);
            this.CodeCPU.TabIndex = 0;
            // 
            // CPUDose
            // 
            this.CPUDose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUDose.Location = new System.Drawing.Point(348, 3);
            this.CPUDose.Multiline = true;
            this.CPUDose.Name = "CPUDose";
            this.CPUDose.Size = new System.Drawing.Size(339, 157);
            this.CPUDose.TabIndex = 1;
            this.CPUDose.Text = "Run, to run the code in Coding tap";
            // 
            // TableUnderCPU
            // 
            this.TableUnderCPU.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableUnderCPU.ColumnCount = 3;
            this.TableUnderCPU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableUnderCPU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableUnderCPU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableUnderCPU.Controls.Add(this.ButtonCPU, 0, 1);
            this.TableUnderCPU.Location = new System.Drawing.Point(3, 166);
            this.TableUnderCPU.Name = "TableUnderCPU";
            this.TableUnderCPU.RowCount = 2;
            this.TableUnderCPU.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableUnderCPU.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableUnderCPU.Size = new System.Drawing.Size(339, 157);
            this.TableUnderCPU.TabIndex = 2;
            // 
            // ButtonCPU
            // 
            this.ButtonCPU.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCPU.Location = new System.Drawing.Point(3, 81);
            this.ButtonCPU.Name = "ButtonCPU";
            this.ButtonCPU.Size = new System.Drawing.Size(107, 73);
            this.ButtonCPU.TabIndex = 1;
            this.ButtonCPU.Text = "Run CPU";
            this.ButtonCPU.UseVisualStyleBackColor = true;
            this.ButtonCPU.Click += new System.EventHandler(this.ButtonCPU_Click);
            // 
            // TapName
            // 
            this.TapName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TapName.Location = new System.Drawing.Point(106, 16);
            this.TapName.Name = "TapName";
            this.TapName.ReadOnly = true;
            this.TapName.Size = new System.Drawing.Size(689, 31);
            this.TapName.TabIndex = 17;
            // 
            // Table4Tap
            // 
            this.Table4Tap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Table4Tap.ColumnCount = 2;
            this.Table4Tap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table4Tap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table4Tap.Controls.Add(this.FileOp, 0, 0);
            this.Table4Tap.Controls.Add(this.FileOpen, 1, 0);
            this.Table4Tap.Controls.Add(this.FileOPt, 1, 1);
            this.Table4Tap.Controls.Add(this.FindAllFiles, 0, 1);
            this.Table4Tap.Location = new System.Drawing.Point(105, 52);
            this.Table4Tap.Name = "Table4Tap";
            this.Table4Tap.RowCount = 2;
            this.Table4Tap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table4Tap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table4Tap.Size = new System.Drawing.Size(690, 326);
            this.Table4Tap.TabIndex = 18;
            // 
            // FileOp
            // 
            this.FileOp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileOp.ColumnCount = 1;
            this.FileOp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FileOp.Controls.Add(this.FileName, 0, 0);
            this.FileOp.Controls.Add(this.Path, 0, 1);
            this.FileOp.Location = new System.Drawing.Point(3, 3);
            this.FileOp.Name = "FileOp";
            this.FileOp.RowCount = 2;
            this.FileOp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FileOp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FileOp.Size = new System.Drawing.Size(339, 157);
            this.FileOp.TabIndex = 0;
            // 
            // FileName
            // 
            this.FileName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileName.Location = new System.Drawing.Point(3, 3);
            this.FileName.Multiline = true;
            this.FileName.Name = "FileName";
            this.FileName.PlaceholderText = "FileName";
            this.FileName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.FileName.Size = new System.Drawing.Size(333, 72);
            this.FileName.TabIndex = 0;
            // 
            // Path
            // 
            this.Path.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Path.Location = new System.Drawing.Point(3, 81);
            this.Path.Multiline = true;
            this.Path.Name = "Path";
            this.Path.PlaceholderText = "Path";
            this.Path.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Path.Size = new System.Drawing.Size(333, 73);
            this.Path.TabIndex = 1;
            // 
            // FileOpen
            // 
            this.FileOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileOpen.Location = new System.Drawing.Point(348, 3);
            this.FileOpen.Multiline = true;
            this.FileOpen.Name = "FileOpen";
            this.FileOpen.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.FileOpen.Size = new System.Drawing.Size(339, 157);
            this.FileOpen.TabIndex = 1;
            // 
            // FileOPt
            // 
            this.FileOPt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileOPt.ColumnCount = 2;
            this.FileOPt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FileOPt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FileOPt.Controls.Add(this.WAllText, 0, 0);
            this.FileOPt.Controls.Add(this.OpenFile, 1, 0);
            this.FileOPt.Controls.Add(this.NewFile, 0, 1);
            this.FileOPt.Controls.Add(this.FindFiles, 1, 1);
            this.FileOPt.Location = new System.Drawing.Point(348, 166);
            this.FileOPt.Name = "FileOPt";
            this.FileOPt.RowCount = 2;
            this.FileOPt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FileOPt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FileOPt.Size = new System.Drawing.Size(339, 157);
            this.FileOPt.TabIndex = 19;
            // 
            // WAllText
            // 
            this.WAllText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WAllText.Location = new System.Drawing.Point(3, 3);
            this.WAllText.Name = "WAllText";
            this.WAllText.Size = new System.Drawing.Size(163, 72);
            this.WAllText.TabIndex = 3;
            this.WAllText.Text = "W all text";
            this.WAllText.UseVisualStyleBackColor = true;
            this.WAllText.Click += new System.EventHandler(this.WAllText_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenFile.Location = new System.Drawing.Point(172, 3);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(164, 72);
            this.OpenFile.TabIndex = 2;
            this.OpenFile.Text = "Open File";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // NewFile
            // 
            this.NewFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewFile.Location = new System.Drawing.Point(3, 81);
            this.NewFile.Name = "NewFile";
            this.NewFile.Size = new System.Drawing.Size(163, 73);
            this.NewFile.TabIndex = 4;
            this.NewFile.Text = "New File";
            this.NewFile.UseVisualStyleBackColor = true;
            this.NewFile.Click += new System.EventHandler(this.NewFile_Click);
            // 
            // FindFiles
            // 
            this.FindFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindFiles.Location = new System.Drawing.Point(172, 81);
            this.FindFiles.Name = "FindFiles";
            this.FindFiles.Size = new System.Drawing.Size(164, 73);
            this.FindFiles.TabIndex = 5;
            this.FindFiles.Text = "FindFiles";
            this.FindFiles.UseVisualStyleBackColor = true;
            this.FindFiles.Click += new System.EventHandler(this.FindFiles_Click);
            // 
            // FindAllFiles
            // 
            this.FindAllFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindAllFiles.Location = new System.Drawing.Point(3, 166);
            this.FindAllFiles.Multiline = true;
            this.FindAllFiles.Name = "FindAllFiles";
            this.FindAllFiles.ReadOnly = true;
            this.FindAllFiles.Size = new System.Drawing.Size(339, 157);
            this.FindAllFiles.TabIndex = 20;
            // 
            // TapPanel2
            // 
            this.TapPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TapPanel2.ColumnCount = 2;
            this.TapPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TapPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TapPanel2.Controls.Add(this.UnderTapPanel2, 0, 1);
            this.TapPanel2.Controls.Add(this.CPUCode, 0, 0);
            this.TapPanel2.Controls.Add(this.CodeCPUdose, 1, 1);
            this.TapPanel2.Location = new System.Drawing.Point(106, 52);
            this.TapPanel2.Name = "TapPanel2";
            this.TapPanel2.RowCount = 2;
            this.TapPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TapPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TapPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TapPanel2.Size = new System.Drawing.Size(689, 326);
            this.TapPanel2.TabIndex = 19;
            // 
            // UnderTapPanel2
            // 
            this.UnderTapPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnderTapPanel2.ColumnCount = 3;
            this.UnderTapPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.UnderTapPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.UnderTapPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.UnderTapPanel2.Controls.Add(this.RunCPUCode, 2, 0);
            this.UnderTapPanel2.Location = new System.Drawing.Point(3, 166);
            this.UnderTapPanel2.Name = "UnderTapPanel2";
            this.UnderTapPanel2.RowCount = 2;
            this.UnderTapPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UnderTapPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UnderTapPanel2.Size = new System.Drawing.Size(338, 157);
            this.UnderTapPanel2.TabIndex = 2;
            // 
            // RunCPUCode
            // 
            this.RunCPUCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RunCPUCode.Location = new System.Drawing.Point(227, 3);
            this.RunCPUCode.Name = "RunCPUCode";
            this.RunCPUCode.Size = new System.Drawing.Size(108, 72);
            this.RunCPUCode.TabIndex = 0;
            this.RunCPUCode.Text = "Run";
            this.RunCPUCode.UseVisualStyleBackColor = true;
            this.RunCPUCode.Click += new System.EventHandler(this.RunCPUCode_Click);
            // 
            // CPUCode
            // 
            this.CPUCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUCode.Location = new System.Drawing.Point(3, 3);
            this.CPUCode.Multiline = true;
            this.CPUCode.Name = "CPUCode";
            this.CPUCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.CPUCode.Size = new System.Drawing.Size(338, 157);
            this.CPUCode.TabIndex = 3;
            // 
            // CodeCPUdose
            // 
            this.CodeCPUdose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CodeCPUdose.Location = new System.Drawing.Point(347, 166);
            this.CodeCPUdose.Multiline = true;
            this.CodeCPUdose.Name = "CodeCPUdose";
            this.CodeCPUdose.ReadOnly = true;
            this.CodeCPUdose.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CodeCPUdose.Size = new System.Drawing.Size(339, 157);
            this.CodeCPUdose.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(94, 74);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(65, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(94, 157);
            this.textBox1.TabIndex = 3;
            // 
            // TapPanel5
            // 
            this.TapPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TapPanel5.ColumnCount = 2;
            this.TapPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TapPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TapPanel5.Controls.Add(this.MusicList, 1, 0);
            this.TapPanel5.Controls.Add(this.UnderTap5, 0, 1);
            this.TapPanel5.Controls.Add(this.FilePath, 0, 0);
            this.TapPanel5.Location = new System.Drawing.Point(106, 53);
            this.TapPanel5.Name = "TapPanel5";
            this.TapPanel5.RowCount = 2;
            this.TapPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TapPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TapPanel5.Size = new System.Drawing.Size(689, 325);
            this.TapPanel5.TabIndex = 20;
            // 
            // MusicList
            // 
            this.MusicList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MusicList.Location = new System.Drawing.Point(347, 3);
            this.MusicList.Multiline = true;
            this.MusicList.Name = "MusicList";
            this.MusicList.Size = new System.Drawing.Size(339, 156);
            this.MusicList.TabIndex = 2;
            // 
            // UnderTap5
            // 
            this.UnderTap5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnderTap5.ColumnCount = 2;
            this.UnderTap5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UnderTap5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UnderTap5.Controls.Add(this.PlayMusic, 0, 0);
            this.UnderTap5.Controls.Add(this.FindMusic, 1, 1);
            this.UnderTap5.Controls.Add(this.Stop, 1, 0);
            this.UnderTap5.Controls.Add(this.LoopMusic, 0, 1);
            this.UnderTap5.Location = new System.Drawing.Point(3, 165);
            this.UnderTap5.Name = "UnderTap5";
            this.UnderTap5.RowCount = 2;
            this.UnderTap5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UnderTap5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UnderTap5.Size = new System.Drawing.Size(338, 157);
            this.UnderTap5.TabIndex = 4;
            // 
            // PlayMusic
            // 
            this.PlayMusic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayMusic.Location = new System.Drawing.Point(3, 3);
            this.PlayMusic.Name = "PlayMusic";
            this.PlayMusic.Size = new System.Drawing.Size(163, 72);
            this.PlayMusic.TabIndex = 1;
            this.PlayMusic.Text = "Play";
            this.PlayMusic.UseVisualStyleBackColor = true;
            this.PlayMusic.Click += new System.EventHandler(this.PlayMusic_Click);
            // 
            // FindMusic
            // 
            this.FindMusic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindMusic.Location = new System.Drawing.Point(172, 81);
            this.FindMusic.Name = "FindMusic";
            this.FindMusic.Size = new System.Drawing.Size(163, 73);
            this.FindMusic.TabIndex = 3;
            this.FindMusic.Text = "Find Music";
            this.FindMusic.UseVisualStyleBackColor = true;
            this.FindMusic.Click += new System.EventHandler(this.FindMusic_Click);
            // 
            // Stop
            // 
            this.Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Stop.Location = new System.Drawing.Point(172, 3);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(163, 72);
            this.Stop.TabIndex = 2;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // LoopMusic
            // 
            this.LoopMusic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoopMusic.AutoSize = true;
            this.LoopMusic.Location = new System.Drawing.Point(3, 81);
            this.LoopMusic.Name = "LoopMusic";
            this.LoopMusic.Size = new System.Drawing.Size(163, 73);
            this.LoopMusic.TabIndex = 3;
            this.LoopMusic.Text = "Loop";
            this.LoopMusic.UseVisualStyleBackColor = true;
            // 
            // FilePath
            // 
            this.FilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilePath.Location = new System.Drawing.Point(3, 3);
            this.FilePath.Multiline = true;
            this.FilePath.Name = "FilePath";
            this.FilePath.PlaceholderText = "FileName.wav";
            this.FilePath.Size = new System.Drawing.Size(338, 156);
            this.FilePath.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(94, 74);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(65, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 31);
            this.button2.TabIndex = 0;
            this.button2.Text = "Run";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(3, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(94, 157);
            this.textBox2.TabIndex = 3;
            // 
            // TapPanel6
            // 
            this.TapPanel6.ColumnCount = 2;
            this.TapPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TapPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TapPanel6.Location = new System.Drawing.Point(105, 52);
            this.TapPanel6.Name = "TapPanel6";
            this.TapPanel6.RowCount = 2;
            this.TapPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TapPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TapPanel6.Size = new System.Drawing.Size(690, 326);
            this.TapPanel6.TabIndex = 21;
            // 
            // TapPanel7
            // 
            this.TapPanel7.ColumnCount = 2;
            this.TapPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TapPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TapPanel7.Location = new System.Drawing.Point(109, 52);
            this.TapPanel7.Name = "TapPanel7";
            this.TapPanel7.RowCount = 2;
            this.TapPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TapPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TapPanel7.Size = new System.Drawing.Size(686, 326);
            this.TapPanel7.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TapPanel7);
            this.Controls.Add(this.TapPanel6);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.TapsPanel);
            this.Controls.Add(this.lockOn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.TapName);
            this.Controls.Add(this.TapPanel2);
            this.Controls.Add(this.Tap1TablePanel);
            this.Controls.Add(this.Table4Tap);
            this.Controls.Add(this.CPUTable);
            this.Controls.Add(this.TapPanel5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TapsPanel.ResumeLayout(false);
            this.Tap1TablePanel.ResumeLayout(false);
            this.Tap1TablePanel.PerformLayout();
            this.TableUnderCode.ResumeLayout(false);
            this.CPUTable.ResumeLayout(false);
            this.CPUTable.PerformLayout();
            this.TableUnderCPU.ResumeLayout(false);
            this.Table4Tap.ResumeLayout(false);
            this.Table4Tap.PerformLayout();
            this.FileOp.ResumeLayout(false);
            this.FileOp.PerformLayout();
            this.FileOPt.ResumeLayout(false);
            this.TapPanel2.ResumeLayout(false);
            this.TapPanel2.PerformLayout();
            this.UnderTapPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.TapPanel5.ResumeLayout(false);
            this.TapPanel5.PerformLayout();
            this.UnderTap5.ResumeLayout(false);
            this.UnderTap5.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button ButtonTap1;
        public System.Windows.Forms.Button ButtonTap2;
        public System.Windows.Forms.Button ButtonTap3;
        public System.Windows.Forms.Button ButtonTap4;
        public System.Windows.Forms.Button ExitButton;
        public System.Windows.Forms.Button CodeHelp;
        public System.Windows.Forms.Button lockOn;
        public System.Windows.Forms.Button ButtonCPU;
        public System.Windows.Forms.Button OpenFile;
        public System.Windows.Forms.Button WAllText;
        public System.Windows.Forms.Button NewFile;
        public System.Windows.Forms.Button FindFiles;
        public System.Windows.Forms.Timer UpdateOS;
        public System.Windows.Forms.TextBox code;
        public System.Windows.Forms.TextBox helpCode;
        public System.Windows.Forms.TextBox OutputCode;
        public System.Windows.Forms.TableLayoutPanel Tap1TablePanel;
        public System.Windows.Forms.TableLayoutPanel TableUnderCode;
        public System.Windows.Forms.TableLayoutPanel CPUTable;
        public System.Windows.Forms.TextBox CodeCPU;
        public System.Windows.Forms.TextBox CPUDose;
        public System.Windows.Forms.TableLayoutPanel TableUnderCPU;
        public System.Windows.Forms.TextBox Password;
        public System.Windows.Forms.TextBox TapName;
        public System.Windows.Forms.TextBox FileName;
        public System.Windows.Forms.TextBox Path;
        public System.Windows.Forms.TextBox FileOpen;
        public System.Windows.Forms.TextBox FindAllFiles;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Panel TapsPanel;
        public System.Windows.Forms.TableLayoutPanel Table4Tap;
        public System.Windows.Forms.TableLayoutPanel FileOp;
        public System.Windows.Forms.TableLayoutPanel FileOPt;
        private System.Windows.Forms.TableLayoutPanel TapPanel2;
        private System.Windows.Forms.TableLayoutPanel UnderTapPanel2;
        private System.Windows.Forms.Button RunCPUCode;
        private System.Windows.Forms.TextBox CPUCode;
        private System.Windows.Forms.TextBox CodeCPUdose;
        public System.Windows.Forms.Button ButtonTap5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel TapPanel5;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Button PlayMusic;
        private System.Windows.Forms.TextBox MusicList;
        private System.Windows.Forms.Button FindMusic;
        private System.Windows.Forms.TableLayoutPanel UnderTap5;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.CheckBox LoopMusic;
        public System.Windows.Forms.Button tap7;
        public System.Windows.Forms.Button Tap6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TableLayoutPanel TapPanel6;
        private System.Windows.Forms.TableLayoutPanel TapPanel7;
        public System.Windows.Forms.Button LockOff;
    }
}


