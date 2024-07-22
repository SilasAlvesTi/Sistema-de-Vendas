using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Vendas.Repositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        void Adicionar(T entidade);
        void Editar(T entidade);
        void Apagar(T entidade);
    }
}
