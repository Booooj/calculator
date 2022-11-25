namespace calculator
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.boxsecond = new System.Windows.Forms.Button();
            this.boxthird = new System.Windows.Forms.Button();
            this.boxfourth = new System.Windows.Forms.Button();
            this.boxfifth = new System.Windows.Forms.Button();
            this.boxsixth = new System.Windows.Forms.Button();
            this.boxseventh = new System.Windows.Forms.Button();
            this.boxeighth = new System.Windows.Forms.Button();
            this.boxnineth = new System.Windows.Forms.Button();
            this.boxfirst = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.boxzero = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // boxsecond
            // 
            this.boxsecond.Location = new System.Drawing.Point(296, 212);
            this.boxsecond.Name = "boxsecond";
            this.boxsecond.Size = new System.Drawing.Size(64, 61);
            this.boxsecond.TabIndex = 2;
            this.boxsecond.Text = "2";
            this.boxsecond.UseVisualStyleBackColor = true;
            this.boxsecond.Click += new System.EventHandler(this.button2_Click);
            // 
            // boxthird
            // 
            this.boxthird.Location = new System.Drawing.Point(366, 212);
            this.boxthird.Name = "boxthird";
            this.boxthird.Size = new System.Drawing.Size(64, 61);
            this.boxthird.TabIndex = 3;
            this.boxthird.Text = "3";
            this.boxthird.UseVisualStyleBackColor = true;
            this.boxthird.Click += new System.EventHandler(this.button3_Click);
            // 
            // boxfourth
            // 
            this.boxfourth.Location = new System.Drawing.Point(226, 279);
            this.boxfourth.Name = "boxfourth";
            this.boxfourth.Size = new System.Drawing.Size(64, 61);
            this.boxfourth.TabIndex = 4;
            this.boxfourth.Text = "4";
            this.boxfourth.UseVisualStyleBackColor = true;
            this.boxfourth.Click += new System.EventHandler(this.button4_Click);
            // 
            // boxfifth
            // 
            this.boxfifth.Location = new System.Drawing.Point(296, 279);
            this.boxfifth.Name = "boxfifth";
            this.boxfifth.Size = new System.Drawing.Size(64, 61);
            this.boxfifth.TabIndex = 5;
            this.boxfifth.Text = "5";
            this.boxfifth.UseVisualStyleBackColor = true;
            this.boxfifth.Click += new System.EventHandler(this.button5_Click);
            // 
            // boxsixth
            // 
            this.boxsixth.Location = new System.Drawing.Point(366, 279);
            this.boxsixth.Name = "boxsixth";
            this.boxsixth.Size = new System.Drawing.Size(64, 61);
            this.boxsixth.TabIndex = 6;
            this.boxsixth.Text = "6";
            this.boxsixth.UseVisualStyleBackColor = true;
            this.boxsixth.Click += new System.EventHandler(this.button6_Click);
            // 
            // boxseventh
            // 
            this.boxseventh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.boxseventh.Location = new System.Drawing.Point(226, 346);
            this.boxseventh.Name = "boxseventh";
            this.boxseventh.Size = new System.Drawing.Size(64, 61);
            this.boxseventh.TabIndex = 7;
            this.boxseventh.Text = "7";
            this.boxseventh.UseVisualStyleBackColor = true;
            this.boxseventh.Click += new System.EventHandler(this.button7_Click);
            // 
            // boxeighth
            // 
            this.boxeighth.Location = new System.Drawing.Point(296, 346);
            this.boxeighth.Name = "boxeighth";
            this.boxeighth.Size = new System.Drawing.Size(64, 61);
            this.boxeighth.TabIndex = 8;
            this.boxeighth.Text = "8";
            this.boxeighth.UseVisualStyleBackColor = true;
            this.boxeighth.Click += new System.EventHandler(this.button8_Click);
            // 
            // boxnineth
            // 
            this.boxnineth.Location = new System.Drawing.Point(366, 346);
            this.boxnineth.Name = "boxnineth";
            this.boxnineth.Size = new System.Drawing.Size(64, 61);
            this.boxnineth.TabIndex = 9;
            this.boxnineth.Text = "9";
            this.boxnineth.UseVisualStyleBackColor = true;
            this.boxnineth.Click += new System.EventHandler(this.button9_Click);
            // 
            // boxfirst
            // 
            this.boxfirst.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.boxfirst.Location = new System.Drawing.Point(226, 101);
            this.boxfirst.Name = "boxfirst";
            this.boxfirst.Size = new System.Drawing.Size(228, 41);
            this.boxfirst.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(226, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 29);
            this.textBox1.TabIndex = 11;
            // 
            // boxzero
            // 
            this.boxzero.Location = new System.Drawing.Point(226, 148);
            this.boxzero.Name = "boxzero";
            this.boxzero.Size = new System.Drawing.Size(64, 61);
            this.boxzero.TabIndex = 12;
            this.boxzero.Text = "0";
            this.boxzero.UseVisualStyleBackColor = true;
            this.boxzero.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(451, 346);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(64, 61);
            this.button10.TabIndex = 13;
            this.button10.Text = "=";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(451, 279);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(64, 61);
            this.button11.TabIndex = 14;
            this.button11.Text = "-";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(451, 212);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(64, 61);
            this.button12.TabIndex = 15;
            this.button12.Text = "+";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.boxzero);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.boxfirst);
            this.Controls.Add(this.boxnineth);
            this.Controls.Add(this.boxeighth);
            this.Controls.Add(this.boxseventh);
            this.Controls.Add(this.boxsixth);
            this.Controls.Add(this.boxfifth);
            this.Controls.Add(this.boxfourth);
            this.Controls.Add(this.boxthird);
            this.Controls.Add(this.boxsecond);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button boxsecond;
        private System.Windows.Forms.Button boxthird;
        private System.Windows.Forms.Button boxfourth;
        private System.Windows.Forms.Button boxfifth;
        private System.Windows.Forms.Button boxsixth;
        private System.Windows.Forms.Button boxseventh;
        private System.Windows.Forms.Button boxeighth;
        private System.Windows.Forms.Button boxnineth;
        private System.Windows.Forms.TextBox boxfirst;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button boxzero;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
    }
}

