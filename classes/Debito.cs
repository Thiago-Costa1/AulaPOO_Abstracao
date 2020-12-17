using System;

namespace Nova_pasta.classes
{
    public class Debito : Cartao
    {
        private float saldo = 600;
        public float SaldoNaConta{
            get{return saldo;}
            set{saldo = value;}
        }

        public void Pagar(float valor)
        {
            Console.WriteLine($"Você fez um pagamento de R${valor}");
        }

       
        
    }
}