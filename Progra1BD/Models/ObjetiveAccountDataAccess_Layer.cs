using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Progra1BD.Models
{
    public class ObjetiveAccountAccountDataAccess_Layer
    {
        string connectionString = @"Server=192.168.100.30,1433;Database=Progra1BD;User Id=SA;Password=Servidor_123";

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
                    
                    objetiveAccount.idCuenta = Convert.ToInt32(sdr["idCuenta"]);
                    objetiveAccount.fechaInicio = Convert.ToString(sdr["FechaInicio"]);
                    objetiveAccount.fechaFinal = Convert.ToString(sdr["FechaFinal"]);
                    objetiveAccount.saldo = Convert.ToSingle(sdr["Saldo"]);
                    objetiveAccount.montoAhorro = Convert.ToSingle(sdr["MontoAhorro"]);
                    objetiveAccount.descripcion = Convert.ToString(sdr["Descripcion"]);
                    listObjetiveAccount.Add(objetiveAccount);
                }

                con.Close();
            }

            return listObjetiveAccount;
        }
        
        public void AddObjetiveAccount(ObjetiveAccount objetiveAccount)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("COSP_AddCuentaObjetivo", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idCuenta", VariablesLocales.idCuentaActual);
                cmd.Parameters.AddWithValue("@MontoAhorro", objetiveAccount.montoAhorro);
                cmd.Parameters.AddWithValue("@FechaFinal", objetiveAccount.fechaFinal);
                cmd.Parameters.AddWithValue("@Descripcion", objetiveAccount.descripcion);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //To Update the records of a particluar Customer    
        public void DeleteCuentaObjetivo(int? id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("COSP_DeleteCuentaObjetivo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCuenta", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //Get the details of a particular Customer    
        public Beneficiarie GetBeneficiarieData(int? id)
        {
            Beneficiarie beneficiarie = new Beneficiarie();

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand("sp_GetUserByID", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserId", id);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {

                    beneficiarie.ID = Convert.ToInt32(sdr["id"]);
                    beneficiarie.TypeDocID = Convert.ToInt32(sdr["idTipoDocumento"]);
                    beneficiarie.TipoParentesco = Convert.ToInt32(sdr["idTipoParentesco"]);
                    beneficiarie.idCuenta = Convert.ToInt32(sdr["idCuenta"]);
                    beneficiarie.Name = sdr["Nombre"].ToString();
                    beneficiarie.Date = Convert.ToString(sdr["FechaNacimiento"]);
                    beneficiarie.DocID = Convert.ToInt32(sdr["DocId"]);
                    beneficiarie.Email = sdr["Email"].ToString();
                    beneficiarie.Mobile1 = Convert.ToInt32(sdr["Telefono1"]);
                    beneficiarie.Mobile2 = Convert.ToInt32(sdr["Telefono2"]);
                    beneficiarie.Activo = Convert.ToBoolean(sdr["Activo"]);
                    beneficiarie.Porcentaje = Convert.ToInt32(sdr["Telefono2"]);
                    beneficiarie.fechaActivo = Convert.ToDateTime(sdr["FechaActivo"]);
                    beneficiarie.fechaDesactivo = Convert.ToDateTime(sdr["FechaDesactivo"]);
                }
            }

            return beneficiarie;
        }

        //To Delete the record on a particular Customer    
        public void UpdateCuentaObjetivo(ObjetiveAccount co)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("COSP_UpdateCuentaObjetivo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", co.ID );
                cmd.Parameters.AddWithValue("@idCuenta", VariablesLocales.idCuentaActual );
                cmd.Parameters.AddWithValue("@MontoAhorro", co.montoAhorro);
                cmd.Parameters.AddWithValue("@FechaFinal", co.fechaFinal);
                cmd.Parameters.AddWithValue("@Descripcion", co.descripcion);
                
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }
    }
}