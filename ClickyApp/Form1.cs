using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickyApp
{
    public partial class Form1 : Form
    {

        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);


        private const int LEFTUP = 0x0004;
        private const int LEFTDOWN = 0x0002;
        public int interval = 100;
        public bool Click = false;
        public int parsedValue;
        public Keys clickKey;
        private bool released = true;


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread AC = new Thread(AutoClick);
            backgroundWorker1.RunWorkerAsync();
            versionLabel.Text = String.Format("v{0}",System.Reflection.Assembly.GetExecutingAssembly().GetName().Version).Substring(0,6);

            AC.Start();

        }


        private int getRandomInterval()
        {
            int minInt = int.Parse(textBox1.Text);
            int maxInt = int.Parse(textBoxMax.Text);
            int returnVal;

            Random rnd = new Random();

            returnVal = rnd.Next(minInt, maxInt);

            return returnVal;
        }

        private void AutoClick()
        {
            while (true)
            {
                if (Click == true)
                {
                    if (checkBoxRandom.Checked == false)
                    {
                        mouse_event(LEFTUP, 0, 0, 0, 0);
                        Thread.Sleep(1);
                        mouse_event(LEFTDOWN, 0, 0, 0, 0);
                        Thread.Sleep(interval);
                    }

                    if (checkBoxRandom.Checked == true)
                    {
                        mouse_event(LEFTUP, 0, 0, 0, 0);
                        Thread.Sleep(1);
                        mouse_event(LEFTDOWN, 0, 0, 0, 0);
                        Thread.Sleep(getRandomInterval());
                    }
                }
                Thread.Sleep(2);



            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (checkBox1.Checked)
                {
                    if ((GetAsyncKeyState(clickKey) < 0) && released == true && Click == true)
                    {
                        Click = false;
                        this.released = false;

                        //change text color
                        changeStateColor();

                    }
                    if ((GetAsyncKeyState(clickKey) < 0) && released == true && Click == false)
                    {
                        Click = true;
                        this.released = false;
                        changeStateColor();
                    }

                    if (GetAsyncKeyState(clickKey) >= 0)
                    {
                        this.released = true;
                    }

                    Thread.Sleep(1);



                }
                Thread.Sleep(1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out parsedValue))
            {
                MessageBox.Show("Please enter an Integer");
                return;
            }
            else
            {
                interval = int.Parse(textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region switch commands
            switch (comboBox1.Text)
            {
                case "A":
                    clickKey = Keys.A;
                    break;
                case "B":
                    clickKey = Keys.B;
                    break;
                case "C":
                    clickKey = Keys.C;
                    break;
                case "D":
                    clickKey = Keys.D;
                    break;
                case "E":
                    clickKey = Keys.E;
                    break;
                case "F":
                    clickKey = Keys.F;
                    break;
                case "G":
                    clickKey = Keys.G;
                    break;
                case "H":
                    clickKey = Keys.H;
                    break;
                case "I":
                    clickKey = Keys.I;
                    break;
                case "J":
                    clickKey = Keys.J;
                    break;
                case "K":
                    clickKey = Keys.K;
                    break;
                case "L":
                    clickKey = Keys.L;
                    break;
                case "M":
                    clickKey = Keys.M;
                    break;
                case "N":
                    clickKey = Keys.N;
                    break;
                case "O":
                    clickKey = Keys.O;
                    break;
                case "P":
                    clickKey = Keys.P;
                    break;
                case "Q":
                    clickKey = Keys.Q;
                    break;
                case "R":
                    clickKey = Keys.R;
                    break;
                case "S":
                    clickKey = Keys.S;
                    break;
                case "T":
                    clickKey = Keys.T;
                    break;
                case "U":
                    clickKey = Keys.U;
                    break;
                case "V":
                    clickKey = Keys.V;
                    break;
                case "W":
                    clickKey = Keys.W;
                    break;
                case "X":
                    clickKey = Keys.X;
                    break;
                case "Y":
                    clickKey = Keys.Y;
                    break;
                case "Z":
                    clickKey = Keys.Z;
                    break;
                case "1":
                    clickKey = Keys.D1;
                    break;
                case "2":
                    clickKey = Keys.D2;
                    break;
                case "3":
                    clickKey = Keys.D3;
                    break;
                case "4":
                    clickKey = Keys.D4;
                    break;
                case "5":
                    clickKey = Keys.D5;
                    break;
                case "6":
                    clickKey = Keys.D6;
                    break;
                case "7":
                    clickKey = Keys.D7;
                    break;
                case "8":
                    clickKey = Keys.D8;
                    break;
                case "9":
                    clickKey = Keys.D9;
                    break;
                case "0":
                    clickKey = Keys.D0;
                    break;
                case "-":
                    clickKey = Keys.OemMinus;
                    break;
                case "=":
                    clickKey = Keys.Oemplus;
                    break;
                case ";":
                    clickKey = Keys.OemSemicolon;
                    break;
                case "'":
                    clickKey = Keys.OemQuotes;
                    break;
                case ",":
                    clickKey = Keys.Oemcomma;
                    break;
                case ".":
                    clickKey = Keys.OemPeriod;
                    break;
                case "/":
                    clickKey = Keys.OemQuestion;
                    break;
                default:
                    clickKey = Keys.Down;
                    break;

                    #endregion

            }
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
        }

        private void checkBoxRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRandom.Checked == true)
            {
                //show
                setMax.Visible = true;
                textBoxMax.Visible = true;
                labelMax.Visible = true;

                //rename interval(ms) to min interval
                label1.Text = "Min interval (ms)";
                button1.Text = "set Min";
            }
            else
            {
                setMax.Visible = false;
                textBoxMax.Visible = false;
                labelMax.Visible = false;


                //return the names
                label1.Text = "interval (ms)";
                button1.Text = "set Max";
            }
        }


        private void changeStateColor()
        {

            if (Click == true)
            {
                labelState.Text = "ON";
                labelState.ForeColor = Color.Lime;
            }

            else if (Click == false)
            {
                labelState.Text = "OFF";
                labelState.ForeColor = Color.Red;
            }
        }
    }
}
