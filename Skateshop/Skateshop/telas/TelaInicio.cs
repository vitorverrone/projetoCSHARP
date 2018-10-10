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
    public partial class TelaInicio : Form
    {
        public TelaInicio()
        {
            InitializeComponent();
        }

        private void txtClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja se deslogar?", "Logout", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                TelaLogin login = new TelaLogin();
                login.Show();
            }
        }

        private void TelaInicio_Load(object sender, EventArgs e)
        {
            
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            this.panelTelas.Controls.Clear();
            this.IsMdiContainer = true;
            TelaProdutos produtos = new TelaProdutos();
            produtos.MdiParent = this;
            this.panelTelas.Controls.Add(produtos);
            produtos.Show();
        }
        
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.panelTelas.Controls.Clear();
            this.IsMdiContainer = true;
            TelaUsuarios users = new TelaUsuarios();
            users.MdiParent = this;
            this.panelTelas.Controls.Add(users);
            users.Show();
        }
    }
}
