namespace Nova_pasta.classes
{
    public class Boleto : Pagamento
    {
        
        private string codigoDeBarras;
        public string CodigoDeBarras{
            get{return codigoDeBarras;}
            set{codigoDeBarras = value;}
        }
        public void Registro(string valor){
            this.codigoDeBarras = valor;
        }

        public override string Desconto(float valor)
        {
            return $"Desconto de: R${valor*0.12} .\n O preço final com desconto será: R${valor - valor*0.12}";
            
        }   
         
    }
}