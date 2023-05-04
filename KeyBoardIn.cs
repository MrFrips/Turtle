using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turtle
{
    public partial class KeyBoardIn : Form
    {
        public KeyBoardIn()
        {
            InitializeComponent();
            //KeyBoardInfoText.Clear();
        }

        private void KeyBoardIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            InfoFromKeyboard.KeyBoardInfo = KeyBoardInfoText.Text;
        }

        private void KeyBoardIn_Load(object sender, EventArgs e)
        {
            KeyBoardInfoText.Text = InfoFromKeyboard.KeyBoardInfo;
        }

        private void SaveKeyBoardinfo_Click(object sender, EventArgs e)
        {
            InfoFromKeyboard.KeyBoardInfo = KeyBoardInfoText.Text;
            this.Close();
        }

        private void KeyBoardInfoText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
