using System;
using System.ComponentModel.DataAnnotations;

namespace Progra1BD.Models
{
    public class Movement
    {
        public int ID { get; set; }

        public int idEstadoCuenta { get; set; }
        
        public int idCuenta { get; set; }
        
        public int idTipoMovimiento { get; set; }

        [DataType(DataType.Date)]
        public DateTime fecha { get; set; }

        public float monto { get; set; }
        
        public float nuevoSaldo { get; set; }
        
        public String descripcion { get; set; }
    }
}