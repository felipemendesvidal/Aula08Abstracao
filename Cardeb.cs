namespace sextapoo
{
    public class Cardeb
    {
        public float saldo { get; set; }

        public string Transfere (float valor){
            return "tresferido"+valor;
        }

        public string PagarTitulo(){
            return "pagar titulo";
        }
    }
}