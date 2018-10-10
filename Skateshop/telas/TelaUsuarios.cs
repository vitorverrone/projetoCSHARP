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
    public partial class TelaUsuarios : Form
    {
        Login usuarios = new Login();

        public TelaUsuarios()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Regex emailReg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
            if (txtEmail.Text == "" || txtConfEmail.Text == "" || txtSenha.Text == "" || txtConfSenha.Text == "")
            {
                MessageBox.Show("Todos os campos são obrigatórios!");
            }
            else
            {
                if (emailReg.IsMatch(txtEmail.Text))
                {
                    if (txtEmail.Text == txtConfEmail.Text)
                    {
                        if (txtSenha.Text == txtConfSenha.Text)
                        {
                            usuarios.criaUsuario(txtEmail, txtSenha);
                            usuarios.MontaGrid(gridUsuarios);
                            usuarios.limpaCampos(txtCodigo, txtEmail, txtConfEmail, txtSenha, txtConfSenha);
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
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            usuarios.limpaCampos(txtCodigo, txtEmail, txtConfEmail, txtSenha, txtConfSenha);
            btnIncluir.Enabled = true;
            txtConfEmail.Enabled = true;
            txtSenha.Enabled = true;
            txtConfSenha.Enabled = true;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você realmente deseja deletar o usuario " + txtEmail.Text + "?", "Deletar Usuário?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                usuarios.deletar(txtCodigo);
                usuarios.limpaCampos(txtCodigo, txtEmail, txtConfEmail, txtSenha, txtConfSenha);
                usuarios.MontaGrid(gridUsuarios);
                btnDeletar.Enabled = false;
            }
        }

        private void gridUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            usuarios.limpaCampos(txtCodigo, txtEmail, txtConfEmail, txtSenha, txtConfSenha);
            int id = Convert.ToInt32(gridUsuarios.CurrentRow.Cells[0].Value);
            btnDeletar.Enabled = true;
            btnNovo.Enabled = true;
            btnIncluir.Enabled = false;
            usuarios.montaSelect(id, txtCodigo, txtEmail);
            txtConfEmail.Enabled = false;
            txtSenha.Enabled = false;
            txtConfSenha.Enabled = false;
        }

        private void TelaUsuarios_Load(object sender, EventArgs e)
        {
            usuarios.MontaGrid(gridUsuarios);
            btnDeletar.Enabled = false;
            btnIncluir.Enabled = false;
        }
    }
}
