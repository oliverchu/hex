using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Diagnostics;

namespace 进制转换器CSharp
{
    public partial class Form1 : Form
    {

        static int selectItem1 = 2, selectItem2 = 2;
        static Conversion c = new Conversion();
        Process p = new Process();
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormClosing += Form1_FormClosing;
            this.Opacity = 50.0f;
            this.MaximizeBox = false;
            listBox1.SetSelected(selectItem1, true);
            listBox2.SetSelected(selectItem2, true);
            timer1.Interval = 135;
            bA.Enabled = false;
            bB.Enabled = false;
            bC.Enabled = false;
            bE.Enabled = false;
            bF.Enabled = false;
            bD.Enabled = false;
            this.CenterToScreen();
            if (!File.Exists(".\\ConvertedList.txt"))
                button3.Enabled = false;
            else
                button3.Enabled = true;
            if (!Directory.Exists(".\\Songs"))
            {
                Directory.CreateDirectory(".\\Songs");
            }
            Process pp = new Process();
            if (!File.Exists(".\\tag.dat"))
                try
                {
                    pp.StartInfo.FileName = ".\\README.txt";
                    pp.Start();
                    StreamWriter sw = File.CreateText(".\\tag.dat");
                }
                catch { }

        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("是否退出应用程序？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "Decimal-binary Conversion 2015 by Oliver";
            string[] enItems = { "Binary(B)", "Octonary(O)", "Decimal(D)", "Hexadecimal(H)" };
            button1.Text = "Clear All";
            button3.Text = "OpenFile";
            button4.Text = "Copy";
            groupBox1.Text = "Input Value";
            groupBox2.Text = "Output Value";
            groupBox3.Text = "Conversion Set";
            groupBox5.Text = "Contact Me";
            saveFileBtn.Text = "SaveToFile";
            groupBox6.Text = "Keypad";
            listBox1.Items.Clear();
            listBox1.Items.AddRange(enItems);
            listBox2.Items.Clear();
            listBox2.Items.AddRange(enItems);
            listBox1.SetSelected(selectItem1, true);
            listBox2.SetSelected(selectItem2, true);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "进制转换2015 by Oliver";
            string[] enItems = { "二进制(B)", "八进制(O)", "十进制(D)", "十六进制(H)" };
            button1.Text = "清空";
            button3.Text = "打开文件";
            button4.Text = "复制";
            groupBox1.Text = "输入数值";
            groupBox2.Text = "输出数值";
            groupBox3.Text = "转换设置";
            groupBox5.Text = "联系作者";
            saveFileBtn.Text = "保存记录";
            groupBox6.Text = "小键盘";
            listBox1.Items.Clear();
            listBox1.Items.AddRange(enItems);
            listBox2.Items.Clear();
            listBox2.Items.AddRange(enItems);
            listBox1.SetSelected(selectItem1, true);
            listBox2.SetSelected(selectItem2, true);
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.Show();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

                groupBox1.Text = listBox1.SelectedItem.ToString();

            selectItem1 = listBox1.SelectedIndex;

            if (selectItem1 == 0)
            {
                bA.Enabled = false;  //A
                bB.Enabled = false;  //B
                bC.Enabled = false;  //C
                bD.Enabled = false;  //D
                bE.Enabled = false;  //E
                bF.Enabled = false;  //F
                b0.Enabled = true;
                b1.Enabled = true;
                b2.Enabled = false;
                b3.Enabled = false;
                b4.Enabled = false; //6
                b5.Enabled = false; //9
                b6.Enabled = false; //8
                b7.Enabled = false; //7
                b8.Enabled = false;
                b9.Enabled = false;
            }
            if (selectItem1 == 1)
            {
                bA.Enabled = false;  //A
                bB.Enabled = false;  //B
                bC.Enabled = false;  //C
                bD.Enabled = false;  //D
                bE.Enabled = false;  //E
                bF.Enabled = false;  //F
                b0.Enabled = true;
                b1.Enabled = true;
                b2.Enabled = true;
                b3.Enabled = true;
                b4.Enabled = true; //6
                b5.Enabled = true; //9
                b6.Enabled = true; //8
                b7.Enabled = true; //7
                b8.Enabled = false;
                b9.Enabled = false;
            }
            if (selectItem1 == 2)
            {
                bA.Enabled = false;  //A
                bB.Enabled = false;  //B
                bC.Enabled = false;  //C
                bD.Enabled = false;  //D
                bE.Enabled = false;  //E
                bF.Enabled = false;  //F
                b0.Enabled = true;
                b1.Enabled = true;
                b2.Enabled = true;
                b3.Enabled = true;
                b4.Enabled = true; //6
                b5.Enabled = true; //9
                b6.Enabled = true; //8
                b7.Enabled = true; //7
                b8.Enabled = true;
                b9.Enabled = true;
            }
            if (selectItem1 == 3)
            {
                bA.Enabled = true;  //A
                bB.Enabled = true;  //B
                bC.Enabled = true;  //C
                bD.Enabled = true;  //D
                bE.Enabled = true;  //E
                bF.Enabled = true;  //F
                b0.Enabled = true;
                b1.Enabled = true;
                b2.Enabled = true;
                b3.Enabled = true;
                b4.Enabled = true; //6
                b5.Enabled = true; //9
                b6.Enabled = true; //8
                b7.Enabled = true; //7
                b8.Enabled = true;
                b9.Enabled = true;
            }
            StartCoverting();
            textBox1.Focus();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectItem2 = listBox2.SelectedIndex;
            groupBox2.Text = listBox2.SelectedItem.ToString();
            StartCoverting();
            textBox1.Focus();
        }

        private void StartCoverting()
        {
            long myDecimal = 0;
            if (rightInput(textBox1.Text) == true)
            {
                errorProvider1.SetError(listBox2, null);
                if (selectItem1 == 0 && selectItem2 == 2)  // 二进制转十进制
                {
                    myDecimal = c.nToDecimal(textBox1.Text, 2);
                    if (myDecimal < 0)
                        textBox2.Text = "Error";
                    else
                    {
                        textBox2.Text = myDecimal.ToString();
                    }

                }
                if (selectItem1 == 2 && selectItem2 == 2)  // 十进制转十进制
                {
                    myDecimal = c.nToDecimal(textBox1.Text, 10);
                    if (myDecimal < 0)
                        textBox2.Text = "Error";
                    else
                    {
                        textBox2.Text = myDecimal.ToString();
                    }

                }
                if (selectItem1 == 1 && selectItem2 == 2)  // 八进制转十进制
                {
                    myDecimal = c.nToDecimal(textBox1.Text, 8);
                    if (myDecimal < 0)
                        textBox2.Text = "Error";
                    else
                    {
                        textBox2.Text = myDecimal.ToString();
                    }
                }
                if (selectItem1 == 3 && selectItem2 == 2)  // 十六进制转十进制
                {
                    myDecimal = c.nToDecimal(textBox1.Text, 16);
                    if (myDecimal < 0)
                        textBox2.Text = "Error";
                    else
                    {
                        textBox2.Text = myDecimal.ToString();
                    }
                }
                if (selectItem1 == 0 && selectItem2 == 0)  // 二进制转二进制
                {
                    string myBin = c.nToBin(textBox1.Text, 2);
                    if (myBin == "")
                        textBox2.Text = "Error";
                    else
                    {
                        textBox2.Text = myBin;

                    }
                }
                if (selectItem1 == 2 && selectItem2 == 0)  // 十进制转二进制
                {
                    string myBin = c.nToBin(textBox1.Text, 10);
                    if (myBin == "")
                        textBox2.Text = "Error";
                    else
                    {
                        textBox2.Text = myBin;

                    }
                }
                if (selectItem1 == 1 && selectItem2 == 0)  // 八进制转二进制
                {

                    string myBin = c.nToBin(textBox1.Text, 8);
                    if (myBin == "")
                        textBox2.Text = "Error";
                    else
                    {
                        textBox2.Text = myBin;

                    }
                }
                if (selectItem1 == 3 && selectItem2 == 0)  // 十六进制转二进制
                {
                    string myBin = c.nToBin(textBox1.Text, 16);
                    if (myBin == "")
                        textBox2.Text = "Error";
                    else
                    {
                        textBox2.Text = myBin;

                    }
                }
                if (selectItem1 == 0 && selectItem2 == 1)  // 二进制转八进制
                {
                    string myBin = c.nToOct(textBox1.Text, 2);
                    if (myBin == "")
                        textBox2.Text = "Error";
                    else
                    {
                        textBox2.Text = myBin;

                    }
                }
                if (selectItem1 == 1 && selectItem2 == 1)  // 八进制转八进制
                {
                    string myBin = c.nToOct(textBox1.Text, 8);
                    if (myBin == "")
                        textBox2.Text = "Error";
                    else
                    {
                        textBox2.Text = myBin;

                    }
                }
                if (selectItem1 == 2 && selectItem2 == 1)  // 十进制转八进制
                {
                    string myBin = c.nToOct(textBox1.Text, 10);
                    if (myBin == "")
                        textBox2.Text = "Error";
                    else
                    {
                        textBox2.Text = myBin;

                    }
                }

                if (selectItem1 == 3 && selectItem2 == 1)  //十六进制转八进制
                {
                    string myBin = c.nToOct(textBox1.Text, 16);
                    if (myBin == "")
                        textBox2.Text = "Error";
                    else
                    {
                        textBox2.Text = myBin;

                    }
                }
                if (selectItem1 == 0 && selectItem2 == 3)  //二进制转十六进制
                {
                    string myBin = c.nToHex(textBox1.Text, 2);
                    if (myBin == "")
                        textBox2.Text = "Error";
                    else
                    {
                        textBox2.Text = myBin;

                    }
                }
                if (selectItem1 == 1 && selectItem2 == 3)  //八进制转十六进制
                {
                    string myBin = c.nToHex(textBox1.Text, 8);
                    if (myBin == "")
                        textBox2.Text = "Error";
                    else
                    {
                        textBox2.Text = myBin;

                    }
                }
                if (selectItem1 == 2 && selectItem2 == 3)  //十进制转十六进制
                {
                    string myBin = c.nToHex(textBox1.Text, 10);
                    if (myBin == "")
                        textBox2.Text = "Error";
                    else
                    {
                        textBox2.Text = myBin;

                    }
                }
                if (selectItem1 == 3 && selectItem2 == 3)  //十进制转十六进制
                {
                    string myBin = c.nToHex(textBox1.Text, 16);
                    if (myBin == "")
                        textBox2.Text = "Error";
                    else
                    {
                        textBox2.Text = myBin;

                    }
                }
                if (!File.Exists(".\\ConvertedList.txt"))
                    button3.Enabled = false;
                else
                    button3.Enabled = true;
            }

            else
            {
                return;
            }
        }
        private bool rightInput(string text)
        {
            if (text.Contains(' ') || text == "")
                return false;
            bool isTrue = true;
            foreach (char x in text)
            {
                if (!((x >= 48 && x <= 57) || (x >= 'A' && x <= 'F')))
                {
                    isTrue = false;
                }
            }
            if (isTrue == false)
                return false;
            else
            {
                isTrue = true;
                errorProvider1.SetError(textBox1, null);
                return true;
            }
        }

        private void WriteToFile(string converting, string converted, string radix, string toRadix)
        {

            FileStream fs = new FileStream(".\\ConvertedList.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            string str = converting + "  (" + radix[radix.Length - 2] + "-->" + toRadix[toRadix.Length - 2] + ")  " + converted;
            sw.WriteLine(str);
            for (int i = 0; i < str.Length; i++)
                sw.Write("=");
            sw.Write("\r\n");
            sw.Close();
            fs.Close();

        }
        #region 小键盘
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.AppendText("1");
            label2.Text = "1";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.AppendText("0");
            label2.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.AppendText("2");
            label2.Text = "2";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.AppendText("3");
            label2.Text = "3";
            textBox1.Focus();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.AppendText("4");
            label2.Text = "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.AppendText("5");
            label2.Text = "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.AppendText("6");
            label2.Text = "6";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.AppendText("7");
            label2.Text = "7";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.AppendText("8");
            label2.Text = "8";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.AppendText("9");
            label2.Text = "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.AppendText("A");
            label2.Text = "A";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.AppendText("B");
            label2.Text = "B";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.AppendText("C");
            label2.Text = "C";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.AppendText("D");
            label2.Text = "D";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.AppendText("E");
            label2.Text = "E";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.AppendText("F");
            label2.Text = "F";

        }

        private void button19_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length != 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.TextLength - 1);
                label2.Text = "←";
            }

        }
        #endregion

        private void button19_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                this.timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                label2.Text = "←";
            }
        }

        private void button19_MouseUp(object sender, MouseEventArgs e)
        {
            this.timer1.Enabled = false;
        }

        private void groupBox6_Leave(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                p.StartInfo.FileName = ".\\ConvertedList.txt";
                p.Start();
            }
            catch
            {
                MessageBox.Show("文件暂时不能打开！请检查此文件是否存在！", "无法打开",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0)
                textBox2.Text = "";
            StartCoverting();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
        bool isPlayed = false;
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int filesLength = 0;
            string songPath = "";
            var files = Directory.GetFiles(".\\Songs", "*.*", SearchOption.AllDirectories)
            .Where(s => s.EndsWith(".mp3") || s.EndsWith(".mid") || s.EndsWith(".wav") || s.EndsWith(".wma"));
            filesLength = files.Count();
            try
            {
                songPath = files.ElementAt(new Random().Next(1, filesLength));
                axWindowsMediaPlayer1.URL = @songPath;
            }
            catch
            {
                linkLabel2.Text = "NoFile!";
                linkLabel2.LinkColor = Color.Blue;
                return;
            }

            if (filesLength == 0)
            {
                linkLabel2.Text = "NoFile!";
                linkLabel2.LinkColor = Color.Blue;
                return;
            }
            if (isPlayed == false && filesLength >= 1)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                isPlayed = true;
                linkLabel2.Text = "Stop?";
                linkLabel2.LinkColor = Color.Red;
            }
            else if (isPlayed == true)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                isPlayed = false;
                linkLabel2.Text = "Relax?";
                linkLabel2.LinkColor = Color.Green;
            }

        }
        private void button4_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (textBox2.Text != "Error")
                {
                    Clipboard.SetText(textBox2.Text);
                    errorProvider1.SetError(textBox2, null);
                    MessageBox.Show("文本已复制到剪切板", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    errorProvider1.SetError(textBox2, "没有复制任何内容");
                }
            }
            catch
            {
                errorProvider1.SetError(textBox2, "没有复制任何内容");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox2, null);
            errorProvider1.SetError(saveFileBtn, null);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyValue = e.KeyChar;
            if (!((Char.IsDigit(keyValue)) || (keyValue >= 'A' && keyValue <= 'F') || e.KeyChar == 8))
                e.Handled = true;
            if (keyValue == 13)
                StartCoverting();
        }

        private void listBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                StartCoverting();
        }

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                StartCoverting();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void saveFileBtn_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "Error" && textBox2.Text != "")
            {
                errorProvider1.SetError(saveFileBtn, null);
                WriteToFile(textBox1.Text, textBox2.Text, listBox1.Text, listBox2.Text);
            }
            else 
            {
                errorProvider1.SetError(saveFileBtn, "没有可保存的值");
            }   
            textBox1.Focus();
        }
    }
}
