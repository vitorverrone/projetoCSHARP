namespace Skateshop.telas
{
    partial class TelaCadastro
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
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtConfEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSenha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtConfSenha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCriarConta = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClose
            // 
            this.txtClose.AutoSize = true;
            this.txtClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtClose.Location = new System.Drawing.Point(363, 3);
            this.txtClose.Name = "txtClose";
            this.txtClose.Size = new System.Drawing.Size(18, 18);
            this.txtClose.TabIndex = 0;
            this.txtClose.Text = "X";
            this.txtClose.Click += new System.EventHandler(this.txtClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Skateshop.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(127, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 60);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "";
            this.txtEmail.Location = new System.Drawing.Point(75, 122);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(178, 23);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(14, 126);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(55, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "E-mail:";
            // 
            // txtConfEmail
            // 
            this.txtConfEmail.Depth = 0;
            this.txtConfEmail.Hint = "";
            this.txtConfEmail.Location = new System.Drawing.Point(185, 157);
            this.txtConfEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtConfEmail.Name = "txtConfEmail";
            this.txtConfEmail.PasswordChar = '\0';
            this.txtConfEmail.SelectedText = "";
            this.txtConfEmail.SelectionLength = 0;
            this.txtConfEmail.SelectionStart = 0;
            this.txtConfEmail.Size = new System.Drawing.Size(178, 23);
            this.txtConfEmail.TabIndex = 7;
            this.txtConfEmail.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(14, 161);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(165, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Confirmação de e-mail:";
            // 
            // txtSenha
            // 
            this.txtSenha.Depth = 0;
            this.txtSenha.Hint = "";
            this.txtSenha.Location = new System.Drawing.Point(74, 209);
            this.txtSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.Size = new System.Drawing.Size(178, 23);
            this.txtSenha.TabIndex = 9;
            this.txtSenha.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(14, 213);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(54, 19);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "Senha:";
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.Depth = 0;
            this.txtConfSenha.Hint = "";
            this.txtConfSenha.Location = new System.Drawing.Point(185, 243);
            this.txtConfSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.PasswordChar = '*';
            this.txtConfSenha.SelectedText = "";
            this.txtConfSenha.SelectionLength = 0;
            this.txtConfSenha.SelectionStart = 0;
            this.txtConfSenha.Size = new System.Drawing.Size(178, 23);
            this.txtConfSenha.TabIndex = 11;
            this.txtConfSenha.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(14, 247);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(164, 19);
            this.materialLabel4.TabIndex = 10;
            this.materialLabel4.Text = "Confirmação de senha:";
            // 
            // txtCriarConta
            // 
            this.txtCriarConta.AutoSize = true;
            this.txtCriarConta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtCriarConta.Depth = 0;
            this.txtCriarConta.Location = new System.Drawing.Point(140, 324);
            this.txtCriarConta.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtCriarConta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCriarConta.Name = "txtCriarConta";
            this.txtCriarConta.Primary = false;
            this.txtCriarConta.Size = new System.Drawing.Size(100, 36);
            this.txtCriarConta.TabIndex = 12;
            this.txtCriarConta.Text = "Criar Conta";
            this.txtCriarConta.UseVisualStyleBackColor = true;
            this.txtCriarConta.Click += new System.EventHandler(this.txtCriarConta_Click);
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 382);
            this.Controls.Add(this.txtCriarConta);
            this.Controls.Add(this.txtConfSenha);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtConfEmail);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastro";
            this.Load += new System.EventHandler(this.TelaCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtConfEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSenha;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtConfSenha;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialFlatButton txtCriarConta;
    }
}