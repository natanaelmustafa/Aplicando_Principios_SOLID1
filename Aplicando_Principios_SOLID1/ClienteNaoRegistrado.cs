using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicando_Principios_SOLID1 {
    internal class ClienteNaoRegistrado : ICalculoDescontoStatusConta {
        public decimal AplicarDescontoStatusConta(decimal preco) {
            return preco;
        }
    }
}
