using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Turtle
{
    public partial class TurtleLoad : Form
    {
        public TurtleLoad()
        {
            InitializeComponent();
            ProgresTurtleBar.Maximum = 2000;
            Notify_Done.Icon = new Icon("C:\\Users\\portt\\Pictures\\For-C#\\Ico-Fox.ico");
        }

        private void TurtleLoad_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("C:\\Users\\portt\\Pictures\\For-C#\\turtle.gif");
            TurtleTimer.Start();
            DotsTim.Start();
            DotsTim.Interval = 600;
        }

        private async void TurtleTimer_Tick(object sender, EventArgs e)
        {
            if (ProgresTurtleBar.Value != 2000)
            {
                ProgresTurtleBar.Increment(21);
                ProgresTurtleBar.Refresh();
                //progressBar1.Value = progressBar1.Value + 10;
            }
            else
            {
                TurtleTimer.Stop();
                await Task.Delay(420);
                this.Close();
            }
        }
        
        private void TurtleLoad_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Notify_Done.BalloonTipText = "Преждевременное закрытие...";
            //Notify_Done.ShowBalloonTip(100);
        }

        private void TurtleLoad_FormClosing(object sender, FormClosingEventArgs e)
        {
            Notify_Done.BalloonTipText = "Программа завершила расчёт!";
            Notify_Done.ShowBalloonTip(1000);
        }

        private void ProgresTurtleBar_Click(object sender, EventArgs e)
        {

        }
        int numDots = 1;
        private void DotsTim_Tick(object sender, EventArgs e)
        {
            string dots = "";
            for (int idx = 1; idx <= numDots; ++idx) dots += ".";
            LoadText.Text = $"Загрузка" + dots;
            numDots++;
            if (numDots > 3) numDots = 1;
        }
    }
}
