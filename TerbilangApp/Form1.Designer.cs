namespace TerbilangApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Hasil = new System.Windows.Forms.ListBox();
            this.textnominal = new System.Windows.Forms.TextBox();
            this.ButtonCek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nominal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Terbilang";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Hasil
            // 
            this.Hasil.FormattingEnabled = true;
            this.Hasil.Location = new System.Drawing.Point(83, 59);
            this.Hasil.Name = "Hasil";
            this.Hasil.Size = new System.Drawing.Size(507, 69);
            this.Hasil.TabIndex = 2;
            // 
            // textnominal
            // 
            this.textnominal.Location = new System.Drawing.Point(83, 18);
            this.textnominal.Name = "textnominal";
            this.textnominal.Size = new System.Drawing.Size(148, 20);
            this.textnominal.TabIndex = 3;
            this.textnominal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ButtonCek
            // 
            this.ButtonCek.Location = new System.Drawing.Point(257, 16);
            this.ButtonCek.Name = "ButtonCek";
            this.ButtonCek.Size = new System.Drawing.Size(141, 23);
            this.ButtonCek.TabIndex = 4;
            this.ButtonCek.Text = "Cek Terbilang";
            this.ButtonCek.UseVisualStyleBackColor = true;
            this.ButtonCek.Click += new System.EventHandler(this.ButtonCek_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 156);
            this.Controls.Add(this.ButtonCek);
            this.Controls.Add(this.textnominal);
            this.Controls.Add(this.Hasil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Hasil;
        private System.Windows.Forms.TextBox textnominal;
        private System.Windows.Forms.Button ButtonCek;
    }
}

