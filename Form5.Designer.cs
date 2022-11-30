namespace estacoes
{
    partial class frmInverno
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
            this.lblInverno = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.radInverno01 = new System.Windows.Forms.RadioButton();
            this.radInverno02 = new System.Windows.Forms.RadioButton();
            this.radInverno03 = new System.Windows.Forms.RadioButton();
            this.radInverno04 = new System.Windows.Forms.RadioButton();
            this.pctInverno = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctInverno)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInverno
            // 
            this.lblInverno.BackColor = System.Drawing.Color.BlueViolet;
            this.lblInverno.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInverno.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInverno.ForeColor = System.Drawing.Color.Violet;
            this.lblInverno.Location = new System.Drawing.Point(0, 0);
            this.lblInverno.Name = "lblInverno";
            this.lblInverno.Size = new System.Drawing.Size(777, 55);
            this.lblInverno.TabIndex = 3;
            this.lblInverno.Text = "Inverno";
            this.lblInverno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Plum;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(746, 0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(31, 23);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "<<";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // radInverno01
            // 
            this.radInverno01.AutoSize = true;
            this.radInverno01.Location = new System.Drawing.Point(216, 140);
            this.radInverno01.Name = "radInverno01";
            this.radInverno01.Size = new System.Drawing.Size(76, 17);
            this.radInverno01.TabIndex = 11;
            this.radInverno01.TabStop = true;
            this.radInverno01.Text = "Inverno 01";
            this.radInverno01.UseVisualStyleBackColor = true;
            this.radInverno01.CheckedChanged += new System.EventHandler(this.radInverno01_CheckedChanged);
            // 
            // radInverno02
            // 
            this.radInverno02.AutoSize = true;
            this.radInverno02.Location = new System.Drawing.Point(216, 193);
            this.radInverno02.Name = "radInverno02";
            this.radInverno02.Size = new System.Drawing.Size(76, 17);
            this.radInverno02.TabIndex = 12;
            this.radInverno02.TabStop = true;
            this.radInverno02.Text = "Inverno 02";
            this.radInverno02.UseVisualStyleBackColor = true;
            this.radInverno02.CheckedChanged += new System.EventHandler(this.radInverno02_CheckedChanged);
            // 
            // radInverno03
            // 
            this.radInverno03.AutoSize = true;
            this.radInverno03.Location = new System.Drawing.Point(216, 251);
            this.radInverno03.Name = "radInverno03";
            this.radInverno03.Size = new System.Drawing.Size(76, 17);
            this.radInverno03.TabIndex = 13;
            this.radInverno03.TabStop = true;
            this.radInverno03.Text = "Inverno 03";
            this.radInverno03.UseVisualStyleBackColor = true;
            this.radInverno03.CheckedChanged += new System.EventHandler(this.radInverno03_CheckedChanged);
            // 
            // radInverno04
            // 
            this.radInverno04.AutoSize = true;
            this.radInverno04.Location = new System.Drawing.Point(216, 311);
            this.radInverno04.Name = "radInverno04";
            this.radInverno04.Size = new System.Drawing.Size(76, 17);
            this.radInverno04.TabIndex = 14;
            this.radInverno04.TabStop = true;
            this.radInverno04.Text = "Inverno 04";
            this.radInverno04.UseVisualStyleBackColor = true;
            this.radInverno04.CheckedChanged += new System.EventHandler(this.radInverno04_CheckedChanged);
            // 
            // pctInverno
            // 
            this.pctInverno.Location = new System.Drawing.Point(381, 85);
            this.pctInverno.Name = "pctInverno";
            this.pctInverno.Size = new System.Drawing.Size(254, 290);
            this.pctInverno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctInverno.TabIndex = 15;
            this.pctInverno.TabStop = false;
            // 
            // frmInverno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 450);
            this.Controls.Add(this.pctInverno);
            this.Controls.Add(this.radInverno04);
            this.Controls.Add(this.radInverno03);
            this.Controls.Add(this.radInverno02);
            this.Controls.Add(this.radInverno01);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblInverno);
            this.Name = "frmInverno";
            this.Text = "Inverno";
            ((System.ComponentModel.ISupportInitialize)(this.pctInverno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInverno;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.RadioButton radInverno01;
        private System.Windows.Forms.RadioButton radInverno02;
        private System.Windows.Forms.RadioButton radInverno03;
        private System.Windows.Forms.RadioButton radInverno04;
        private System.Windows.Forms.PictureBox pctInverno;
    }
}