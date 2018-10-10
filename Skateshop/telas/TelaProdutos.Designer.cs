namespace Skateshop.telas
{
    partial class TelaProdutos
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
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.cbxAtivo = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnFoto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAtualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDeletar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNovo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnIncluir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtEstoque = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTamanho = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPreco = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNomeProd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCodigo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.gridProdutos = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAtivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcbLoading = new System.Windows.Forms.PictureBox();
            this.pcbProduto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(123, 348);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(68, 19);
            this.materialLabel9.TabIndex = 51;
            this.materialLabel9.Text = "Ex: 90,00";
            // 
            // cbxAtivo
            // 
            this.cbxAtivo.AutoSize = true;
            this.cbxAtivo.Depth = 0;
            this.cbxAtivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbxAtivo.Location = new System.Drawing.Point(256, 216);
            this.cbxAtivo.Margin = new System.Windows.Forms.Padding(0);
            this.cbxAtivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxAtivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxAtivo.Name = "cbxAtivo";
            this.cbxAtivo.Ripple = true;
            this.cbxAtivo.Size = new System.Drawing.Size(68, 30);
            this.cbxAtivo.TabIndex = 50;
            this.cbxAtivo.Text = "Ativo?";
            this.cbxAtivo.UseVisualStyleBackColor = true;
            // 
            // btnFoto
            // 
            this.btnFoto.Depth = 0;
            this.btnFoto.Location = new System.Drawing.Point(339, 361);
            this.btnFoto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Primary = true;
            this.btnFoto.Size = new System.Drawing.Size(115, 44);
            this.btnFoto.TabIndex = 49;
            this.btnFoto.Text = "Selecionar foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Depth = 0;
            this.btnAtualizar.Location = new System.Drawing.Point(246, 422);
            this.btnAtualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Primary = true;
            this.btnAtualizar.Size = new System.Drawing.Size(80, 35);
            this.btnAtualizar.TabIndex = 48;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Depth = 0;
            this.btnDeletar.Location = new System.Drawing.Point(157, 422);
            this.btnDeletar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Primary = true;
            this.btnDeletar.Size = new System.Drawing.Size(80, 35);
            this.btnDeletar.TabIndex = 47;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Depth = 0;
            this.btnNovo.Location = new System.Drawing.Point(245, 375);
            this.btnNovo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Primary = true;
            this.btnNovo.Size = new System.Drawing.Size(80, 35);
            this.btnNovo.TabIndex = 46;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Depth = 0;
            this.btnIncluir.Location = new System.Drawing.Point(157, 375);
            this.btnIncluir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Primary = true;
            this.btnIncluir.Size = new System.Drawing.Size(80, 35);
            this.btnIncluir.TabIndex = 45;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(2, 425);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(69, 19);
            this.materialLabel8.TabIndex = 43;
            this.materialLabel8.Text = "Estoque:";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Depth = 0;
            this.txtEstoque.Hint = "";
            this.txtEstoque.Location = new System.Drawing.Point(73, 422);
            this.txtEstoque.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.PasswordChar = '\0';
            this.txtEstoque.SelectedText = "";
            this.txtEstoque.SelectionLength = 0;
            this.txtEstoque.SelectionStart = 0;
            this.txtEstoque.Size = new System.Drawing.Size(44, 23);
            this.txtEstoque.TabIndex = 42;
            this.txtEstoque.UseSystemPasswordChar = false;
            this.txtEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstoque_KeyPress);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(2, 386);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(76, 19);
            this.materialLabel7.TabIndex = 41;
            this.materialLabel7.Text = "Tamanho:";
            // 
            // txtTamanho
            // 
            this.txtTamanho.Depth = 0;
            this.txtTamanho.Hint = "";
            this.txtTamanho.Location = new System.Drawing.Point(82, 382);
            this.txtTamanho.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.PasswordChar = '\0';
            this.txtTamanho.SelectedText = "";
            this.txtTamanho.SelectionLength = 0;
            this.txtTamanho.SelectionStart = 0;
            this.txtTamanho.Size = new System.Drawing.Size(51, 23);
            this.txtTamanho.TabIndex = 40;
            this.txtTamanho.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(2, 348);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(52, 19);
            this.materialLabel6.TabIndex = 39;
            this.materialLabel6.Text = "Preço:";
            // 
            // txtPreco
            // 
            this.txtPreco.Depth = 0;
            this.txtPreco.Hint = "";
            this.txtPreco.Location = new System.Drawing.Point(58, 344);
            this.txtPreco.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.PasswordChar = '\0';
            this.txtPreco.SelectedText = "";
            this.txtPreco.SelectionLength = 0;
            this.txtPreco.SelectionStart = 0;
            this.txtPreco.Size = new System.Drawing.Size(59, 23);
            this.txtPreco.TabIndex = 38;
            this.txtPreco.UseSystemPasswordChar = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Location = new System.Drawing.Point(6, 249);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(319, 75);
            this.txtDescricao.TabIndex = 37;
            this.txtDescricao.Text = "";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(2, 227);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(81, 19);
            this.materialLabel5.TabIndex = 36;
            this.materialLabel5.Text = "Descrição:";
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
            this.materialLabel4.Size = new System.Drawing.Size(70, 19);
            this.materialLabel4.TabIndex = 35;
            this.materialLabel4.Text = "Produtos";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(2, 194);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(131, 19);
            this.materialLabel3.TabIndex = 34;
            this.materialLabel3.Text = "Nome do produto:";
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.Depth = 0;
            this.txtNomeProd.Hint = "";
            this.txtNomeProd.Location = new System.Drawing.Point(136, 190);
            this.txtNomeProd.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.PasswordChar = '\0';
            this.txtNomeProd.SelectedText = "";
            this.txtNomeProd.SelectionLength = 0;
            this.txtNomeProd.SelectionStart = 0;
            this.txtNomeProd.Size = new System.Drawing.Size(188, 23);
            this.txtNomeProd.TabIndex = 33;
            this.txtNomeProd.UseSystemPasswordChar = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Hint = "";
            this.txtCodigo.Location = new System.Drawing.Point(415, 190);
            this.txtCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.Size = new System.Drawing.Size(44, 23);
            this.txtCodigo.TabIndex = 32;
            this.txtCodigo.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(352, 194);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(61, 19);
            this.materialLabel2.TabIndex = 31;
            this.materialLabel2.Text = "Código:";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // gridProdutos
            // 
            this.gridProdutos.AllowUserToDeleteRows = false;
            this.gridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colAtivo,
            this.colNomeProd,
            this.colPreco,
            this.colTamanho,
            this.colQtd});
            this.gridProdutos.Location = new System.Drawing.Point(6, 28);
            this.gridProdutos.Name = "gridProdutos";
            this.gridProdutos.ReadOnly = true;
            this.gridProdutos.Size = new System.Drawing.Size(453, 150);
            this.gridProdutos.TabIndex = 30;
            this.gridProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProdutos_CellClick);
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "#";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Width = 50;
            // 
            // colAtivo
            // 
            this.colAtivo.HeaderText = "Ativo";
            this.colAtivo.Name = "colAtivo";
            this.colAtivo.ReadOnly = true;
            this.colAtivo.Width = 40;
            // 
            // colNomeProd
            // 
            this.colNomeProd.HeaderText = "Produto";
            this.colNomeProd.Name = "colNomeProd";
            this.colNomeProd.ReadOnly = true;
            this.colNomeProd.Width = 150;
            // 
            // colPreco
            // 
            this.colPreco.HeaderText = "Preço";
            this.colPreco.Name = "colPreco";
            this.colPreco.ReadOnly = true;
            this.colPreco.Width = 50;
            // 
            // colTamanho
            // 
            this.colTamanho.HeaderText = "Tamanho";
            this.colTamanho.Name = "colTamanho";
            this.colTamanho.ReadOnly = true;
            this.colTamanho.Width = 60;
            // 
            // colQtd
            // 
            this.colQtd.HeaderText = "Estoque";
            this.colQtd.Name = "colQtd";
            this.colQtd.ReadOnly = true;
            this.colQtd.Width = 60;
            // 
            // pcbLoading
            // 
            this.pcbLoading.Image = global::Skateshop.Properties.Resources.loading;
            this.pcbLoading.Location = new System.Drawing.Point(339, 421);
            this.pcbLoading.Name = "pcbLoading";
            this.pcbLoading.Size = new System.Drawing.Size(115, 40);
            this.pcbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLoading.TabIndex = 52;
            this.pcbLoading.TabStop = false;
            // 
            // pcbProduto
            // 
            this.pcbProduto.Location = new System.Drawing.Point(339, 227);
            this.pcbProduto.Name = "pcbProduto";
            this.pcbProduto.Size = new System.Drawing.Size(115, 115);
            this.pcbProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbProduto.TabIndex = 44;
            this.pcbProduto.TabStop = false;
            // 
            // TelaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 462);
            this.Controls.Add(this.pcbLoading);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.cbxAtivo);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.pcbProduto);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtNomeProd);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.gridProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaProdutos";
            this.Text = "TelaProdutos";
            this.Load += new System.EventHandler(this.TelaProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbLoading;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialCheckBox cbxAtivo;
        private MaterialSkin.Controls.MaterialRaisedButton btnFoto;
        private MaterialSkin.Controls.MaterialRaisedButton btnAtualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnDeletar;
        private MaterialSkin.Controls.MaterialRaisedButton btnNovo;
        private MaterialSkin.Controls.MaterialRaisedButton btnIncluir;
        private System.Windows.Forms.PictureBox pcbProduto;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEstoque;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTamanho;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPreco;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNomeProd;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodigo;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DataGridView gridProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAtivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtd;
    }
}