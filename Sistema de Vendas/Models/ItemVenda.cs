using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Sistema_de_Vendas.Models
{
    public class ItemVenda
    {
        [JsonPropertyName("produtoID")]
        public int ProdutoID { get; set; }
        [JsonPropertyName("quantidade")]
        public int Quantidade { get; set; }
        [JsonPropertyName("precoUnitario")]
        public decimal PrecoUnitario { get; set; }

    }
}
