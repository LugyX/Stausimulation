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
        }

        FieldType frm;        

        Point pos = new Point();
        public Point Pos
        {
            get { return pos; }
            set { pos = value; }
        }

        string[,] str_map;
        public string[,] Str_map
        {
            get { return str_map; }
            set { str_map = value; }
        }

        Bitmap bit_map;
        public Bitmap Bit_map
        {
            get { return bit_map; }
            set { bit_map = value; }
        }

        bool locked = false;
        int SCREEN_WIDTH, SCREEN_HEIGHT;

        private void Form1_Load(object sender, EventArgs e)
        {
            bit_map = new Bitmap(picBox.Width, picBox.Height);
            picBox.Image = bit_map;

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
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (locked)
                {
                    locked = false;
                    lblLock.Text = "Entsperrt";
                    btnEvent.Visible = false;
                }
            }
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            frm = new FieldType(this);
            frm.Show();

            lblLock.Text = "Entsperrt";
            btnEvent.Visible = false;
            locked = false;

            picBox.Refresh();
        }
    }
}