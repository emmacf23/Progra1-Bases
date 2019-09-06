namespace Progra1BD.Models
{
    public class Account
    {
        public int ID { get; set; }
        
        public int idCliente { get; set; }
        public int idTipoCuenta { get; set; }
        
        public int numCuenta { get; set; }
        public float saldo { get; set; }
    }
}
