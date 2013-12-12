namespace Designer
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        private void InitializeComponent()
        {
            this.picBox = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblPos = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLock = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.höheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.breiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.btnEvent = new System.Windows.Forms.Button();
            this.combField = new System.Windows.Forms.ComboBox();
            this.txtWesten = new System.Windows.Forms.TextBox();
            this.txtSüden = new System.Windows.Forms.TextBox();
            this.txtOsten = new System.Windows.Forms.TextBox();
            this.txtNorden = new System.Windows.Forms.TextBox();
            this.cBoxWesten = new System.Windows.Forms.CheckBox();
            this.cBoxSüden = new System.Windows.Forms.CheckBox();
            this.cBoxOsten = new System.Windows.Forms.CheckBox();
            this.cBoxNorden = new System.Windows.Forms.CheckBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.txtManX = new System.Windows.Forms.TextBox();
            this.txtManY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.Gainsboro;
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Location = new System.Drawing.Point(12, 27);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(290, 272);
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            this.picBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseClick);
            this.picBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseMove);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblPos,
            this.lblLock});
            this.statusStrip1.Location = new System.Drawing.Point(0, 402);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(481, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblPos
            // 
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(32, 17);
            this.lblPos.Text = "Pos :";
            // 
            // lblLock
            // 
            this.lblLock.Name = "lblLock";
            this.lblLock.Size = new System.Drawing.Size(54, 17);
            this.lblLock.Text = "Entsperrt";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.optionenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(481, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speichernToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.speichernToolStripMenuItem.Text = "Speichern";
            // 
            // optionenToolStripMenuItem
            // 
            this.optionenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.höheToolStripMenuItem,
            this.breiteToolStripMenuItem});
            this.optionenToolStripMenuItem.Name = "optionenToolStripMenuItem";
            this.optionenToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.optionenToolStripMenuItem.Text = "Optionen";
            // 
            // höheToolStripMenuItem
            // 
            this.höheToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.höheToolStripMenuItem.Name = "höheToolStripMenuItem";
            this.höheToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.höheToolStripMenuItem.Text = "Höhe";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // breiteToolStripMenuItem
            // 
            this.breiteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2});
            this.breiteToolStripMenuItem.Name = "breiteToolStripMenuItem";
            this.breiteToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.breiteToolStripMenuItem.Text = "Breite";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            // 
            // btnEvent
            // 
            this.btnEvent.Location = new System.Drawing.Point(227, 302);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(75, 23);
            this.btnEvent.TabIndex = 3;
            this.btnEvent.Text = "Ereignis";
            this.btnEvent.UseVisualStyleBackColor = true;
            this.btnEvent.Visible = false;
            this.btnEvent.Click += new System.EventHandler(this.btnEvent_Click);
            // 
            // combField
            // 
            this.combField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combField.FormattingEnabled = true;
            this.combField.Items.AddRange(new object[] {
            "Spawnfeld",
            "Unterscheidungsfeld",
            "Despawnfeld"});
            this.combField.Location = new System.Drawing.Point(308, 132);
            this.combField.Name = "combField";
            this.combField.Size = new System.Drawing.Size(165, 24);
            this.combField.TabIndex = 19;
            this.combField.Text = "Unterscheidungsfeld";
            // 
            // txtWesten
            // 
            this.txtWesten.Enabled = false;
            this.txtWesten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWesten.Location = new System.Drawing.Point(387, 103);
            this.txtWesten.Name = "txtWesten";
            this.txtWesten.Size = new System.Drawing.Size(86, 22);
            this.txtWesten.TabIndex = 18;
            // 
            // txtSüden
            // 
            this.txtSüden.Enabled = false;
            this.txtSüden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSüden.Location = new System.Drawing.Point(387, 77);
            this.txtSüden.Name = "txtSüden";
            this.txtSüden.Size = new System.Drawing.Size(86, 22);
            this.txtSüden.TabIndex = 17;
            // 
            // txtOsten
            // 
            this.txtOsten.Enabled = false;
            this.txtOsten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOsten.Location = new System.Drawing.Point(387, 51);
            this.txtOsten.Name = "txtOsten";
            this.txtOsten.Size = new System.Drawing.Size(86, 22);
            this.txtOsten.TabIndex = 16;
            // 
            // txtNorden
            // 
            this.txtNorden.Enabled = false;
            this.txtNorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNorden.Location = new System.Drawing.Point(387, 25);
            this.txtNorden.Name = "txtNorden";
            this.txtNorden.Size = new System.Drawing.Size(86, 22);
            this.txtNorden.TabIndex = 15;
            // 
            // cBoxWesten
            // 
            this.cBoxWesten.AutoSize = true;
            this.cBoxWesten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxWesten.Location = new System.Drawing.Point(308, 105);
            this.cBoxWesten.Name = "cBoxWesten";
            this.cBoxWesten.Size = new System.Drawing.Size(73, 20);
            this.cBoxWesten.TabIndex = 14;
            this.cBoxWesten.Text = "Westen";
            this.cBoxWesten.UseVisualStyleBackColor = true;
            this.cBoxWesten.CheckedChanged += new System.EventHandler(this.cBoxWesten_CheckedChanged);
            // 
            // cBoxSüden
            // 
            this.cBoxSüden.AutoSize = true;
            this.cBoxSüden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxSüden.Location = new System.Drawing.Point(308, 79);
            this.cBoxSüden.Name = "cBoxSüden";
            this.cBoxSüden.Size = new System.Drawing.Size(66, 20);
            this.cBoxSüden.TabIndex = 13;
            this.cBoxSüden.Text = "Süden";
            this.cBoxSüden.UseVisualStyleBackColor = true;
            this.cBoxSüden.CheckedChanged += new System.EventHandler(this.cBoxSüden_CheckedChanged);
            // 
            // cBoxOsten
            // 
            this.cBoxOsten.AutoSize = true;
            this.cBoxOsten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxOsten.Location = new System.Drawing.Point(308, 53);
            this.cBoxOsten.Name = "cBoxOsten";
            this.cBoxOsten.Size = new System.Drawing.Size(62, 20);
            this.cBoxOsten.TabIndex = 12;
            this.cBoxOsten.Text = "Osten";
            this.cBoxOsten.UseVisualStyleBackColor = true;
            this.cBoxOsten.CheckedChanged += new System.EventHandler(this.cBoxOsten_CheckedChanged);
            // 
            // cBoxNorden
            // 
            this.cBoxNorden.AutoSize = true;
            this.cBoxNorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxNorden.Location = new System.Drawing.Point(308, 27);
            this.cBoxNorden.Name = "cBoxNorden";
            this.cBoxNorden.Size = new System.Drawing.Size(72, 20);
            this.cBoxNorden.TabIndex = 11;
            this.cBoxNorden.Text = "Norden";
            this.cBoxNorden.UseVisualStyleBackColor = true;
            this.cBoxNorden.CheckedChanged += new System.EventHandler(this.cBoxNorden_CheckedChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.Enabled = false;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(308, 162);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Erstellen";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnN
            // 
            this.btnN.Location = new System.Drawing.Point(164, 305);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(26, 23);
            this.btnN.TabIndex = 20;
            this.btnN.Text = "N";
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Visible = false;
            this.btnN.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(164, 363);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(26, 23);
            this.btnS.TabIndex = 21;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Visible = false;
            this.btnS.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnW
            // 
            this.btnW.Location = new System.Drawing.Point(138, 334);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(26, 23);
            this.btnW.TabIndex = 22;
            this.btnW.Text = "W";
            this.btnW.UseVisualStyleBackColor = true;
            this.btnW.Visible = false;
            this.btnW.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnO
            // 
            this.btnO.Location = new System.Drawing.Point(187, 334);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(26, 23);
            this.btnO.TabIndex = 23;
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = true;
            this.btnO.Visible = false;
            this.btnO.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtManX
            // 
            this.txtManX.Enabled = false;
            this.txtManX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManX.Location = new System.Drawing.Point(29, 317);
            this.txtManX.Name = "txtManX";
            this.txtManX.Size = new System.Drawing.Size(86, 22);
            this.txtManX.TabIndex = 24;
            // 
            // txtManY
            // 
            this.txtManY.Enabled = false;
            this.txtManY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManY.Location = new System.Drawing.Point(29, 345);
            this.txtManY.Name = "txtManY";
            this.txtManY.Size = new System.Drawing.Size(86, 22);
            this.txtManY.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "X:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Y:";
            // 
            // btnMan
            // 
            this.btnMan.Location = new System.Drawing.Point(29, 373);
            this.btnMan.Name = "btnMan";
            this.btnMan.Size = new System.Drawing.Size(86, 23);
            this.btnMan.TabIndex = 28;
            this.btnMan.Text = "Übernehmen";
            this.btnMan.UseVisualStyleBackColor = true;
            this.btnMan.Visible = false;
            this.btnMan.Click += new System.EventHandler(this.btnMan_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 424);
            this.Controls.Add(this.btnMan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtManY);
            this.Controls.Add(this.txtManX);
            this.Controls.Add(this.btnO);
            this.Controls.Add(this.btnW);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.combField);
            this.Controls.Add(this.txtWesten);
            this.Controls.Add(this.txtSüden);
            this.Controls.Add(this.txtOsten);
            this.Controls.Add(this.txtNorden);
            this.Controls.Add(this.cBoxWesten);
            this.Controls.Add(this.cBoxSüden);
            this.Controls.Add(this.cBoxOsten);
            this.Controls.Add(this.cBoxNorden);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnEvent);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.picBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Designer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblPos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionenToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblLock;
        private System.Windows.Forms.ToolStripMenuItem höheToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem breiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.Button btnEvent;
        private System.Windows.Forms.ComboBox combField;
        private System.Windows.Forms.TextBox txtWesten;
        private System.Windows.Forms.TextBox txtSüden;
        private System.Windows.Forms.TextBox txtOsten;
        private System.Windows.Forms.TextBox txtNorden;
        private System.Windows.Forms.CheckBox cBoxWesten;
        private System.Windows.Forms.CheckBox cBoxSüden;
        private System.Windows.Forms.CheckBox cBoxOsten;
        private System.Windows.Forms.CheckBox cBoxNorden;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.TextBox txtManX;
        private System.Windows.Forms.TextBox txtManY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMan;
    }
}

