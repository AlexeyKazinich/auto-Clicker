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


//REFERENCE: https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-mouse_event //BUTTON PRESSES
namespace ClickyApp
{
    public partial class Form1 : Form
    {

        //get keyboard keystate
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);

        //get mouse keystate
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        
        //drag application
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        private int BUTTONUP;
        private int BUTTONDOWN;
        public int interval;
        public bool click = false;
        public int parsedValue;
        public Keys clickKey;
        private bool released = true;

        private Form activeForm;


        public Form1()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread AC = new Thread(AutoClick);
            backgroundWorker1.RunWorkerAsync();
            versionLabel.Text = String.Format("v{0}",System.Reflection.Assembly.GetExecutingAssembly().GetName().Version).Substring(0,6);
            versionLabel.Location = new Point(panelTitleBar.Width-versionLabel.Width, versionLabel.Location.Y);

            comboBox1.SelectedIndex = 0;

            LoadSettings();


            AC.Start();

        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm!= null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelMainMenu.Controls.Add(childForm);
            this.panelMainMenu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void LoadSettings()
        {
            //check keybind
            comboBox1.SelectedIndex = (int)Properties.Settings.Default["keybindIndex"];
            #region switch cases
            switch (Properties.Settings.Default["keybind"])
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

                
            }
            #endregion

            //load delay settings
            this.interval = (int)Properties.Settings.Default["delay"]; //update value
            textBoxMinInterval.Text = Properties.Settings.Default["delay"].ToString(); // update textbox text

            //load button to press
            if((string)Properties.Settings.Default["MouseClick"] == "left")
            {
                this.BUTTONUP = 0x0004;
                this.BUTTONDOWN = 0x0002;

            }
            else
            {
                this.BUTTONUP = 0x0010;
                this.BUTTONDOWN = 0x0008;
            }

        }

        private void SaveNewSettings()
        {
            //save index
            Properties.Settings.Default["keybindIndex"] = comboBox1.SelectedIndex;
            //save keybind
            Properties.Settings.Default["keybind"] = comboBox1.Text;
            //save button press
            Properties.Settings.Default["MouseClick"] = "left"; //Temporary
            //save delay settings
            Properties.Settings.Default["delay"] = interval;

            Properties.Settings.Default.Save();
        }


        private int GetRandomInterval()
        {
            int minInt = int.Parse(textBoxMinInterval.Text);
            int maxInt = int.Parse(textBoxMaxInterval.Text);
            int returnVal;

            Random rnd = new Random();

            returnVal = rnd.Next(minInt, maxInt);

            return returnVal;
        }

        private void AutoClick()
        {
            while (true)
            {
                if (click == true)
                {
                    if (checkBoxRandom.Checked == false)
                    {
                        mouse_event(BUTTONUP, 0, 0, 0, 0);
                        Thread.Sleep(1);
                        mouse_event(BUTTONDOWN, 0, 0, 0, 0);
                        Thread.Sleep(interval);
                    }

                    if (checkBoxRandom.Checked == true)
                    {
                        mouse_event(BUTTONUP, 0, 0, 0, 0);
                        Thread.Sleep(1);
                        mouse_event(BUTTONDOWN, 0, 0, 0, 0);
                        Thread.Sleep(GetRandomInterval());
                    }
                }
                Thread.Sleep(2);



            }
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (enableButton.Checked)
                {
                    if ((GetAsyncKeyState(clickKey) < 0) && released == true && click == true)
                    {
                        click = false;
                        this.released = false;

                        //change text color
                        ChangeStateColor();

                    }
                    if ((GetAsyncKeyState(clickKey) < 0) && released == true && click == false)
                    {
                        click = true;
                        this.released = false;
                        ChangeStateColor();
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


        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            SaveNewSettings();
            Application.Exit();
            Environment.Exit(0);
        }

        private void ToolTip1_Popup(object sender, PopupEventArgs e)
        {
        }

        private void CheckBoxRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRandom.Checked == true)
            {
                //show
                textBoxMaxInterval.Visible = true;
                labelMax.Visible = true;

                //rename interval(ms) to min interval
                label1.Text = "Min interval (ms)";
            }
            else
            {
                textBoxMaxInterval.Visible = false;
                labelMax.Visible = false;


                //return the names
                label1.Text = "interval (ms)";
            }
        }


        private void ChangeStateColor()
        {

            if (click == true)
            {
                labelState.Text = "ON";
                labelState.ForeColor = Color.Lime;
            }

            else if (click == false)
            {
                labelState.Text = "OFF";
                labelState.ForeColor = Color.Red;
            }
        }

        private void TextBoxMinInterval_TextChanged(object sender, EventArgs e)
        {
            
            if (!int.TryParse(textBoxMinInterval.Text, out parsedValue))
            {
                MessageBox.Show("Please enter an Integer");
                return;
            }
            else
            {
                interval = int.Parse(textBoxMinInterval.Text);
            }
            
        }        

        private void TextBoxMaxInterval_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void TextBoxMinInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                this.ActiveControl = label1;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TextBoxMaxInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.ActiveControl = label1;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ComboBox1_TextChanged(object sender, EventArgs e)
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

        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #region application close,maximize,minimize buttons
        private void btnClose_Click(object sender, EventArgs e)
        {
            SaveNewSettings();
            Application.Exit();
            Environment.Exit(0);
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
                WindowState = FormWindowState.Normal;

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }


        #endregion

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSettings(), sender);
        }

        private void PatternClick_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormClickPattern(), sender);
        }
    }
}
