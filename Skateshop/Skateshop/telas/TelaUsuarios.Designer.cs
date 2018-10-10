namespace Skateshop.telas
{
    partial class TelaUsuarios
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
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.gridUsuarios = new System.Windows.Forms.DataGridView();
            this.txtConfSenha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSenha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtConfEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.btnDeletar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNovo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnIncluir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtCodigo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(2, 2);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(69, 19);
            this.materialLabel4.TabIndex = 36;
            this.materialLabel4.Text = "Usuários";
            // 
            // gridUsuarios
            // 
            this.gridUsuarios.AllowUserToDeleteRows = false;
            this.gridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colEmail});
            this.gridUsuarios.Location = new System.Drawing.Point(6, 28);
            this.gridUsuarios.Name = "gridUsuarios";
            this.gridUsuarios.ReadOnly = true;
            this.gridUsuarios.Size = new System.Drawing.Size(453, 150);
            this.gridUsuarios.TabIndex = 37;
            this.gridUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUsuarios_CellClick);
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.Depth = 0;
            this.txtConfSenha.Hint = "";
            this.txtConfSenha.Location = new System.Drawing.Point(174, 302);
            this.txtConfSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.PasswordChar = '*';
            this.txtConfSenha.SelectedText = "";
            this.txtConfSenha.SelectionLength = 0;
            this.txtConfSenha.SelectionStart = 0;
            this.txtConfSenha.Size = new System.Drawing.Size(178, 23);
            this.txtConfSenha.TabIndex = 45;
            this.txtConfSenha.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 306);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(164, 19);
            this.materialLabel1.TabIndex = 44;
            this.materialLabel1.Text = "Confirmação de senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Depth = 0;
            this.txtSenha.Hint = "";
            this.txtSenha.Location = new System.Drawing.Point(63, 268);
            this.txtSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.Size = new System.Drawing.Size(178, 23);
            this.txtSenha.TabIndex = 43;
            this.txtSenha.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(3, 272);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(54, 19);
            this.materialLabel3.TabIndex = 42;
            this.materialLabel3.Text = "Senha:";
            // 
            // txtConfEmail
            // 
            this.txtConfEmail.Depth = 0;
            this.txtConfEmail.Hint = "";
            this.txtConfEmail.Location = new System.Drawing.Point(173, 230);
            this.txtConfEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtConfEmail.Name = "txtConfEmail";
            this.txtConfEmail.PasswordChar = '\0';
            this.txtConfEmail.SelectedText = "";
            this.txtConfEmail.SelectionLength = 0;
            this.txtConfEmail.SelectionStart = 0;
            this.txtConfEmail.Size = new System.Drawing.Size(178, 23);
            this.txtConfEmail.TabIndex = 41;
            this.txtConfEmail.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(2, 234);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(165, 19);
            this.materialLabel2.TabIndex = 40;
            this.materialLabel2.Text = "Confirmação de e-mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "";
            this.txtEmail.Location = new System.Drawing.Point(63, 195);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(178, 23);
            this.txtEmail.TabIndex = 39;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(2, 199);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(55, 19);
            this.materialLabel5.TabIndex = 38;
            this.materialLabel5.Text = "E-mail:";
            // 
            // btnDeletar
            // 
            this.btnDeletar.Depth = 0;
            this.btnDeletar.Location = new System.Drawing.Point(185, 404);
            this.btnDeletar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Primary = true;
            this.btnDeletar.Size = new System.Drawing.Size(80, 35);
            this.btnDeletar.TabIndex = 51;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Depth = 0;
            this.btnNovo.Location = new System.Drawing.Point(282, 404);
            this.btnNovo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Primary = true;
            this.btnNovo.Size = new System.Drawing.Size(80, 35);
            this.btnNovo.TabIndex = 50;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Depth = 0;
            this.btnIncluir.Location = new System.Drawing.Point(90, 404);
            this.btnIncluir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Primary = true;
            this.btnIncluir.Size = new System.Drawing.Size(80, 35);
            this.btnIncluir.TabIndex = 49;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Hint = "";
            this.txtCodigo.Location = new System.Drawing.Point(413, 195);
            this.txtCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.Size = new System.Drawing.Size(44, 23);
            this.txtCodigo.TabIndex = 53;
            this.txtCodigo.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(350, 199);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(61, 19);
            this.materialLabel6.TabIndex = 52;
            this.materialLabel6.Text = "Código:";
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "#";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Width = 50;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "E-mail";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 360;
            // 
            // TelaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 462);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.txtConfSenha);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtConfEmail);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.gridUsuarios);
            this.Controls.Add(this.materialLabel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaUsuarios";
            this.Text = "TelaUsuarios";
            this.Load += new System.EventHandler(this.TelaUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.DataGridView gridUsuarios;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtConfSenha;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSenha;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtConfEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialRaisedButton btnDeletar;
        private MaterialSkin.Controls.MaterialRaisedButton btnNovo;
        private MaterialSkin.Controls.MaterialRaisedButton btnIncluir;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodigo;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
    }
}