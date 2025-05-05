using DeveloperStore.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperStore.Service.Service.Interface
{
    public interface IVendaService
    {
        Task<Venda> AdicionarVenda(Venda venda);

        Task<List<Venda>> ListarVendas();
    }
}
