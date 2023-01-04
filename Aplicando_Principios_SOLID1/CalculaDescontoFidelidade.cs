using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicando_Principios_SOLID1 {
    internal class CalculaDescontoFidelidade : ICalculaDescontoFidelidade {
        public decimal AplicarDescontoFidelidade(decimal preco, int tempoEmAnos) {

            decimal descontoPorFidelidade = (tempoEmAnos > Constantes.DECONTO_MAXIMO_POR_FIDELIDADE) ?
                (decimal)Constantes.DECONTO_MAXIMO_POR_FIDELIDADE / 100 : (decimal)tempoEmAnos / 100;
            return preco - (preco * descontoPorFidelidade);
        }
    }
}
