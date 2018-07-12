using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastKeyTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.BackColor = Color.DarkGreen;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.BackColor = Color.DarkGreen;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox13.BackColor = Color.DarkGreen;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox14.BackColor = Color.DarkGreen;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox15.BackColor = Color.DarkGreen;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox16.BackColor = Color.DarkGreen;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pictureBox17.BackColor = Color.DarkGreen;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            pictureBox18.BackColor = Color.DarkGreen;
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            pictureBox29.BackColor = Color.DarkGreen;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            pictureBox19.BackColor = Color.DarkGreen;
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            pictureBox20.BackColor = Color.DarkGreen;
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            pictureBox31.BackColor = Color.DarkGreen;
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            pictureBox21.BackColor = Color.DarkGreen;
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            pictureBox22.BackColor = Color.DarkGreen;
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            pictureBox33.BackColor = Color.DarkGreen;
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            pictureBox23.BackColor = Color.DarkGreen;
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            pictureBox24.BackColor = Color.DarkGreen;
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            pictureBox35.BackColor = Color.DarkGreen;
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            pictureBox25.BackColor = Color.DarkGreen;
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            pictureBox26.BackColor = Color.DarkGreen;
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            pictureBox37.BackColor = Color.DarkGreen;
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            pictureBox39.BackColor = Color.DarkGreen;
        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {
            pictureBox41.BackColor = Color.DarkGreen;
        }

        private void pictureBox46_Click(object sender, EventArgs e)
        {
            pictureBox46.BackColor = Color.DarkGreen;
        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {
            pictureBox42.BackColor = Color.DarkGreen;
        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {
            pictureBox44.BackColor = Color.DarkGreen;
        }
        //water 6 / spirit / 5 / shadow 5 / forest 5 / fire 8 /GTG 9 / BOTS 3
        private void button7_Click(object sender, EventArgs e)
        {
            int nbr = Int32.Parse(forestKey.Text);
            nbr++;
            forestKey.Text = nbr.ToString();
            if (nbr == 5) {  button7.Enabled = false; }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int nbr = Int32.Parse(fireKey.Text);
            nbr++;
            fireKey.Text = nbr.ToString();
            if (nbr == 8) { button9.Enabled = false; }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int nbr = Int32.Parse(waterKey.Text);
            nbr++;
            waterKey.Text = nbr.ToString();
            if (nbr == 6) {  button11.Enabled = false; }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int nbr = Int32.Parse(shadowKey.Text);
            nbr++;
            shadowKey.Text = nbr.ToString();
            if (nbr == 5) {  button13.Enabled = false; }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int nbr = Int32.Parse(spiritKey.Text);
            nbr++;
            spiritKey.Text = nbr.ToString();
            if (nbr == 5) {  button15.Enabled = false; }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int nbr = Int32.Parse(gtgKey.Text);
            nbr++;
            gtgKey.Text = nbr.ToString();
            if (nbr == 9) {  button17.Enabled = false; }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int nbr = Int32.Parse(botwKey.Text);
            nbr++;
            botwKey.Text = nbr.ToString();
            if (nbr == 3) { button19.Enabled = false; }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            int nbr = Int32.Parse(trialKey.Text);
            nbr++;
            trialKey.Text = nbr.ToString();
            if (nbr == 2) { button21.Enabled = false; }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button7.Enabled = true;
            int nbr = Int32.Parse(forestKey.Text);
            nbr--;
            forestKey.Text = nbr.ToString();
            if (nbr == 0) { button8.Enabled = false; }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button9.Enabled = true;
            int nbr = Int32.Parse(fireKey.Text);
            nbr--;
            fireKey.Text = nbr.ToString();
            if (nbr == 0) { button10.Enabled = false; }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button11.Enabled = true;
            int nbr = Int32.Parse(waterKey.Text);
            nbr--;
            waterKey.Text = nbr.ToString();
            if (nbr == 0) { button12.Enabled = false; }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button13.Enabled = true;
            int nbr = Int32.Parse(shadowKey.Text);
            nbr--;
            shadowKey.Text = nbr.ToString();
            if (nbr == 0) { button14.Enabled = false; }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button15.Enabled = true;
            int nbr = Int32.Parse(spiritKey.Text);
            nbr--;
            spiritKey.Text = nbr.ToString();
            if (nbr == 0) { button16.Enabled = false; }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button17.Enabled = true;
            int nbr = Int32.Parse(gtgKey.Text);
            nbr--;
            gtgKey.Text = nbr.ToString();
            if (nbr == 0) { button18.Enabled = false; }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button19.Enabled = true;
            int nbr = Int32.Parse(botwKey.Text);
            nbr--;
            botwKey.Text = nbr.ToString();
            if (nbr == 0) { button20.Enabled = false; }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button21.Enabled = true;
            int nbr = Int32.Parse(trialKey.Text);
            nbr--;
            trialKey.Text = nbr.ToString();
            if (nbr == 0) { button22.Enabled = false; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox29.BackColor = Color.DarkRed;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox31.BackColor = Color.DarkRed;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox33.BackColor = Color.DarkRed;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox35.BackColor = Color.DarkRed;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox37.BackColor = Color.DarkRed;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox46.BackColor = Color.DarkRed;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            MessageBox.Show("When you get the maximum amount of Small Keys in a dungeons, the button '+' or '-' become disable. It re-enable again when you unadd or add keys. And I just added a temporary button for undo the Boss Keys. It will be removed in newer versions. And yes, you can't undo maps or compassed but it's very useless now, it'll be implemented later.");
        }
    }
}
