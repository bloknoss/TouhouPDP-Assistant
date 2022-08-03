namespace TPDP_Charts
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
            this.ppt_field = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.scrapbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.typing = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.supeffec = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.neueffec = new System.Windows.Forms.Label();
            this.weakeffec = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Puppet1 = new System.Windows.Forms.LinkLabel();
            this.Puppet2 = new System.Windows.Forms.LinkLabel();
            this.Puppet3 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.HP = new System.Windows.Forms.Label();
            this.FoAtk = new System.Windows.Forms.Label();
            this.FoDef = new System.Windows.Forms.Label();
            this.SpAtk = new System.Windows.Forms.Label();
            this.SpDef = new System.Windows.Forms.Label();
            this.Spd = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.autosearch = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.costlabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ppt_field
            // 
            this.ppt_field.Location = new System.Drawing.Point(699, 4);
            this.ppt_field.Name = "ppt_field";
            this.ppt_field.Size = new System.Drawing.Size(122, 20);
            this.ppt_field.TabIndex = 4;
            this.ppt_field.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ppt_field.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(301, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "TPDP: Puppet Types Tool";
            // 
            // scrapbtn
            // 
            this.scrapbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.scrapbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.scrapbtn.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrapbtn.Location = new System.Drawing.Point(699, 30);
            this.scrapbtn.Name = "scrapbtn";
            this.scrapbtn.Size = new System.Drawing.Size(122, 23);
            this.scrapbtn.TabIndex = 7;
            this.scrapbtn.Text = "Find Puppet";
            this.scrapbtn.UseVisualStyleBackColor = false;
            this.scrapbtn.Click += new System.EventHandler(this.GetTypes);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(10, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Puppet Type";
            // 
            // typing
            // 
            this.typing.AutoSize = true;
            this.typing.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold);
            this.typing.Location = new System.Drawing.Point(13, 251);
            this.typing.Name = "typing";
            this.typing.Size = new System.Drawing.Size(34, 19);
            this.typing.TabIndex = 9;
            this.typing.Text = "N/A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(187, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Super Effective";
            // 
            // supeffec
            // 
            this.supeffec.AutoSize = true;
            this.supeffec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supeffec.ForeColor = System.Drawing.Color.Red;
            this.supeffec.Location = new System.Drawing.Point(-3, -1);
            this.supeffec.Name = "supeffec";
            this.supeffec.Size = new System.Drawing.Size(26, 15);
            this.supeffec.TabIndex = 11;
            this.supeffec.Text = "N/A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(369, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "Neutral";
            // 
            // neueffec
            // 
            this.neueffec.AutoSize = true;
            this.neueffec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neueffec.ForeColor = System.Drawing.Color.Navy;
            this.neueffec.Location = new System.Drawing.Point(-3, -1);
            this.neueffec.Name = "neueffec";
            this.neueffec.Size = new System.Drawing.Size(26, 15);
            this.neueffec.TabIndex = 13;
            this.neueffec.Text = "N/A";
            // 
            // weakeffec
            // 
            this.weakeffec.AutoSize = true;
            this.weakeffec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weakeffec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.weakeffec.Location = new System.Drawing.Point(-3, -1);
            this.weakeffec.Name = "weakeffec";
            this.weakeffec.Size = new System.Drawing.Size(26, 15);
            this.weakeffec.TabIndex = 15;
            this.weakeffec.Text = "N/A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(494, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Resistant/Immune";
            // 
            // Puppet1
            // 
            this.Puppet1.AutoSize = true;
            this.Puppet1.Location = new System.Drawing.Point(696, 79);
            this.Puppet1.Name = "Puppet1";
            this.Puppet1.Size = new System.Drawing.Size(39, 13);
            this.Puppet1.TabIndex = 17;
            this.Puppet1.TabStop = true;
            this.Puppet1.Text = "Form 1";
            this.Puppet1.Visible = false;
            this.Puppet1.Click += new System.EventHandler(this.PuppetStyle);
            // 
            // Puppet2
            // 
            this.Puppet2.AutoSize = true;
            this.Puppet2.Location = new System.Drawing.Point(696, 97);
            this.Puppet2.Name = "Puppet2";
            this.Puppet2.Size = new System.Drawing.Size(39, 13);
            this.Puppet2.TabIndex = 18;
            this.Puppet2.TabStop = true;
            this.Puppet2.Text = "Form 2";
            this.Puppet2.Visible = false;
            this.Puppet2.Click += new System.EventHandler(this.PuppetStyle);
            // 
            // Puppet3
            // 
            this.Puppet3.AutoSize = true;
            this.Puppet3.Location = new System.Drawing.Point(696, 115);
            this.Puppet3.Name = "Puppet3";
            this.Puppet3.Size = new System.Drawing.Size(39, 13);
            this.Puppet3.TabIndex = 19;
            this.Puppet3.TabStop = true;
            this.Puppet3.Text = "Form 3";
            this.Puppet3.Visible = false;
            this.Puppet3.Click += new System.EventHandler(this.PuppetStyle);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "HP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Fo. Att";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 19);
            this.label10.TabIndex = 22;
            this.label10.Text = "Fo. Def";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 19);
            this.label11.TabIndex = 25;
            this.label11.Text = "Speed";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 19);
            this.label12.TabIndex = 24;
            this.label12.Text = "Sp. Def";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 19);
            this.label13.TabIndex = 23;
            this.label13.Text = "Sp. Att";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 181);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 19);
            this.label14.TabIndex = 26;
            this.label14.Text = "Total";
            // 
            // HP
            // 
            this.HP.AutoSize = true;
            this.HP.Location = new System.Drawing.Point(77, 81);
            this.HP.Name = "HP";
            this.HP.Size = new System.Drawing.Size(13, 13);
            this.HP.TabIndex = 27;
            this.HP.Text = "0";
            // 
            // FoAtk
            // 
            this.FoAtk.AutoSize = true;
            this.FoAtk.Location = new System.Drawing.Point(77, 100);
            this.FoAtk.Name = "FoAtk";
            this.FoAtk.Size = new System.Drawing.Size(13, 13);
            this.FoAtk.TabIndex = 28;
            this.FoAtk.Text = "0";
            // 
            // FoDef
            // 
            this.FoDef.AutoSize = true;
            this.FoDef.Location = new System.Drawing.Point(77, 117);
            this.FoDef.Name = "FoDef";
            this.FoDef.Size = new System.Drawing.Size(13, 13);
            this.FoDef.TabIndex = 29;
            this.FoDef.Text = "0";
            // 
            // SpAtk
            // 
            this.SpAtk.AutoSize = true;
            this.SpAtk.Location = new System.Drawing.Point(77, 134);
            this.SpAtk.Name = "SpAtk";
            this.SpAtk.Size = new System.Drawing.Size(13, 13);
            this.SpAtk.TabIndex = 30;
            this.SpAtk.Text = "0";
            // 
            // SpDef
            // 
            this.SpDef.AutoSize = true;
            this.SpDef.Location = new System.Drawing.Point(77, 152);
            this.SpDef.Name = "SpDef";
            this.SpDef.Size = new System.Drawing.Size(13, 13);
            this.SpDef.TabIndex = 31;
            this.SpDef.Text = "0";
            // 
            // Spd
            // 
            this.Spd.AutoSize = true;
            this.Spd.Location = new System.Drawing.Point(75, 169);
            this.Spd.Name = "Spd";
            this.Spd.Size = new System.Drawing.Size(13, 13);
            this.Spd.TabIndex = 32;
            this.Spd.Text = "0";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(75, 187);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(13, 13);
            this.Total.TabIndex = 33;
            this.Total.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Brown;
            this.label15.Location = new System.Drawing.Point(9, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 24);
            this.label15.TabIndex = 34;
            this.label15.Text = "Puppet Stats";
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // autosearch
            // 
            this.autosearch.AutoSize = true;
            this.autosearch.Checked = true;
            this.autosearch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autosearch.Location = new System.Drawing.Point(736, 349);
            this.autosearch.Name = "autosearch";
            this.autosearch.Size = new System.Drawing.Size(85, 17);
            this.autosearch.TabIndex = 35;
            this.autosearch.Text = "Auto-Search";
            this.autosearch.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(10, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 23);
            this.label2.TabIndex = 36;
            this.label2.Text = "Puppet Abilities";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 304);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(94, 48);
            this.flowLayoutPanel1.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.supeffec);
            this.panel1.Location = new System.Drawing.Point(191, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(98, 128);
            this.panel1.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.neueffec);
            this.panel2.Location = new System.Drawing.Point(375, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(98, 128);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.weakeffec);
            this.panel3.Location = new System.Drawing.Point(501, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(98, 128);
            this.panel3.TabIndex = 42;
            // 
            // costlabel
            // 
            this.costlabel.AutoSize = true;
            this.costlabel.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold);
            this.costlabel.Location = new System.Drawing.Point(190, 251);
            this.costlabel.Name = "costlabel";
            this.costlabel.Size = new System.Drawing.Size(34, 19);
            this.costlabel.TabIndex = 44;
            this.costlabel.Text = "N/A";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(187, 227);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 23);
            this.label16.TabIndex = 43;
            this.label16.Text = "Puppet Cost";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 369);
            this.Controls.Add(this.costlabel);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.autosearch);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Spd);
            this.Controls.Add(this.SpDef);
            this.Controls.Add(this.SpAtk);
            this.Controls.Add(this.FoDef);
            this.Controls.Add(this.FoAtk);
            this.Controls.Add(this.HP);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Puppet3);
            this.Controls.Add(this.Puppet2);
            this.Controls.Add(this.Puppet1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.typing);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.scrapbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ppt_field);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Touhou Puppet Dance Performance ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ppt_field;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button scrapbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label typing;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label supeffec;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label neueffec;
        private System.Windows.Forms.Label weakeffec;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel Puppet1;
        private System.Windows.Forms.LinkLabel Puppet2;
        private System.Windows.Forms.LinkLabel Puppet3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label HP;
        private System.Windows.Forms.Label FoAtk;
        private System.Windows.Forms.Label FoDef;
        private System.Windows.Forms.Label SpAtk;
        private System.Windows.Forms.Label SpDef;
        private System.Windows.Forms.Label Spd;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox autosearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label costlabel;
        private System.Windows.Forms.Label label16;
    }
}

