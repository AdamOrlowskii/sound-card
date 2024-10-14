namespace up1_karta_dzwiekowa
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnPlaySoundStart = new System.Windows.Forms.Button();
            this.btnPlaySoundStop = new System.Windows.Forms.Button();
            this.btnWMPStart = new System.Windows.Forms.Button();
            this.btnWMPStop = new System.Windows.Forms.Button();
            this.btnWMPPause = new System.Windows.Forms.Button();
            this.btnMCIStart = new System.Windows.Forms.Button();
            this.btnMCIStop = new System.Windows.Forms.Button();
            this.btnMCIPause = new System.Windows.Forms.Button();
            this.btnWaveOutStart = new System.Windows.Forms.Button();
            this.btnWaveOutStop = new System.Windows.Forms.Button();
            this.btnDirectSoundStart = new System.Windows.Forms.Button();
            this.btnDirectSoundStop = new System.Windows.Forms.Button();
            this.btnDirectSoundPause = new System.Windows.Forms.Button();
            this.wmpPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.labPlaySound = new System.Windows.Forms.Label();
            this.labMCI = new System.Windows.Forms.Label();
            this.labWMP = new System.Windows.Forms.Label();
            this.labWaveOutWrite = new System.Windows.Forms.Label();
            this.labDirectSound = new System.Windows.Forms.Label();
            this.btnWMPContinue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wmpPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(13, 12);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(274, 33);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "SELECT FILE";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(13, 52);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(274, 22);
            this.txtFilePath.TabIndex = 1;
            this.txtFilePath.TextChanged += new System.EventHandler(this.txtFilePath_TextChanged);
            // 
            // btnPlaySoundStart
            // 
            this.btnPlaySoundStart.Location = new System.Drawing.Point(12, 157);
            this.btnPlaySoundStart.Name = "btnPlaySoundStart";
            this.btnPlaySoundStart.Size = new System.Drawing.Size(99, 33);
            this.btnPlaySoundStart.TabIndex = 2;
            this.btnPlaySoundStart.Text = "PS START";
            this.btnPlaySoundStart.UseVisualStyleBackColor = true;
            this.btnPlaySoundStart.Click += new System.EventHandler(this.btnPlaySoundStart_Click);
            // 
            // btnPlaySoundStop
            // 
            this.btnPlaySoundStop.Location = new System.Drawing.Point(14, 196);
            this.btnPlaySoundStop.Name = "btnPlaySoundStop";
            this.btnPlaySoundStop.Size = new System.Drawing.Size(99, 33);
            this.btnPlaySoundStop.TabIndex = 3;
            this.btnPlaySoundStop.Text = "PS STOP";
            this.btnPlaySoundStop.UseVisualStyleBackColor = true;
            this.btnPlaySoundStop.Click += new System.EventHandler(this.btnPlaySoundStop_Click);
            // 
            // btnWMPStart
            // 
            this.btnWMPStart.Location = new System.Drawing.Point(143, 157);
            this.btnWMPStart.Name = "btnWMPStart";
            this.btnWMPStart.Size = new System.Drawing.Size(129, 33);
            this.btnWMPStart.TabIndex = 4;
            this.btnWMPStart.Text = "WMP START";
            this.btnWMPStart.UseVisualStyleBackColor = true;
            this.btnWMPStart.Click += new System.EventHandler(this.btnWMPStart_Click);
            // 
            // btnWMPStop
            // 
            this.btnWMPStop.Location = new System.Drawing.Point(143, 196);
            this.btnWMPStop.Name = "btnWMPStop";
            this.btnWMPStop.Size = new System.Drawing.Size(129, 33);
            this.btnWMPStop.TabIndex = 5;
            this.btnWMPStop.Text = "WMP STOP";
            this.btnWMPStop.UseVisualStyleBackColor = true;
            this.btnWMPStop.Click += new System.EventHandler(this.btnWMPStop_Click);
            // 
            // btnWMPPause
            // 
            this.btnWMPPause.Location = new System.Drawing.Point(143, 235);
            this.btnWMPPause.Name = "btnWMPPause";
            this.btnWMPPause.Size = new System.Drawing.Size(129, 29);
            this.btnWMPPause.TabIndex = 6;
            this.btnWMPPause.Text = "WMP PAUSE";
            this.btnWMPPause.UseVisualStyleBackColor = true;
            this.btnWMPPause.Click += new System.EventHandler(this.btnWMPPause_Click);
            // 
            // btnMCIStart
            // 
            this.btnMCIStart.Location = new System.Drawing.Point(301, 157);
            this.btnMCIStart.Name = "btnMCIStart";
            this.btnMCIStart.Size = new System.Drawing.Size(114, 32);
            this.btnMCIStart.TabIndex = 8;
            this.btnMCIStart.Text = "MCI START";
            this.btnMCIStart.UseVisualStyleBackColor = true;
            this.btnMCIStart.Click += new System.EventHandler(this.btnMCIStart_Click);
            // 
            // btnMCIStop
            // 
            this.btnMCIStop.Location = new System.Drawing.Point(301, 195);
            this.btnMCIStop.Name = "btnMCIStop";
            this.btnMCIStop.Size = new System.Drawing.Size(114, 32);
            this.btnMCIStop.TabIndex = 9;
            this.btnMCIStop.Text = "MCI STOP";
            this.btnMCIStop.UseVisualStyleBackColor = true;
            this.btnMCIStop.Click += new System.EventHandler(this.btnMCIStop_Click);
            // 
            // btnMCIPause
            // 
            this.btnMCIPause.Location = new System.Drawing.Point(301, 231);
            this.btnMCIPause.Name = "btnMCIPause";
            this.btnMCIPause.Size = new System.Drawing.Size(114, 33);
            this.btnMCIPause.TabIndex = 10;
            this.btnMCIPause.Text = "MCI PAUSE";
            this.btnMCIPause.UseVisualStyleBackColor = true;
            this.btnMCIPause.Click += new System.EventHandler(this.btnMCIPause_Click);
            // 
            // btnWaveOutStart
            // 
            this.btnWaveOutStart.Location = new System.Drawing.Point(14, 353);
            this.btnWaveOutStart.Name = "btnWaveOutStart";
            this.btnWaveOutStart.Size = new System.Drawing.Size(99, 28);
            this.btnWaveOutStart.TabIndex = 11;
            this.btnWaveOutStart.Text = "WV START";
            this.btnWaveOutStart.UseVisualStyleBackColor = true;
            this.btnWaveOutStart.Click += new System.EventHandler(this.btnWaveOutStart_Click);
            // 
            // btnWaveOutStop
            // 
            this.btnWaveOutStop.Location = new System.Drawing.Point(14, 389);
            this.btnWaveOutStop.Name = "btnWaveOutStop";
            this.btnWaveOutStop.Size = new System.Drawing.Size(99, 32);
            this.btnWaveOutStop.TabIndex = 12;
            this.btnWaveOutStop.Text = "WV STOP";
            this.btnWaveOutStop.UseVisualStyleBackColor = true;
            this.btnWaveOutStop.Click += new System.EventHandler(this.btnWaveOutStop_Click);
            // 
            // btnDirectSoundStart
            // 
            this.btnDirectSoundStart.Location = new System.Drawing.Point(143, 353);
            this.btnDirectSoundStart.Name = "btnDirectSoundStart";
            this.btnDirectSoundStart.Size = new System.Drawing.Size(129, 28);
            this.btnDirectSoundStart.TabIndex = 13;
            this.btnDirectSoundStart.Text = "DS START";
            this.btnDirectSoundStart.UseVisualStyleBackColor = true;
            this.btnDirectSoundStart.Click += new System.EventHandler(this.btnDirectSoundStart_Click);
            // 
            // btnDirectSoundStop
            // 
            this.btnDirectSoundStop.Location = new System.Drawing.Point(143, 389);
            this.btnDirectSoundStop.Name = "btnDirectSoundStop";
            this.btnDirectSoundStop.Size = new System.Drawing.Size(129, 32);
            this.btnDirectSoundStop.TabIndex = 14;
            this.btnDirectSoundStop.Text = "DS STOP";
            this.btnDirectSoundStop.UseVisualStyleBackColor = true;
            this.btnDirectSoundStop.Click += new System.EventHandler(this.btnDirectSoundStop_Click);
            // 
            // btnDirectSoundPause
            // 
            this.btnDirectSoundPause.Location = new System.Drawing.Point(143, 427);
            this.btnDirectSoundPause.Name = "btnDirectSoundPause";
            this.btnDirectSoundPause.Size = new System.Drawing.Size(129, 29);
            this.btnDirectSoundPause.TabIndex = 15;
            this.btnDirectSoundPause.Text = "DS PAUSE";
            this.btnDirectSoundPause.UseVisualStyleBackColor = true;
            this.btnDirectSoundPause.Click += new System.EventHandler(this.btnDirectSoundPause_Click);
            // 
            // wmpPlayer
            // 
            this.wmpPlayer.Enabled = true;
            this.wmpPlayer.Location = new System.Drawing.Point(494, 12);
            this.wmpPlayer.Name = "wmpPlayer";
            this.wmpPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpPlayer.OcxState")));
            this.wmpPlayer.Size = new System.Drawing.Size(741, 515);
            this.wmpPlayer.TabIndex = 7;
            // 
            // labPlaySound
            // 
            this.labPlaySound.AutoSize = true;
            this.labPlaySound.Location = new System.Drawing.Point(23, 118);
            this.labPlaySound.Name = "labPlaySound";
            this.labPlaySound.Size = new System.Drawing.Size(76, 16);
            this.labPlaySound.TabIndex = 16;
            this.labPlaySound.Text = "Play Sound";
            this.labPlaySound.Click += new System.EventHandler(this.label1_Click);
            // 
            // labMCI
            // 
            this.labMCI.AutoSize = true;
            this.labMCI.Location = new System.Drawing.Point(279, 118);
            this.labMCI.Name = "labMCI";
            this.labMCI.Size = new System.Drawing.Size(144, 16);
            this.labMCI.TabIndex = 17;
            this.labMCI.Text = "Media Control Interface";
            // 
            // labWMP
            // 
            this.labWMP.AutoSize = true;
            this.labWMP.Location = new System.Drawing.Point(127, 118);
            this.labWMP.Name = "labWMP";
            this.labWMP.Size = new System.Drawing.Size(145, 16);
            this.labWMP.TabIndex = 18;
            this.labWMP.Text = "Windows Media Player";
            // 
            // labWaveOutWrite
            // 
            this.labWaveOutWrite.AutoSize = true;
            this.labWaveOutWrite.Location = new System.Drawing.Point(13, 320);
            this.labWaveOutWrite.Name = "labWaveOutWrite";
            this.labWaveOutWrite.Size = new System.Drawing.Size(100, 16);
            this.labWaveOutWrite.TabIndex = 19;
            this.labWaveOutWrite.Text = "Wave Out Write";
            // 
            // labDirectSound
            // 
            this.labDirectSound.AutoSize = true;
            this.labDirectSound.Location = new System.Drawing.Point(155, 320);
            this.labDirectSound.Name = "labDirectSound";
            this.labDirectSound.Size = new System.Drawing.Size(84, 16);
            this.labDirectSound.TabIndex = 20;
            this.labDirectSound.Text = "Direct Sound";
            // 
            // btnWMPContinue
            // 
            this.btnWMPContinue.Location = new System.Drawing.Point(143, 270);
            this.btnWMPContinue.Name = "btnWMPContinue";
            this.btnWMPContinue.Size = new System.Drawing.Size(129, 27);
            this.btnWMPContinue.TabIndex = 21;
            this.btnWMPContinue.Text = "WMP CONTINUE";
            this.btnWMPContinue.UseVisualStyleBackColor = true;
            this.btnWMPContinue.Click += new System.EventHandler(this.btnWMPContinue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 539);
            this.Controls.Add(this.btnWMPContinue);
            this.Controls.Add(this.labDirectSound);
            this.Controls.Add(this.labWaveOutWrite);
            this.Controls.Add(this.labWMP);
            this.Controls.Add(this.labMCI);
            this.Controls.Add(this.labPlaySound);
            this.Controls.Add(this.btnDirectSoundPause);
            this.Controls.Add(this.btnDirectSoundStop);
            this.Controls.Add(this.btnDirectSoundStart);
            this.Controls.Add(this.btnWaveOutStop);
            this.Controls.Add(this.btnWaveOutStart);
            this.Controls.Add(this.btnMCIPause);
            this.Controls.Add(this.btnMCIStop);
            this.Controls.Add(this.btnMCIStart);
            this.Controls.Add(this.wmpPlayer);
            this.Controls.Add(this.btnWMPPause);
            this.Controls.Add(this.btnWMPStop);
            this.Controls.Add(this.btnWMPStart);
            this.Controls.Add(this.btnPlaySoundStop);
            this.Controls.Add(this.btnPlaySoundStart);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnSelectFile);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.wmpPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnPlaySoundStart;
        private System.Windows.Forms.Button btnPlaySoundStop;
        private System.Windows.Forms.Button btnWMPStart;
        private System.Windows.Forms.Button btnWMPStop;
        private System.Windows.Forms.Button btnWMPPause;
        private AxWMPLib.AxWindowsMediaPlayer wmpPlayer;
        private System.Windows.Forms.Button btnMCIStart;
        private System.Windows.Forms.Button btnMCIStop;
        private System.Windows.Forms.Button btnMCIPause;
        private System.Windows.Forms.Button btnWaveOutStart;
        private System.Windows.Forms.Button btnWaveOutStop;
        private System.Windows.Forms.Button btnDirectSoundStart;
        private System.Windows.Forms.Button btnDirectSoundStop;
        private System.Windows.Forms.Button btnDirectSoundPause;
        private System.Windows.Forms.Label labPlaySound;
        private System.Windows.Forms.Label labMCI;
        private System.Windows.Forms.Label labWMP;
        private System.Windows.Forms.Label labWaveOutWrite;
        private System.Windows.Forms.Label labDirectSound;
        private System.Windows.Forms.Button btnWMPContinue;
    }
}

