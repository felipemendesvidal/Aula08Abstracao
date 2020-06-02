namespace sextapoo
{
    public class Cartao : Pagamento
    {
        public int numero { get; set; }
        public string titular { get; set; }
        public string bandeira { get; set; }
        public string cvv { get; set; }
        private string token = "tstedetoken1234"; 

        /// <summary>
        /// verifica se é verdadeiro ou falso
        /// </summary>
        /// <returns> true or false</returns>
         public bool validarToken(){
            if(token != null){
                return true;
            }
            return false;
        }
    }
}