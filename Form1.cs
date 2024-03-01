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
            string path = AppDomain.CurrentDomain.BaseDirectory + "Sound\\key" + key + ".mp3";
            player.URL = path;
            player.controls.play();
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
                case Keys.Q:
                    play("09");
                    break;
                case Keys.W:
                    play("10");
                    break;
                case Keys.E:
                    play("11");
                    break;
                case Keys.R:
                    play("12");
                    break;
                case Keys.T:
                    play("13");
                    break;
                case Keys.Y:
                    play("14");
                    break;
                case Keys.U:
                    play("15");
                    break;
                case Keys.I:
                    play("16");
                    break;
                case Keys.A:
                    play("17");
                    break;
                case Keys.S:
                    play("18");
                    break;
                case Keys.D:
                    play("19");
                    break;
                case Keys.F:
                    play("20");
                    break;
                case Keys.G:
                    play("21");
                    break;
                case Keys.H:
                    play("22");
                    break;
                case Keys.J:
                    play("23");
                    break;
                case Keys.K:
                    play("24");
                    break;
                default: break;
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

        private void button9_Click(object sender, EventArgs e)
        {
            play("09");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            play("10");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            play("11");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            play("12");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            play("13");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            play("14");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            play("15");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            play("16");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            play("17");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            play("18");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            play("19");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            play("20");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            play("21");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            play("22");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            play("23");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            play("24");
        }
    }
}
