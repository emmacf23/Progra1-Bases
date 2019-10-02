using System;
using System.ComponentModel.DataAnnotations;

namespace Progra1BD.Models
{
    public class ObjetiveAccount
    {
        public int ID { get; set; }

        public int idCuenta { get; set; }

        [DataType(DataType.Date)]
        public DateTime fechaInicio { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime fechaFinal { get; set; }

        public float saldo { get; set; }
        
        public float montoAhorro { get; set; }
        
        public String descripcion { get; set; }
        
        public bool activo { get; set; }
    }
}