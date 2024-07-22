using Sistema_de_Vendas.Models;
using Sistema_de_Vendas.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Vendas.Services
{
    internal class ClienteService
    {
        private readonly ClienteRepository _clienteRepository;

        public ClienteService()
        {
            _clienteRepository = new ClienteRepository();
        }

        public List<Cliente> GetAllClientes()
        {
            return _clienteRepository.GetAll().ToList();
        }

        public void AdicionarCliente(Cliente cliente)
        {
            _clienteRepository.Adicionar(cliente);
        }
    }
}
