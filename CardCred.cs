namespace sextapoo
{
    public class CardCred : Cartao
    {
        public int limite;

        /// <summary>
        /// soma a e b
        /// </summary>
        /// <param name="limiteA">a</param>
        /// <param name="acres">b</param>
        /// <returns>soma</returns>
         public float AumentarLimite(float limiteA, float acres){
            return limiteA + acres;
        }
        /// <summary>
        /// nada 
        /// </summary>
        /// <returns></returns>
        public string BloquearCartaoDeCredito(){
            return "teste cartão de crédito bloqueado";
        }
        
    }
    
}