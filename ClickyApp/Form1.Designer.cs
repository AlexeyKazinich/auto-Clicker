
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
            this.textBoxMinInterval = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxRandom = new System.Windows.Forms.CheckBox();
            this.labelState = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.textBoxMaxInterval = new System.Windows.Forms.TextBox();
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
            // textBoxMinInterval
            // 
            this.textBoxMinInterval.Location = new System.Drawing.Point(12, 45);
            this.textBoxMinInterval.Name = "textBoxMinInterval";
            this.textBoxMinInterval.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinInterval.TabIndex = 2;
            this.textBoxMinInterval.Text = "100";
            this.textBoxMinInterval.TextChanged += new System.EventHandler(this.textBoxMinInterval_TextChanged);
            this.textBoxMinInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMinInterval_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
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
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
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
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(132, 26);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(86, 13);
            this.labelMax.TabIndex = 8;
            this.labelMax.Text = "Max interval (ms)";
            this.labelMax.Visible = false;
            // 
            // textBoxMaxInterval
            // 
            this.textBoxMaxInterval.Location = new System.Drawing.Point(118, 45);
            this.textBoxMaxInterval.Name = "textBoxMaxInterval";
            this.textBoxMaxInterval.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxInterval.TabIndex = 9;
            this.textBoxMaxInterval.Visible = false;
            this.textBoxMaxInterval.TextChanged += new System.EventHandler(this.textBoxMaxInterval_TextChanged);
            this.textBoxMaxInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMaxInterval_KeyPress);
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
            this.Controls.Add(this.textBoxMaxInterval);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.checkBoxRandom);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMinInterval);
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
        private System.Windows.Forms.TextBox textBoxMinInterval;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox checkBoxRandom;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.TextBox textBoxMaxInterval;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label versionLabel;
    }
}

