using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace おみくじアプリ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int lots = random.Next(5);
            string[] msg = new string[5]
            {
                "がっかり凶です。",
                "やりました！！大吉です！！",
                "まぁまぁですね、吉です。",
                "やったね。中吉です。",
                "ガーン。大凶です。"
            };
            

            label1.Text = msg[lots];

            //配列なしでやるなら！
            //label1.Text = "がっかり凶です。";
            //switch(lots)
            //{
            //    case 0:
            //        label1.Text = "やりました！！大吉です！！";
            //        break;

            //    case 1:
            //        label1.Text = "まぁまぁですね、吉です。";
            //        break;

            //    case 2:
            //        label1.Text = "やったね。中吉です。";
            //        break;

            //    case 3:
            //        label1.Text = "ガーン。大凶です。";
            //        break;
            //}
        }
    }
}
