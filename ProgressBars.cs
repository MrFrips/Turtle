using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turtle
{
    public partial class ProgressBars : Form
    {
        public ProgressBars()
        {
            InitializeComponent();
            progressBar1.Maximum= 1000;
            DotTimer.Interval = 750;
        }
        public void ProgressBars_Load(object sender, EventArgs e)
        {
            ProgressTimer.Start();
            DotTimer.Start();
        }
        async private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 1000)
            {
                progressBar1.Increment(21);
                progressBar1.Refresh();
                //progressBar1.Value = progressBar1.Value + 10;
            }else
            {
                await Task.Delay(420);
                this.Close();
            }
        }
        int numDots = 1;
        private void DotTimer_Tick_1(object sender, EventArgs e)
        {
            string dots = "";
            for (int idx = 1; idx <= numDots; ++idx) dots += ".";
            TextLoading.Text = $"Загрузка" + dots;
            numDots++;
            if (numDots > 3) numDots = 1;
        }
    }
}
