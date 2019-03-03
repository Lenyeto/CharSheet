namespace CharacterSheet
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
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Equipment");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Weapons");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CorePage = new System.Windows.Forms.TabPage();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.combatStats = new System.Windows.Forms.GroupBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.CurHitPoints = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.armorClass = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BioPage = new System.Windows.Forms.TabPage();
            this.SpellsPage = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.MaxHitPoints = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.CorePage.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.combatStats.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CorePage);
            this.tabControl1.Controls.Add(this.BioPage);
            this.tabControl1.Controls.Add(this.SpellsPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(747, 972);
            this.tabControl1.TabIndex = 0;
            // 
            // CorePage
            // 
            this.CorePage.Controls.Add(this.groupBox17);
            this.CorePage.Controls.Add(this.groupBox16);
            this.CorePage.Controls.Add(this.combatStats);
            this.CorePage.Controls.Add(this.groupBox7);
            this.CorePage.Controls.Add(this.groupBox6);
            this.CorePage.Controls.Add(this.groupBox5);
            this.CorePage.Controls.Add(this.groupBox4);
            this.CorePage.Controls.Add(this.groupBox3);
            this.CorePage.Controls.Add(this.groupBox2);
            this.CorePage.Controls.Add(this.groupBox1);
            this.CorePage.Location = new System.Drawing.Point(4, 22);
            this.CorePage.Name = "CorePage";
            this.CorePage.Padding = new System.Windows.Forms.Padding(3);
            this.CorePage.Size = new System.Drawing.Size(739, 946);
            this.CorePage.TabIndex = 0;
            this.CorePage.Text = "Core";
            this.CorePage.UseVisualStyleBackColor = true;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.treeView1);
            this.groupBox17.Controls.Add(this.toolStrip1);
            this.groupBox17.Location = new System.Drawing.Point(253, 581);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(274, 359);
            this.groupBox17.TabIndex = 9;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Equipment";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(7, 45);
            this.treeView1.Name = "treeView1";
            treeNode13.Name = "Equipment";
            treeNode13.Text = "Equipment";
            treeNode14.Name = "Weapons";
            treeNode14.Text = "Weapons";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            this.treeView1.Size = new System.Drawing.Size(261, 308);
            this.treeView1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(268, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyDown);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(54, 22);
            this.toolStripLabel1.Text = "Weight : ";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(31, 22);
            this.toolStripLabel2.Text = "0 lbs";
            // 
            // groupBox16
            // 
            this.groupBox16.Location = new System.Drawing.Point(253, 431);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(274, 143);
            this.groupBox16.TabIndex = 8;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Attacks and Spellcasting";
            // 
            // combatStats
            // 
            this.combatStats.Controls.Add(this.groupBox15);
            this.combatStats.Controls.Add(this.groupBox14);
            this.combatStats.Controls.Add(this.groupBox13);
            this.combatStats.Controls.Add(this.groupBox12);
            this.combatStats.Controls.Add(this.groupBox11);
            this.combatStats.Controls.Add(this.groupBox10);
            this.combatStats.Controls.Add(this.armorClass);
            this.combatStats.Location = new System.Drawing.Point(253, 7);
            this.combatStats.Name = "combatStats";
            this.combatStats.Size = new System.Drawing.Size(274, 418);
            this.combatStats.TabIndex = 7;
            this.combatStats.TabStop = false;
            this.combatStats.Text = "Combat Info";
            // 
            // groupBox15
            // 
            this.groupBox15.Location = new System.Drawing.Point(144, 339);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(124, 73);
            this.groupBox15.TabIndex = 6;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Death Saves";
            // 
            // groupBox14
            // 
            this.groupBox14.Location = new System.Drawing.Point(7, 339);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(130, 73);
            this.groupBox14.TabIndex = 5;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Hit Dice";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.label1);
            this.groupBox13.Location = new System.Drawing.Point(7, 223);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(261, 109);
            this.groupBox13.TabIndex = 4;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Temporary Hit Points";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Heat Metal";
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.numericUpDown1);
            this.groupBox12.Controls.Add(this.MaxHitPoints);
            this.groupBox12.Controls.Add(this.CurHitPoints);
            this.groupBox12.Controls.Add(this.trackBar1);
            this.groupBox12.Location = new System.Drawing.Point(7, 106);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(261, 110);
            this.groupBox12.TabIndex = 3;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Currernt Hit Points";
            // 
            // CurHitPoints
            // 
            this.CurHitPoints.AutoSize = true;
            this.CurHitPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurHitPoints.Location = new System.Drawing.Point(7, 67);
            this.CurHitPoints.Name = "CurHitPoints";
            this.CurHitPoints.Size = new System.Drawing.Size(29, 31);
            this.CurHitPoints.TabIndex = 11;
            this.CurHitPoints.Text = "0";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 19);
            this.trackBar1.Maximum = 40;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(249, 45);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // groupBox11
            // 
            this.groupBox11.Location = new System.Drawing.Point(177, 20);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(91, 79);
            this.groupBox11.TabIndex = 2;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Speed";
            // 
            // groupBox10
            // 
            this.groupBox10.Location = new System.Drawing.Point(91, 20);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(79, 79);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Initiative";
            // 
            // armorClass
            // 
            this.armorClass.Location = new System.Drawing.Point(7, 20);
            this.armorClass.Name = "armorClass";
            this.armorClass.Size = new System.Drawing.Size(78, 79);
            this.armorClass.TabIndex = 0;
            this.armorClass.TabStop = false;
            this.armorClass.Text = "Armor Class";
            // 
            // groupBox7
            // 
            this.groupBox7.Location = new System.Drawing.Point(533, 538);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 402);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Features and Traits";
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(634, 432);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(99, 100);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Resource";
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(533, 431);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(95, 100);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Resource";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.richTextBox4);
            this.groupBox4.Location = new System.Drawing.Point(533, 325);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Flaws";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBox3);
            this.groupBox3.Location = new System.Drawing.Point(533, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bonds";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox2);
            this.groupBox2.Location = new System.Drawing.Point(533, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ideals";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(533, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personality Traits";
            // 
            // BioPage
            // 
            this.BioPage.Location = new System.Drawing.Point(4, 22);
            this.BioPage.Name = "BioPage";
            this.BioPage.Padding = new System.Windows.Forms.Padding(3);
            this.BioPage.Size = new System.Drawing.Size(739, 946);
            this.BioPage.TabIndex = 1;
            this.BioPage.Text = "Bio";
            this.BioPage.UseVisualStyleBackColor = true;
            // 
            // SpellsPage
            // 
            this.SpellsPage.Location = new System.Drawing.Point(4, 22);
            this.SpellsPage.Name = "SpellsPage";
            this.SpellsPage.Size = new System.Drawing.Size(739, 946);
            this.SpellsPage.TabIndex = 2;
            this.SpellsPage.Text = "Spells";
            this.SpellsPage.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(7, 20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(187, 74);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(7, 20);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(187, 74);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(7, 20);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(187, 80);
            this.richTextBox3.TabIndex = 0;
            this.richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(7, 20);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(187, 74);
            this.richTextBox4.TabIndex = 0;
            this.richTextBox4.Text = "";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(84, 65);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(69, 38);
            this.numericUpDown1.TabIndex = 14;
            // 
            // MaxHitPoints
            // 
            this.MaxHitPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxHitPoints.Location = new System.Drawing.Point(161, 67);
            this.MaxHitPoints.Name = "MaxHitPoints";
            this.MaxHitPoints.Size = new System.Drawing.Size(94, 38);
            this.MaxHitPoints.TabIndex = 13;
            this.MaxHitPoints.Text = "40";
            this.MaxHitPoints.TextChanged += new System.EventHandler(this.MaxHitPoints_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 996);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.CorePage.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.combatStats.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CorePage;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage BioPage;
        private System.Windows.Forms.TabPage SpellsPage;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.GroupBox combatStats;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox armorClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label CurHitPoints;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox MaxHitPoints;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

