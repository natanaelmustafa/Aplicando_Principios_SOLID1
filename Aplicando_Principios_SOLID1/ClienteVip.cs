using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicando_Principios_SOLID1 {
    internal class ClienteVip : ICalculoDescontoStatusConta {
        public decimal AplicarDescontoStatusConta(decimal precoProduto) {
            return (precoProduto - (Constantes.DESCONTO_CLIENTE_VIP * precoProduto));
        }
    }
}
