using System;

namespace Aplicando_Principios_SOLID1 {
    internal class GerenciadorDeDesconto
    {   
        readonly ICalculaDescontoFidelidade _descontoFidelidade;
        readonly ICalculaDescontoStatusContaFactory _descontoStatusConta;
        public GerenciadorDeDesconto(ICalculaDescontoFidelidade descontoFidelidade, ICalculaDescontoStatusContaFactory descontoStatusConta) {
            _descontoFidelidade = descontoFidelidade;
            _descontoStatusConta = descontoStatusConta;
        }
      
        public decimal AplicarDesconto(decimal precoProduto, StatusContaCliente statusContaCliente, int tempoDeContaEmAnos)
        {
            decimal precoAposDesconto = 0;

            precoAposDesconto = _descontoStatusConta.GetCalculoDescontoStatusConta(statusContaCliente)
                .AplicarDescontoStatusConta(precoProduto);

            precoAposDesconto = _descontoFidelidade.AplicarDescontoFidelidade(precoAposDesconto, tempoDeContaEmAnos); 
           
            return precoAposDesconto;
        }
    }
}
