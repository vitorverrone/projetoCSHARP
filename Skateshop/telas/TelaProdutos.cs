using Skateshop.sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skateshop.telas
{
    public partial class TelaProdutos : Form
    {
        Produtos produtos = new Produtos();

        public TelaProdutos()
        {
            InitializeComponent();
        }

        private void TelaProdutos_Load(object sender, EventArgs e)
        {
            produtos.MontaGrid(gridProdutos);
            btnAtualizar.Enabled = false;
            btnDeletar.Enabled = false;
            btnNovo.Enabled = false;
            pcbLoading.Visible = false;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Regex preco = new Regex(@"\d{1,4},+\d{2}");
            if (txtNomeProd.Text == "" || txtPreco.Text == "" || txtEstoque.Text == "" || txtDescricao.Text == "" || txtTamanho.Text == "")
            {
                MessageBox.Show("Todos os campos são obrigatórios!");
            }
            else if (!preco.IsMatch(txtPreco.Text))
            {
                MessageBox.Show("Preencha o campo preço conforme o exemplo: 90.00");
            }
            else
            {
                produtos.incluir(txtNomeProd, cbxAtivo, txtEstoque, txtDescricao, txtPreco, txtTamanho, pcbProduto, pcbLoading);
                produtos.MontaGrid(gridProdutos);
                produtos.limpaCampos(txtCodigo, txtNomeProd, cbxAtivo, txtEstoque, txtDescricao, txtPreco, txtTamanho, pcbProduto);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            produtos.limpaCampos(txtCodigo, txtNomeProd, cbxAtivo, txtEstoque, txtDescricao, txtPreco, txtTamanho, pcbProduto);
            btnIncluir.Enabled = true;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja deletar o produto " + txtNomeProd.Text + "?", "Deletar Produto?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                produtos.deletar(txtCodigo);
                produtos.limpaCampos(txtCodigo, txtNomeProd, cbxAtivo, txtEstoque, txtDescricao, txtPreco, txtTamanho, pcbProduto);
                produtos.MontaGrid(gridProdutos);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Regex preco = new Regex(@"\d{1,4},+\d{2}");
            if (txtNomeProd.Text == "" || txtPreco.Text == "" || txtEstoque.Text == "" || txtDescricao.Text == "" || txtTamanho.Text == "")
            {
                MessageBox.Show("Todos os campos são obrigatórios!");
            }
            else if (!preco.IsMatch(txtPreco.Text))
            {
                MessageBox.Show("Preencha o campo preço conforme o exemplo: 90.00");
            }
            else
            {
                produtos.atualizar(txtCodigo, txtNomeProd, cbxAtivo, txtEstoque, txtDescricao, txtPreco, txtTamanho, pcbProduto);
                produtos.MontaGrid(gridProdutos);
            }
        }

        private void gridProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            produtos.limpaCampos(txtCodigo, txtNomeProd, cbxAtivo, txtEstoque, txtDescricao, txtPreco, txtTamanho, pcbProduto);
            int id = Convert.ToInt32(gridProdutos.CurrentRow.Cells[0].Value);

            btnDeletar.Enabled = true;
            btnAtualizar.Enabled = true;
            btnNovo.Enabled = true;
            btnIncluir.Enabled = false;

            produtos.montaSelect(id, txtCodigo, txtNomeProd, cbxAtivo, txtEstoque, txtDescricao, txtPreco, txtTamanho, pcbProduto);
        }

        private void txtEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            { e.Handled = true; }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Imagens (*.jpg, *.png)|*.jpg;*.png";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pcbProduto.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
