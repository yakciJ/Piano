using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.IO;
using WMPLib;
namespace Piano
{
    public partial class Form1 : Form
    {

        public void play(string key)
        {
            WindowsMediaPlayer player = new WindowsMediaPlayer();

            string path = @"" + AppDomain.CurrentDomain.BaseDirectory + "Sound\\key";
            switch (key)
            {
                case "01":
                    path = @"" + path + key + ".mp3";
                    player.URL = path;
                    player.controls.play();
                    break;
                case "02":
                    path = @"" + path + key + ".mp3";
                    player.URL = path;
                    player.controls.play();
                    break;
                case "03":
                    path = @"" + path + key + ".mp3";
                    player.URL = path;
                    player.controls.play();
                    break;
                case "04":
                    path = @"" + path + key + ".mp3";
                    player.URL = path;
                    player.controls.play();
                    break;
                case "05":
                    path = @"" + path + key + ".mp3";
                    player.URL = path;
                    player.controls.play();
                    break;
                case "06":
                    path = @"" + path + key + ".mp3";
                    player.URL = path;
                    player.controls.play();
                    break;
                case "07":
                    path = @"" + path + key + ".mp3";
                    player.URL = path;
                    player.controls.play();
                    break;
                case "08":
                    path = @"" + path + key + ".mp3";
                    player.URL = path;
                    player.controls.play();
                    break;
                default: break;
            }
        }


        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1: 
                    play("01");
                    break;
                case Keys.D2:
                    play("02");
                    break;
                case Keys.D3:
                    play("03");
                    break;
                case Keys.D4:
                    play("04");
                    break;
                case Keys.D5:
                    play("05");
                    break;
                case Keys.D6:
                    play("06");
                    break;
                case Keys.D7:
                    play("07");
                    break;
                case Keys.D8:
                    play("08");
                    break;
                default: break;
            }
            if (e.KeyCode == Keys.Space)
            {
                play("01");  // This will call the button1_Click event handler
            }
        }
        public Form1()
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            play("01");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            play("02");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            play("03");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            play("04");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            play("05");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            play("06");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            play("07");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            play("08");
        }
    }
}
