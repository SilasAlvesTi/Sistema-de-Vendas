using Sistema_de_Vendas.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Vendas
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            var cadastroClientes = new CadastroClientesForm();
            cadastroClientes.ShowDialog();
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            var cadastroProdutos = new CadastroProdutoForm();
            cadastroProdutos.ShowDialog();
        }
    }
}
