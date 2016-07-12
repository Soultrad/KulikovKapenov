namespace kalkul
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.minus = new System.Windows.Forms.Button();
            this.delenie = new System.Windows.Forms.Button();
            this.ymno = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.Tg = new System.Windows.Forms.Button();
            this.Ctg = new System.Windows.Forms.Button();
            this.Sqr = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.SqrTriple = new System.Windows.Forms.Button();
            this.SqrtTriple = new System.Windows.Forms.Button();
            this.ArcSin = new System.Windows.Forms.Button();
            this.ArcCos = new System.Windows.Forms.Button();
            this.LogTen = new System.Windows.Forms.Button();
            this.Ln = new System.Windows.Forms.Button();
            this.Exp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(12, 64);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 23);
            this.plus.TabIndex = 1;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.button_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 122);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(93, 64);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 23);
            this.minus.TabIndex = 4;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.button_Click);
            // 
            // delenie
            // 
            this.delenie.Location = new System.Drawing.Point(12, 93);
            this.delenie.Name = "delenie";
            this.delenie.Size = new System.Drawing.Size(75, 23);
            this.delenie.TabIndex = 5;
            this.delenie.Text = "/";
            this.delenie.UseVisualStyleBackColor = true;
            this.delenie.Click += new System.EventHandler(this.button_Click);
            // 
            // ymno
            // 
            this.ymno.Location = new System.Drawing.Point(93, 93);
            this.ymno.Name = "ymno";
            this.ymno.Size = new System.Drawing.Size(75, 23);
            this.ymno.TabIndex = 6;
            this.ymno.Text = "*";
            this.ymno.UseVisualStyleBackColor = true;
            this.ymno.Click += new System.EventHandler(this.button_Click);
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(12, 160);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(75, 23);
            this.cos.TabIndex = 7;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.sin_Click);
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(93, 160);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(75, 23);
            this.sin.TabIndex = 8;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.sin_Click);
            // 
            // Tg
            // 
            this.Tg.Location = new System.Drawing.Point(12, 189);
            this.Tg.Name = "Tg";
            this.Tg.Size = new System.Drawing.Size(75, 23);
            this.Tg.TabIndex = 9;
            this.Tg.Text = "Tg";
            this.Tg.UseVisualStyleBackColor = true;
            this.Tg.Click += new System.EventHandler(this.sin_Click);
            // 
            // Ctg
            // 
            this.Ctg.Location = new System.Drawing.Point(93, 190);
            this.Ctg.Name = "Ctg";
            this.Ctg.Size = new System.Drawing.Size(75, 23);
            this.Ctg.TabIndex = 10;
            this.Ctg.Text = "Ctg";
            this.Ctg.UseVisualStyleBackColor = true;
            this.Ctg.Click += new System.EventHandler(this.sin_Click);
            // 
            // Sqr
            // 
            this.Sqr.Location = new System.Drawing.Point(12, 218);
            this.Sqr.Name = "Sqr";
            this.Sqr.Size = new System.Drawing.Size(75, 23);
            this.Sqr.TabIndex = 11;
            this.Sqr.Text = "Sqr";
            this.Sqr.UseVisualStyleBackColor = true;
            this.Sqr.Click += new System.EventHandler(this.sin_Click);
            // 
            // Sqrt
            // 
            this.Sqrt.Location = new System.Drawing.Point(93, 218);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(75, 23);
            this.Sqrt.TabIndex = 12;
            this.Sqrt.Text = "Sqrt";
            this.Sqrt.UseVisualStyleBackColor = true;
            this.Sqrt.Click += new System.EventHandler(this.sin_Click);
            // 
            // SqrTriple
            // 
            this.SqrTriple.Location = new System.Drawing.Point(174, 160);
            this.SqrTriple.Name = "SqrTriple";
            this.SqrTriple.Size = new System.Drawing.Size(75, 23);
            this.SqrTriple.TabIndex = 13;
            this.SqrTriple.Text = "x^3";
            this.SqrTriple.UseVisualStyleBackColor = true;
            this.SqrTriple.Click += new System.EventHandler(this.sin_Click);
            // 
            // SqrtTriple
            // 
            this.SqrtTriple.Location = new System.Drawing.Point(174, 189);
            this.SqrtTriple.Name = "SqrtTriple";
            this.SqrtTriple.Size = new System.Drawing.Size(75, 23);
            this.SqrtTriple.TabIndex = 14;
            this.SqrtTriple.Text = "Sqrt3";
            this.SqrtTriple.UseVisualStyleBackColor = true;
            this.SqrtTriple.Click += new System.EventHandler(this.sin_Click);
            // 
            // ArcSin
            // 
            this.ArcSin.Location = new System.Drawing.Point(174, 218);
            this.ArcSin.Name = "ArcSin";
            this.ArcSin.Size = new System.Drawing.Size(75, 23);
            this.ArcSin.TabIndex = 15;
            this.ArcSin.Text = "ASin";
            this.ArcSin.UseVisualStyleBackColor = true;
            this.ArcSin.Click += new System.EventHandler(this.sin_Click);
            // 
            // ArcCos
            // 
            this.ArcCos.Location = new System.Drawing.Point(255, 160);
            this.ArcCos.Name = "ArcCos";
            this.ArcCos.Size = new System.Drawing.Size(75, 23);
            this.ArcCos.TabIndex = 16;
            this.ArcCos.Text = "ACos";
            this.ArcCos.UseVisualStyleBackColor = true;
            this.ArcCos.Click += new System.EventHandler(this.sin_Click);
            // 
            // LogTen
            // 
            this.LogTen.Location = new System.Drawing.Point(255, 188);
            this.LogTen.Name = "LogTen";
            this.LogTen.Size = new System.Drawing.Size(75, 23);
            this.LogTen.TabIndex = 17;
            this.LogTen.Text = "log10";
            this.LogTen.UseVisualStyleBackColor = true;
            this.LogTen.Click += new System.EventHandler(this.sin_Click);
            // 
            // Ln
            // 
            this.Ln.Location = new System.Drawing.Point(254, 217);
            this.Ln.Name = "Ln";
            this.Ln.Size = new System.Drawing.Size(75, 23);
            this.Ln.TabIndex = 18;
            this.Ln.Text = "ln";
            this.Ln.UseVisualStyleBackColor = true;
            this.Ln.Click += new System.EventHandler(this.sin_Click);
            // 
            // Exp
            // 
            this.Exp.Location = new System.Drawing.Point(174, 131);
            this.Exp.Name = "Exp";
            this.Exp.Size = new System.Drawing.Size(75, 23);
            this.Exp.TabIndex = 22;
            this.Exp.Text = "e";
            this.Exp.UseVisualStyleBackColor = true;
            this.Exp.Click += new System.EventHandler(this.sin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 262);
            this.Controls.Add(this.Exp);
            this.Controls.Add(this.Ln);
            this.Controls.Add(this.LogTen);
            this.Controls.Add(this.ArcCos);
            this.Controls.Add(this.ArcSin);
            this.Controls.Add(this.SqrtTriple);
            this.Controls.Add(this.SqrTriple);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.Sqr);
            this.Controls.Add(this.Ctg);
            this.Controls.Add(this.Tg);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.ymno);
            this.Controls.Add(this.delenie);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button delenie;
        private System.Windows.Forms.Button ymno;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button Tg;
        private System.Windows.Forms.Button Ctg;
        private System.Windows.Forms.Button Sqr;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button SqrTriple;
        private System.Windows.Forms.Button SqrtTriple;
        private System.Windows.Forms.Button ArcSin;
        private System.Windows.Forms.Button ArcCos;
        private System.Windows.Forms.Button LogTen;
        private System.Windows.Forms.Button Ln;
        private System.Windows.Forms.Button Exp;
    }
}

