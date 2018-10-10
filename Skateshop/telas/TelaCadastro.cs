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
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void txtClose_Click(object sender, EventArgs e)
        {
            TelaLogin login = new TelaLogin();
            login.Show();
            this.Close();
        }

        private void txtCriarConta_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string confEmail = txtConfEmail.Text;
            string senha = txtSenha.Text;
            string confSenha = txtConfSenha.Text;
            int adm = 0;

            Regex emailReg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            Conexao objConexao = new Conexao();
            objConexao.ConexaoDB();

            var objDados = objConexao.objDados;
            var objCmd = objConexao.objComando;
            var objCnx = objConexao.objConect;

            objCnx.Close();
            objCnx.Open();

            string sql_Select = "SELECT * FROM usuarios WHERE email = '" + txtEmail.Text + "'";
            objCmd.CommandText = sql_Select;
            objCmd.Connection = objCnx;
            objDados = objCmd.ExecuteReader();
            if (objDados.HasRows)
            {
                MessageBox.Show("Esse e-mail já esta cadastrado em nosso sistema");
            }
            else
            {
                if (senha == "")
                {
                    MessageBox.Show("O campo de senha deve ser preenchido");
                }

                if (emailReg.IsMatch(email))
                {
                    if (email == confEmail)
                    {
                        if (senha == confSenha)
                        {
                            Login classLogin = new Login();
                            classLogin.criaUsuario(txtEmail, txtSenha);
                            TelaLogin login = new TelaLogin();
                            login.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("As senhas devem coincidir!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Os e-mails devem coincidir!");
                    }
                }
                else
                {
                    MessageBox.Show("Email Inválido!");
                }
            }
        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
