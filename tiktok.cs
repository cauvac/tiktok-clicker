using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace tiktok_clicker
{
    public partial class tiktok : Form
    {
        public tiktok()
        {
            InitializeComponent();
            label2.Text = "tc v." + version;
        }

        private void OpenURL(string url)
        {

            Process.Start("explorer", url);

        }

        private String FancifyNumber(double number)
        {

            var cool = new StringBuilder();
            if (number < 1000)
                cool.Append((Math.Round(number * 10) / 10));
            else
            {
                cool.AppendFormat("{0:0.0000}", (number / Math.Pow(10, Math.Floor(Math.Log10(number)))));
                cool.Append("+e");
                cool.Append(Math.Floor(Math.Log10(number)));
            }

            return cool.ToString();
        }

        private double tiktik = 0;
        private double tikk = 1;
        private double tikkkok = 50;
        private double tps = 1;
        private int upgrades = 0;
        private String version = "1.2.4";
        private String filepath = ".\\tiktok.tc-sf";
        private String confpath = ".\\default.tc-cf";
        private String preferredSaveName = string.Empty;
        private Random random = new Random();

        private void Update_Tiktok()
        {

            label1.Text = FancifyNumber(tiktik) + " tiktok";
            button1.Text = "tiktok (x" + FancifyNumber(tikk) + ")";
            button2.Text = "upgrade tiktok (" + FancifyNumber(tikkkok) + " tiktok)";
            label4.Text = FancifyNumber(tps) + " tps";
            label3.Text = "level " + (upgrades + 1);
            if (!(tiktik > tikkkok)) progressBar1.Value = (int)(tiktik / tikkkok * 100);
            else progressBar1.Value = 100;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            tiktik += 1 * tikk;
            Update_Tiktok();
            button2.ForeColor = Color.Black;
            button2.Text = "upgrade tiktok (" + FancifyNumber(tikkkok) + " tiktok)";

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (tiktik >= tikkkok)
            {

                tiktik -= tikkkok;
                tikk *= (1.1 + (random.NextDouble() * 2)) + random.NextDouble() / 2;
                tikkkok *= 8;
                button2.Text = "upgrade tiktok (" + FancifyNumber(tikkkok) + " tiktok)";
                tps += tikk * (random.NextDouble() * 0.1 + 1) * (10 + (upgrades * 3));
                upgrades += 1;

            }
            else
            {

                button2.ForeColor = Color.Red;
                button2.Text = "not enough tiktok!";

            }

            Update_Tiktok();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenURL("https://t.me/tiktokclicker/");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            tiktik += tps;
            label4.Text = Math.Round(tps * 10) / 10 + " tps";
            Update_Tiktok();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var fs = new FileStream(textBox1.Text == string.Empty ? filepath : ".\\" + textBox1.Text + ".tc-sf", FileMode.OpenOrCreate))
            using (var sw = new StreamWriter(fs))
            {
                sw.WriteLine(tiktik);
                sw.WriteLine(tikk);
                sw.WriteLine(tikkkok);
                sw.WriteLine(tps);
                sw.WriteLine(upgrades);
            }

            using (var fs = new FileStream(confpath, FileMode.OpenOrCreate))
            using (var sw = new StreamWriter(fs))
            {
                sw.WriteLine(textBox1.Text);
            }

            Update_Tiktok();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            using (var fs = new FileStream(textBox1.Text == string.Empty ? filepath : ".\\" + textBox1.Text + ".tc-sf", FileMode.OpenOrCreate))
            using (var sw = new StreamReader(fs))
            {
                try
                {

                    tiktik = double.Parse(sw.ReadLine());
                    tikk = double.Parse(sw.ReadLine());
                    tikkkok = double.Parse(sw.ReadLine());
                    tps = double.Parse(sw.ReadLine());
                    upgrades = int.Parse(sw.ReadLine());

                }
                catch
                {

                }
            }

            using (var fs = new FileStream(confpath, FileMode.OpenOrCreate))
            using (var sw = new StreamWriter(fs))
            {
                sw.WriteLine(textBox1.Text);
            }

            Update_Tiktok();

        }

        private void LoadConf(string confpath)
        {

            using (var fs = new FileStream(confpath, FileMode.OpenOrCreate))
            using (var sw = new StreamReader(fs))
            {
                try
                {

                    preferredSaveName = sw.ReadLine();

                }
                catch
                {

                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            camera newCamera = new camera(tikkkok, tiktik, tps);
            newCamera.ShowDialog();

        }

        private void tiktok_Load(object sender, EventArgs e)
        {

            LoadConf(confpath);
            textBox1.Text = preferredSaveName;

        }
    }
}
