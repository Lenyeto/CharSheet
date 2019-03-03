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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CorePage = new System.Windows.Forms.TabPage();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.combatStats = new System.Windows.Forms.GroupBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
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
            this.tabControl1.SuspendLayout();
            this.CorePage.SuspendLayout();
            this.combatStats.SuspendLayout();
            this.groupBox13.SuspendLayout();
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
            this.groupBox17.Location = new System.Drawing.Point(253, 581);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(274, 359);
            this.groupBox17.TabIndex = 9;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Equipment";
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
            this.groupBox12.Location = new System.Drawing.Point(7, 106);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(261, 110);
            this.groupBox12.TabIndex = 3;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Currernt Hit Points";
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
            this.groupBox4.Location = new System.Drawing.Point(533, 325);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Flaws";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(533, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bonds";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(533, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ideals";
            // 
            // groupBox1
            // 
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 996);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.CorePage.ResumeLayout(false);
            this.combatStats.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
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
    }
}

