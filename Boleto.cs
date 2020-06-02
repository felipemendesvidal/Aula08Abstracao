namespace sextapoo
{
    public class Boleto : Pagamento

    {
        public  DataTime vencimento{get;set;}
        public string Emissor { get; set; }
        public string codDeBarras { get; set; }

        public string RegistrarBoleto(){
            return "boleto registrado no sistema";
        }
    }
}