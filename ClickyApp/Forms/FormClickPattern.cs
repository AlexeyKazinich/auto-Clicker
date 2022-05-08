using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace ClickyApp.Forms
{
    public partial class FormClickPattern : Form
    {
        private List<ListViewItem> itemsList = new List<ListViewItem>();
        private bool released;
        private bool click;

        //mouse buttons
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);


        //keyboard buttons
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);

        public FormClickPattern()
        {
            InitializeComponent();

            
        }

        private void FormClickPattern_Load(object sender, EventArgs e)
        {

            listView1.View = View.Details;
            listView1.LabelEdit = true;
            listView1.AllowColumnReorder = true;
            listView1.CheckBoxes = false;
            listView1.FullRowSelect = true;

            

            // Create three items and three sets of subitems for each item.
            ListViewItem item1 = new ListViewItem("item1");
            // Place a check mark next to the item.
            item1.Checked = true;
            item1.SubItems.Add("1");
            item1.SubItems.Add("2");
            item1.SubItems.Add("3");
            ListViewItem item2 = new ListViewItem("item2");
            item2.SubItems.Add("4");
            item2.SubItems.Add("5");
            item2.SubItems.Add("6");
            ListViewItem item3 = new ListViewItem("item3");
            // Place a check mark next to the item.
            item3.SubItems.Add("7");
            item3.SubItems.Add("8");
            item3.SubItems.Add("9");

            itemsList.Add(item1);
            itemsList.Add(item2);
            itemsList.Add(item3);
            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.
            listView1.Columns.Add("Type", 60, HorizontalAlignment.Left);
            listView1.Columns.Add("X", 60, HorizontalAlignment.Left);
            listView1.Columns.Add("Y", 60, HorizontalAlignment.Left);
            listView1.Columns.Add("Delay", 60, HorizontalAlignment.Center);


            CheckForIllegalCrossThreadCalls = false;
            Thread run = new Thread(listenForKeyPresses);
            backgroundWorker1.RunWorkerAsync();



            run.Start();


            
        }

      

        private void addItemToList()
        {
            string[] row = { "Click", "50", "450", "5.5ms" };
            var listViewItem = new ListViewItem(row);
            listView1.Items.Add(listViewItem);

        }

        private void addKeyPressToList(string key)
        {
            string[] row = { key, "null", "null", "2ms" };
            listView1.Items.Add(new ListViewItem(row));
        }

        private void listenForKeyPresses()
        {
            
        }


        private bool checkIfPressed()
        {
            return false;
        }
        private void FormClickPattern_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while(true)
            {
                if(GetAsyncKeyState(Keys.X ) < 0 && released == true && click == true)
                {
                    click = false;
                    this.released = false;
                }
                else if(GetAsyncKeyState(Keys.X) < 0 && released == true && click == false)
                {
                    click = true;
                    this.released = false;
                }
                if(GetAsyncKeyState(Keys.X) >= 0)
                {
                    this.released = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            run_cmd();
        }

        private void run_cmd()
        {


            var psi = new ProcessStartInfo();
            psi.FileName = @"C:\Users\SOSIG\AppData\Local\Programs\Python\Python38\python.exe";
            var script = @"F:\Git_projects\C#\Auto Clicker\auto-Clicker\ClickyApp\Python\Script.py";

            psi.Arguments = $"\"{script}\"";

            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            var errors = "";
            var results = "";

            using(var process = Process.Start(psi))
            {
                errors = process.StandardError.ReadToEnd();
                results = process.StandardOutput.ReadToEnd();
            }

            label3.Text = errors;
            label4.Text = results;



        }
    }
}
