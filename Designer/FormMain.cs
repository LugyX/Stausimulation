using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Designer
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            this.ClientSize = new System.Drawing.Size(308, 424);
        }       

        Point pos = new Point();
        Bitmap bit_map;
        string[,] str_map;       

        bool locked = false;
        string result;
        int SCREEN_WIDTH, SCREEN_HEIGHT;

        private void Form1_Load(object sender, EventArgs e)
        {
            bit_map = new Bitmap(picBox.Width, picBox.Height);
            picBox.Image = bit_map;

            btnMan.Visible = true;

            txtManX.Enabled = true;
            txtManY.Enabled = true;

            SCREEN_WIDTH = picBox.Width;
            SCREEN_HEIGHT = picBox.Height;

            str_map = new string[SCREEN_WIDTH, SCREEN_HEIGHT];

            for (int x = 0; x < SCREEN_WIDTH; x++)
            {
                for (int y = 0; y < SCREEN_HEIGHT; y++)
                {
                    str_map[x, y] = "0";
                }
            }
        }

        private void picBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!locked)
            {
                pos.X = e.X; pos.Y = e.Y;
                lblPos.Text = "Pos: " + "X->" + e.X + " | " + "Y->" + e.Y;
            }
        }

        private void picBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!locked)
                {
                    locked = true;
                    lblLock.Text = "Gesperrt";
                    btnEvent.Visible = true;
                    btnN.Visible = true;
                    btnO.Visible = true;
                    btnS.Visible = true;
                    btnW.Visible = true;
                  
                    
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (locked)
                {
                    locked = false;
                    lblLock.Text = "Entsperrt";
                    btnEvent.Visible = false;

                    btnN.Visible = false;
                    btnO.Visible = false;
                    btnS.Visible = false;
                    btnW.Visible = false;

                  
                }
            }
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            picBox.Enabled = false;

            cBoxNorden.Checked = false;
            cBoxOsten.Checked = false;
            cBoxSüden.Checked = false;
            cBoxWesten.Checked = false;

            txtNorden.Text = "";
            txtOsten.Text = "";
            txtSüden.Text = "";
            txtWesten.Text = "";

            combField.Text = "Unterscheidungsfeld";

            this.ClientSize = new System.Drawing.Size(481, 424);

            picBox.Refresh();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (combField.Text == "Unterscheidungsfeld")
                result += "U,";
            else if (combField.Text == "Spawnfeld")
                result += "S,";
            else if (combField.Text == "Despawnfeld")
                result += "D,";
            else
            {
                MessageBox.Show("Feld nicht bekannt");
                return;
            }

            if (cBoxNorden.Checked)
                result += "N>" + txtNorden.Text + ",";
            if (cBoxOsten.Checked)
                result += "O>" + txtOsten.Text + ",";
            if (cBoxSüden.Checked)
                result += "S>" + txtSüden.Text + ",";
            if (cBoxWesten.Checked)
                result += "W>" + txtWesten.Text + ",";

            if (result != null)
            {

                txtManX.Text = string.Empty;
                txtManY.Text = string.Empty;

                str_map[pos.X, pos.Y] = result;
                bit_map.SetPixel(pos.X, pos.Y, Color.Black);

                picBox.Enabled = true;

                lblLock.Text = "Entsperrt";
                btnEvent.Visible = false;
                locked = false;

                btnN.Visible = false;
                btnO.Visible = false;
                btnS.Visible = false;
                btnW.Visible = false;

                this.ClientSize = new System.Drawing.Size(308, 424);
            }
            else
                return;            
        }

        private void cBoxNorden_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxNorden.Checked)
                txtNorden.Enabled = true;
            else
                txtNorden.Enabled = false;

            if (cBoxNorden.Checked || cBoxOsten.Checked || cBoxSüden.Checked || cBoxWesten.Checked)
                btnCreate.Enabled = true;
            else
                btnCreate.Enabled = false;
        }
        private void cBoxOsten_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxOsten.Checked)
                txtOsten.Enabled = true;
            else
                txtOsten.Enabled = false;

            if (cBoxNorden.Checked || cBoxOsten.Checked || cBoxSüden.Checked || cBoxWesten.Checked)
                btnCreate.Enabled = true;
            else
                btnCreate.Enabled = false;
        }
        private void cBoxSüden_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxSüden.Checked)
                txtSüden.Enabled = true;
            else
                txtSüden.Enabled = false;

            if (cBoxNorden.Checked || cBoxOsten.Checked || cBoxSüden.Checked || cBoxWesten.Checked)
                btnCreate.Enabled = true;
            else
                btnCreate.Enabled = false;
        }
        private void cBoxWesten_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxWesten.Checked)
                txtWesten.Enabled = true;
            else
                txtWesten.Enabled = false;

            if (cBoxNorden.Checked || cBoxOsten.Checked || cBoxSüden.Checked || cBoxWesten.Checked)
                btnCreate.Enabled = true;
            else
                btnCreate.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pos.Y = pos.Y - 1;
            lblPos.Text = "Pos: " + "X->" + pos.X + " | " + "Y->" + pos.Y;

            if (txtManY.Text != String.Empty)
            {
                txtManY.Text = Convert.ToString(pos.Y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            pos.X = pos.X - 1;
            lblPos.Text = "Pos: " + "X->" + pos.X + " | " + "Y->" + pos.Y;

            if (txtManX.Text != String.Empty)
            {
                txtManX.Text = Convert.ToString(pos.X);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pos.X = pos.X + 1;
            lblPos.Text = "Pos: " + "X->" + pos.X + " | " + "Y->" + pos.Y;

            if (txtManX.Text != String.Empty)
            {
                txtManX.Text = Convert.ToString(pos.X);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pos.Y = pos.Y + 1;
            lblPos.Text = "Pos: " + "X->" + pos.X + " | " + "Y->" + pos.Y;

            if (txtManY.Text != String.Empty)
            {
                txtManY.Text = Convert.ToString(pos.Y);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMan_Click(object sender, EventArgs e)
        {
            // Manueller button:

            locked = true;
            lblLock.Text = "Gesperrt";
            btnEvent.Visible = true;
            btnN.Visible = true;
            btnO.Visible = true;
            btnS.Visible = true;
            btnW.Visible = true;


            pos.X = Convert.ToInt32(txtManX.Text);
            pos.Y = Convert.ToInt32(txtManY.Text);

            lblPos.Text = "Pos: " + "X->" + pos.X + " | " + "Y->" + pos.Y;

        }
    }
}

//Penis