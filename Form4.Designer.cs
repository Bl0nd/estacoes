namespace estacoes
{
    partial class frmOutono
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
            this.lblOutono = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.radOutono01 = new System.Windows.Forms.RadioButton();
            this.radOutono02 = new System.Windows.Forms.RadioButton();
            this.radOutono03 = new System.Windows.Forms.RadioButton();
            this.radOutono04 = new System.Windows.Forms.RadioButton();
            this.pctOutono = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctOutono)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOutono
            // 
            this.lblOutono.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblOutono.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOutono.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutono.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblOutono.Location = new System.Drawing.Point(0, 0);
            this.lblOutono.Name = "lblOutono";
            this.lblOutono.Size = new System.Drawing.Size(771, 55);
            this.lblOutono.TabIndex = 2;
            this.lblOutono.Text = "Outono";
            this.lblOutono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(738, 0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(31, 23);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "<<";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // radOutono01
            // 
            this.radOutono01.AutoSize = true;
            this.radOutono01.Location = new System.Drawing.Point(225, 137);
            this.radOutono01.Name = "radOutono01";
            this.radOutono01.Size = new System.Drawing.Size(75, 17);
            this.radOutono01.TabIndex = 10;
            this.radOutono01.TabStop = true;
            this.radOutono01.Text = "Outono 01";
            this.radOutono01.UseVisualStyleBackColor = true;
            this.radOutono01.CheckedChanged += new System.EventHandler(this.radOutono01_CheckedChanged);
            // 
            // radOutono02
            // 
            this.radOutono02.AutoSize = true;
            this.radOutono02.Location = new System.Drawing.Point(225, 184);
            this.radOutono02.Name = "radOutono02";
            this.radOutono02.Size = new System.Drawing.Size(75, 17);
            this.radOutono02.TabIndex = 11;
            this.radOutono02.TabStop = true;
            this.radOutono02.Text = "Outono 02";
            this.radOutono02.UseVisualStyleBackColor = true;
            this.radOutono02.CheckedChanged += new System.EventHandler(this.radOutono02_CheckedChanged);
            // 
            // radOutono03
            // 
            this.radOutono03.AutoSize = true;
            this.radOutono03.Location = new System.Drawing.Point(225, 236);
            this.radOutono03.Name = "radOutono03";
            this.radOutono03.Size = new System.Drawing.Size(75, 17);
            this.radOutono03.TabIndex = 12;
            this.radOutono03.TabStop = true;
            this.radOutono03.Text = "Outono 03";
            this.radOutono03.UseVisualStyleBackColor = true;
            this.radOutono03.CheckedChanged += new System.EventHandler(this.radOutono03_CheckedChanged);
            // 
            // radOutono04
            // 
            this.radOutono04.AutoSize = true;
            this.radOutono04.Location = new System.Drawing.Point(225, 291);
            this.radOutono04.Name = "radOutono04";
            this.radOutono04.Size = new System.Drawing.Size(75, 17);
            this.radOutono04.TabIndex = 13;
            this.radOutono04.TabStop = true;
            this.radOutono04.Text = "Outono 04";
            this.radOutono04.UseVisualStyleBackColor = true;
            this.radOutono04.CheckedChanged += new System.EventHandler(this.radOutono04_CheckedChanged);
            // 
            // pctOutono
            // 
            this.pctOutono.Location = new System.Drawing.Point(389, 99);
            this.pctOutono.Name = "pctOutono";
            this.pctOutono.Size = new System.Drawing.Size(261, 253);
            this.pctOutono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctOutono.TabIndex = 9;
            this.pctOutono.TabStop = false;
            // 
            // frmOutono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 450);
            this.Controls.Add(this.radOutono04);
            this.Controls.Add(this.radOutono03);
            this.Controls.Add(this.radOutono02);
            this.Controls.Add(this.radOutono01);
            this.Controls.Add(this.pctOutono);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblOutono);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOutono";
            this.Text = "Outono";
            ((System.ComponentModel.ISupportInitialize)(this.pctOutono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOutono;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pctOutono;
        private System.Windows.Forms.RadioButton radOutono01;
        private System.Windows.Forms.RadioButton radOutono02;
        private System.Windows.Forms.RadioButton radOutono03;
        private System.Windows.Forms.RadioButton radOutono04;
    }
}