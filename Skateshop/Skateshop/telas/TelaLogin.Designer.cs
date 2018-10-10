namespace Skateshop.telas
{
    partial class TelaLogin
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
            this.txtClose = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSenha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnLogar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCriaConta = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClose
            // 
            this.txtClose.AutoSize = true;
            this.txtClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtClose.Location = new System.Drawing.Point(342, 2);
            this.txtClose.Name = "txtClose";
            this.txtClose.Size = new System.Drawing.Size(18, 18);
            this.txtClose.TabIndex = 0;
            this.txtClose.Text = "X";
            this.txtClose.Click += new System.EventHandler(this.txtClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Skateshop.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(118, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 60);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(55, 110);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(55, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "E-mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "";
            this.txtEmail.Location = new System.Drawing.Point(116, 106);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(178, 23);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // txtSenha
            // 
            this.txtSenha.Depth = 0;
            this.txtSenha.Hint = "";
            this.txtSenha.Location = new System.Drawing.Point(115, 151);
            this.txtSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.Size = new System.Drawing.Size(179, 23);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(55, 155);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(54, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Senha:";
            // 
            // btnLogar
            // 
            this.btnLogar.AutoSize = true;
            this.btnLogar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogar.Depth = 0;
            this.btnLogar.Location = new System.Drawing.Point(293, 210);
            this.btnLogar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Primary = false;
            this.btnLogar.Size = new System.Drawing.Size(56, 36);
            this.btnLogar.TabIndex = 6;
            this.btnLogar.Text = "Logar";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // btnCriaConta
            // 
            this.btnCriaConta.AutoSize = true;
            this.btnCriaConta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCriaConta.Depth = 0;
            this.btnCriaConta.Location = new System.Drawing.Point(13, 210);
            this.btnCriaConta.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCriaConta.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCriaConta.Name = "btnCriaConta";
            this.btnCriaConta.Primary = false;
            this.btnCriaConta.Size = new System.Drawing.Size(100, 36);
            this.btnCriaConta.TabIndex = 7;
            this.btnCriaConta.Text = "Criar Conta";
            this.btnCriaConta.UseVisualStyleBackColor = true;
            this.btnCriaConta.Click += new System.EventHandler(this.btnCriaConta_Click);
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 261);
            this.Controls.Add(this.btnCriaConta);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(342, 2);
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaLogin";
            this.Load += new System.EventHandler(this.TelaLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSenha;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialFlatButton btnLogar;
        private MaterialSkin.Controls.MaterialFlatButton btnCriaConta;
    }
}