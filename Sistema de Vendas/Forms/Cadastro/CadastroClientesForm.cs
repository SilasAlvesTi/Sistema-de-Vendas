using Sistema_de_Vendas.Forms.Cadastro;
using Sistema_de_Vendas.Models;
using Sistema_de_Vendas.Services;
using System.Data;
using System.Diagnostics;

namespace Sistema_de_Vendas.Forms
{
    public partial class CadastroClientesForm : BaseCadastroForm
    {
        public CadastroClientesForm()
        {
            InitializeComponent();
            this.lblCadastroTitulo.Text = "Cadastro de Clientes";
            this.lblDescricao.Text = "Nome";
            ListarClientes();
        }

        private void CadastroClientesForm_Load(object sender, EventArgs e)
        {

        }

        private async void ListarClientes()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Nome");

            ClienteService clienteService = new ClienteService();
            var clientes = await clienteService.GetAllClientes();
            foreach (var cliente in clientes)
            {
                var row = dataTable.NewRow();

                row["ID"] = cliente.Id;
                row["Nome"] = cliente.Nome;

                dataTable.Rows.Add(row);
            }
            this.dgvTabela.DataSource = dataTable;
        }

        private void lblDescricao_Click(object sender, EventArgs e)
        {

        }

        private void Adicionar(object sender, EventArgs e)
        {
            BaseCriarEditarForm criarEditarForm = new BaseCriarEditarForm();
            if (criarEditarForm.ShowDialog() == DialogResult.OK)
            {
                ListarClientes();
            }
        }

        private async void Editar(object sender, EventArgs e)
        {
            var val = this.dgvTabela.SelectedRows[0]?.Cells[0].Value.ToString();
            if (val is null || val.Length is 0)
                return;

            int clienteId = int.Parse(val);

            var clienteService = new ClienteService();
            var cliente = await clienteService.GetClienteById(clienteId);

            if (cliente is null) return;

            BaseCriarEditarForm editarForm = new BaseCriarEditarForm();
            editarForm.EditarCliente(cliente);

            if (editarForm.ShowDialog() == DialogResult.OK)
            {
                ListarClientes();
            }
        }

        private async void Deletar(object sender, EventArgs e)
        {
            var val = this.dgvTabela.SelectedRows[0]?.Cells[0].Value.ToString();
            if (val is null || val.Length is 0)
                return;

            int clienteId = int.Parse(val);

            var clienteService = new ClienteService();

            await clienteService.DeletarCliente(clienteId);

            ListarClientes();

        }

    }
}
