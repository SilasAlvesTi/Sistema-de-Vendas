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

namespace Sistema_de_Vendas.Forms.Cadastro
{
    public partial class BaseCriarEditarForm : Form
    {
        public BaseCriarEditarForm()
        {
            InitializeComponent();

            this.DialogResult = DialogResult.Cancel;
        }
        
        private int clienteId = 0;

        public void EditarCliente(Cliente cliente)
        {
            this.txtTitulo.Text = "Editar Cliente";

            this.lblId.Text = "" + cliente.Id;
            this.txtNome.Text = cliente.Nome;

            this.clienteId = cliente.Id;
            btnAdicionar_Click(this, new EventArgs());
        }

        public void btnAdicionar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Id = this.clienteId;
            cliente.Nome = this.txtNome.Text;
            ClienteService clienteService = new ClienteService();

            if (cliente.Id == 0)
            {
                clienteService.AdicionarCliente(cliente);
            }
            else
            {
                clienteService.EditarCliente(cliente);
            }


            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
