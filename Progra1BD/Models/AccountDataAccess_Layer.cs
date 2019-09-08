using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Progra1BD.Models
{
    public class AccountDataAccess_Layer
    {
        string connectionString = @"Server=127.0.0.1,1433;Database=Progra1BD;User Id=SA;Password=Ps3owner";

        //To View all Customers details      
        public IEnumerable<Account> GetAllAccounts(int? id)
        {
            List<Account> listAccounts = new List<Account>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("CASP_GetCuentas", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Account account = new Account();

                    account.ID = Convert.ToInt32(sdr["id"]);
                    account.idCliente = Convert.ToInt32(sdr["idCliente"]);
                    account.idTipoCuenta = Convert.ToInt32(sdr["idTipoCuenta"]);
                    account.numCuenta = Convert.ToInt32(sdr["NumeroCuenta"]);
                    account.saldo = Convert.ToSingle(sdr["Saldo"]);
                    listAccounts.Add(account);
                }

                con.Close();
            }

            return listAccounts;
        }  
    }
}