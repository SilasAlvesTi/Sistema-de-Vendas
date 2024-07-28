using Sistema_de_Vendas.DTOs;
using Sistema_de_Vendas.Models;
using Sistema_de_Vendas.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Vendas.Forms.Vender
{
    public partial class VenderForm : Form
    {
        public VenderForm()
        {
            InitializeComponent();
            InicializarTextBoxComNomesCliente();
            //InicializarTextBoxComNomesProduto();
        }

        private void VenderForm_Load(object sender, EventArgs e)
        {
            // Configuração inicial do FlowLayoutPanel (se necessário)
            painelProdutos.FlowDirection = FlowDirection.TopDown;
            painelProdutos.WrapContents = false;
            painelProdutos.AutoScroll = true;
        }

        private async void InicializarTextBoxComNomesCliente()
        {
            ClienteService clienteService = new ClienteService();
            var clientes = await clienteService.GetAllClientes();

            var clienteNomeEID = clientes.ToDictionary(c => c.Nome, c => c.Id);

            var nomes = (clientes.Select(cliente => cliente.Nome).ToArray());


            AutoCompleteStringCollection allowedTypes = new AutoCompleteStringCollection();
            allowedTypes.AddRange(nomes);
            txtClienteNome.AutoCompleteCustomSource = allowedTypes;
            txtClienteNome.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtClienteNome.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        /*private async void InicializarTextBoxComNomesProduto()
        {
            ProdutoService produtoService = new ProdutoService();
            var produtos = await produtoService.GetAllProdutos();

            var clienteNomeEID = produtos.ToDictionary(p => p.Nome, p => p.Id);

            var nomes = (produtos.Select(produto => produto.Nome).ToArray());


            AutoCompleteStringCollection allowedTypes = new AutoCompleteStringCollection();
            allowedTypes.AddRange(nomes);
            txtProdutoNome.AutoCompleteCustomSource = allowedTypes;
            txtProdutoNome.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtProdutoNome.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }*/


        private void AdicionarCampo(object sender, EventArgs e)
        {
            Label lblProdutoNome = new Label();
            lblProdutoNome.Text = "Produto: ";
            lblProdutoNome.AutoSize = true;
            lblProdutoNome.Size = new Size(50, 15);

            TextBox novaTxtBoxProduto = new TextBox();
            novaTxtBoxProduto.Size = new Size(322, 23);
            novaTxtBoxProduto.Tag = "txtProdutoNome";

            Label lblQuantidade = new Label();
            lblQuantidade.Text = "Quantidade: ";
            lblQuantidade.AutoSize = true;
            lblQuantidade.Size = new Size(50, 15);

            TextBox novaTxtBoxQuantidade = new TextBox();
            novaTxtBoxQuantidade.Size = new Size(68, 23);
            novaTxtBoxQuantidade.Tag = "txtQuantidade";

            // Adicionar a TextBox ao FlowLayoutPanel
            painelProdutos.Controls.Add(lblProdutoNome);
            painelProdutos.Controls.Add(novaTxtBoxProduto);
            painelProdutos.Controls.Add(lblQuantidade);
            painelProdutos.Controls.Add(novaTxtBoxQuantidade);
        }

        private async Task<List<ItemVenda>> RecuperarItensVenda()
        {
            List<ItemVenda> itensVenda = new List<ItemVenda>();
            ProdutoService produtoService = new ProdutoService();
            var produtos = await produtoService.GetAllProdutos();

            string itemNome = null;
            string itemQuantidade = null;

            foreach (Control control in painelProdutos.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (textBox.Tag.ToString() == "txtProdutoNome")
                    {
                        itemNome = textBox.Text;
                    }
                    else if (textBox.Tag.ToString() == "txtQuantidade")
                    {
                        itemQuantidade = textBox.Text;
                    }

                    
                    if (!string.IsNullOrEmpty(itemNome) && !string.IsNullOrEmpty(itemQuantidade))
                    {
                        ItemVenda itemVenda = new ItemVenda();
                        var produto = produtos.FirstOrDefault((p => p.Nome == itemNome));
                        itemVenda.ProdutoID = produto.Id;
                        itemVenda.Quantidade = Int32.Parse(itemQuantidade);
                        itemVenda.PrecoUnitario = 0.0m;

                        itensVenda.Add(itemVenda);

                        itemNome = null;
                        itemQuantidade = null;
                    }
                }
            }

            return itensVenda;
        }

        private async void SalvarVenda(object sender, EventArgs e)
        {
            string nome = txtClienteNome.Text;
            if (nome is null)
            {
                return;
            }
            // Criar um model venda e itemvenda
            Venda venda = new Venda();
            List<ItemVenda> itensVenda = await RecuperarItensVenda();

            // Procurar pelo nome
            ClienteService clienteService = new ClienteService();
            var clientes = await clienteService.GetAllClientes();

            Cliente cliente = clientes.First(c => c.Nome == nome);

            VendaAdicionarDTO vendaAdicionarDTO = new(cliente.Id, itensVenda);

            // enviar para o service o objeto venda
            VendaService vendaService = new VendaService();
            await vendaService.AdicionarVenda(vendaAdicionarDTO);

            this.DialogResult = DialogResult.Cancel;
        }   
    }
}
