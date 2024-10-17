using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace up1_karta_dzwiekowa
{
    public partial class Form1 : Form
    {
        private String selectedFile;
        SoundPlayer player = null;
        public Form1()
        {
            InitializeComponent();
        }
        //--------------------------- Wybieranie pliku ----------------------------------------
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Pliki dźwiękowe (*.wav)|*.wav|Wszystkie pliki (*.*)|*.*";
                openFileDialog.Title = "Wybierz plik dźwiękowy";
                
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFile = openFileDialog.FileName;
                    txtFilePath.Text = selectedFile;
                }
            }
        }

        private void txtFilePath_TextChanged(object sender, EventArgs e)
        {

        }
        //--------------------- Play Sound ----------------------------------------
        private void btnPlaySoundStart_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(selectedFile))
            {
                player = new SoundPlayer(selectedFile);
                player.Play();
            }
        }

        private void btnPlaySoundStop_Click(object sender, EventArgs e)
        {
            if (player != null)
            {
                player.Stop();
                player.Dispose();
            }
        }
        //-------------------- Windows Media Player ------------------------------------
        private void btnWMPStart_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(selectedFile))
            {
                wmpPlayer.URL = selectedFile;
                wmpPlayer.Ctlcontrols.play();
            }
        }

        private void btnWMPStop_Click(object sender, EventArgs e)
        {
            wmpPlayer.Ctlcontrols.stop();
        }

        private void btnWMPPause_Click(object sender, EventArgs e)
        {
            wmpPlayer.Ctlcontrols.pause();
        }
        private void btnWMPContinue_Click(object sender, EventArgs e)
        {
            wmpPlayer.Ctlcontrols.play();
        }
        //----------------------- Media Control Interface ---------------------------
        [DllImport("winmm.dll")]
        public static extern int mciSendString(string command, StringBuilder buffer, int bufferSize, IntPtr hwndCallback);

        private void btnMCIStart_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedFile))
            {
                string command = $"open \"{selectedFile}\" type waveaudio alias sound";
                mciSendString(command, null, 0, IntPtr.Zero);
                mciSendString("play sound", null, 0, IntPtr.Zero);
            }
        }

        private void btnMCIStop_Click(object sender, EventArgs e)
        {
            mciSendString("stop sound", null, 0, IntPtr.Zero);
            mciSendString("close sound", null, 0, IntPtr.Zero);
        }

        private void btnMCIPause_Click(object sender, EventArgs e)
        {
            mciSendString("pause sound", null, 0, IntPtr.Zero);
        }

        //---------------------------- Direct Sound ------------------------------
        private void btnDirectSoundStart_Click(object sender, EventArgs e)
        {

        }

        private void btnDirectSoundStop_Click(object sender, EventArgs e)
        {

        }

        private void btnDirectSoundPause_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //----------------------------- nagrywanie MCI ------------------------------------
        private void btnStartRecording_Click(object sender, EventArgs e)
        {
            string command = "open new type waveaudio alias mic";
            mciSendString(command, null, 0, IntPtr.Zero);
            command = "set mic channels 2 samplespersec 44100 bitspersample 16";
            mciSendString(command, null, 0, IntPtr.Zero);
            command = "record mic";
            mciSendString(command, null, 0, IntPtr.Zero);
        }

        private void btnStopRecording_Click(object sender, EventArgs e)
        {
            string command = "stop mic";
            mciSendString(command, null, 0, IntPtr.Zero);
            command = "save mic C:\\Users\\aorlo\\Downloads\\nagranie.wav";
            mciSendString(command, null, 0, IntPtr.Zero);
            command = "close mic";
            mciSendString(command, null, 0, IntPtr.Zero);
        }
    }
}
