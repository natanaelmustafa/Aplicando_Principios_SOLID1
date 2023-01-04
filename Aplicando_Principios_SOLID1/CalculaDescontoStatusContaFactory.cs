using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicando_Principios_SOLID1 {
    internal class CalculaDescontoStatusContaFactory : ICalculaDescontoStatusContaFactory {
        public ICalculoDescontoStatusConta GetCalculoDescontoStatusConta(StatusContaCliente statusContaCliente) {

            ICalculoDescontoStatusConta calcular;

            switch (statusContaCliente) {
                case StatusContaCliente.NaoRegistrado:
                    calcular = new ClienteNaoRegistrado();
                    break;
                case StatusContaCliente.ClienteComum:
                    calcular = new ClienteComum();
                    break;
                case StatusContaCliente.ClienteEspecial:
                    calcular = new ClienteEspecial();
                    break;
                case StatusContaCliente.ClienteVip:
                    calcular = new ClienteVip();
                    break;
                default: throw new NotImplementedException();
            }
            return calcular;
        }
    }
}
