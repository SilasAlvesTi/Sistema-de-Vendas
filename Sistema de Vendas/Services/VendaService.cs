using Sistema_de_Vendas.DTOs;
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
    internal class VendaService
    {
        private readonly string _urlBase;

        public VendaService()
        {
            _urlBase = ConfigurationManager.AppSettings["UrlBase"] + "vendas";
        }

        public async Task AdicionarVenda(VendaAdicionarDTO vendaAdicionarDTO)
        {
            using (var httpCliente = new HttpClient())
            {
                using StringContent jsonContent = new(JsonSerializer.Serialize(vendaAdicionarDTO));
                jsonContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var body = await jsonContent.ReadAsStringAsync();
                Debug.WriteLine(body);
                using HttpResponseMessage response = await httpCliente.PostAsync(_urlBase, jsonContent);
                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine("Venda adicionada com sucesso.");
                }
                else
                {
                    var result = await response.Content.ReadAsStringAsync();
                    Debug.WriteLine($"Erro ao adicionar cliente: {result}");
                }

            }
        }
    }
}
