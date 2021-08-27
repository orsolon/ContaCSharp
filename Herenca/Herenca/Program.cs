using System; 

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta1 = new ContaCorrente(20);
            var conta2 = new ContaInvestimento(30);
            var conta3 = new ContaPoupanca(14);

            var contaDestino = ConverteConta<ContaCorrente, ContaPoupanca>(conta1);
            
        }

        public static G ConverteConta<T, G>(T contaOrigem)
            where T : conta
            where G : conta
        {
            G contaDestino = Activator.CreateInstance<G>();
            return contaDestino;

        }
    }
}
