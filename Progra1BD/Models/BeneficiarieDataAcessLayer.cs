using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Progra1BD.Models
{
    public class BeneficiarieDataAcessLayer
    {
                string connectionString = @"Server=127.0.0.1,1433;Database=Progra1BD;User Id=SA;Password=Ps3owner";

                //To View all Customers details      
        public IEnumerable<Beneficiarie> GetAllBeneficiaries()
        {
            List<Beneficiarie> lstBeneficiaries = new List<Beneficiarie>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("CASP_GetBeneficiarios", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idCuenta", VariablesLocales.idCuentaActual);

                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Beneficiarie beneficiarie = new Beneficiarie();
                    
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
                    beneficiarie.Porcentaje = Convert.ToInt32(sdr["Porcentaje"]);
                    beneficiarie.fechaActivo = Convert.ToDateTime(sdr["FechaActivo"]);

                    lstBeneficiaries.Add(beneficiarie);
                }

                con.Close();
            }

            return lstBeneficiaries;
        }

        //To Add new Customer record      
        public void AddBeneficiarie(Beneficiarie beneficiarie)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("CASP_AddBeneficiario", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idCuenta", beneficiarie.idCuenta);
                cmd.Parameters.AddWithValue("@idTipoDocumento", beneficiarie.TypeDocID);
                cmd.Parameters.AddWithValue("@idTipoParentesco", beneficiarie.TipoParentesco);
                cmd.Parameters.AddWithValue("@Nombre", beneficiarie.Name);
                cmd.Parameters.AddWithValue("@FechaNacimiento", beneficiarie.Date);
                cmd.Parameters.AddWithValue("@DocId", beneficiarie.DocID);
                cmd.Parameters.AddWithValue("@Email", beneficiarie.Email);
                cmd.Parameters.AddWithValue("@Telefono1", beneficiarie.Mobile1);
                cmd.Parameters.AddWithValue("@Telefono2", beneficiarie.Mobile2);
                cmd.Parameters.AddWithValue("@Porcentaje", beneficiarie.Porcentaje);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //To Update the records of a particluar Customer    
        public void UpdateBeneficiaries(Beneficiarie beneficiarie)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("CASP_UpdateBeneficiario", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", beneficiarie.ID);
                cmd.Parameters.AddWithValue("@idCuenta", beneficiarie.idCuenta);
                cmd.Parameters.AddWithValue("@idTipoDocumento", beneficiarie.TypeDocID);
                cmd.Parameters.AddWithValue("@idTipoParentesco", beneficiarie.TipoParentesco);
                cmd.Parameters.AddWithValue("@Nombre", beneficiarie.Name);
                cmd.Parameters.AddWithValue("@FechaNacimiento", beneficiarie.Date);
                cmd.Parameters.AddWithValue("@DocId", beneficiarie.DocID);
                cmd.Parameters.AddWithValue("@Email", beneficiarie.Email);
                cmd.Parameters.AddWithValue("@Telefono1", beneficiarie.Mobile1);
                cmd.Parameters.AddWithValue("@Telefono2", beneficiarie.Mobile2);
                cmd.Parameters.AddWithValue("@Porcentaje", beneficiarie.Porcentaje);

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
        public void DeleteBeneficiarie(int? id)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("CASP_DeleteBeneficiario", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }
    }
}