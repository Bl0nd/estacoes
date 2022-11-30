namespace estacoes
{
    partial class frmPrimavera
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
            this.lblPrimavera = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.radPrimavera01 = new System.Windows.Forms.RadioButton();
            this.radPrimavera02 = new System.Windows.Forms.RadioButton();
            this.radPrimavera03 = new System.Windows.Forms.RadioButton();
            this.radPrimavera04 = new System.Windows.Forms.RadioButton();
            this.pctPrimavera = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctPrimavera)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrimavera
            // 
            this.lblPrimavera.BackColor = System.Drawing.Color.Cyan;
            this.lblPrimavera.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPrimavera.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimavera.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblPrimavera.Location = new System.Drawing.Point(0, 0);
            this.lblPrimavera.Name = "lblPrimavera";
            this.lblPrimavera.Size = new System.Drawing.Size(773, 55);
            this.lblPrimavera.TabIndex = 1;
            this.lblPrimavera.Text = "Primavera";
            this.lblPrimavera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(740, 0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(31, 23);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "<<";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // radPrimavera01
            // 
            this.radPrimavera01.AutoSize = true;
            this.radPrimavera01.Location = new System.Drawing.Point(212, 145);
            this.radPrimavera01.Name = "radPrimavera01";
            this.radPrimavera01.Size = new System.Drawing.Size(87, 17);
            this.radPrimavera01.TabIndex = 7;
            this.radPrimavera01.TabStop = true;
            this.radPrimavera01.Text = "Primavera 01";
            this.radPrimavera01.UseVisualStyleBackColor = true;
            this.radPrimavera01.CheckedChanged += new System.EventHandler(this.radPrimavera01_CheckedChanged);
            // 
            // radPrimavera02
            // 
            this.radPrimavera02.AutoSize = true;
            this.radPrimavera02.Location = new System.Drawing.Point(212, 200);
            this.radPrimavera02.Name = "radPrimavera02";
            this.radPrimavera02.Size = new System.Drawing.Size(87, 17);
            this.radPrimavera02.TabIndex = 8;
            this.radPrimavera02.TabStop = true;
            this.radPrimavera02.Text = "Primavera 02";
            this.radPrimavera02.UseVisualStyleBackColor = true;
            this.radPrimavera02.CheckedChanged += new System.EventHandler(this.radPrimavera02_CheckedChanged);
            // 
            // radPrimavera03
            // 
            this.radPrimavera03.AutoSize = true;
            this.radPrimavera03.Location = new System.Drawing.Point(212, 264);
            this.radPrimavera03.Name = "radPrimavera03";
            this.radPrimavera03.Size = new System.Drawing.Size(87, 17);
            this.radPrimavera03.TabIndex = 9;
            this.radPrimavera03.TabStop = true;
            this.radPrimavera03.Text = "Primavera 03";
            this.radPrimavera03.UseVisualStyleBackColor = true;
            this.radPrimavera03.CheckedChanged += new System.EventHandler(this.radPrimavera03_CheckedChanged);
            // 
            // radPrimavera04
            // 
            this.radPrimavera04.AutoSize = true;
            this.radPrimavera04.Location = new System.Drawing.Point(212, 329);
            this.radPrimavera04.Name = "radPrimavera04";
            this.radPrimavera04.Size = new System.Drawing.Size(87, 17);
            this.radPrimavera04.TabIndex = 10;
            this.radPrimavera04.TabStop = true;
            this.radPrimavera04.Text = "Primavera 04";
            this.radPrimavera04.UseVisualStyleBackColor = true;
            this.radPrimavera04.CheckedChanged += new System.EventHandler(this.radPrimavera04_CheckedChanged);
            // 
            // pctPrimavera
            // 
            this.pctPrimavera.Location = new System.Drawing.Point(379, 94);
            this.pctPrimavera.Name = "pctPrimavera";
            this.pctPrimavera.Size = new System.Drawing.Size(264, 303);
            this.pctPrimavera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPrimavera.TabIndex = 11;
            this.pctPrimavera.TabStop = false;
            // 
            // frmPrimavera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.pctPrimavera);
            this.Controls.Add(this.radPrimavera04);
            this.Controls.Add(this.radPrimavera03);
            this.Controls.Add(this.radPrimavera02);
            this.Controls.Add(this.radPrimavera01);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblPrimavera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrimavera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primavera";
            ((System.ComponentModel.ISupportInitialize)(this.pctPrimavera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimavera;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.RadioButton radPrimavera01;
        private System.Windows.Forms.RadioButton radPrimavera02;
        private System.Windows.Forms.RadioButton radPrimavera03;
        private System.Windows.Forms.RadioButton radPrimavera04;
        private System.Windows.Forms.PictureBox pctPrimavera;
    }
}