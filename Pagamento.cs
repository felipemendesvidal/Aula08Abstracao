namespace sextapoo
{
    public class Pagamento
    {
        public DataTime data {get;set;}
        public float valor{get; set;}

        public string Pagar(){
            return "pagamento feito";
        }
        public string CancelarCompra(){
            return " caNCELADO";
        }
    }
}