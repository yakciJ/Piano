using System.DirectoryServices.ActiveDirectory;
using System.IO;

namespace Piano
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            player.URL = @"C:\Users\Administrator\OneDrive\Documents\Coding\CsProject\Piano\bin\Debug\Sound\key01.mp3";
            player.controls.play();
        }
    }
}
