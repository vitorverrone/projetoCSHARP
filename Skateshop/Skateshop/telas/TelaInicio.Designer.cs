namespace Skateshop.telas
{
    partial class TelaInicio
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtClose = new System.Windows.Forms.Label();
            this.panelTelas = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Controls.Add(this.btnProdutos);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-6, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 507);
            this.panel1.TabIndex = 0;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnUsuarios.Location = new System.Drawing.Point(6, 122);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(219, 44);
            this.btnUsuarios.TabIndex = 4;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnProdutos.Location = new System.Drawing.Point(6, 77);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(219, 44);
            this.btnProdutos.TabIndex = 2;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(6, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 68);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Skateshop.Properties.Resources.logo_branco;
            this.pictureBox1.Location = new System.Drawing.Point(36, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button1.Location = new System.Drawing.Point(6, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtClose
            // 
            this.txtClose.AutoSize = true;
            this.txtClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtClose.Location = new System.Drawing.Point(458, 16);
            this.txtClose.Name = "txtClose";
            this.txtClose.Size = new System.Drawing.Size(18, 18);
            this.txtClose.TabIndex = 25;
            this.txtClose.Text = "X";
            this.txtClose.Click += new System.EventHandler(this.txtClose_Click);
            // 
            // panelTelas
            // 
            this.panelTelas.Location = new System.Drawing.Point(221, 24);
            this.panelTelas.Name = "panelTelas";
            this.panelTelas.Size = new System.Drawing.Size(473, 474);
            this.panelTelas.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtClose);
            this.panel3.Location = new System.Drawing.Point(215, -13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(499, 70);
            this.panel3.TabIndex = 0;
            // 
            // TelaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(694, 491);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTelas);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaInicio";
            this.Load += new System.EventHandler(this.TelaInicio_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtClose;
        private System.Windows.Forms.Panel panelTelas;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUsuarios;
    }
}