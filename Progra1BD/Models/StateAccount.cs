namespace Progra1BD.Models
{
    public class StateAccount
    {
        public int ID { get; set; }
        
        public int idCuenta { get; set; }
        public string fechaInicio { get; set; }
        public string fechaFinal { get; set; }
        public float saldoInicial { get; set; }
        public float saldoFinal { get; set; }
        public float saldoMinimo { get; set; }
    }
}