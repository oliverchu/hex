namespace 进制转换器CSharp
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clrKey = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bD = new System.Windows.Forms.Button();
            this.bE = new System.Windows.Forms.Button();
            this.bF = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.bB = new System.Windows.Forms.Button();
            this.bA = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.saveFileBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.textBox1.Location = new System.Drawing.Point(6, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 52);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入数值";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(320, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "清空";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(12, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 101);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "转换数值";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(349, 39);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 40);
            this.button4.TabIndex = 1;
            this.button4.Text = "复制";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(6, 20);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(337, 75);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.saveFileBtn);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.listBox2);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(404, 114);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "转换设置";
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.DeepPink;
            this.button3.Location = new System.Drawing.Point(314, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 36);
            this.button3.TabIndex = 18;
            this.button3.Text = "查看文件";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(128, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "--->";
            // 
            // listBox2
            // 
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Items.AddRange(new object[] {
            "二进制(B)",
            "八进制(O)",
            "十进制(D)",
            "十六进制(H)"});
            this.listBox2.Location = new System.Drawing.Point(177, 20);
            this.listBox2.Name = "listBox2";
            this.listBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox2.Size = new System.Drawing.Size(115, 82);
            this.listBox2.TabIndex = 1;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            this.listBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBox2_KeyPress);
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "二进制(B)",
            "八进制(O)",
            "十进制(D)",
            "十六进制(H)"});
            this.listBox1.Location = new System.Drawing.Point(7, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBox1.Size = new System.Drawing.Size(115, 82);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Location = new System.Drawing.Point(12, 297);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(156, 45);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "语言设置/Lauguage";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(69, 23);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "English";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "中文";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.linkLabel1);
            this.groupBox5.Location = new System.Drawing.Point(260, 297);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(156, 45);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "联系作者";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.LinkVisited = true;
            this.linkLabel1.Location = new System.Drawing.Point(44, 17);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(68, 17);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Oliver Chu";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.clrKey);
            this.groupBox6.Controls.Add(this.b0);
            this.groupBox6.Controls.Add(this.bD);
            this.groupBox6.Controls.Add(this.bE);
            this.groupBox6.Controls.Add(this.bF);
            this.groupBox6.Controls.Add(this.bC);
            this.groupBox6.Controls.Add(this.bB);
            this.groupBox6.Controls.Add(this.bA);
            this.groupBox6.Controls.Add(this.b9);
            this.groupBox6.Controls.Add(this.b8);
            this.groupBox6.Controls.Add(this.b7);
            this.groupBox6.Controls.Add(this.b6);
            this.groupBox6.Controls.Add(this.b5);
            this.groupBox6.Controls.Add(this.b4);
            this.groupBox6.Controls.Add(this.b3);
            this.groupBox6.Controls.Add(this.b2);
            this.groupBox6.Controls.Add(this.b1);
            this.groupBox6.Location = new System.Drawing.Point(422, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(188, 330);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "小键盘";
            this.groupBox6.Leave += new System.EventHandler(this.groupBox6_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(62, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 75);
            this.label2.TabIndex = 17;
            // 
            // clrKey
            // 
            this.clrKey.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clrKey.ForeColor = System.Drawing.Color.Crimson;
            this.clrKey.Location = new System.Drawing.Point(144, 97);
            this.clrKey.Name = "clrKey";
            this.clrKey.Size = new System.Drawing.Size(40, 40);
            this.clrKey.TabIndex = 16;
            this.clrKey.Text = "←";
            this.clrKey.UseVisualStyleBackColor = true;
            this.clrKey.Click += new System.EventHandler(this.button19_Click);
            this.clrKey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button19_MouseDown);
            this.clrKey.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button19_MouseUp);
            // 
            // b0
            // 
            this.b0.Font = new System.Drawing.Font("幼圆", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.b0.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.b0.Location = new System.Drawing.Point(6, 285);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(176, 40);
            this.b0.TabIndex = 15;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.button18_Click);
            // 
            // bD
            // 
            this.bD.Font = new System.Drawing.Font("幼圆", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bD.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bD.Location = new System.Drawing.Point(98, 97);
            this.bD.Name = "bD";
            this.bD.Size = new System.Drawing.Size(40, 40);
            this.bD.TabIndex = 14;
            this.bD.Text = "D";
            this.bD.UseVisualStyleBackColor = true;
            this.bD.Click += new System.EventHandler(this.button15_Click);
            // 
            // bE
            // 
            this.bE.Font = new System.Drawing.Font("幼圆", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bE.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bE.Location = new System.Drawing.Point(52, 97);
            this.bE.Name = "bE";
            this.bE.Size = new System.Drawing.Size(40, 40);
            this.bE.TabIndex = 13;
            this.bE.Text = "E";
            this.bE.UseVisualStyleBackColor = true;
            this.bE.Click += new System.EventHandler(this.button16_Click);
            // 
            // bF
            // 
            this.bF.Font = new System.Drawing.Font("幼圆", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bF.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bF.Location = new System.Drawing.Point(6, 97);
            this.bF.Name = "bF";
            this.bF.Size = new System.Drawing.Size(40, 40);
            this.bF.TabIndex = 12;
            this.bF.Text = "F";
            this.bF.UseVisualStyleBackColor = true;
            this.bF.Click += new System.EventHandler(this.button17_Click);
            // 
            // bC
            // 
            this.bC.Font = new System.Drawing.Font("幼圆", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bC.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bC.Location = new System.Drawing.Point(144, 143);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(40, 40);
            this.bC.TabIndex = 11;
            this.bC.Text = "C";
            this.bC.UseVisualStyleBackColor = true;
            this.bC.Click += new System.EventHandler(this.button9_Click);
            // 
            // bB
            // 
            this.bB.Font = new System.Drawing.Font("幼圆", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bB.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bB.Location = new System.Drawing.Point(144, 193);
            this.bB.Name = "bB";
            this.bB.Size = new System.Drawing.Size(40, 40);
            this.bB.TabIndex = 10;
            this.bB.Text = "B";
            this.bB.UseVisualStyleBackColor = true;
            this.bB.Click += new System.EventHandler(this.button10_Click);
            // 
            // bA
            // 
            this.bA.Font = new System.Drawing.Font("幼圆", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bA.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bA.Location = new System.Drawing.Point(142, 239);
            this.bA.Name = "bA";
            this.bA.Size = new System.Drawing.Size(40, 40);
            this.bA.TabIndex = 9;
            this.bA.Text = "A";
            this.bA.UseVisualStyleBackColor = true;
            this.bA.Click += new System.EventHandler(this.button11_Click);
            // 
            // b9
            // 
            this.b9.Font = new System.Drawing.Font("幼圆", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.b9.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.b9.Location = new System.Drawing.Point(98, 143);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(40, 40);
            this.b9.TabIndex = 8;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.button12_Click);
            // 
            // b8
            // 
            this.b8.Font = new System.Drawing.Font("幼圆", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.b8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.b8.Location = new System.Drawing.Point(52, 143);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(40, 40);
            this.b8.TabIndex = 7;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.button13_Click);
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("幼圆", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.b7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.b7.Location = new System.Drawing.Point(6, 143);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(40, 40);
            this.b7.TabIndex = 6;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.button14_Click);
            // 
            // b6
            // 
            this.b6.Font = new System.Drawing.Font("幼圆", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.b6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.b6.Location = new System.Drawing.Point(98, 191);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(40, 40);
            this.b6.TabIndex = 5;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.button6_Click);
            // 
            // b5
            // 
            this.b5.Font = new System.Drawing.Font("幼圆", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.b5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.b5.Location = new System.Drawing.Point(52, 191);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(40, 40);
            this.b5.TabIndex = 4;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.button7_Click);
            // 
            // b4
            // 
            this.b4.Font = new System.Drawing.Font("幼圆", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.b4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.b4.Location = new System.Drawing.Point(6, 191);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(40, 40);
            this.b4.TabIndex = 3;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.button8_Click);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("幼圆", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.b3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.b3.Location = new System.Drawing.Point(98, 239);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(40, 40);
            this.b3.TabIndex = 2;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.button5_Click);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("幼圆", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.b2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.b2.Location = new System.Drawing.Point(52, 239);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(40, 40);
            this.b2.TabIndex = 1;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.button4_Click);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("幼圆", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.b1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.b1.Location = new System.Drawing.Point(6, 239);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(40, 40);
            this.b1.TabIndex = 0;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(174, 294);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 10);
            this.axWindowsMediaPlayer1.TabIndex = 18;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.Green;
            this.linkLabel2.Location = new System.Drawing.Point(189, 320);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(41, 12);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Relax?";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // saveFileBtn
            // 
            this.saveFileBtn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.saveFileBtn.ForeColor = System.Drawing.Color.MediumBlue;
            this.saveFileBtn.Location = new System.Drawing.Point(314, 20);
            this.saveFileBtn.Name = "saveFileBtn";
            this.saveFileBtn.Size = new System.Drawing.Size(81, 36);
            this.saveFileBtn.TabIndex = 19;
            this.saveFileBtn.Text = "保存记录";
            this.saveFileBtn.UseVisualStyleBackColor = true;
            this.saveFileBtn.Click += new System.EventHandler(this.saveFileBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 354);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(632, 384);
            this.MinimumSize = new System.Drawing.Size(632, 384);
            this.Name = "Form1";
            this.Opacity = 0.5D;
            this.Text = "进制转换2015 by Oliver";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button clrKey;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bD;
        private System.Windows.Forms.Button bE;
        private System.Windows.Forms.Button bF;
        private System.Windows.Forms.Button bC;
        private System.Windows.Forms.Button bB;
        private System.Windows.Forms.Button bA;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button saveFileBtn;
    }
}

