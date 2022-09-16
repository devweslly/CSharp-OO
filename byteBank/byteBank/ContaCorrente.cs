using byteBank.Titular;

namespace byteBank
{
    public class ContaCorrente
    {
        // Os campos de uma classe possuem valores padrão
        public Cliente titular;
        public string conta;
        public int numero_agencia;
        public string nome_agencia;
        public double saldo;

        // Método - Comportamento

        // Retorna um valor, pois o método tem um tipo (neste caso, TRUE)
        public bool Sacar(double valor)
        {
            if (saldo < valor || valor < 0)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                return true;
            }
        }

        // Este método void não retorna um valor
        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
            }
        }

        // O método Transferir possui mais de um parametro
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if(saldo < valor || valor < 0)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                destino.saldo += valor;
                return true;
            }
        }
    }
}