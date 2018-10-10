using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skateshop.sql
{
    class Login
    {
        public string loga(MaterialSkin.Controls.MaterialSingleLineTextField txtUser, MaterialSkin.Controls.MaterialSingleLineTextField txtSenha)
        {
            string logou = "";
            string senha = "";
            if (txtSenha.Text.Length < 5)
            {
                senha = txtSenha.Text;
            }
            else
            {
                MD5 md5Hash = MD5.Create();
                // Converter a String para array de bytes, que é como a biblioteca trabalha.
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(txtSenha.Text));

                // Cria-se um StringBuilder para recompôr a string.
                StringBuilder sBuilder = new StringBuilder();

                // Loop para formatar cada byte como uma String em hexadecimal
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                senha = sBuilder.ToString();
            }


            Conexao objConexao = new Conexao();
            objConexao.ConexaoDB();

            var objDados = objConexao.objDados;
            var objCmd = objConexao.objComando;
            var objCnx = objConexao.objConect;

            objCnx.Close();
            objCnx.Open();

            string sql_Select = "SELECT * FROM usuarios WHERE email = '" + txtUser.Text + "' and senha = '" + senha + "'";
            objCmd.CommandText = sql_Select;
            objCmd.Connection = objCnx;
            objDados = objCmd.ExecuteReader();
            if (objDados.HasRows)
            {
                logou = "sim";
            }
            return logou;
        }

        public void criaUsuario(MaterialSkin.Controls.MaterialSingleLineTextField email, MaterialSkin.Controls.MaterialSingleLineTextField txtSenha)
        {
            string senha = "";

            MD5 md5Hash = MD5.Create();
            // Converter a String para array de bytes, que é como a biblioteca trabalha.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(txtSenha.Text));

            // Cria-se um StringBuilder para recompôr a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop para formatar cada byte como uma String em hexadecimal
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            senha = sBuilder.ToString();

            Conexao objConexao = new Conexao();
            objConexao.ConexaoDB();

            var objDados = objConexao.objDados;
            var objCmd = objConexao.objComando;
            var objCnx = objConexao.objConect;

            objCnx.Close();
            objCnx.Open();

            string sql_Select = "INSERT INTO usuarios (email, senha) values ('" + email.Text + "', '" + senha + "');";
            objCmd.CommandText = sql_Select;
            objCmd.Connection = objCnx;
            objDados = objCmd.ExecuteReader();
            if (objDados.RecordsAffected > 0)
            {
                MessageBox.Show("Incluído com sucesso !");
            }
            else
            {
                MessageBox.Show("Falha na inclusão !");
            }
            objCnx.Close();
        }

        public void MontaGrid(DataGridView gridUsuarios)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                gridUsuarios.Rows.Clear();
                Conexao objConexao = new Conexao();
                objConexao.ConexaoDB();

                var objDados = objConexao.objDados;
                var objCmd = objConexao.objComando;
                var objCnx = objConexao.objConect;
                objCnx.Close();
                objCnx.Open();

                string sql_Select = "SELECT * FROM usuarios";
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
                        gridUsuarios.Rows.Add(
                            objDados["idUsuario"].ToString(),
                            objDados["email"].ToString()
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

        public void limpaCampos(MaterialSkin.Controls.MaterialSingleLineTextField txtCodigo, MaterialSkin.Controls.MaterialSingleLineTextField txtEmail, MaterialSkin.Controls.MaterialSingleLineTextField txtConfEmail, MaterialSkin.Controls.MaterialSingleLineTextField txtSenha, MaterialSkin.Controls.MaterialSingleLineTextField txtConfSenha)
        {
            txtEmail.Text = "";
            txtCodigo.Text = "";
            txtConfEmail.Text = "";
            txtSenha.Text = "";
            txtConfSenha.Text = "";
        }

        public void montaSelect(int id, MaterialSkin.Controls.MaterialSingleLineTextField txtId, MaterialSkin.Controls.MaterialSingleLineTextField txtEmail)
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
                string sql_Select = "SELECT * FROM usuarios WHERE idUsuario = " + id;
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
                        txtEmail.Text = objDados["email"].ToString();
                        txtId.Text = objDados["idUsuario"].ToString();
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

                string sql_Select = "DELETE FROM usuarios WHERE idUsuario = '" + txtId.Text + "'";
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
