using DeveloperStore.Data.Context;
using DeveloperStore.Data.Repository.Interface;
using DeveloperStore.Dominio.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperStore.Data.Repository
{
    public class VendaRepository : IVendaRepository
    {
        private readonly DbContexto _db;

        public VendaRepository(DbContexto db)
        {
            _db = db;
        }

        public async Task<Venda> AdicionarVenda(Venda venda)
        {
            _db.Vendas.Add(venda);
            await _db.SaveChangesAsync();
            return venda;
        }

        public async Task<List<Venda>> ListarCancelados(int cancelar)
        {
            return await _db.Vendas.Where(x => x.Status == 0).
                ToListAsync();
        }

        public async Task<List<Venda>> ListarNaocancelados(int naocancelar)
        {
            return await _db.Vendas.Where(x => x.Status == 1).
                ToListAsync();
        }

        public async Task<List<Venda>> ListarVendas()
        {
            return await _db.Vendas.ToListAsync();
        }
    }
}
