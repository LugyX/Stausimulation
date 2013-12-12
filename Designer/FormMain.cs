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
            result = "";

            int gültig = 1;

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
            {
                if (pos.Y -(Convert.ToInt32(txtNorden.Text)) < 2)
                {
                    gültig = 0;
                }
                
                result += "N>" + txtNorden.Text + ",";
            }
           
            
            if (cBoxOsten.Checked)
            {
                if (pos.X + (Convert.ToInt32(txtOsten.Text)) > 290)
                {
                    gültig = 0;
                }

                result += "O>" + txtOsten.Text + ",";
            }
          
            
            if (cBoxSüden.Checked)
            {
                if (pos.Y + (Convert.ToInt32(txtSüden.Text)) > 271)
                {
                    gültig = 0;
                }

                result += "S>" + txtSüden.Text + ",";
            }
          
            
            if (cBoxWesten.Checked)
            {
                if (pos.X - (Convert.ToInt32(txtWesten.Text)) < 2)
                {
                    gültig = 0;
                }

                result += "W>" + txtWesten.Text + ",";
            }


            if (result != null && gültig == 1)
            {
                if (cBoxNorden.Checked)
                {
                    for (int n = (pos.Y - 1); n >= (pos.Y - Convert.ToInt32(txtNorden.Text)); n--)
                    {
                        bit_map.SetPixel(pos.X, n, Color.Blue);
                    }
                }
                if (cBoxOsten.Checked)
                {
                    for (int n = (pos.X + 1); n <= (pos.X + Convert.ToInt32(txtOsten.Text)); n++)
                    {
                        bit_map.SetPixel(n, pos.Y, Color.Blue);
                    }
                }
                if (cBoxSüden.Checked)
                {
                    for (int n = (pos.Y + 1); n <= (pos.Y + Convert.ToInt32(txtSüden.Text)); n++)
                    {
                        bit_map.SetPixel(pos.X, n, Color.Blue);
                    }
                }
                if (cBoxWesten.Checked)
                {
                    for (int n = (pos.X - 1); n >= (pos.X - Convert.ToInt32(txtWesten.Text)); n--)
                    {
                        bit_map.SetPixel(n, pos.Y, Color.Blue);
                    }
                }




                if (cBoxOsten.Checked)

                    if (cBoxSüden.Checked)

                        if (cBoxWesten.Checked)



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
            {
                MessageBox.Show("Falscher Wert");
                return;
            }
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
            if (pos.Y > 1)
            {
                pos.Y = pos.Y - 1;
                lblPos.Text = "Pos: " + "X->" + pos.X + " | " + "Y->" + pos.Y;

                if (txtManY.Text != String.Empty)
                {
                    txtManY.Text = Convert.ToString(pos.Y);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (pos.X > 1)
            {
                pos.X = pos.X - 1;
                lblPos.Text = "Pos: " + "X->" + pos.X + " | " + "Y->" + pos.Y;

                if (txtManX.Text != String.Empty)
                {
                    txtManX.Text = Convert.ToString(pos.X);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pos.X < 290)
            {
                pos.X = pos.X + 1;
                lblPos.Text = "Pos: " + "X->" + pos.X + " | " + "Y->" + pos.Y;

                if (txtManX.Text != String.Empty)
                {
                    txtManX.Text = Convert.ToString(pos.X);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pos.Y < 272)
            {
                pos.Y = pos.Y + 1;
                lblPos.Text = "Pos: " + "X->" + pos.X + " | " + "Y->" + pos.Y;

                if (txtManY.Text != String.Empty)
                {
                    txtManY.Text = Convert.ToString(pos.Y);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMan_Click(object sender, EventArgs e)
        {
            // Manueller button:
            int tempX,tempY;

            tempX=Convert.ToInt32(txtManX.Text);
            tempY=Convert.ToInt32(txtManY.Text);

            if (tempX > 0 && tempX <= 290 && tempY > 0 && tempY <= 272)
            {

                pos.X = tempX;
                pos.Y = tempY;

                lblPos.Text = "Pos: " + "X->" + pos.X + " | " + "Y->" + pos.Y;


                locked = true;
                lblLock.Text = "Gesperrt";
                btnEvent.Visible = true;
                btnN.Visible = true;
                btnO.Visible = true;
                btnS.Visible = true;
                btnW.Visible = true;
            }

        }
    }
}

