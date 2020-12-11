namespace Nova_pasta.classes
{
    public abstract class Cartao : Pagamento
    {         
        public string bandeira;
        public string numero;
        public string titular;
        public string cvv;

        public override string Desconto(float valor)
        {
            return "";
        }

        public string SalvarCartao(){
            return $"Bandeira: {bandeira}\n Número: {numero}\n Titular: {titular}\n CVV: {cvv}";
        }

    }
}