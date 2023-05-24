using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDePedidos.Historico
{
    internal class Pedido
    {
        public string Produto { get; set; }
        public Cliente titular { get; set; }
        public int NumeroPedido { get; set; }
        public double ValorProduto { get; set; }
        public double ValorFrete { get; set; }
        public double ValorTotal { get; set; }
    }
}
