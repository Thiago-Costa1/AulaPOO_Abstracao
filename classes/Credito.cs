using System;

namespace Nova_pasta.classes
{
    public class Credito : Cartao
    {
        private float limite = 3000;
        public float Limite{
            get{return limite;}
            set{limite = value;}
        }

        public void Pagar(float valor, int parcela){
            if(parcela <= 6){
                Console.WriteLine($"Você pagará 5% de juros no total. O valor ficou por: RS{valor + valor*0.05}");
            }else if(parcela >= 7 && parcela <=12){
                Console.WriteLine($"Você pagará 8% de juros no total. O valor ficou por: RS{valor + valor*0.08}");
            }else{
                Console.WriteLine("O limite de parcelamento é em até 12x.");
            }
    }
}
}