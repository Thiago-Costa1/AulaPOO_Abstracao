using System;

namespace Nova_pasta.classes
{
    public abstract class Pagamento
    {
        private DateTime data;
        protected float valor;

        public string Cancelar(){
            return $"Cancelamento feito!!";
        }

        public abstract string Desconto(float valor);

    }
}