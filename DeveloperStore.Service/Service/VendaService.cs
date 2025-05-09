﻿using DeveloperStore.Data.Repository.Interface;
using DeveloperStore.Dominio.Dominio;
using DeveloperStore.Service.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperStore.Service.Service
{
    public class VendaService : IVendaService
    {
        private readonly IVendaRepository _vendaRepository;

        public VendaService(IVendaRepository vendaRepository)
        {
            _vendaRepository = vendaRepository;
        }

        public async Task<Venda> AdicionarVenda(Venda venda)
        {
            return await _vendaRepository.AdicionarVenda(venda); 
        }

        public async Task AtualizarAsync(Venda venda)
        {
            await _vendaRepository.AtualizarAsync(venda);
        }

        public async Task<bool> DeletarVendaAsync(Guid id)
        {
            var venda = await _vendaRepository.ObterPorIdAsync(id);
            if (venda == null) return false;

            await _vendaRepository.DeletarAsync(venda);
            return true;
        }

        public async Task<List<Venda>> ListarCancelados(int cancelar)
        {
            return await _vendaRepository.ListarCancelados(cancelar);
        }

        public async Task<List<Venda>> ListarNaocancelados(int naocancelar)
        {
            return await _vendaRepository.ListarNaocancelados(naocancelar);
        }

        public async Task<List<Venda>> ListarVendas()
        {
            return await _vendaRepository.ListarVendas();
        }

        public async Task<Venda?> ObterPorIdAsync(Guid id)
        {
            return await _vendaRepository.ObterPorIdAsync(id);
        }
    }
}
