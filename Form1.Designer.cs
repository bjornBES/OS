
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
            this.ExitTable = new System.Windows.Forms.TableLayoutPanel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.Tap1TablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.code = new System.Windows.Forms.TextBox();
            this.helpCode = new System.Windows.Forms.TextBox();
            this.TableUnderCode = new System.Windows.Forms.TableLayoutPanel();
            this.CodeHelp = new System.Windows.Forms.Button();
            this.OutputCode = new System.Windows.Forms.TextBox();
            this.doce = new System.Windows.Forms.TextBox();
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
            this.WhatFiles = new System.Windows.Forms.TextBox();
            this.UpdateWhatFile = new System.Windows.Forms.Button();
            this.TapsPanel.SuspendLayout();
            this.ExitTable.SuspendLayout();
            this.Tap1TablePanel.SuspendLayout();
            this.TableUnderCode.SuspendLayout();
            this.CPUTable.SuspendLayout();
            this.TableUnderCPU.SuspendLayout();
            this.Table4Tap.SuspendLayout();
            this.FileOp.SuspendLayout();
            this.FileOPt.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
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
            this.Password.Location = new System.Drawing.Point(300, 15);
            this.Password.Name = "Password";
            this.Password.PlaceholderText = "Password";
            this.Password.Size = new System.Drawing.Size(200, 31);
            this.Password.TabIndex = 2;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ButtonTap1
            // 
            this.ButtonTap1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonTap1.Location = new System.Drawing.Point(1, 0);
            this.ButtonTap1.Name = "ButtonTap1";
            this.ButtonTap1.Size = new System.Drawing.Size(40, 34);
            this.ButtonTap1.TabIndex = 3;
            this.ButtonTap1.UseVisualStyleBackColor = true;
            this.ButtonTap1.Click += new System.EventHandler(this.Tap1_Click);
            // 
            // ButtonTap2
            // 
            this.ButtonTap2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonTap2.Location = new System.Drawing.Point(47, 0);
            this.ButtonTap2.Name = "ButtonTap2";
            this.ButtonTap2.Size = new System.Drawing.Size(40, 34);
            this.ButtonTap2.TabIndex = 4;
            this.ButtonTap2.UseVisualStyleBackColor = true;
            this.ButtonTap2.Click += new System.EventHandler(this.Tap2_Click);
            // 
            // ButtonTap3
            // 
            this.ButtonTap3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonTap3.Location = new System.Drawing.Point(47, 40);
            this.ButtonTap3.Name = "ButtonTap3";
            this.ButtonTap3.Size = new System.Drawing.Size(40, 34);
            this.ButtonTap3.TabIndex = 5;
            this.ButtonTap3.UseVisualStyleBackColor = true;
            this.ButtonTap3.Click += new System.EventHandler(this.Tap3_Click);
            // 
            // ButtonTap4
            // 
            this.ButtonTap4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonTap4.Location = new System.Drawing.Point(1, 40);
            this.ButtonTap4.Name = "ButtonTap4";
            this.ButtonTap4.Size = new System.Drawing.Size(40, 34);
            this.ButtonTap4.TabIndex = 6;
            this.ButtonTap4.UseVisualStyleBackColor = true;
            this.ButtonTap4.Click += new System.EventHandler(this.Tap4_Click);
            // 
            // TapsPanel
            // 
            this.TapsPanel.Controls.Add(this.ExitTable);
            this.TapsPanel.Controls.Add(this.ButtonTap1);
            this.TapsPanel.Controls.Add(this.ButtonTap4);
            this.TapsPanel.Controls.Add(this.ButtonTap2);
            this.TapsPanel.Controls.Add(this.ButtonTap3);
            this.TapsPanel.Location = new System.Drawing.Point(12, 12);
            this.TapsPanel.Name = "TapsPanel";
            this.TapsPanel.Size = new System.Drawing.Size(88, 366);
            this.TapsPanel.TabIndex = 7;
            // 
            // ExitTable
            // 
            this.ExitTable.ColumnCount = 1;
            this.ExitTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ExitTable.Controls.Add(this.ExitButton, 0, 0);
            this.ExitTable.Controls.Add(this.ResetButton, 0, 1);
            this.ExitTable.Location = new System.Drawing.Point(1, 279);
            this.ExitTable.Name = "ExitTable";
            this.ExitTable.RowCount = 2;
            this.ExitTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ExitTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ExitTable.Size = new System.Drawing.Size(87, 87);
            this.ExitTable.TabIndex = 8;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.Location = new System.Drawing.Point(3, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(81, 37);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(3, 46);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(81, 38);
            this.ResetButton.TabIndex = 8;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Tap1TablePanel
            // 
            this.Tap1TablePanel.ColumnCount = 2;
            this.Tap1TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tap1TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tap1TablePanel.Controls.Add(this.code, 0, 0);
            this.Tap1TablePanel.Controls.Add(this.helpCode, 1, 0);
            this.Tap1TablePanel.Controls.Add(this.TableUnderCode, 0, 1);
            this.Tap1TablePanel.Controls.Add(this.OutputCode, 1, 1);
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
            this.code.Location = new System.Drawing.Point(3, 3);
            this.code.Multiline = true;
            this.code.Name = "code";
            this.code.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.code.Size = new System.Drawing.Size(335, 157);
            this.code.TabIndex = 0;
            this.code.TextChanged += new System.EventHandler(this.code_TextChanged);
            // 
            // helpCode
            // 
            this.helpCode.Location = new System.Drawing.Point(345, 3);
            this.helpCode.Multiline = true;
            this.helpCode.Name = "helpCode";
            this.helpCode.Size = new System.Drawing.Size(336, 157);
            this.helpCode.TabIndex = 1;
            // 
            // TableUnderCode
            // 
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
            this.TableUnderCode.Size = new System.Drawing.Size(335, 157);
            this.TableUnderCode.TabIndex = 2;
            // 
            // CodeHelp
            // 
            this.CodeHelp.Location = new System.Drawing.Point(225, 81);
            this.CodeHelp.Name = "CodeHelp";
            this.CodeHelp.Size = new System.Drawing.Size(107, 73);
            this.CodeHelp.TabIndex = 0;
            this.CodeHelp.Text = "CodeHelp";
            this.CodeHelp.UseVisualStyleBackColor = true;
            // 
            // OutputCode
            // 
            this.OutputCode.Location = new System.Drawing.Point(345, 166);
            this.OutputCode.Multiline = true;
            this.OutputCode.Name = "OutputCode";
            this.OutputCode.ReadOnly = true;
            this.OutputCode.Size = new System.Drawing.Size(336, 157);
            this.OutputCode.TabIndex = 3;
            // 
            // doce
            // 
            this.doce.Location = new System.Drawing.Point(105, 52);
            this.doce.Multiline = true;
            this.doce.Name = "doce";
            this.doce.ReadOnly = true;
            this.doce.Size = new System.Drawing.Size(684, 326);
            this.doce.TabIndex = 15;
            // 
            // CPUTable
            // 
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
            this.CodeCPU.Location = new System.Drawing.Point(3, 3);
            this.CodeCPU.Multiline = true;
            this.CodeCPU.Name = "CodeCPU";
            this.CodeCPU.Size = new System.Drawing.Size(335, 157);
            this.CodeCPU.TabIndex = 0;
            // 
            // CPUDose
            // 
            this.CPUDose.Location = new System.Drawing.Point(348, 3);
            this.CPUDose.Multiline = true;
            this.CPUDose.Name = "CPUDose";
            this.CPUDose.Size = new System.Drawing.Size(336, 157);
            this.CPUDose.TabIndex = 1;
            this.CPUDose.Text = "Run, to run the code in Coding tap";
            // 
            // TableUnderCPU
            // 
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
            this.TableUnderCPU.Size = new System.Drawing.Size(335, 157);
            this.TableUnderCPU.TabIndex = 2;
            // 
            // ButtonCPU
            // 
            this.ButtonCPU.Location = new System.Drawing.Point(3, 81);
            this.ButtonCPU.Name = "ButtonCPU";
            this.ButtonCPU.Size = new System.Drawing.Size(105, 73);
            this.ButtonCPU.TabIndex = 1;
            this.ButtonCPU.Text = "Run CPU";
            this.ButtonCPU.UseVisualStyleBackColor = true;
            this.ButtonCPU.Click += new System.EventHandler(this.ButtonCPU_Click);
            // 
            // TapName
            // 
            this.TapName.Location = new System.Drawing.Point(106, 16);
            this.TapName.Name = "TapName";
            this.TapName.ReadOnly = true;
            this.TapName.Size = new System.Drawing.Size(689, 31);
            this.TapName.TabIndex = 17;
            // 
            // Table4Tap
            // 
            this.Table4Tap.ColumnCount = 2;
            this.Table4Tap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table4Tap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table4Tap.Controls.Add(this.FileOp, 0, 0);
            this.Table4Tap.Controls.Add(this.FileOpen, 1, 0);
            this.Table4Tap.Controls.Add(this.FileOPt, 1, 1);
            this.Table4Tap.Controls.Add(this.WhatFiles, 0, 1);
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
            this.FileOpen.Location = new System.Drawing.Point(348, 3);
            this.FileOpen.Multiline = true;
            this.FileOpen.Name = "FileOpen";
            this.FileOpen.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.FileOpen.Size = new System.Drawing.Size(339, 157);
            this.FileOpen.TabIndex = 1;
            // 
            // FileOPt
            // 
            this.FileOPt.ColumnCount = 2;
            this.FileOPt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FileOPt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FileOPt.Controls.Add(this.WAllText, 0, 0);
            this.FileOPt.Controls.Add(this.OpenFile, 1, 0);
            this.FileOPt.Controls.Add(this.NewFile, 0, 1);
            this.FileOPt.Controls.Add(this.UpdateWhatFile, 1, 1);
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
            this.NewFile.Location = new System.Drawing.Point(3, 81);
            this.NewFile.Name = "NewFile";
            this.NewFile.Size = new System.Drawing.Size(163, 73);
            this.NewFile.TabIndex = 4;
            this.NewFile.Text = "New File";
            this.NewFile.UseVisualStyleBackColor = true;
            this.NewFile.Click += new System.EventHandler(this.NewFile_Click);
            // 
            // WhatFiles
            // 
            this.WhatFiles.Location = new System.Drawing.Point(3, 166);
            this.WhatFiles.Multiline = true;
            this.WhatFiles.Name = "WhatFiles";
            this.WhatFiles.ReadOnly = true;
            this.WhatFiles.Size = new System.Drawing.Size(339, 157);
            this.WhatFiles.TabIndex = 20;
            // 
            // UpdateWhatFile
            // 
            this.UpdateWhatFile.Location = new System.Drawing.Point(172, 81);
            this.UpdateWhatFile.Name = "UpdateWhatFile";
            this.UpdateWhatFile.Size = new System.Drawing.Size(164, 73);
            this.UpdateWhatFile.TabIndex = 5;
            this.UpdateWhatFile.Text = "Update Files";
            this.UpdateWhatFile.UseVisualStyleBackColor = true;
            this.UpdateWhatFile.Click += new System.EventHandler(this.UpdateWhatFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.TapsPanel);
            this.Controls.Add(this.lockOn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.TapName);
            this.Controls.Add(this.Table4Tap);
            this.Controls.Add(this.CPUTable);
            this.Controls.Add(this.doce);
            this.Controls.Add(this.Tap1TablePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TapsPanel.ResumeLayout(false);
            this.ExitTable.ResumeLayout(false);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region buttons
        #region Taps
        private System.Windows.Forms.Button ButtonTap1;
        private System.Windows.Forms.Button ButtonTap2;
        private System.Windows.Forms.Button ButtonTap3;
        private System.Windows.Forms.Button ButtonTap4;
        #endregion
        private System.Windows.Forms.Button CodeHelp;
        private System.Windows.Forms.Button lockOn;
        private System.Windows.Forms.Button ButtonCPU;
        #endregion
        #region BG
        #region timers
        private System.Windows.Forms.Timer UpdateOS;
        #endregion
        #endregion
        #region Taps
        #region code
        #region text
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.TextBox helpCode;
        private System.Windows.Forms.TextBox doce;
        private System.Windows.Forms.TextBox OutputCode;
        #endregion
        #region table
        private System.Windows.Forms.TableLayoutPanel Tap1TablePanel;
        private System.Windows.Forms.TableLayoutPanel TableUnderCode;
        #endregion
        #endregion
        #region CPU
        private System.Windows.Forms.TableLayoutPanel CPUTable;
        private System.Windows.Forms.TextBox CodeCPU;
        private System.Windows.Forms.TextBox CPUDose;
        private System.Windows.Forms.TableLayoutPanel TableUnderCPU;
        #endregion
        #endregion
        #region textbox
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox TapName;
        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel TapsPanel;
        private System.Windows.Forms.TableLayoutPanel Table4Tap;
        private System.Windows.Forms.TableLayoutPanel FileOp;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.TextBox Path;
        private System.Windows.Forms.TextBox FileOpen;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button WAllText;
        private System.Windows.Forms.TableLayoutPanel FileOPt;
        private System.Windows.Forms.Button NewFile;
        private System.Windows.Forms.TableLayoutPanel ExitTable;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TextBox WhatFiles;
        private System.Windows.Forms.Button UpdateWhatFile;
    }
}

