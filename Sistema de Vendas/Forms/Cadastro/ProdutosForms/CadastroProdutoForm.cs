using Sistema_de_Vendas.Forms.Cadastro;
using Sistema_de_Vendas.Forms.Cadastro.ProdutosForms;
using Sistema_de_Vendas.Services;
using System.Data;

namespace Sistema_de_Vendas.Forms
{
    public partial class CadastroProdutoForm : BaseCadastroForm
    {
        public CadastroProdutoForm()
        {
            InitializeComponent();
            this.lblCadastroTitulo.Text = "Cadastro de Produtos";
            this.lblDescricao.Text = "Descrição";
            ListarProdutos();
        }

        private void CadastroProdutoForm_Load(object sender, EventArgs e)
        {

        }

        private async void ListarProdutos()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Nome");
            dataTable.Columns.Add("Preço");
            dataTable.Columns.Add("Estoque");

            ProdutoService produtoService = new ProdutoService();
            var produtos = await produtoService.GetAllProdutos();
            foreach (var produto in produtos)
            {
                var row = dataTable.NewRow();

                row["ID"] = produto.Id;
                row["Nome"] = produto.Nome;
                row["Preço"] = produto.Preco;
                row["Estoque"] = produto.Estoque;

                dataTable.Rows.Add(row);
            }
            this.dgvTabela.DataSource = dataTable;
        }

        private void Adicionar(object sender, EventArgs e)
        {
            CriarEditarProdutoForm criarEditarForm = new CriarEditarProdutoForm();
            if (criarEditarForm.ShowDialog() == DialogResult.OK)
            {
                ListarProdutos();
            }
        }

        private async void Editar(object sender, EventArgs e)
        {
            var val = this.dgvTabela.SelectedRows[0]?.Cells[0].Value.ToString();
            if (val is null || val.Length is 0)
                return;

            int produtoId = int.Parse(val);

            var produtoService = new ProdutoService();
            var produto = await produtoService.GetProdutoById(produtoId);

            if (produto is null) return;

            CriarEditarProdutoForm editarForm = new CriarEditarProdutoForm();
            editarForm.EditarProduto(produto);

            if (editarForm.ShowDialog() == DialogResult.OK)
            {
                ListarProdutos();
            }
        }

        private async void Deletar(object sender, EventArgs e)
        {
            var val = this.dgvTabela.SelectedRows[0]?.Cells[0].Value.ToString();
            if (val is null || val.Length is 0)
                return;

            int produtoId = int.Parse(val);

            var produtoService = new ProdutoService();

            await produtoService.DeletarProduto(produtoId);

            ListarProdutos();

        }
    }
}
