namespace kalkul
{
    partial class Form2
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
            this.SelectSort = new System.Windows.Forms.Button();
            this.InsertSort = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SelectSort
            // 
            this.SelectSort.Location = new System.Drawing.Point(12, 90);
            this.SelectSort.Name = "SelectSort";
            this.SelectSort.Size = new System.Drawing.Size(75, 23);
            this.SelectSort.TabIndex = 0;
            this.SelectSort.Text = "SelectSort";
            this.SelectSort.UseVisualStyleBackColor = true;
            this.SelectSort.Click += new System.EventHandler(this.button1_Click);
            // 
            // InsertSort
            // 
            this.InsertSort.Location = new System.Drawing.Point(107, 90);
            this.InsertSort.Name = "InsertSort";
            this.InsertSort.Size = new System.Drawing.Size(75, 23);
            this.InsertSort.TabIndex = 1;
            this.InsertSort.Text = "InsertSort";
            this.InsertSort.UseVisualStyleBackColor = true;
            this.InsertSort.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.InsertSort);
            this.Controls.Add(this.SelectSort);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectSort;
        private System.Windows.Forms.Button InsertSort;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}