using System;

namespace Aplicando_Principios_SOLID1
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculaDescontoFidelidade descFidelidade = new CalculaDescontoFidelidade();
            ICalculaDescontoStatusContaFactory descStatusConta = new CalculaDescontoStatusContaFactory();

            GerenciadorDeDesconto gerDesc = new GerenciadorDeDesconto(descFidelidade, descStatusConta);

            Console.WriteLine("Valor da compra 1000 e fidelidade 10 anos (5%)\n");
            var resultado1 = gerDesc.AplicarDesconto(1000, StatusContaCliente.ClienteComum, 10);

            Console.WriteLine($"Cliente {StatusContaCliente.ClienteComum}, valor do desconto é de: {resultado1}");
            var resultado2 = gerDesc.AplicarDesconto(1000, StatusContaCliente.ClienteEspecial, 10);
            Console.WriteLine($"Cliente {StatusContaCliente.ClienteEspecial}, valor do desconto é de: {resultado2}");
            var resultado3 = gerDesc.AplicarDesconto(1000, StatusContaCliente.ClienteVip, 10);
            Console.WriteLine($"Cliente {StatusContaCliente.ClienteVip}, valor do desconto é de: {resultado3}");
            Console.WriteLine("\n\nValor da compra 1000 e fidelidade 4 anos (4%)\n");

            var resultado4 = gerDesc.AplicarDesconto(1000, StatusContaCliente.ClienteComum, 4);
            Console.WriteLine($"Cliente {StatusContaCliente.ClienteComum}, valor do desconto é de: {resultado4}");
            var resultado5 = gerDesc.AplicarDesconto(1000, StatusContaCliente.ClienteEspecial, 4);
            Console.WriteLine($"Cliente {StatusContaCliente.ClienteEspecial}, valor do desconto é de: {resultado5}");
            var resultado6 = gerDesc.AplicarDesconto(1000, StatusContaCliente.ClienteVip, 4);
            Console.WriteLine($"Cliente {StatusContaCliente.ClienteVip}, valor do desconto é de: {resultado6}");

            Console.ReadLine();
        }
    }
}
