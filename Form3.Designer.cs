namespace estacoes
{
    partial class frmVerao
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
            this.lblVerao = new System.Windows.Forms.Label();
            this.radVerao01 = new System.Windows.Forms.RadioButton();
            this.radVerao02 = new System.Windows.Forms.RadioButton();
            this.radVerao03 = new System.Windows.Forms.RadioButton();
            this.radVerao04 = new System.Windows.Forms.RadioButton();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pctVerao = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctVerao)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVerao
            // 
            this.lblVerao.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblVerao.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblVerao.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerao.ForeColor = System.Drawing.Color.Orange;
            this.lblVerao.Location = new System.Drawing.Point(0, 0);
            this.lblVerao.Name = "lblVerao";
            this.lblVerao.Size = new System.Drawing.Size(766, 55);
            this.lblVerao.TabIndex = 1;
            this.lblVerao.Text = "Verão";
            this.lblVerao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radVerao01
            // 
            this.radVerao01.AutoSize = true;
            this.radVerao01.Location = new System.Drawing.Point(193, 153);
            this.radVerao01.Name = "radVerao01";
            this.radVerao01.Size = new System.Drawing.Size(68, 17);
            this.radVerao01.TabIndex = 2;
            this.radVerao01.TabStop = true;
            this.radVerao01.Text = "Verão 01";
            this.radVerao01.UseVisualStyleBackColor = true;
            this.radVerao01.CheckedChanged += new System.EventHandler(this.radVerao01_CheckedChanged);
            // 
            // radVerao02
            // 
            this.radVerao02.AutoSize = true;
            this.radVerao02.Location = new System.Drawing.Point(193, 209);
            this.radVerao02.Name = "radVerao02";
            this.radVerao02.Size = new System.Drawing.Size(68, 17);
            this.radVerao02.TabIndex = 3;
            this.radVerao02.TabStop = true;
            this.radVerao02.Text = "Verão 02";
            this.radVerao02.UseVisualStyleBackColor = true;
            this.radVerao02.CheckedChanged += new System.EventHandler(this.radVerao02_CheckedChanged);
            // 
            // radVerao03
            // 
            this.radVerao03.AutoSize = true;
            this.radVerao03.Location = new System.Drawing.Point(193, 270);
            this.radVerao03.Name = "radVerao03";
            this.radVerao03.Size = new System.Drawing.Size(68, 17);
            this.radVerao03.TabIndex = 4;
            this.radVerao03.TabStop = true;
            this.radVerao03.Text = "Verão 03";
            this.radVerao03.UseVisualStyleBackColor = true;
            this.radVerao03.CheckedChanged += new System.EventHandler(this.radVerao03_CheckedChanged);
            // 
            // radVerao04
            // 
            this.radVerao04.AutoSize = true;
            this.radVerao04.Location = new System.Drawing.Point(193, 336);
            this.radVerao04.Name = "radVerao04";
            this.radVerao04.Size = new System.Drawing.Size(68, 17);
            this.radVerao04.TabIndex = 5;
            this.radVerao04.TabStop = true;
            this.radVerao04.Text = "Verão 04";
            this.radVerao04.UseVisualStyleBackColor = true;
            this.radVerao04.CheckedChanged += new System.EventHandler(this.radVerao04_CheckedChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.LightGreen;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(735, 0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(31, 23);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "<<";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pctVerao
            // 
            this.pctVerao.Location = new System.Drawing.Point(361, 100);
            this.pctVerao.Name = "pctVerao";
            this.pctVerao.Size = new System.Drawing.Size(258, 290);
            this.pctVerao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctVerao.TabIndex = 8;
            this.pctVerao.TabStop = false;
            // 
            // frmVerao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(766, 450);
            this.Controls.Add(this.pctVerao);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.radVerao04);
            this.Controls.Add(this.radVerao03);
            this.Controls.Add(this.radVerao02);
            this.Controls.Add(this.radVerao01);
            this.Controls.Add(this.lblVerao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVerao";
            this.Text = "Verao";
            ((System.ComponentModel.ISupportInitialize)(this.pctVerao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVerao;
        private System.Windows.Forms.RadioButton radVerao01;
        private System.Windows.Forms.RadioButton radVerao02;
        private System.Windows.Forms.RadioButton radVerao03;
        private System.Windows.Forms.RadioButton radVerao04;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pctVerao;
    }
}