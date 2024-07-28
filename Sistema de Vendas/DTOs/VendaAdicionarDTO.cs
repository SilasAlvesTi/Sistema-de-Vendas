using Sistema_de_Vendas.Models;

namespace Sistema_de_Vendas.DTOs
{
    internal record VendaAdicionarDTO(int ClienteID, List<ItemVenda> ItensVenda);
}
