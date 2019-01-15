using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_chelek_c___etgar
{
    public partial class Form1 : Form
    {
        int sum1 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            random1Lbl.Text = r.Next(100).ToString();
            random2Lbl.Text = r.Next(100).ToString();
            random3Lbl.Text = r.Next(100).ToString();
            random4Lbl.Text = r.Next(100).ToString();
            random5Lbl.Text = r.Next(100).ToString();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
           
            random1Lbl.ForeColor = random1Lbl.BackColor;
            random2Lbl.ForeColor = random2Lbl.BackColor;
            random3Lbl.ForeColor = random3Lbl.BackColor;
            random4Lbl.ForeColor = random4Lbl.BackColor;
            random5Lbl.ForeColor = random5Lbl.BackColor;
        }

        private void finishBtn_Click(object sender, EventArgs e)
        {
            
            int sum = 0;
            if (random1Lbl.Text == memory1TxtBx.Text)
            {
                sum = sum + 1;
            }
            else
            {
                memory1TxtBx.ForeColor = Color.Red;
            }
            if (random2Lbl.Text == memory2TxtBx.Text)
            {
                sum = sum + 1;
            }
            else
            {
                memory2TxtBx.ForeColor = Color.Red;
            }
            if (random3Lbl.Text == memory3TxtBx.Text)
            {
                sum = sum + 1;
            }
            else
            {
                memory3TxtBx.ForeColor = Color.Red;
            }

            if (random4Lbl.Text == memory4TxtBx.Text)
            {
                sum = sum + 1;
            }
            else
            {
                memory4TxtBx.ForeColor = Color.Red;
            }
            if (random5Lbl.Text == memory5TxtBx.Text)
            {
                sum = sum + 1;
            }
            else
            {
                memory5TxtBx.ForeColor = Color.Red;
            }
            if (sum == 5)
            {
                MessageBox.Show("you won!!", "very good!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                resultsLstBox.Items.Add(sum);
            }
            else
            {
                MessageBox.Show("wrong!!", "try again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resultsLstBox.Items.Add(sum);
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            random1Lbl.ForeColor = Color.Black;
            random2Lbl.ForeColor = Color.Black;
            random3Lbl.ForeColor = Color.Black;
            random4Lbl.ForeColor = Color.Black;
            random5Lbl.ForeColor = Color.Black;
            memory1TxtBx.Text = "";
            memory2TxtBx.Text = "";
            memory3TxtBx.Text = "";
            memory4TxtBx.Text = "";
            memory5TxtBx.Text = "";
            Random r = new Random();
            random1Lbl.Text = r.Next(100).ToString();
            random2Lbl.Text = r.Next(100).ToString();
            random3Lbl.Text = r.Next(100).ToString();
            random4Lbl.Text = r.Next(100).ToString();
            random5Lbl.Text = r.Next(100).ToString();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void memory1TxtBx_Leave_1(object sender, EventArgs e)
        {
            if (random1Lbl.Text == memory1TxtBx.Text)
            {
                sum1 = sum1 + 1;
            }
        }

        private void memory2TxtBx_Leave(object sender, EventArgs e)
        {
            if (random2Lbl.Text == memory2TxtBx.Text)
            {
                sum1 = sum1 + 1;
            }
        }

        private void memory3TxtBx_Leave(object sender, EventArgs e)
        {
            if (random3Lbl.Text == memory3TxtBx.Text)
            {
                sum1 = sum1 + 1;
            }
        }

        private void memory4TxtBx_Leave(object sender, EventArgs e)
        {
            if (random4Lbl.Text == memory4TxtBx.Text)
            {
                sum1 = sum1 + 1;
            }
        }

        private void memory5TxtBx_Leave(object sender, EventArgs e)
        {
            if (random5Lbl.Text == memory5TxtBx.Text)
            {
                sum1 = sum1 + 1;
            }
            if (sum1 == 5)
            {
                MessageBox.Show("you won!!", "very good!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                resultsLstBox.Items.Add(sum1);
            }
            else
            {
                MessageBox.Show("wrong!!", "try again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resultsLstBox.Items.Add(sum1);
            }
        }


    }
    
}