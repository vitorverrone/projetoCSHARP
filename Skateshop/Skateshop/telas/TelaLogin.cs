using Skateshop.sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skateshop.telas
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnCriaConta_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaCadastro cadastro = new TelaCadastro();
            cadastro.Show();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            Login senha = new Login();
            string logou = senha.loga(txtEmail, txtSenha);

            if (logou == "")
            {
                MessageBox.Show("Login ou senha incorretos!");
            }
            else
            {
                MessageBox.Show("Bem vindo!");
                this.Hide();
                TelaInicio inicio = new TelaInicio();
                inicio.Show();
            }
        }
    }
}
