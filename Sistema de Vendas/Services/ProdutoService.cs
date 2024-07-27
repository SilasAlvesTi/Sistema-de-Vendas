using Sistema_de_Vendas.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Sistema_de_Vendas.Services
{
    internal class ProdutoService
    {
        private readonly string _urlBase;

        public ProdutoService()
        {
            _urlBase = ConfigurationManager.AppSettings["UrlBase"] + "produtos";
        }

        public async Task<IEnumerable<Produto>> GetAllProdutos()
        {
            using (var httpCliente = new HttpClient())
            {
                var response = await httpCliente.GetAsync(_urlBase);
                var jsonString = await response.Content.ReadAsStringAsync();

                var produtos = JsonSerializer.Deserialize<List<Produto>>(jsonString);

                return produtos;
            }
        }

        public async Task<Produto?> GetProdutoById(int id)
        {
            using (var httpCliente = new HttpClient())
            {
                var response = await httpCliente.GetAsync(_urlBase + $"/{id}");
                var jsonString = await response.Content.ReadAsStringAsync();

                var produto = JsonSerializer.Deserialize<Produto>(jsonString);

                return produto;
            }
        }

        public async Task AdicionarProduto(Produto produto)
        {
            using (var httpCliente = new HttpClient())
            {
                using StringContent jsonContent = new(JsonSerializer.Serialize(produto));
                jsonContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                using HttpResponseMessage response = await httpCliente.PostAsync(_urlBase, jsonContent);
                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine("Produto adicionado com sucesso.");
                }
                else
                {
                    var result = await response.Content.ReadAsStringAsync();
                    Debug.WriteLine($"Erro ao adicionar produto: {result}");
                }

            }
        }

        public async void EditarProduto(Produto produto)
        {
            using (var httpCliente = new HttpClient())
            {
                using StringContent jsonContent = new(JsonSerializer.Serialize(produto));
                jsonContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                using HttpResponseMessage response = await httpCliente.PutAsync(_urlBase + $"/{produto.Id}", jsonContent);
            }
        }

        public async Task DeletarProduto(int produtoId)
        {
            using (var httpCliente = new HttpClient())
            {
                var produto = await this.GetProdutoById(produtoId);
                using HttpResponseMessage response = await httpCliente.DeleteAsync(_urlBase + $"/{produto.Id}");
            }
        }
    }
}
