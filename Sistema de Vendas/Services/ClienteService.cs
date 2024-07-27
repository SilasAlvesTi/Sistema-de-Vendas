using Sistema_de_Vendas.Models;
using System.Configuration;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
namespace Sistema_de_Vendas.Services
{
    internal class ClienteService
    {
        private readonly string _urlBase;

        public ClienteService()
        {
            _urlBase = ConfigurationManager.AppSettings["UrlBase"] + "clientes";
        }

        public async Task<IEnumerable<Cliente>> GetAllClientes()
        {
            using (var httpCliente = new HttpClient())
            {
                var response = await httpCliente.GetAsync(_urlBase);
                var jsonString = await response.Content.ReadAsStringAsync();

                var clientes = JsonSerializer.Deserialize<List<Cliente>>(jsonString);

                return clientes;

            }
        }

        public async Task AdicionarCliente(Cliente cliente)
        {
            using (var httpCliente = new HttpClient())
            {
                using StringContent jsonContent =  new(JsonSerializer.Serialize(cliente));
                jsonContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                using HttpResponseMessage response = await httpCliente.PostAsync(_urlBase, jsonContent);
                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine("Cliente adicionado com sucesso.");
                }
                else
                {
                    var result = await response.Content.ReadAsStringAsync();
                    Debug.WriteLine($"Erro ao adicionar cliente: {result}");
                }

            }
        }

        public async Task<Cliente?> EditarCliente(Cliente cliente)
        {
            using (var httpCliente = new HttpClient())
            {
                using StringContent jsonContent = new(JsonSerializer.Serialize(cliente));
                jsonContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                using HttpResponseMessage response = await httpCliente.PutAsync(_urlBase + $"/{cliente.Id}", jsonContent);
                return cliente;
            }
        }

        public async Task<Cliente?> GetClienteById(int id)
        {
            using (var httpCliente = new HttpClient())
            {
                var response = await httpCliente.GetAsync(_urlBase + $"/{id}");
                var jsonString = await response.Content.ReadAsStringAsync();

                var cliente = JsonSerializer.Deserialize<Cliente>(jsonString);

                return cliente;

            }
        }
    }
}
