using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Progra1BD.Models
{
    public class StateAccountDataAccess_Layer
    {
        string connectionString = @"Server=127.0.0.1,1433;Database=Progra1BD;User Id=SA;Password=Servidor_123";

        //To View all Customers details      
        public IEnumerable<StateAccount> GetAllStateAccounts(int? id)
        {
            List<StateAccount> listStateAccounts = new List<StateAccount>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("ECSP_GetEstadosDeCuenta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCuenta", id);

                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    StateAccount stateAccount = new StateAccount();

                    stateAccount.ID = Convert.ToInt32(sdr["id"]);
                    stateAccount.idCuenta = Convert.ToInt32(sdr["idCuenta"]);
                    stateAccount.fechaInicio = Convert.ToDateTime(sdr["FechaInicio"]);
                    stateAccount.fechaFinal = Convert.ToDateTime(sdr["FechaFinal"]);
                    stateAccount.saldoMinimo = Convert.ToSingle(sdr["SaldoMin"]);
                    stateAccount.saldoInicial = Convert.ToSingle(sdr["SaldoInicial"]);
                    stateAccount.saldoFinal = Convert.ToSingle(sdr["SaldoFinal"]);
                    stateAccount.intereses = Convert.ToInt32(sdr["Intereses"]);
                    listStateAccounts.Add(stateAccount);
                }

                con.Close();
            }

            return listStateAccounts;
        }
    }
}