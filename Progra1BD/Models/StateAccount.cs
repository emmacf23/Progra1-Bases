using System;
using System.ComponentModel.DataAnnotations;

namespace Progra1BD.Models
{
    public class StateAccount
    {
        public int ID { get; set; }
        
        public int idCuenta { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime fechaInicio { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime fechaFinal { get; set; }
        
        public float saldoInicial { get; set; }
        
        public float saldoFinal { get; set; }
        
        public float saldoMinimo { get; set; }
    }
}