namespace Progra1BD.Models
{
    public class Account
    {
        public int ID { get; set; }
        
        public long idCliente { get; set; }
        
        public int idTipoCuenta { get; set; }
        
        public long numCuenta { get; set; }
        
        public float saldo { get; set; }
    }
}
