using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace 进制转换器CSharp
{
    partial class AboutBox1 : Form
    {
        static int scrWidth = Screen.PrimaryScreen.WorkingArea.Width;
        static int scrHeight = Screen.PrimaryScreen.WorkingArea.Height;
        static int curPosX = 0;
        static int curPosY = 0;
        static int formPosX = 0;
        static int formPosY = 0;
        static int timerCount = 0;
        public AboutBox1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void okButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            timer1.Stop();
        }

        private void AboutBox1_MouseEnter(object sender, EventArgs e)
        {
            curPosX = Cursor.Position.X;
            curPosY = Cursor.Position.Y;
            formPosX = this.DesktopLocation.X;
            formPosY = this.DesktopLocation.Y;
            for(int i=curPosX-formPosX,j=curPosY-formPosY;i>0&&j>0;i--,j--)
            this.SetDesktopLocation(curPosX-i, curPosY-j);
            
        }

        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerCount++;
            if (timerCount % 5 ==0)
            {
                MessageBox.Show(this,"Don't touch me!","提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);             
                this.Hide();
                timer1.Stop();
            }
                
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void AboutBox1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
