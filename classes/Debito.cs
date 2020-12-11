using System;

namespace Nova_pasta.classes
{
    public class Debito
    {
        internal string bandeira;
        internal string numero;
        internal string titular;
        internal string cvv;
        private float saldo = 600;
        public float SaldoNaConta{
            get{return saldo;}
            set{saldo = value;}
        }

        public void Pagar(float valor)
        {
            Console.WriteLine($"Você fez um pagamento de R${valor}");
        }

        internal bool Cancelar()
        {
            throw new NotImplementedException();
        }

        internal bool SalvarCartao()
        {
            throw new NotImplementedException();
        }
    }
}