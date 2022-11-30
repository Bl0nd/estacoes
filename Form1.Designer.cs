namespace estacoes
{
    partial class frmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMenuPrincipal = new System.Windows.Forms.Label();
            this.btnPrimavera = new System.Windows.Forms.Button();
            this.btnVerao = new System.Windows.Forms.Button();
            this.btnOutono = new System.Windows.Forms.Button();
            this.btnInverno = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenuPrincipal
            // 
            this.lblMenuPrincipal.BackColor = System.Drawing.Color.Black;
            this.lblMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMenuPrincipal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuPrincipal.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.lblMenuPrincipal.Name = "lblMenuPrincipal";
            this.lblMenuPrincipal.Size = new System.Drawing.Size(713, 55);
            this.lblMenuPrincipal.TabIndex = 0;
            this.lblMenuPrincipal.Text = "Menu Principal";
            this.lblMenuPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrimavera
            // 
            this.btnPrimavera.Location = new System.Drawing.Point(176, 505);
            this.btnPrimavera.Name = "btnPrimavera";
            this.btnPrimavera.Size = new System.Drawing.Size(75, 23);
            this.btnPrimavera.TabIndex = 1;
            this.btnPrimavera.Text = "Primavera";
            this.btnPrimavera.UseVisualStyleBackColor = true;
            this.btnPrimavera.Click += new System.EventHandler(this.btnPrimavera_Click);
            // 
            // btnVerao
            // 
            this.btnVerao.Location = new System.Drawing.Point(509, 505);
            this.btnVerao.Name = "btnVerao";
            this.btnVerao.Size = new System.Drawing.Size(75, 23);
            this.btnVerao.TabIndex = 2;
            this.btnVerao.Text = "Verão";
            this.btnVerao.UseVisualStyleBackColor = true;
            this.btnVerao.Click += new System.EventHandler(this.btnVerao_Click);
            // 
            // btnOutono
            // 
            this.btnOutono.Location = new System.Drawing.Point(176, 201);
            this.btnOutono.Name = "btnOutono";
            this.btnOutono.Size = new System.Drawing.Size(75, 23);
            this.btnOutono.TabIndex = 3;
            this.btnOutono.Text = "Outono";
            this.btnOutono.UseVisualStyleBackColor = true;
            this.btnOutono.Click += new System.EventHandler(this.btnOutono_Click);
            // 
            // btnInverno
            // 
            this.btnInverno.Location = new System.Drawing.Point(509, 201);
            this.btnInverno.Name = "btnInverno";
            this.btnInverno.Size = new System.Drawing.Size(75, 23);
            this.btnInverno.TabIndex = 4;
            this.btnInverno.Text = "Inverno";
            this.btnInverno.UseVisualStyleBackColor = true;
            this.btnInverno.Click += new System.EventHandler(this.btnInverno_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(682, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(31, 23);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::estacoes.Properties.Resources.estacoes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(713, 695);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnInverno);
            this.Controls.Add(this.btnOutono);
            this.Controls.Add(this.btnVerao);
            this.Controls.Add(this.btnPrimavera);
            this.Controls.Add(this.lblMenuPrincipal);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMenuPrincipal;
        private System.Windows.Forms.Button btnPrimavera;
        private System.Windows.Forms.Button btnVerao;
        private System.Windows.Forms.Button btnOutono;
        private System.Windows.Forms.Button btnInverno;
        private System.Windows.Forms.Button btnSair;
    }
}

