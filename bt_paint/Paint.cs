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
        int flag = 0;
        Point starttemp, endtemp;
        private Graphics g;
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

        public void LineDraw(Bitmap bmp, Point s, Point e, Color color)
        {
            int flag = 0;
            if (Math.Abs(e.Y - s.Y) > Math.Abs(e.X - s.X))
            {
                flag = 1;
                int temp = s.X;
                s.X = s.Y;
                s.Y = temp;
                temp = e.X;
                e.X = e.Y;
                e.Y = temp;
            }
            if (s.X > e.X)
            {
                Point temp = s;
                s = e;
                e = temp;
            }
            int dX = e.X - s.X;
            int dY = Math.Abs(e.Y - s.Y);
            int selectY = 1;
            if ((e.Y - s.Y) < 0) selectY = -1;
            int p = 2 * dY - dX;
            int x, y;
            y = s.Y;
            for (x = s.X; x <= e.X; x++)
            {
                if (p < 0) p += 2 * dY;
                else
                {
                    p += 2 * (dY - dX);
                    y = y + selectY;
                }
                if (flag == 1)
                { if (0 < y && y < pnlPaint.Width && 0 < x && x < pnlPaint.Height) bmp.SetPixel(y, x, color); }
                else if (flag == 0)
                { if (0 < x && x < pnlPaint.Width && 0 < y && y < pnlPaint.Height) bmp.SetPixel(x, y, color); }
                
            }

        }

        public void VeTamGiacVuong(Bitmap bmp, Point s, Point e, Color color)
        {
            Point A, B;
            A = new Point();
            B = new Point();
            A.X = s.X;
            A.Y = e.Y;
            B.Y = s.Y;
            B.X = e.X;
            LineDraw(bmp, s, A, color);
            LineDraw(bmp, s, B, color);
            LineDraw(bmp, A, B, color);
        }
        public void VeHinhChuNhat(Bitmap bmp, Point s, Point e, Color color)
        {
            Point A, B;
            A = new Point();
            B = new Point();
            A.X = s.X;
            A.Y = e.Y;
            B.Y = s.Y;
            B.X = e.X;
            LineDraw(bmp, s, A, color);
            LineDraw(bmp, s, B, color);
            LineDraw(bmp, e, B, color);
            LineDraw(bmp, e, A, color);
        }

        public void put4pixel(Bitmap bmp, int centerx, int centery, int b2, int a2, Color color)
        {
            if (0 < centerx + a2 && centerx + a2 < pnlPaint.Width && 0 < centery + b2 && centery + b2 < pnlPaint.Height) bmp.SetPixel(centerx + a2, centery + b2, color);
            if (0 < centerx - a2 && centerx - a2 < pnlPaint.Width && 0 < centery + b2 && centery + b2 < pnlPaint.Height) bmp.SetPixel(centerx - a2, centery + b2, color);
            if (0 < centerx + a2 && centerx + a2 < pnlPaint.Width && 0 < centery - b2 && centery - b2 < pnlPaint.Height) bmp.SetPixel(centerx + a2, centery - b2, color);
            if (0 < centerx - a2 && centerx - a2 < pnlPaint.Width && 0 < centery - b2 && centery - b2 < pnlPaint.Height) bmp.SetPixel(centerx - a2, centery - b2, color);
        }
        public void VeElip(Bitmap bmp, Point s, Point e, Color color)
        {
            int centerx, centery, a, b;
            centerx = (s.X);
            centery = (e.Y);
            a = (int)Math.Sqrt((e.Y - s.Y) * (e.Y - s.Y));
            b = (int)Math.Sqrt((s.X - e.X) * (s.X - e.X));
            b = b / 2;
            a = a / 2;
            int a2, b2;
            float r, p;
            a2 = 0; b2 = b;
            r = (float)b / a;
            r = r * r; p = 2 * r - 2 * b + 1;
            while (r * a2 <= b2)
            {
                put4pixel(bmp, centerx, centery, a2, b2, color);
                if (p < 0) p += 2 * r * (2 * a2 + 3);
                else
                {
                    p += 4 * (1 - b2) + 2 * r * (2 * a2 + 3);
                    b2--;
                }
                a2++;
            }
            b2 = 0; a2 = a;
            r = (float)a / b;
            r = r * r; p = 2 * r - 2 * a + 1;
            while (r * b2 <= a2)
            {
                put4pixel(bmp, centerx, centery, a2, b2, color);
                if (p < 0) p += 2 * r * (2 * b2 + 3);
                else
                {
                    p += 4 * (1 - a2) + 2 * r * (2 * b2 + 3);
                    a2--;
                }
                b2++;
            }
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
        }

        private void i2_Click(object sender, EventArgs e)
        {
            pw = 2;
        }

        private void i3_Click(object sender, EventArgs e)
        {
            pw = 3;
        }

        private void i4_Click(object sender, EventArgs e)
        {
            pw = 5;
        }

        #endregion

        #region paint
        private void pnlPaint_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bmp;
            Point A;
            Point B;
            A = new Point(0, 0);
            B = new Point(0, 0);
            if (pnlPaint.BackgroundImage == null) bmp = new Bitmap(pnlPaint.Width, pnlPaint.Height);
            else
                bmp = (Bitmap)pnlPaint.BackgroundImage.Clone();
            if (paintting)
            {
                switch (select)
                {
                    case 1:
                        e.Graphics.DrawLine(new Pen(cl,pw), start, end);
                        break;
                    case 2:
                        A.X = start.X;
                        A.Y = end.Y;
                        B.Y = start.Y;
                        B.X = end.X;
                        e.Graphics.DrawLine(new Pen(cl,pw), start, A);
                        e.Graphics.DrawLine(new Pen(cl,pw), start, B);
                        e.Graphics.DrawLine(new Pen(cl,pw), end, A);
                        e.Graphics.DrawLine(new Pen(cl,pw), end, B);
                        break;
                    case 3:
                        A.X = start.X;
                        A.Y = end.Y;
                        B.Y = start.Y;
                        B.X = end.X;
                        e.Graphics.DrawLine(new Pen(cl,pw), start, A);
                        e.Graphics.DrawLine(new Pen(cl,pw), start, B);
                        e.Graphics.DrawLine(new Pen(cl,pw), A, B);
                        break;
                    case 4:
                        int centerx, centery, a, b;
                        centerx = start.X;
                        centery = end.Y;
                        a = (int)Math.Sqrt((end.Y - start.Y) * (end.Y - start.Y));
                        b = (int)Math.Sqrt((start.X - end.X) * (start.X - end.X));
                        e.Graphics.DrawEllipse(new Pen(cl,pw), centerx, centery, b, a);
                        break;
                }
            }
        }

        private void pnlPaint_MouseDown(object sender, MouseEventArgs e)
        {
            pnlPaint.Refresh();
            start = e.Location;
            pre = start;
            paintting = true;
            mouseDown = e.Location;
        }

        private void pnlPaint_MouseUp(object sender, MouseEventArgs e)
        {
            end = e.Location;
            Bitmap bmp;
            if (pnlPaint.BackgroundImage == null) bmp = new Bitmap(pnlPaint.Width, pnlPaint.Height);
            else
                bmp = (Bitmap)pnlPaint.BackgroundImage.Clone();
            pnlPaint.BackgroundImage = bmp;
            starttemp = endtemp = new Point(0, 0);
            paintting = false;
            switch (select)
            {
                case 1:
                    LineDraw(bmp, start, end, cl);
                    break;
                case 2:
                    VeHinhChuNhat(bmp, start, end, cl);                    
                    break;
                case 3:
                    VeTamGiacVuong(bmp, start, end, cl);
                    break;
                case 4:
                    VeElip(bmp, start, end, cl);
                    break;           
                default:
                    break;

            }
        }

        private void pnlPaint_MouseMove(object sender, MouseEventArgs e)
        {
            lbLocation.Text = e.Location.ToString();
            end = e.Location;
            Bitmap bmp;
            if (pnlPaint.BackgroundImage == null) bmp = new Bitmap(pnlPaint.Width, pnlPaint.Height);
            else
                bmp = (Bitmap)pnlPaint.BackgroundImage.Clone();
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
                g.DrawImage(img, mouseDown);
                
            }
        }
        #endregion
    }
}
