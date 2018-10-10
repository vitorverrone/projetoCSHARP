using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skateshop.sql
{
    class Produtos
    {
        Util classUtil = new Util();
        public void MontaGrid(DataGridView gridProdutos)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                gridProdutos.Rows.Clear();
                Conexao objConexao = new Conexao();
                objConexao.ConexaoDB();

                var objDados = objConexao.objDados;
                var objCmd = objConexao.objComando;
                var objCnx = objConexao.objConect;
                objCnx.Close();
                objCnx.Open();

                string sql_Select = "SELECT * FROM produtos";
                objCmd.CommandText = sql_Select;
                objCmd.Connection = objCnx;
                objDados = objCmd.ExecuteReader();

                if (!objDados.HasRows)
                {
                    MessageBox.Show("Não há dados para exibir!");
                }
                else
                {

                    while (objDados.Read())
                    {
                        string ativo = "";
                        if (objDados["ativo"].ToString() == "1")
                        {
                            ativo = "Sim";
                        }
                        else
                        {
                            ativo = "Não";
                        }
                        gridProdutos.Rows.Add(
                            objDados["id"].ToString(),
                            ativo,
                            objDados["nomeProd"].ToString(),
                            objDados["preco"].ToString(),
                            objDados["tamanho"].ToString(),
                            objDados["estoque"].ToString()
                        );
                    }

                }
                objCnx.Close();
                Cursor.Current = Cursors.Default;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ->" + e.Message);
                Cursor.Current = Cursors.Default;
            }
        }


        public void incluir(MaterialSkin.Controls.MaterialSingleLineTextField txtNome, MaterialSkin.Controls.MaterialCheckBox checkAtivo, MaterialSkin.Controls.MaterialSingleLineTextField txtEstoque, RichTextBox txtDescricao, MaterialSkin.Controls.MaterialSingleLineTextField txtPreco, MaterialSkin.Controls.MaterialSingleLineTextField txtTamanho, PictureBox pcbFoto, PictureBox pcbLoading)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                
                Conexao objConexao = new Conexao();
                objConexao.ConexaoDB();

                var objDados = objConexao.objDados;
                var objCmd = objConexao.objComando;
                var objCnx = objConexao.objConect;
                int ativo = 0;

                objCnx.Close();
                objCnx.Open();
                if (checkAtivo.Checked == true)
                {
                    ativo = 1;
                }
                else
                {
                    ativo = 0;
                }
                string sql_Select = "INSERT INTO produtos (nomeProd, estoque, tamanho, descricao, ativo, foto, preco) " +
                                    "values ('" + txtNome.Text + "','" + txtEstoque.Text + "','" + txtTamanho.Text + "', '" + txtDescricao.Text + "','" + ativo + "', @foto, '" + txtPreco.Text + "')";
                objCmd.Parameters.AddWithValue("@foto", classUtil.PreparaFoto(pcbFoto.Image));
                objCmd.CommandText = sql_Select;
                objCmd.Connection = objCnx;
                objDados = objCmd.ExecuteReader();
                if (objDados.RecordsAffected > 0)
                {
                    MessageBox.Show("Incluído com sucesso !");
                    pcbLoading.Visible = false;
                }
                else
                {
                    MessageBox.Show("Falha na inclusão !");
                    pcbLoading.Visible = false;
                }
                objCnx.Close();
                Cursor.Current = Cursors.Default;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ->" + e.Message);
                pcbLoading.Visible = false;
                Cursor.Current = Cursors.Default;
            }
        }

        public void limpaCampos(MaterialSkin.Controls.MaterialSingleLineTextField txtCodigo, MaterialSkin.Controls.MaterialSingleLineTextField txtNome, MaterialSkin.Controls.MaterialCheckBox checkAtivo, MaterialSkin.Controls.MaterialSingleLineTextField txtEstoque, RichTextBox txtDescricao, MaterialSkin.Controls.MaterialSingleLineTextField txtPreco, MaterialSkin.Controls.MaterialSingleLineTextField txtTamanho, PictureBox pcbFoto)
        {
            txtNome.Text = "";
            txtCodigo.Text = "";
            txtEstoque.Text = "";
            txtDescricao.Text = "";
            txtPreco.Text = "";
            txtTamanho.Text = "";
            pcbFoto.Image = null;
            checkAtivo.Checked = false;
        }

        public void atualizar(MaterialSkin.Controls.MaterialSingleLineTextField txtId, MaterialSkin.Controls.MaterialSingleLineTextField txtNome, MaterialSkin.Controls.MaterialCheckBox checkAtivo, MaterialSkin.Controls.MaterialSingleLineTextField txtEstoque, RichTextBox txtDescricao, MaterialSkin.Controls.MaterialSingleLineTextField txtPreco, MaterialSkin.Controls.MaterialSingleLineTextField txtTamanho, PictureBox pcbFoto)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                Conexao objConexao = new Conexao();
                objConexao.ConexaoDB();

                var objDados = objConexao.objDados;
                var objCmd = objConexao.objComando;
                var objCnx = objConexao.objConect;
                int ativo = 0;

                objCnx.Close();
                objCnx.Open();

                if (checkAtivo.Checked == true)
                {
                    ativo = 1;
                }
                else
                {
                    ativo = 0;
                }
                string sql_Select = "UPDATE produtos SET nomeProd = '" + txtNome.Text + "', ativo = '" + ativo + "', estoque = '" + txtEstoque.Text + "', tamanho = '" + txtTamanho.Text + "', descricao = '" + txtDescricao.Text + "', preco = '" + txtPreco.Text + "', foto = @foto WHERE id = '" + txtId.Text + "'";
                objCmd.Parameters.AddWithValue("@foto", classUtil.PreparaFoto(pcbFoto.Image));
                objCmd.CommandText = sql_Select;
                objCmd.Connection = objCnx;
                objDados = objCmd.ExecuteReader();
                if (objDados.RecordsAffected > 0)
                {
                    MessageBox.Show("Atualizado com sucesso !");

                }
                else
                {
                    MessageBox.Show("Falha na atualização !");
                }
                objCnx.Close();
                Cursor.Current = Cursors.Default;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ->" + e.Message);
                Cursor.Current = Cursors.Default;
            }

        }

        public void montaSelect(int id, MaterialSkin.Controls.MaterialSingleLineTextField txtId, MaterialSkin.Controls.MaterialSingleLineTextField txtNome, MaterialSkin.Controls.MaterialCheckBox checkAtivo, MaterialSkin.Controls.MaterialSingleLineTextField txtEstoque, RichTextBox txtDescricao, MaterialSkin.Controls.MaterialSingleLineTextField txtPreco, MaterialSkin.Controls.MaterialSingleLineTextField txtTamanho, PictureBox pcbFoto)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                Conexao objConexao = new Conexao();
                objConexao.ConexaoDB();

                var objDados = objConexao.objDados;
                var objCmd = objConexao.objComando;
                var objCnx = objConexao.objConect;

                objCnx.Close();
                objCnx.Open();
                string sql_Select = "SELECT * FROM produtos WHERE id = " + id;
                objCmd.CommandText = sql_Select;
                objCmd.Connection = objCnx;
                objDados = objCmd.ExecuteReader();
                if (!objDados.HasRows)
                {
                    MessageBox.Show("Não há dados para exibir!");
                }
                else
                {

                    while (objDados.Read())
                    {

                        if (objDados["ativo"].ToString() == "1")
                        {
                            checkAtivo.Checked = true;
                        }
                        txtEstoque.Text = objDados["estoque"].ToString();
                        txtId.Text = objDados["id"].ToString();
                        txtNome.Text = objDados["nomeProd"].ToString();
                        txtPreco.Text = objDados["preco"].ToString();
                        txtDescricao.Text = objDados["descricao"].ToString();
                        txtTamanho.Text = objDados["tamanho"].ToString();
                        if (objDados["foto"].ToString() != "")
                        {
                            byte[] imgbyte1 = (byte[])objDados["foto"];
                            try
                            {
                                pcbFoto.Image = classUtil.RecuperaImagem(imgbyte1);
                            }
                            catch
                            {
                                MessageBox.Show("Imagem 1 com problema na abertura", "Imagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                objCnx.Close();
                Cursor.Current = Cursors.Default;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ->" + e.Message);
                Cursor.Current = Cursors.Default;
            }

        }

        public void deletar(MaterialSkin.Controls.MaterialSingleLineTextField txtId)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                Conexao objConexao = new Conexao();
                objConexao.ConexaoDB();

                var objDados = objConexao.objDados;
                var objCmd = objConexao.objComando;
                var objCnx = objConexao.objConect;

                objCnx.Close();
                objCnx.Open();

                string sql_Select = "DELETE FROM produtos WHERE id = '" + txtId.Text + "'";
                objCmd.CommandText = sql_Select;
                objCmd.Connection = objCnx;
                objDados = objCmd.ExecuteReader();
                if (objDados.RecordsAffected > 0)
                {
                    MessageBox.Show("Deletado com sucesso !");

                }
                else
                {
                    MessageBox.Show("Falha ao deletar!");
                }
                objCnx.Close();
                Cursor.Current = Cursors.Default;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ->" + e.Message);
                Cursor.Current = Cursors.Default;
            }
        }

    }
}
