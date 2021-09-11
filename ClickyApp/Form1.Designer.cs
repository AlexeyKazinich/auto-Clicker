
namespace ClickyApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxRandom = new System.Windows.Forms.CheckBox();
            this.labelState = new System.Windows.Forms.Label();
            this.setMax = new System.Windows.Forms.Button();
            this.labelMax = new System.Windows.Forms.Label();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.versionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 182);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Enable";
            this.toolTip1.SetToolTip(this.checkBox1, "Click to enable the clicker. Wont start clicking until\r\nKeybind is pressed. ON wi" +
        "ll show when the clicker \r\nis clicking.");
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(118, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Set";
            this.toolTip1.SetToolTip(this.button1, "Click Set to confirm the new desired interval value\r\n");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Interval (ms)";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            "-",
            "=",
            "[",
            "]",
            ";",
            "\'",
            ",",
            ".",
            "/"});
            this.comboBox1.Location = new System.Drawing.Point(12, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(118, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "setKey";
            this.toolTip1.SetToolTip(this.button2, "Click setKey to confirm the new selected key");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // checkBoxRandom
            // 
            this.checkBoxRandom.AutoSize = true;
            this.checkBoxRandom.Location = new System.Drawing.Point(12, 205);
            this.checkBoxRandom.Name = "checkBoxRandom";
            this.checkBoxRandom.Size = new System.Drawing.Size(140, 17);
            this.checkBoxRandom.TabIndex = 6;
            this.checkBoxRandom.Text = "Enable Random Interval";
            this.toolTip1.SetToolTip(this.checkBoxRandom, "Allows to generate random inputs using a max value\r\nand a min value given by the " +
        "user");
            this.checkBoxRandom.UseVisualStyleBackColor = true;
            this.checkBoxRandom.CheckedChanged += new System.EventHandler(this.checkBoxRandom_CheckedChanged);
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.BackColor = System.Drawing.Color.Black;
            this.labelState.ForeColor = System.Drawing.Color.Red;
            this.labelState.Location = new System.Drawing.Point(77, 183);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(27, 13);
            this.labelState.TabIndex = 10;
            this.labelState.Text = "OFF";
            this.toolTip1.SetToolTip(this.labelState, "Shows if you are clicking");
            // 
            // setMax
            // 
            this.setMax.Location = new System.Drawing.Point(382, 45);
            this.setMax.Name = "setMax";
            this.setMax.Size = new System.Drawing.Size(75, 23);
            this.setMax.TabIndex = 7;
            this.setMax.Text = "setMax";
            this.setMax.UseVisualStyleBackColor = true;
            this.setMax.Visible = false;
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(309, 26);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(86, 13);
            this.labelMax.TabIndex = 8;
            this.labelMax.Text = "Max interval (ms)";
            this.labelMax.Visible = false;
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(276, 47);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(100, 20);
            this.textBoxMax.TabIndex = 9;
            this.textBoxMax.Visible = false;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.Location = new System.Drawing.Point(409, 290);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(48, 16);
            this.versionLabel.TabIndex = 11;
            this.versionLabel.Text = "v1.0.0";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 306);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.setMax);
            this.Controls.Add(this.checkBoxRandom);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ClickyApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox checkBoxRandom;
        private System.Windows.Forms.Button setMax;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label versionLabel;
    }
}

