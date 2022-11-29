namespace WindowsFormsApp2
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
            this.Actionbutton = new System.Windows.Forms.Button();
            this.Txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Actionbutton
            // 
            this.Actionbutton.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Actionbutton.Location = new System.Drawing.Point(342, 187);
            this.Actionbutton.Name = "Actionbutton";
            this.Actionbutton.Size = new System.Drawing.Size(127, 52);
            this.Actionbutton.TabIndex = 1;
            this.Actionbutton.Text = "Action";
            this.Actionbutton.UseVisualStyleBackColor = true;
            this.Actionbutton.Click += new System.EventHandler(this.Actionbutton_Click);
            this.Actionbutton.MouseLeave += new System.EventHandler(this.Actionbutton_MouseLeave);
            this.Actionbutton.MouseHover += new System.EventHandler(this.Actionbutton_MouseHover);
            // 
            // Txt
            // 
            this.Txt.AutoSize = true;
            this.Txt.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Txt.Location = new System.Drawing.Point(563, 204);
            this.Txt.Name = "Txt";
            this.Txt.Size = new System.Drawing.Size(48, 25);
            this.Txt.TabIndex = 2;
            this.Txt.Text = "Txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Txt);
            this.Controls.Add(this.Actionbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Actionbutton;
        private System.Windows.Forms.Label Txt;
    }
}

