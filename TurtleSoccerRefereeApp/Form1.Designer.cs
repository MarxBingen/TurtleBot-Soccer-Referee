namespace TurtleSoccerReferee
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mapControl1 = new TurtleSoccerReferee.Controls.MapControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonStopAll = new System.Windows.Forms.Button();
            this.buttonStartAll = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControlRobots = new System.Windows.Forms.TabControl();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sucheSpielerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.masterTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rosIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rosIPTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.startAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.mapControl1);
            this.groupBox1.Location = new System.Drawing.Point(307, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 373);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Karte";
            // 
            // mapControl1
            // 
            this.mapControl1.AutoSize = true;
            this.mapControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Location = new System.Drawing.Point(3, 16);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(297, 354);
            this.mapControl1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.tabControlMain);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 373);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Roboter";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(3, 16);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(286, 354);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(278, 328);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Schiedsrichter";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button7);
            this.groupBox6.Controls.Add(this.buttonStopAll);
            this.groupBox6.Controls.Add(this.buttonStartAll);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(272, 322);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Steuerung";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 48);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 2;
            this.button7.Text = "Aufstellung";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.resetAllButton_click);
            // 
            // buttonStopAll
            // 
            this.buttonStopAll.BackColor = System.Drawing.Color.Red;
            this.buttonStopAll.Location = new System.Drawing.Point(87, 19);
            this.buttonStopAll.Name = "buttonStopAll";
            this.buttonStopAll.Size = new System.Drawing.Size(75, 23);
            this.buttonStopAll.TabIndex = 1;
            this.buttonStopAll.Text = "Stop";
            this.buttonStopAll.UseVisualStyleBackColor = false;
            this.buttonStopAll.Click += new System.EventHandler(this.buttonStopAll_Click);
            // 
            // buttonStartAll
            // 
            this.buttonStartAll.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonStartAll.Location = new System.Drawing.Point(6, 19);
            this.buttonStartAll.Name = "buttonStartAll";
            this.buttonStartAll.Size = new System.Drawing.Size(75, 23);
            this.buttonStartAll.TabIndex = 0;
            this.buttonStartAll.Text = "Start";
            this.buttonStartAll.UseVisualStyleBackColor = false;
            this.buttonStartAll.Click += new System.EventHandler(this.buttonStartAll_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControlRobots);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(278, 328);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Spieler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControlRobots
            // 
            this.tabControlRobots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlRobots.Location = new System.Drawing.Point(3, 3);
            this.tabControlRobots.Name = "tabControlRobots";
            this.tabControlRobots.SelectedIndex = 0;
            this.tabControlRobots.Size = new System.Drawing.Size(272, 322);
            this.tabControlRobots.TabIndex = 3;
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.dateiToolStripMenuItem.Text = "Datei...";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // sucheSpielerToolStripMenuItem
            // 
            this.sucheSpielerToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.sucheSpielerToolStripMenuItem.Enabled = false;
            this.sucheSpielerToolStripMenuItem.Name = "sucheSpielerToolStripMenuItem";
            this.sucheSpielerToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.sucheSpielerToolStripMenuItem.Text = "Suche Spieler";
            this.sucheSpielerToolStripMenuItem.Click += new System.EventHandler(this.sucheSpielerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterTextBox});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(77, 20);
            this.toolStripMenuItem1.Text = "Master IP...";
            // 
            // masterTextBox
            // 
            this.masterTextBox.Name = "masterTextBox";
            this.masterTextBox.Size = new System.Drawing.Size(100, 23);
            this.masterTextBox.Text = "192.168.64.211";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.startAdminToolStripMenuItem,
            this.rosIPToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sucheSpielerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(622, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rosIPToolStripMenuItem
            // 
            this.rosIPToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rosIPToolStripMenuItem.BackColor = System.Drawing.Color.Yellow;
            this.rosIPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rosIPTextBox});
            this.rosIPToolStripMenuItem.Name = "rosIPToolStripMenuItem";
            this.rosIPToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.rosIPToolStripMenuItem.Text = "ROS_IP...";
            // 
            // rosIPTextBox
            // 
            this.rosIPTextBox.Name = "rosIPTextBox";
            this.rosIPTextBox.Size = new System.Drawing.Size(100, 23);
            this.rosIPTextBox.Text = "192.168.64.211";
            // 
            // startAdminToolStripMenuItem
            // 
            this.startAdminToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.startAdminToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.startAdminToolStripMenuItem.Name = "startAdminToolStripMenuItem";
            this.startAdminToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.startAdminToolStripMenuItem.Text = "Start Admin";
            this.startAdminToolStripMenuItem.Click += new System.EventHandler(this.startAdminToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 412);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Turtlebot Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.MapControl mapControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControlRobots;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonStopAll;
        private System.Windows.Forms.Button buttonStartAll;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sucheSpielerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox masterTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rosIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox rosIPTextBox;
        private System.Windows.Forms.ToolStripMenuItem startAdminToolStripMenuItem;
    }
}

