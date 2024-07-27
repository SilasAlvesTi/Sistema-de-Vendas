using Sistema_de_Vendas.Models;
using Sistema_de_Vendas.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Vendas.Forms.Cadastro.ProdutosForms
{
    public partial class CriarEditarProdutoForm : Form
    {
        public CriarEditarProdutoForm()
        {
            InitializeComponent();
        }

        private int produtoId = 0;

        public void EditarProduto(Produto produto)
        {
            this.txtTitulo.Text = "Editar Cliente";

            this.lblId.Text = "" + produto.Id;
            this.txtNome.Text = produto.Nome;
            this.txtPreco.Text = produto.Preco.ToString();
            this.txtEstoque.Text = produto.Estoque.ToString();

            this.produtoId = produto.Id;
            btnAdicionar_Click(this, new EventArgs());
        }


        public void btnAdicionar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Id = this.produtoId;
            produto.Nome = this.txtNome.Text;
            produto.Preco = Decimal.Parse(this.txtPreco.Text);
            produto.Estoque = Int32.Parse(this.txtEstoque.Text);

            ProdutoService produtoService = new ProdutoService();

            if (produto.Id == 0)
            {
                produtoService.AdicionarProduto(produto);
            }
            else
            {
                produtoService.EditarProduto(produto);
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
