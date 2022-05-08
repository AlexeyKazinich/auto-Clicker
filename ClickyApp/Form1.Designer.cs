
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
            this.textBoxMinInterval = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxRandom = new System.Windows.Forms.CheckBox();
            this.labelState = new System.Windows.Forms.Label();
            this.enableButton = new ClickyApp.Controls.CustomButton();
            this.labelMax = new System.Windows.Forms.Label();
            this.textBoxMaxInterval = new System.Windows.Forms.TextBox();
            this.versionLabel = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.PatternClick = new FontAwesome.Sharp.IconButton();
            this.SettingsButton = new FontAwesome.Sharp.IconButton();
            this.MainMenuButton = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxMinInterval
            // 
            this.textBoxMinInterval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.textBoxMinInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMinInterval.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxMinInterval.Location = new System.Drawing.Point(35, 38);
            this.textBoxMinInterval.Name = "textBoxMinInterval";
            this.textBoxMinInterval.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinInterval.TabIndex = 2;
            this.textBoxMinInterval.Text = "1";
            this.textBoxMinInterval.TextChanged += new System.EventHandler(this.TextBoxMinInterval_TextChanged);
            this.textBoxMinInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxMinInterval_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(35, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Interval (ms)";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.comboBox1.Location = new System.Drawing.Point(35, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.TextChanged += new System.EventHandler(this.ComboBox1_TextChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.ToolTip1_Popup);
            // 
            // checkBoxRandom
            // 
            this.checkBoxRandom.AutoSize = true;
            this.checkBoxRandom.Location = new System.Drawing.Point(35, 126);
            this.checkBoxRandom.Name = "checkBoxRandom";
            this.checkBoxRandom.Size = new System.Drawing.Size(140, 17);
            this.checkBoxRandom.TabIndex = 6;
            this.checkBoxRandom.Text = "Enable Random Interval";
            this.toolTip1.SetToolTip(this.checkBoxRandom, "Allows to generate random inputs using a max value\r\nand a min value given by the " +
        "user");
            this.checkBoxRandom.UseVisualStyleBackColor = true;
            this.checkBoxRandom.CheckedChanged += new System.EventHandler(this.CheckBoxRandom_CheckedChanged);
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.BackColor = System.Drawing.Color.Black;
            this.labelState.ForeColor = System.Drawing.Color.Red;
            this.labelState.Location = new System.Drawing.Point(198, 104);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(27, 13);
            this.labelState.TabIndex = 10;
            this.labelState.Text = "OFF";
            this.toolTip1.SetToolTip(this.labelState, "Shows if you are clicking");
            // 
            // enableButton
            // 
            this.enableButton.Location = new System.Drawing.Point(34, 100);
            this.enableButton.MinimumSize = new System.Drawing.Size(45, 22);
            this.enableButton.Name = "enableButton";
            this.enableButton.OffBackColor = System.Drawing.Color.Gray;
            this.enableButton.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.enableButton.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.enableButton.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.enableButton.Size = new System.Drawing.Size(58, 22);
            this.enableButton.TabIndex = 11;
            this.enableButton.Text = "customButton1";
            this.toolTip1.SetToolTip(this.enableButton, "Click to enable the clicker. Wont start clicking until\r\nKeybind is pressed. ON wi" +
        "ll show when the clicker \r\nis clicking.\r\n");
            this.enableButton.UseVisualStyleBackColor = true;
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.ForeColor = System.Drawing.SystemColors.Info;
            this.labelMax.Location = new System.Drawing.Point(155, 19);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(86, 13);
            this.labelMax.TabIndex = 8;
            this.labelMax.Text = "Max interval (ms)";
            this.labelMax.Visible = false;
            // 
            // textBoxMaxInterval
            // 
            this.textBoxMaxInterval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.textBoxMaxInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMaxInterval.Location = new System.Drawing.Point(141, 38);
            this.textBoxMaxInterval.Name = "textBoxMaxInterval";
            this.textBoxMaxInterval.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxInterval.TabIndex = 9;
            this.textBoxMaxInterval.Visible = false;
            this.textBoxMaxInterval.TextChanged += new System.EventHandler(this.TextBoxMaxInterval_TextChanged);
            this.textBoxMaxInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxMaxInterval_KeyPress);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.Location = new System.Drawing.Point(828, 61);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(32, 16);
            this.versionLabel.TabIndex = 11;
            this.versionLabel.Text = "123";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.PatternClick);
            this.panelMenu.Controls.Add(this.SettingsButton);
            this.panelMenu.Controls.Add(this.MainMenuButton);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 310);
            this.panelMenu.TabIndex = 12;
            // 
            // PatternClick
            // 
            this.PatternClick.Dock = System.Windows.Forms.DockStyle.Top;
            this.PatternClick.FlatAppearance.BorderSize = 0;
            this.PatternClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatternClick.ForeColor = System.Drawing.Color.Gainsboro;
            this.PatternClick.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.PatternClick.IconColor = System.Drawing.Color.Gainsboro;
            this.PatternClick.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PatternClick.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PatternClick.Location = new System.Drawing.Point(0, 200);
            this.PatternClick.Name = "PatternClick";
            this.PatternClick.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.PatternClick.Size = new System.Drawing.Size(220, 60);
            this.PatternClick.TabIndex = 7;
            this.PatternClick.Text = "Pattern Click";
            this.PatternClick.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PatternClick.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PatternClick.UseVisualStyleBackColor = true;
            this.PatternClick.Click += new System.EventHandler(this.PatternClick_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.SettingsButton.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.SettingsButton.IconColor = System.Drawing.Color.Gainsboro;
            this.SettingsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.Location = new System.Drawing.Point(0, 140);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.SettingsButton.Size = new System.Drawing.Size(220, 60);
            this.SettingsButton.TabIndex = 6;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainMenuButton.FlatAppearance.BorderSize = 0;
            this.MainMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenuButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.MainMenuButton.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.MainMenuButton.IconColor = System.Drawing.Color.Gainsboro;
            this.MainMenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MainMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainMenuButton.Location = new System.Drawing.Point(0, 80);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.MainMenuButton.Size = new System.Drawing.Size(220, 60);
            this.MainMenuButton.TabIndex = 2;
            this.MainMenuButton.Text = "Home";
            this.MainMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Controls.Add(this.labelTitle);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Mistral", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.Info;
            this.labelTitle.Location = new System.Drawing.Point(51, 28);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(108, 23);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Wolferwow Inc.";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelTitleBar.Controls.Add(this.versionLabel);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(314, 80);
            this.panelTitleBar.TabIndex = 13;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 24;
            this.btnMinimize.Location = new System.Drawing.Point(226, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.Black;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 24;
            this.btnMaximize.Location = new System.Drawing.Point(254, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(30, 30);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 24;
            this.btnClose.Location = new System.Drawing.Point(281, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelMainMenu.Controls.Add(this.label3);
            this.panelMainMenu.Controls.Add(this.label2);
            this.panelMainMenu.Controls.Add(this.enableButton);
            this.panelMainMenu.Controls.Add(this.label1);
            this.panelMainMenu.Controls.Add(this.labelState);
            this.panelMainMenu.Controls.Add(this.checkBoxRandom);
            this.panelMainMenu.Controls.Add(this.comboBox1);
            this.panelMainMenu.Controls.Add(this.textBoxMaxInterval);
            this.panelMainMenu.Controls.Add(this.textBoxMinInterval);
            this.panelMainMenu.Controls.Add(this.labelMax);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainMenu.Location = new System.Drawing.Point(220, 80);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(314, 230);
            this.panelMainMenu.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(148, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Running:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(95, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Enable";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(534, 310);
            this.Controls.Add(this.panelMainMenu);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ClickyApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelMainMenu.ResumeLayout(false);
            this.panelMainMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton SettingsButton;
        private FontAwesome.Sharp.IconButton MainMenuButton;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel panelMainMenu;
        private Controls.CustomButton enableButton;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton PatternClick;
    }
}

