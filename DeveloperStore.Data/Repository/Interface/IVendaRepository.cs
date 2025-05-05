using DeveloperStore.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperStore.Data.Repository.Interface
{
    public interface IVendaRepository
    {
        Task<Venda> AdicionarVenda(Venda venda);

        Task<List<Venda>> ListarVendas();

        Task<List<Venda>> ListarCancelados(int cancelar);

        Task<List<Venda>> ListarNaocancelados(int naocancelar);

        Task<Venda?> ObterPorIdAsync(Guid id);

        Task AtualizarAsync(Venda venda);


        Task DeletarAsync(Venda venda);
    }
}
