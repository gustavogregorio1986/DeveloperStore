using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperStore.Dominio.Dominio
{
    public class Venda
    {
        public int Id { get; set; }

        public int NumeroVenda { get; set; }

        public DateTime DataTotalVenda { get; set; }

        public string? Cliente { get; set; }

        public double ValorTotalVenda { get; set; }

        public string? FilialVenda { get; set; }

        public string? Produto { get; set; }

        public int Quantidade { get; set; }

        public decimal PrecoUnitario { get; set; }

        public double Desconto { get; set; }

        public double ValorTotalItem { get; set; }

        public int Status { get; set; }
    }
}
