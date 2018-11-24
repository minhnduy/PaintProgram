namespace bt_paint
{
    partial class Paint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.lbLocation = new System.Windows.Forms.Label();
            this.pnlPaint = new System.Windows.Forms.Panel();
            this.grPic = new System.Windows.Forms.GroupBox();
            this.btPic = new System.Windows.Forms.Button();
            this.grColor = new System.Windows.Forms.GroupBox();
            this.btLightBlue = new System.Windows.Forms.Button();
            this.btOr = new System.Windows.Forms.Button();
            this.btGray = new System.Windows.Forms.Button();
            this.btPink = new System.Windows.Forms.Button();
            this.btBlue = new System.Windows.Forms.Button();
            this.btGreen = new System.Windows.Forms.Button();
            this.btRed = new System.Windows.Forms.Button();
            this.btYellow = new System.Windows.Forms.Button();
            this.btWhite = new System.Windows.Forms.Button();
            this.btBlack = new System.Windows.Forms.Button();
            this.btMoreColor = new System.Windows.Forms.Button();
            this.btBackColor = new System.Windows.Forms.Button();
            this.grShape = new System.Windows.Forms.GroupBox();
            this.i4 = new System.Windows.Forms.Button();
            this.i3 = new System.Windows.Forms.Button();
            this.i2 = new System.Windows.Forms.Button();
            this.i1 = new System.Windows.Forms.Button();
            this.btEraser = new System.Windows.Forms.Button();
            this.btOvan = new System.Windows.Forms.Button();
            this.btTri = new System.Windows.Forms.Button();
            this.btRec = new System.Windows.Forms.Button();
            this.btLine = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pnlContainer.SuspendLayout();
            this.grPic.SuspendLayout();
            this.grColor.SuspendLayout();
            this.grShape.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlContainer.Controls.Add(this.lbLocation);
            this.pnlContainer.Controls.Add(this.pnlPaint);
            this.pnlContainer.Controls.Add(this.grPic);
            this.pnlContainer.Controls.Add(this.grColor);
            this.pnlContainer.Controls.Add(this.grShape);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(800, 450);
            this.pnlContainer.TabIndex = 0;
            // 
            // lbLocation
            // 
            this.lbLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbLocation.Location = new System.Drawing.Point(9, 426);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(165, 15);
            this.lbLocation.TabIndex = 4;
            // 
            // pnlPaint
            // 
            this.pnlPaint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPaint.AutoScroll = true;
            this.pnlPaint.BackColor = System.Drawing.Color.White;
            this.pnlPaint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPaint.Location = new System.Drawing.Point(3, 89);
            this.pnlPaint.Name = "pnlPaint";
            this.pnlPaint.Size = new System.Drawing.Size(792, 331);
            this.pnlPaint.TabIndex = 3;
            this.pnlPaint.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPaint_Paint);
            this.pnlPaint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlPaint_MouseDown);
            this.pnlPaint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlPaint_MouseMove);
            this.pnlPaint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlPaint_MouseUp);
            // 
            // grPic
            // 
            this.grPic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grPic.Controls.Add(this.btPic);
            this.grPic.Location = new System.Drawing.Point(700, 3);
            this.grPic.Name = "grPic";
            this.grPic.Size = new System.Drawing.Size(95, 80);
            this.grPic.TabIndex = 2;
            this.grPic.TabStop = false;
            // 
            // btPic
            // 
            this.btPic.BackgroundImage = global::bt_paint.Properties.Resources.images;
            this.btPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btPic.Location = new System.Drawing.Point(18, 12);
            this.btPic.Name = "btPic";
            this.btPic.Size = new System.Drawing.Size(60, 60);
            this.btPic.TabIndex = 0;
            this.btPic.UseVisualStyleBackColor = true;
            this.btPic.Click += new System.EventHandler(this.btPic_Click);
            // 
            // grColor
            // 
            this.grColor.Controls.Add(this.btLightBlue);
            this.grColor.Controls.Add(this.btOr);
            this.grColor.Controls.Add(this.btGray);
            this.grColor.Controls.Add(this.btPink);
            this.grColor.Controls.Add(this.btBlue);
            this.grColor.Controls.Add(this.btGreen);
            this.grColor.Controls.Add(this.btRed);
            this.grColor.Controls.Add(this.btYellow);
            this.grColor.Controls.Add(this.btWhite);
            this.grColor.Controls.Add(this.btBlack);
            this.grColor.Controls.Add(this.btMoreColor);
            this.grColor.Controls.Add(this.btBackColor);
            this.grColor.Location = new System.Drawing.Point(411, 3);
            this.grColor.Name = "grColor";
            this.grColor.Size = new System.Drawing.Size(283, 80);
            this.grColor.TabIndex = 1;
            this.grColor.TabStop = false;
            this.grColor.Text = "Color";
            // 
            // btLightBlue
            // 
            this.btLightBlue.BackColor = System.Drawing.Color.Cyan;
            this.btLightBlue.Location = new System.Drawing.Point(191, 45);
            this.btLightBlue.Name = "btLightBlue";
            this.btLightBlue.Size = new System.Drawing.Size(25, 25);
            this.btLightBlue.TabIndex = 0;
            this.btLightBlue.UseVisualStyleBackColor = false;
            this.btLightBlue.Click += new System.EventHandler(this.btLightBlue_Click);
            // 
            // btOr
            // 
            this.btOr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btOr.Location = new System.Drawing.Point(191, 14);
            this.btOr.Name = "btOr";
            this.btOr.Size = new System.Drawing.Size(25, 25);
            this.btOr.TabIndex = 0;
            this.btOr.UseVisualStyleBackColor = false;
            this.btOr.Click += new System.EventHandler(this.btOr_Click);
            // 
            // btGray
            // 
            this.btGray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btGray.Location = new System.Drawing.Point(160, 45);
            this.btGray.Name = "btGray";
            this.btGray.Size = new System.Drawing.Size(25, 25);
            this.btGray.TabIndex = 0;
            this.btGray.UseVisualStyleBackColor = false;
            this.btGray.Click += new System.EventHandler(this.btGray_Click);
            // 
            // btPink
            // 
            this.btPink.BackColor = System.Drawing.Color.Fuchsia;
            this.btPink.Location = new System.Drawing.Point(160, 14);
            this.btPink.Name = "btPink";
            this.btPink.Size = new System.Drawing.Size(25, 25);
            this.btPink.TabIndex = 0;
            this.btPink.UseVisualStyleBackColor = false;
            this.btPink.Click += new System.EventHandler(this.btPink_Click);
            // 
            // btBlue
            // 
            this.btBlue.BackColor = System.Drawing.Color.Blue;
            this.btBlue.Location = new System.Drawing.Point(129, 45);
            this.btBlue.Name = "btBlue";
            this.btBlue.Size = new System.Drawing.Size(25, 25);
            this.btBlue.TabIndex = 0;
            this.btBlue.UseVisualStyleBackColor = false;
            this.btBlue.Click += new System.EventHandler(this.btBlue_Click);
            // 
            // btGreen
            // 
            this.btGreen.BackColor = System.Drawing.Color.Lime;
            this.btGreen.Location = new System.Drawing.Point(129, 14);
            this.btGreen.Name = "btGreen";
            this.btGreen.Size = new System.Drawing.Size(25, 25);
            this.btGreen.TabIndex = 0;
            this.btGreen.UseVisualStyleBackColor = false;
            this.btGreen.Click += new System.EventHandler(this.btGreen_Click);
            // 
            // btRed
            // 
            this.btRed.BackColor = System.Drawing.Color.Red;
            this.btRed.Location = new System.Drawing.Point(98, 45);
            this.btRed.Name = "btRed";
            this.btRed.Size = new System.Drawing.Size(25, 25);
            this.btRed.TabIndex = 0;
            this.btRed.UseVisualStyleBackColor = false;
            this.btRed.Click += new System.EventHandler(this.btRed_Click);
            // 
            // btYellow
            // 
            this.btYellow.BackColor = System.Drawing.Color.Yellow;
            this.btYellow.Location = new System.Drawing.Point(98, 14);
            this.btYellow.Name = "btYellow";
            this.btYellow.Size = new System.Drawing.Size(25, 25);
            this.btYellow.TabIndex = 0;
            this.btYellow.UseVisualStyleBackColor = false;
            this.btYellow.Click += new System.EventHandler(this.btYellow_Click);
            // 
            // btWhite
            // 
            this.btWhite.Location = new System.Drawing.Point(67, 45);
            this.btWhite.Name = "btWhite";
            this.btWhite.Size = new System.Drawing.Size(25, 25);
            this.btWhite.TabIndex = 0;
            this.btWhite.UseVisualStyleBackColor = true;
            this.btWhite.Click += new System.EventHandler(this.btWhite_Click);
            // 
            // btBlack
            // 
            this.btBlack.BackColor = System.Drawing.Color.Black;
            this.btBlack.Location = new System.Drawing.Point(67, 14);
            this.btBlack.Name = "btBlack";
            this.btBlack.Size = new System.Drawing.Size(25, 25);
            this.btBlack.TabIndex = 0;
            this.btBlack.Text = "button1";
            this.btBlack.UseVisualStyleBackColor = false;
            this.btBlack.Click += new System.EventHandler(this.btBlack_Click);
            // 
            // btMoreColor
            // 
            this.btMoreColor.BackgroundImage = global::bt_paint.Properties.Resources.MoreColor;
            this.btMoreColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMoreColor.Location = new System.Drawing.Point(228, 22);
            this.btMoreColor.Name = "btMoreColor";
            this.btMoreColor.Size = new System.Drawing.Size(40, 40);
            this.btMoreColor.TabIndex = 0;
            this.btMoreColor.UseVisualStyleBackColor = true;
            this.btMoreColor.Click += new System.EventHandler(this.btMoreColor_Click);
            // 
            // btBackColor
            // 
            this.btBackColor.BackColor = System.Drawing.Color.Black;
            this.btBackColor.Location = new System.Drawing.Point(14, 22);
            this.btBackColor.Name = "btBackColor";
            this.btBackColor.Size = new System.Drawing.Size(40, 40);
            this.btBackColor.TabIndex = 0;
            this.btBackColor.UseVisualStyleBackColor = false;
            // 
            // grShape
            // 
            this.grShape.Controls.Add(this.i4);
            this.grShape.Controls.Add(this.i3);
            this.grShape.Controls.Add(this.i2);
            this.grShape.Controls.Add(this.i1);
            this.grShape.Controls.Add(this.btEraser);
            this.grShape.Controls.Add(this.btOvan);
            this.grShape.Controls.Add(this.btTri);
            this.grShape.Controls.Add(this.btRec);
            this.grShape.Controls.Add(this.btLine);
            this.grShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grShape.Location = new System.Drawing.Point(3, 3);
            this.grShape.Name = "grShape";
            this.grShape.Size = new System.Drawing.Size(402, 80);
            this.grShape.TabIndex = 0;
            this.grShape.TabStop = false;
            this.grShape.Text = "Shape";
            // 
            // i4
            // 
            this.i4.Location = new System.Drawing.Point(289, 58);
            this.i4.Name = "i4";
            this.i4.Size = new System.Drawing.Size(100, 14);
            this.i4.TabIndex = 0;
            this.i4.UseVisualStyleBackColor = true;
            this.i4.Click += new System.EventHandler(this.i4_Click);
            // 
            // i3
            // 
            this.i3.Location = new System.Drawing.Point(289, 42);
            this.i3.Name = "i3";
            this.i3.Size = new System.Drawing.Size(100, 12);
            this.i3.TabIndex = 0;
            this.i3.UseVisualStyleBackColor = true;
            this.i3.Click += new System.EventHandler(this.i3_Click);
            // 
            // i2
            // 
            this.i2.Location = new System.Drawing.Point(289, 29);
            this.i2.Name = "i2";
            this.i2.Size = new System.Drawing.Size(100, 10);
            this.i2.TabIndex = 0;
            this.i2.UseVisualStyleBackColor = true;
            this.i2.Click += new System.EventHandler(this.i2_Click);
            // 
            // i1
            // 
            this.i1.BackColor = System.Drawing.Color.Black;
            this.i1.Location = new System.Drawing.Point(289, 19);
            this.i1.Name = "i1";
            this.i1.Size = new System.Drawing.Size(100, 5);
            this.i1.TabIndex = 0;
            this.i1.UseVisualStyleBackColor = false;
            this.i1.Click += new System.EventHandler(this.i1_Click);
            // 
            // btEraser
            // 
            this.btEraser.BackgroundImage = global::bt_paint.Properties.Resources.eraser;
            this.btEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEraser.Location = new System.Drawing.Point(233, 19);
            this.btEraser.Name = "btEraser";
            this.btEraser.Size = new System.Drawing.Size(50, 50);
            this.btEraser.TabIndex = 0;
            this.btEraser.UseVisualStyleBackColor = true;
            this.btEraser.Click += new System.EventHandler(this.btEraser_Click);
            // 
            // btOvan
            // 
            this.btOvan.BackgroundImage = global::bt_paint.Properties.Resources.ovan;
            this.btOvan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btOvan.Location = new System.Drawing.Point(177, 19);
            this.btOvan.Name = "btOvan";
            this.btOvan.Size = new System.Drawing.Size(50, 50);
            this.btOvan.TabIndex = 0;
            this.btOvan.UseVisualStyleBackColor = true;
            this.btOvan.Click += new System.EventHandler(this.btOvan_Click);
            // 
            // btTri
            // 
            this.btTri.BackgroundImage = global::bt_paint.Properties.Resources.triang;
            this.btTri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btTri.Location = new System.Drawing.Point(121, 19);
            this.btTri.Name = "btTri";
            this.btTri.Size = new System.Drawing.Size(50, 50);
            this.btTri.TabIndex = 0;
            this.btTri.UseVisualStyleBackColor = true;
            this.btTri.Click += new System.EventHandler(this.btTri_Click);
            // 
            // btRec
            // 
            this.btRec.BackgroundImage = global::bt_paint.Properties.Resources.rec;
            this.btRec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRec.Location = new System.Drawing.Point(65, 19);
            this.btRec.Name = "btRec";
            this.btRec.Size = new System.Drawing.Size(50, 50);
            this.btRec.TabIndex = 0;
            this.btRec.UseVisualStyleBackColor = true;
            this.btRec.Click += new System.EventHandler(this.btRec_Click);
            // 
            // btLine
            // 
            this.btLine.BackgroundImage = global::bt_paint.Properties.Resources.line;
            this.btLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btLine.Location = new System.Drawing.Point(9, 19);
            this.btLine.Name = "btLine";
            this.btLine.Size = new System.Drawing.Size(50, 50);
            this.btLine.TabIndex = 0;
            this.btLine.UseVisualStyleBackColor = true;
            this.btLine.Click += new System.EventHandler(this.btLine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContainer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlContainer.ResumeLayout(false);
            this.grPic.ResumeLayout(false);
            this.grColor.ResumeLayout(false);
            this.grShape.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.GroupBox grColor;
        private System.Windows.Forms.GroupBox grShape;
        private System.Windows.Forms.GroupBox grPic;
        private System.Windows.Forms.Button btPic;
        private System.Windows.Forms.Button btLightBlue;
        private System.Windows.Forms.Button btOr;
        private System.Windows.Forms.Button btGray;
        private System.Windows.Forms.Button btPink;
        private System.Windows.Forms.Button btBlue;
        private System.Windows.Forms.Button btGreen;
        private System.Windows.Forms.Button btRed;
        private System.Windows.Forms.Button btYellow;
        private System.Windows.Forms.Button btWhite;
        private System.Windows.Forms.Button btBlack;
        private System.Windows.Forms.Button btBackColor;
        private System.Windows.Forms.Button i4;
        private System.Windows.Forms.Button i3;
        private System.Windows.Forms.Button i2;
        private System.Windows.Forms.Button i1;
        private System.Windows.Forms.Button btEraser;
        private System.Windows.Forms.Button btOvan;
        private System.Windows.Forms.Button btTri;
        private System.Windows.Forms.Button btRec;
        private System.Windows.Forms.Button btLine;
        private System.Windows.Forms.Button btMoreColor;
        private System.Windows.Forms.Panel pnlPaint;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

