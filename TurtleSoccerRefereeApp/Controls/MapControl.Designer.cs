namespace TurtleSoccerReferee.Controls
{
    partial class MapControl
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
            this.mapPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mapYCoordLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mapXCoordLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mapResolutionLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mapHeightLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mapWidthLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonTorYellow = new System.Windows.Forms.Button();
            this.buttonTorBlue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapPictureBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.mapPictureBox, 2);
            this.mapPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapPictureBox.Location = new System.Drawing.Point(3, 3);
            this.mapPictureBox.Name = "mapPictureBox";
            this.mapPictureBox.Size = new System.Drawing.Size(283, 124);
            this.mapPictureBox.TabIndex = 0;
            this.mapPictureBox.TabStop = false;
            this.mapPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapPictureBox_MouseDown);
            this.mapPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mapPictureBox_MouseMove);
            this.mapPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mapPictureBox_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.mapYCoordLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mapXCoordLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(3, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 64);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cursor";
            // 
            // mapYCoordLabel
            // 
            this.mapYCoordLabel.AutoSize = true;
            this.mapYCoordLabel.Location = new System.Drawing.Point(63, 29);
            this.mapYCoordLabel.Name = "mapYCoordLabel";
            this.mapYCoordLabel.Size = new System.Drawing.Size(0, 13);
            this.mapYCoordLabel.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y:";
            // 
            // mapXCoordLabel
            // 
            this.mapXCoordLabel.AutoSize = true;
            this.mapXCoordLabel.Location = new System.Drawing.Point(63, 16);
            this.mapXCoordLabel.Name = "mapXCoordLabel";
            this.mapXCoordLabel.Size = new System.Drawing.Size(0, 13);
            this.mapXCoordLabel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "X:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mapResolutionLabel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.mapHeightLabel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.mapWidthLabel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(147, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 64);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kartendaten";
            // 
            // mapResolutionLabel
            // 
            this.mapResolutionLabel.AutoSize = true;
            this.mapResolutionLabel.Location = new System.Drawing.Point(63, 42);
            this.mapResolutionLabel.Name = "mapResolutionLabel";
            this.mapResolutionLabel.Size = new System.Drawing.Size(0, 13);
            this.mapResolutionLabel.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Auflösung:";
            // 
            // mapHeightLabel
            // 
            this.mapHeightLabel.AutoSize = true;
            this.mapHeightLabel.Location = new System.Drawing.Point(63, 29);
            this.mapHeightLabel.Name = "mapHeightLabel";
            this.mapHeightLabel.Size = new System.Drawing.Size(0, 13);
            this.mapHeightLabel.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Höhe:";
            // 
            // mapWidthLabel
            // 
            this.mapWidthLabel.AutoSize = true;
            this.mapWidthLabel.Location = new System.Drawing.Point(63, 16);
            this.mapWidthLabel.Name = "mapWidthLabel";
            this.mapWidthLabel.Size = new System.Drawing.Size(0, 13);
            this.mapWidthLabel.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Breite:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.mapPictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(289, 250);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox3, 2);
            this.groupBox3.Controls.Add(this.buttonTorYellow);
            this.groupBox3.Controls.Add(this.buttonTorBlue);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 44);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tore";
            // 
            // buttonTorYellow
            // 
            this.buttonTorYellow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTorYellow.BackColor = System.Drawing.Color.Yellow;
            this.buttonTorYellow.Location = new System.Drawing.Point(145, 15);
            this.buttonTorYellow.Name = "buttonTorYellow";
            this.buttonTorYellow.Size = new System.Drawing.Size(132, 23);
            this.buttonTorYellow.TabIndex = 1;
            this.buttonTorYellow.Text = "Tor Gelb festlegen";
            this.buttonTorYellow.UseVisualStyleBackColor = false;
            this.buttonTorYellow.Click += new System.EventHandler(this.buttonTore_Click);
            // 
            // buttonTorBlue
            // 
            this.buttonTorBlue.BackColor = System.Drawing.Color.Blue;
            this.buttonTorBlue.Location = new System.Drawing.Point(6, 15);
            this.buttonTorBlue.Name = "buttonTorBlue";
            this.buttonTorBlue.Size = new System.Drawing.Size(132, 23);
            this.buttonTorBlue.TabIndex = 0;
            this.buttonTorBlue.Text = "Tor Blau festlegen";
            this.buttonTorBlue.UseVisualStyleBackColor = false;
            this.buttonTorBlue.Click += new System.EventHandler(this.buttonTore_Click);
            // 
            // MapControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MapControl";
            this.Size = new System.Drawing.Size(289, 250);
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mapPictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label mapResolutionLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label mapHeightLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label mapWidthLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label mapYCoordLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label mapXCoordLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonTorYellow;
        private System.Windows.Forms.Button buttonTorBlue;
    }
}
