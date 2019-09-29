using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Progra1BD.Models
{
    public class MovementAccountDataAccess_Layer
    {
        string connectionString = @"Server=127.0.0.1,1433;Database=Progra1BD;User Id=SA;Password=Servidor_123";

        //To View all Customers details      
        public IEnumerable<Movement> GetAllMovements(int? id)
        {
            List<Movement> listMovements = new List<Movement>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("MOVSP_GetMovimientos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEstadoCuenta", id);

                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Movement movement = new Movement();
                    
                    movement.ID = Convert.ToInt32(sdr["id"]);
                    movement.idEstadoCuenta = Convert.ToInt32(sdr["idEstadoCuenta"]);
                    movement.fecha = Convert.ToDateTime(sdr["Fecha"]);
                    movement.monto = Convert.ToSingle(sdr["Monto"]);
                    movement.nuevoSaldo = Convert.ToSingle(sdr["NuevoSaldo"]);
                    movement.descripcion = Convert.ToString(sdr["Descripcion"]);
                    listMovements.Add(movement);
                }

                con.Close();
            }

            return listMovements;
        }
    }
}