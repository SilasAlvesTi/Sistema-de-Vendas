using Sistema_de_Vendas.Forms.Cadastro;
using Sistema_de_Vendas.Services;
using System.Data;

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

        private void ListarClientes()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Nome");

            ClienteService clienteService = new ClienteService();
            var clientes = clienteService.GetAllClientes();

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
    }
}
