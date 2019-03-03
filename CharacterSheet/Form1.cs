﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterSheet
{
    public partial class Form1 : Form
    {
        private WebBrowser web;
        private WebBrowserToolTip2 toolTip;

        public Form1()
        {
            InitializeComponent();
            web = new WebBrowser();
            web.Width = 600;
            web.Height = 400;
            
            web.ScrollBarsEnabled = false;
            toolTip = new WebBrowserToolTip2(web);
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            web.DocumentText = "<div class=\"listResult booktemplate closed single\"> <div class=\"list - hide inapp - hide single - view slide - down content - toggle\"> <div class=\"gold\"></div> <div class=\"body\"> <div class=\"name\"> <a name=\"toc_2\"></a><h1>Heat Metal</h1> </div> <div class=\"subtitle redsubtitle\"><span class=\"level2\">2</span> <span>Transmutation </span></div> <div class=\"single - list\"> <ul> <li><span>Casting Time: </span>1 action</li> <li><span>Range: </span>60 feet</li> <li><span>Components: </span>V S M (A piece of iron and a flame)</li> <li><span>Duration: </span><span class=\"con\">Yes</span>Up to 1 minute</li> <li><span>Classes: </span>Bard, Druid</li> <li>Choose a manufactured metal object, such as a metal weapon or a suit of heavy or medium metal armor, that you can see within range. You cause the object to glow red-hot. Any creature in physical contact with the object takes 2d8 fire damage when you cast the spell. Until the spell ends, you can use a bonus action on each of your subsequent turns to cause this damage again. If a creature is holding or wearing the object and takes the damage from it, the creature must succeed on a Constitution saving throw or drop the object if it can. If it doesn’t drop the object, it has disadvantage on attack rolls and ability checks until the start of your next turn.</li> <li><span>At Higher Levels: </span>When you cast this spell using a spell slot of 3rd level or higher, the damage increases by 1d8 for each slot above 2nd.</li> </ul> </div> </div> <div class=\"gold\"></div> </div> </div>";
            
            if (web.Document.Body != null)
            web.Document.Body.Style = "font-size:x-small";
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            Point point = new Point();
            point.X = label1.Location.X + label1.Width / 2;
            point.Y = label1.Location.Y + label1.Height / 2;
            toolTip.Show(web, point);
        }
    }

    class WebBrowserToolTip2 : ToolStripDropDown

    {

        public Control ctl;



        public WebBrowserToolTip2(Control aControl)

            : base()

        {

            this.ctl = aControl;

            Initialize();

        }



        public void Initialize()

        {

            this.AutoSize = false;

            ToolStripControlHost host = new ToolStripControlHost(this.ctl);

            this.Margin = Padding.Empty;

            this.Padding = Padding.Empty;

            host.Margin = Padding.Empty;

            host.Padding = Padding.Empty;

            host.AutoSize = false;

            host.Size = ctl.Size;

            this.Size = ctl.Size;

            this.Items.Add(host);

        }

    }
}