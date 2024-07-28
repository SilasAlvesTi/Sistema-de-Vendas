using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Sistema_de_Vendas.Models
{
    public class Venda
    {
        [JsonPropertyName("clienteID")]
        public int ClienteID { get; set; }
        [JsonPropertyName("itensVenda")]
        public List<ItemVenda> ItensVenda { get; set; } = new List<ItemVenda>();
    }
}
