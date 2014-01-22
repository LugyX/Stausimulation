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

            this.ClientSize = new System.Drawing.Size((picBox.Width + 265), (picBox.Height + 152));

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
                if (pos.Y -(Convert.ToInt32(txtNorden.Text)) < 1)
                {
                    gültig = 0;
                }
                
                result += "N>" + txtNorden.Text + ",";
            }
           
            
            if (cBoxOsten.Checked)
            {
                if (pos.X + (Convert.ToInt32(txtOsten.Text)) > SCREEN_WIDTH)
                {
                    gültig = 0;
                }

                result += "O>" + txtOsten.Text + ",";
            }
          
            
            if (cBoxSüden.Checked)
            {
                if (pos.Y + (Convert.ToInt32(txtSüden.Text)) > SCREEN_HEIGHT)
                {
                    gültig = 0;
                }

                result += "S>" + txtSüden.Text + ",";
            }
          
            
            if (cBoxWesten.Checked)
            {
                if ((pos.X - (Convert.ToInt32(txtNorden.Text)) < 1))
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

                this.ClientSize = new System.Drawing.Size((picBox.Width + 18), (picBox.Height + 152));
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

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (pos.Y < SCREEN_WIDTH)
            {
                pos.Y = pos.Y + 1;
                lblPos.Text = "Pos: " + "X->" + pos.X + " | " + "Y->" + pos.Y;

                if (txtManY.Text != String.Empty)
                {
                    txtManY.Text = Convert.ToString(pos.Y);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pos.X < SCREEN_HEIGHT)
            {
                pos.X = pos.X + 1;
                lblPos.Text = "Pos: " + "X->" + pos.X + " | " + "Y->" + pos.Y;

                if (txtManX.Text != String.Empty)
                {
                    txtManX.Text = Convert.ToString(pos.X);
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

            if (tempX > 0 && tempX <= SCREEN_WIDTH && tempY > 0 && tempY <= SCREEN_HEIGHT)
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

        private void bestätigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Größe Übernehmen (picBox)
            if (toolStripTextBox1 != null && toolStripTextBox2 != null)
            {
                picBox.Width = Convert.ToInt16(toolStripTextBox1.Text);
                picBox.Height = Convert.ToInt16(toolStripTextBox2.Text);

                SCREEN_WIDTH = picBox.Width;
                SCREEN_HEIGHT = picBox.Height;

                this.picBox.Size = new System.Drawing.Size(picBox.Width, picBox.Height);
                this.ClientSize = new System.Drawing.Size((picBox.Width + 18), (picBox.Height + 152));

                label1.Location = new Point(label1.Location.X, (picBox.Height + 49));
                label2.Location = new Point(label2.Location.X, (picBox.Height + 78));
                txtManX.Location = new Point(txtManX.Location.X, (picBox.Height + 45));
                txtManY.Location = new Point(txtManX.Location.X, (picBox.Height + 73));
                btnN.Location = new Point(btnN.Location.X, (picBox.Height + 33));
                btnO.Location = new Point(btnO.Location.X, (picBox.Height + 62));
                btnS.Location = new Point(btnS.Location.X, (picBox.Height + 91));
                btnW.Location = new Point(btnW.Location.X, (picBox.Height + 62));
                btnMan.Location = new Point(btnMan.Location.X, (picBox.Height + 101));
                btnEvent.Location = new Point(btnEvent.Location.X, (picBox.Height + 30));
                cBoxNorden.Location = new Point( (picBox.Width + 18),cBoxNorden.Location.Y);
                cBoxOsten.Location = new Point((picBox.Width + 18), cBoxOsten.Location.Y);
                cBoxSüden.Location = new Point((picBox.Width + 18), cBoxSüden.Location.Y);
                cBoxWesten.Location = new Point((picBox.Width + 18), cBoxWesten.Location.Y);
                txtNorden.Location = new Point((picBox.Width + 97), txtNorden.Location.Y);
                txtOsten.Location = new Point((picBox.Width + 97), txtOsten.Location.Y);
                txtSüden.Location = new Point((picBox.Width + 97), txtSüden.Location.Y);
                txtWesten.Location = new Point((picBox.Width + 97), txtWesten.Location.Y);
                combField.Location = new Point((picBox.Width + 97), combField.Location.Y);
                btnCreate.Location = new Point((picBox.Width + 18), btnCreate.Location.Y);

                str_map = new string[SCREEN_WIDTH, SCREEN_HEIGHT];
                bit_map = new Bitmap(picBox.Width, picBox.Height);
                picBox.Image = bit_map;

                for (int x = 0; x < SCREEN_WIDTH; x++)
                {
                    for (int y = 0; y < SCREEN_HEIGHT; y++)
                    {
                        str_map[x, y] = "0";
                    }
                }
            }
            else
            {
                MessageBox.Show("Kein Wert eingetragen");
            }

            
        }
    }
}

