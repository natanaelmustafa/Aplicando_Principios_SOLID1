﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicando_Principios_SOLID1 {
    internal interface ICalculaDescontoFidelidade {

        decimal AplicarDescontoFidelidade(decimal preco, int tempoEmAnos);
    }
}
