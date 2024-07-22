using Microsoft.Data.SqlClient;
using Sistema_de_Vendas.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Vendas.Repositories
{
    internal class ClienteRepository : IRepository<Cliente>
    {
        private readonly string _connectionString;
        public ClienteRepository() 
        {
            _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }
        public Cliente Adicionar(Cliente entidade)
        {
            throw new NotImplementedException();
        }

        public Cliente Apagar(Cliente entidade)
        {
            throw new NotImplementedException();
        }

        public Cliente Editar(Cliente entidade)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> GetAll()
        {
            var clientes = new List<Cliente>();

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM clientes";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Cliente cliente = new Cliente();
                                cliente.Id = reader.GetInt32(0);
                                cliente.Nome = reader.GetString(1);
                                cliente.CreatedAt = reader.GetDateTime(2).ToString();
                                clientes.Add(cliente);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return clientes;
        }
    }
}
