using System;
using HtmlAgilityPack;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net;
using System.Text;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ScrapySharp.Extensions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace TPDP_Charts
{
    /*
     1 = Void
     2 = Fire
     3 = Water
     4 = Nature
     5 = Earth
     6 = Steel
     7 = Wind
     8 = Electric
     9 = Light
     10 = Dark
     11 = Nether
     12 = Poison
     13 = Fighting
     14 = Illusion
     15 = Sound
     16 = Warped
     17 = Dream
     
     O = Super Effective (2x)
     △ = Not Very Effective (0.5x)
     X = No Effect (0x)
    */

    public partial class Form1 : Form
    {
        string URL = "http://en.tpdpwiki.net/wiki/";
        string FORM_NAME = "Touhou Puppet Dance Performance";
        string procName = "幻想人形演舞-ユメノカケラ-";
        string last_puppet = "";
        int last_style = 0;
        public ChromeDriver GlobalDriver;
        Memory MemX = new Memory();
        

        public Form1()
        {
            InitializeComponent();
            GlobalDriver = HideSeleniumDrivers();
        }

        private ChromeDriver HideSeleniumDrivers()
        {
            ChromeDriverService srv = ChromeDriverService.CreateDefaultService();
            srv.HideCommandPromptWindow = true;

            var options = new ChromeOptions();
            options.AddArgument("headless");
            
            return new ChromeDriver(srv, options);
        }


        private void GetTypes(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            supeffec.Text = "N/A";
            neueffec.Text = "N/A";
            weakeffec.Text = "N/A";

            Dictionary<string, string> table_dict = new Dictionary<string, string>();
            GlobalDriver.Navigate().GoToUrl(URL + ppt_field.Text);
            List<string> abs = new List<string>();

            var types = GlobalDriver.FindElements(By.XPath("//table[@border='1']//tr[3]//td"));
            var cost = GlobalDriver.FindElements(By.XPath("//table[@border='1']//tr[4]//td"));
            var styles = GlobalDriver.FindElements(By.XPath("//table[@border='1']//tr[9]//td[1]//a"));
            var abilities = GlobalDriver.FindElements(By.XPath("//table[@border='1']//tr[6]//td[1]//a"));


            var stats = GlobalDriver.FindElements(By.XPath("//table[@class='wikitable'][1]//tbody//tr[2]//td"));
            var effectivity = GlobalDriver.FindElements(By.XPath("//table[@class='wikitable'][2]//tbody//td"));

            //MessageBox.Show(ppt_field.Text);
            bool is_ok = effectivity[0].Text.Contains("x");

            if (is_ok) {
                stats = GlobalDriver.FindElements(By.XPath("//table[@class='wikitable'][1]//tbody//tr[2]//td"));
                effectivity = GlobalDriver.FindElements(By.XPath("//table[@class='wikitable'][2]//tbody//td"));
            }

            else {
                stats = GlobalDriver.FindElements(By.XPath("//table[@class='wikitable'][2]//tbody//tr[2]//td"));
                effectivity = GlobalDriver.FindElements(By.XPath("//table[@class='wikitable'][3]//tbody//td"));
            }

            typing.Text = types[0].Text;
            costlabel.Text = cost[0].Text;

            for (int i = 0; i < 16; i++)
                table_dict.Add(UglyFunctions.GetEffectivity(i + 1), effectivity[i].Text.ToString().Replace("x", "").Replace("*",""));
            
            string super = "";
            string neutral = "";
            string weak = "";

            foreach (var item in table_dict) {
                var eff_multiplier = float.Parse(item.Value);

                if (eff_multiplier > 1 & eff_multiplier <= 4)
                    super += $"{item.Key} ({item.Value}x)\n";
                else if (eff_multiplier == 1)
                    neutral += $"{item.Key} ({item.Value}x)\n";
                else
                    weak += $"{item.Key} ({item.Value}x)\n";
            }

            if (super != "")
                supeffec.Text = super;
            if (neutral != "")
                neueffec.Text = neutral;
            if (weak != "")
                weakeffec.Text = weak;

            Puppet1.Text = styles[0].Text;
            Puppet2.Text = styles[1].Text;
            Puppet3.Text = styles[2].Text;


            Puppet1.Visible = true;
            Puppet2.Visible = true;
            Puppet3.Visible = true;

            HP.Text = stats[0].Text;
            FoAtk.Text = stats[1].Text;
            FoDef.Text = stats[2].Text;
            SpAtk.Text = stats[3].Text;
            SpDef.Text = stats[4].Text;
            Spd.Text = stats[5].Text;
            Total.Text = stats[6].Text;

            //string abs = "";

            foreach (var ab in abilities)
            {
                LinkLabel lnkLbl = new LinkLabel();
                lnkLbl.Text = ab.Text.CleanInnerText().Trim();
                lnkLbl.LinkClicked += (x, y) => MessageBox.Show(UglyFunctions.Find(((LinkLabel)x).Text), ((LinkLabel)x).Text);
                abs.Add(ab.Text.CleanInnerText().Trim());
                flowLayoutPanel1.Controls.Add(lnkLbl);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(URL + $"{ppt_field.Text}");
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
                scrapbtn.PerformClick();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalDriver.Quit();
            GlobalDriver.Dispose();
            Application.Exit();
        }

        private void PuppetStyle(object sender, EventArgs e)
        {
            string style = ((Label)sender).Text;
            ppt_field.Text = style;
            scrapbtn.PerformClick();
        }

        public void LookStyle(string name,int style_byte)
        {
            style_byte -= 144;
            string final_url = "http://en.tpdpwiki.net/wiki/" + name.CleanInnerText().Trim();
            TextBox tb = new TextBox();
            tb.Visible = false;
            tb.Text = final_url.CleanInnerText().Trim();
            GlobalDriver.Navigate().GoToUrl(tb.Text);
            var styles = GlobalDriver.FindElements(By.XPath("//table[@border='1']//tr[9]//td[1]//a"));

            ppt_field.Text = styles[style_byte-1].Text.CleanInnerText();
            scrapbtn.PerformClick();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (autosearch.Checked)
            {
                try {
                    long baseAddress = MemX.GetBaseAddress($"{procName}.exe");
                    bool isRunning = MemX.GetBaseAddress(procName + ".exe") != 0 ? true : false;
                    if (!isRunning)
                    {
                        this.Text = FORM_NAME;
                        MemX.GetProcessHandle(procName);

                    }
                    else
                        this.Text = FORM_NAME + $" [Connected to Process {procName}]";



                    var name_offset = 0xC5A514;
                    var style_offset = 0xC5A17A;

                    var name_address = baseAddress + name_offset;
                    var style_address = baseAddress + style_offset;

                    string name = MemX.ReadString(name_address, 10).CleanInnerText().Trim();
                    int style = Convert.ToInt32(MemX.ReadMemory(style_address, 1)[0].ToString());

                    if (Regex.Match(name[0].ToString(), @"[a-zA-Z]").Success)
                        if (last_puppet != name.CleanInnerText().Trim() | last_style != style)
                        {

                            if (style > 144)
                                LookStyle(name.Split('\0')[0], style);
                            else
                            {
                                ppt_field.Text = name.CleanInnerText().Trim();
                                scrapbtn.PerformClick();
                            }
                            last_puppet = name.CleanInnerText().Trim();
                            last_style = style;
                        }
                }
                catch(Exception ex) {
                    autosearch.Checked = false;
                    MessageBox.Show("An exception was thrown and Auto-Search was disabled.", "Auto-Search Notification", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
        }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            MemX.GetProcessHandle(procName);
            bool isRunning = MemX.GetBaseAddress(procName + ".exe") != 0 ? true : false;
            if (!isRunning)
                MessageBox.Show("Touhou Puppet Dance Performance SoD was not detected.", "Error");
            else
                this.Text = FORM_NAME + $" [Connected to Process {procName}]";
            
            timer1.Start();
        }
    }
}
