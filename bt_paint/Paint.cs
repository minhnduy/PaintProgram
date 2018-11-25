using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace bt_paint
{
    public partial class Paint : Form
    {

        #region Thuộc tính

        private Color cl; // Màu vẽ
        private int pw; // Độ đậm
        private int select;
        Point start, end, pre;
        Point mouseDown;
        private Pen pen;
        bool paintting = false;
        Point starttemp, endtemp;
        public Graphics g;
        public Graphics grp;
        #endregion

        #region khởi tạo
        private void Form1_Load(object sender, EventArgs e)
        {
            cl = Color.Black;
            pw = 1;
            pen = new Pen(cl, pw);
            select = 0;
            g = pnlPaint.CreateGraphics();
        }

        public Paint()
        {
            InitializeComponent();
        }
        #endregion

        #region bt Shape Click
        private void btLine_Click(object sender, EventArgs e)
        {
            select = 1;
        }

        private void btRec_Click(object sender, EventArgs e)
        {
            select = 2;
        }

        private void btTri_Click(object sender, EventArgs e)
        {
            select = 3;
        }

        private void btOvan_Click(object sender, EventArgs e)
        {
            select = 4;
        }

        private void btEraser_Click(object sender, EventArgs e)
        {
            Bitmap bmp;
            if (pnlPaint.BackgroundImage != null)
            {
                bmp = new Bitmap(pnlPaint.Width, pnlPaint.Height);
                pnlPaint.BackgroundImage = bmp;
            }
            pnlPaint.Refresh();
        }
        #endregion

        #region bt Color Click

        private void btBlack_Click(object sender, EventArgs e)
        {
            cl = Color.Black;
            btBackColor.BackColor = cl;
        }

        private void btYellow_Click(object sender, EventArgs e)
        {
            cl = Color.Yellow;
            btBackColor.BackColor = cl;
        }

        private void btGreen_Click(object sender, EventArgs e)
        {
            cl = Color.Green;
            btBackColor.BackColor = cl;
        }

        private void btPink_Click(object sender, EventArgs e)
        {
            cl = Color.Pink;
            btBackColor.BackColor = cl;
        }

        private void btOr_Click(object sender, EventArgs e)
        {
            cl = Color.Orange;
            btBackColor.BackColor = cl;
        }

        private void btWhite_Click(object sender, EventArgs e)
        {
            cl = Color.White;
            btBackColor.BackColor = cl;
        }

        private void btRed_Click(object sender, EventArgs e)
        {
            cl = Color.Red;
            btBackColor.BackColor = cl;
        }

        private void btBlue_Click(object sender, EventArgs e)
        {
            cl = Color.Blue;
            btBackColor.BackColor = cl;
        }

        private void btGray_Click(object sender, EventArgs e)
        {
            cl = Color.Gray;
            btBackColor.BackColor = cl;
        }

        private void btLightBlue_Click(object sender, EventArgs e)
        {
            cl = Color.LightBlue;
            btBackColor.BackColor = cl;
        }

        private void btMoreColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btBackColor.BackColor = colorDialog1.Color;
                cl = btBackColor.BackColor;                
            }
        }

        #endregion

        #region width Line

        private void i1_Click(object sender, EventArgs e)
        {
            pw = 1;
            i1.Enabled = false;
            i1.BackColor = Color.Black;
            i2.Enabled = i3.Enabled = i4.Enabled = true;
            i2.BackColor = i3.BackColor = i4.BackColor = Color.Silver;
            pnlPaint.Focus();
        }

        private void i2_Click(object sender, EventArgs e)
        {
            pw = 2;
            i2.Enabled = false;
            i2.BackColor = Color.Black;
            i1.Enabled = i3.Enabled = i4.Enabled = true;
            i1.BackColor = i3.BackColor = i4.BackColor = Color.Silver;
            pnlPaint.Focus();
        }

        private void i3_Click(object sender, EventArgs e)
        {
            pw = 3;
            i3.Enabled = false;
            i3.BackColor = Color.Black;
            i2.Enabled = i1.Enabled = i4.Enabled = true;
            i2.BackColor = i1.BackColor = i4.BackColor = Color.Silver;
            pnlPaint.Focus();
        }

        private void i4_Click(object sender, EventArgs e)
        {
            pw = 5;
            i4.Enabled = false;
            i4.BackColor = Color.Black;
            i2.Enabled = i3.Enabled = i1.Enabled = true;
            i2.BackColor = i3.BackColor = i1.BackColor = Color.Silver;
            pnlPaint.Focus();
        }

        #endregion

        #region paint
        private void pnlPaint_Paint(object sender, PaintEventArgs e)
        {
            Point A;
            Point B;
            A = new Point(0, 0);
            B = new Point(0, 0);
            if (paintting)
            {
                switch (select)
                {
                    case 1:
                        g.DrawLine(new Pen(cl,pw), start, end);
                        break;
                    case 2:
                        A.X = start.X;
                        A.Y = end.Y;
                        B.Y = start.Y;
                        B.X = end.X;
                        g.DrawLine(new Pen(cl,pw), start, A);
                        g.DrawLine(new Pen(cl,pw), start, B);
                        g.DrawLine(new Pen(cl,pw), end, A);
                        g.DrawLine(new Pen(cl,pw), end, B);
                        break;
                    case 3:
                        A.X = start.X;
                        A.Y = end.Y;
                        B.Y = start.Y;
                        B.X = end.X;
                        g.DrawLine(new Pen(cl,pw), start, A);
                        g.DrawLine(new Pen(cl,pw), start, B);
                        g.DrawLine(new Pen(cl,pw), A, B);
                        break;
                    case 4:
                        int centerx, centery, a, b;
                        centerx = start.X;
                        centery = end.Y;
                        a = (int)Math.Sqrt((end.Y - start.Y) * (end.Y - start.Y));
                        b = (int)Math.Sqrt((start.X - end.X) * (start.X - end.X));
                        g.DrawEllipse(new Pen(cl,pw), centerx, centery, b, a);
                        break;
                }
            }
        }

        private void pnlPaint_MouseDown(object sender, MouseEventArgs e)
        {
            start = e.Location;
            pre = start;
            paintting = true;
            mouseDown = e.Location;
        }

        private void pnlPaint_MouseUp(object sender, MouseEventArgs e)
        {
            end = e.Location;
            Point A;
            Point B;
            A = new Point(0, 0);
            B = new Point(0, 0);
            paintting = false;
            switch (select)
            {
                case 1:
                    g.DrawLine(new Pen(cl, pw), start, end);
                    break;
                case 2:
                    A.X = start.X;
                    A.Y = end.Y;
                    B.Y = start.Y;
                    B.X = end.X;
                    g.DrawLine(new Pen(cl, pw), start, A);
                    g.DrawLine(new Pen(cl, pw), start, B);
                    g.DrawLine(new Pen(cl, pw), end, A);
                    g.DrawLine(new Pen(cl, pw), end, B);
                    break;
                case 3:
                    A.X = start.X;
                    A.Y = end.Y;
                    B.Y = start.Y;
                    B.X = end.X;
                    g.DrawLine(new Pen(cl, pw), start, A);
                    g.DrawLine(new Pen(cl, pw), start, B);
                    g.DrawLine(new Pen(cl, pw), A, B);
                    break;
                case 4:
                    int centerx, centery, a, b;
                    centerx = start.X;
                    centery = end.Y;
                    a = (int)Math.Sqrt((end.Y - start.Y) * (end.Y - start.Y));
                    b = (int)Math.Sqrt((start.X - end.X) * (start.X - end.X));
                    g.DrawEllipse(new Pen(cl, pw), centerx, centery, b, a);
                    break;
            }
        }

        private void pnlPaint_MouseMove(object sender, MouseEventArgs e)
        {
            lbLocation.Text = e.Location.ToString();
            end = e.Location;
            if (paintting)
            {
                switch (select)
                {
                    case 1:
                        pnlPaint.Refresh();

                        break;
                    case 2:
                        pnlPaint.Refresh();
                        break;
                    case 3:
                        pnlPaint.Refresh();
                        break;
                    case 4:
                        pnlPaint.Refresh();
                        break;
                }
            }

        }
        private void btPic_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog(this)==DialogResult.OK)
            {
                Image img;
                Bitmap temp = new Bitmap(openFileDialog1.FileName);
                img = temp;
                g.DrawImage(img, mouseDown.X, mouseDown.Y, img.Width/4, img.Height/4);
            }
        }
    
        #endregion
    }
}
