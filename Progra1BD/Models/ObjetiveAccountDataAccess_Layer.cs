using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Progra1BD.Models
{
    public class ObjetiveAccountAccountDataAccess_Layer
    {
        string connectionString = @"Server=127.0.0.1,1433;Database=Progra1BD;User Id=SA;Password=Servidor_123";

        //To View all Customers details      
        public IEnumerable<ObjetiveAccount> GetAllObjetiveAccounts(int? id)
        {
            List<ObjetiveAccount> listObjetiveAccount = new List<ObjetiveAccount>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("COSP_GetCuentasObjetivo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCuenta", id);
                

                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    ObjetiveAccount objetiveAccount = new ObjetiveAccount();
                    
                    objetiveAccount.ID = Convert.ToInt32(sdr["id"]);
                    objetiveAccount.idCuenta = Convert.ToInt32(sdr["idCuenta"]);
                    objetiveAccount.fechaInicio = Convert.ToDateTime(sdr["FechaInicio"]);
                    objetiveAccount.fechaFinal = Convert.ToDateTime(sdr["FechaFinal"]);
                    objetiveAccount.saldo = Convert.ToSingle(sdr["Saldo"]);
                    objetiveAccount.montoAhorro = Convert.ToSingle(sdr["MontoAhorro"]);
                    objetiveAccount.descripcion = Convert.ToString(sdr["Descripcion"]);
                    objetiveAccount.activo = Convert.ToBoolean(sdr["Activo"]);
                    listObjetiveAccount.Add(objetiveAccount);
                }

                con.Close();
            }

            return listObjetiveAccount;
        }
    }
}