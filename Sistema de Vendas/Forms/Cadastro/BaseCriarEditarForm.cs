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

namespace Sistema_de_Vendas.Forms.Cadastro
{
    public partial class BaseCriarEditarForm : Form
    {
        public BaseCriarEditarForm()
        {
            InitializeComponent();

            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Id = 0;
            cliente.Nome = this.txtNome.Text;

            ClienteService clienteService = new ClienteService();
            clienteService.AdicionarCliente(cliente);


            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
