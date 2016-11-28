namespace TurtleSoccerReferee.Controls
{
    partial class RobotControl
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonAufstellung = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFunktion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTeam = new System.Windows.Forms.ComboBox();
            this.checkBoxHuman = new System.Windows.Forms.CheckBox();
            this.buttonStartPosition = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.buttonAufstellung);
            this.groupBox4.Controls.Add(this.buttonStop);
            this.groupBox4.Controls.Add(this.buttonStart);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(280, 80);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Steuerung";
            // 
            // buttonAufstellung
            // 
            this.buttonAufstellung.Location = new System.Drawing.Point(6, 48);
            this.buttonAufstellung.Name = "buttonAufstellung";
            this.buttonAufstellung.Size = new System.Drawing.Size(75, 23);
            this.buttonAufstellung.TabIndex = 2;
            this.buttonAufstellung.Text = "Aufstellung";
            this.buttonAufstellung.UseVisualStyleBackColor = true;
            this.buttonAufstellung.Click += new System.EventHandler(this.buttonAufstellung_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Red;
            this.buttonStop.Location = new System.Drawing.Point(87, 19);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonStart.Location = new System.Drawing.Point(6, 19);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.comboBoxFunktion);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.comboBoxTeam);
            this.groupBox5.Controls.Add(this.checkBoxHuman);
            this.groupBox5.Controls.Add(this.buttonStartPosition);
            this.groupBox5.Location = new System.Drawing.Point(6, 89);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(277, 157);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Einstellungen";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(95, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "senden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "KI";
            // 
            // comboBoxFunktion
            // 
            this.comboBoxFunktion.FormattingEnabled = true;
            this.comboBoxFunktion.Location = new System.Drawing.Point(46, 46);
            this.comboBoxFunktion.Name = "comboBoxFunktion";
            this.comboBoxFunktion.Size = new System.Drawing.Size(76, 21);
            this.comboBoxFunktion.TabIndex = 6;
            this.comboBoxFunktion.SelectedIndexChanged += new System.EventHandler(this.comboBoxFunktion_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Team";
            // 
            // comboBoxTeam
            // 
            this.comboBoxTeam.FormattingEnabled = true;
            this.comboBoxTeam.Items.AddRange(new object[] {
            "Blau",
            "Gelb"});
            this.comboBoxTeam.Location = new System.Drawing.Point(46, 19);
            this.comboBoxTeam.Name = "comboBoxTeam";
            this.comboBoxTeam.Size = new System.Drawing.Size(76, 21);
            this.comboBoxTeam.TabIndex = 4;
            this.comboBoxTeam.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeam_SelectedIndexChanged);
            // 
            // checkBoxHuman
            // 
            this.checkBoxHuman.AutoSize = true;
            this.checkBoxHuman.Location = new System.Drawing.Point(169, 23);
            this.checkBoxHuman.Name = "checkBoxHuman";
            this.checkBoxHuman.Size = new System.Drawing.Size(72, 17);
            this.checkBoxHuman.TabIndex = 3;
            this.checkBoxHuman.Text = "Steuerbar";
            this.checkBoxHuman.UseVisualStyleBackColor = true;
            this.checkBoxHuman.CheckStateChanged += new System.EventHandler(this.checkBoxHuman_CheckStateChanged);
            // 
            // buttonStartPosition
            // 
            this.buttonStartPosition.Location = new System.Drawing.Point(6, 73);
            this.buttonStartPosition.Name = "buttonStartPosition";
            this.buttonStartPosition.Size = new System.Drawing.Size(75, 23);
            this.buttonStartPosition.TabIndex = 0;
            this.buttonStartPosition.Text = "Startposition";
            this.buttonStartPosition.UseVisualStyleBackColor = true;
            this.buttonStartPosition.Click += new System.EventHandler(this.buttonStartPosition_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(3, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 75);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(274, 56);
            this.textBox1.TabIndex = 0;
            // 
            // RobotControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Name = "RobotControl";
            this.Size = new System.Drawing.Size(286, 330);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonAufstellung;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBoxHuman;
        private System.Windows.Forms.Button buttonStartPosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFunktion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTeam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
