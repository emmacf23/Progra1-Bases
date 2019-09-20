using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Progra1BD.Models
{
    public class UserDataAcess_Layer
    {
        string connectionString = @"Server=172.19.52.84,1433;Database=Progra1BD;User Id=SA;Password=Servidor_123";

        //To View all Customers details      
        public IEnumerable<User> GetAllUsers()
        {
            List<User> lstUsers = new List<User>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("CLSP_GetClientes", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    User user = new User();

                    user.ID = Convert.ToInt32(sdr["id"]);
                    user.TypeDocID = Convert.ToInt32(sdr["idTipoDocumento"]);
                    user.Name = sdr["Nombre"].ToString();
                    user.Date = Convert.ToDateTime(sdr["FechaNacimiento"]);
                    user.DocID = Convert.ToInt32(sdr["DocId"]);
                    user.Email = sdr["Email"].ToString();
                    user.Mobile1 = Convert.ToInt32(sdr["Telefono1"]);
                    user.Mobile2 = Convert.ToInt32(sdr["Telefono2"]);
                    user.Username = sdr["Username"].ToString();
                    user.Password = sdr["Password"].ToString();
                    lstUsers.Add(user);
                }

                con.Close();
            }

            return lstUsers;
        }

        //Tow Add new Customer record      
        public void AddUser(User user)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("CLSP_AddCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idTipoDoc", user.TypeDocID);
                cmd.Parameters.AddWithValue("@Nombre", user.Name);
                cmd.Parameters.AddWithValue("@FechaNacimiento", user.Date);
                cmd.Parameters.AddWithValue("@DocId", user.DocID);
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Telefono1", user.Mobile1);
                cmd.Parameters.AddWithValue("@Telefono2", user.Mobile2);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //To Update the records of a particluar Customer    
        public void UpdateUser(User user)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_UpdateCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", user.Name);
                cmd.Parameters.AddWithValue("@idTipoDocumento", user.TypeDocID);
                cmd.Parameters.AddWithValue("@DocId", user.DocID);
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Telefono1", user.Mobile1);
                cmd.Parameters.AddWithValue("@Telefono2", user.Mobile2);
                cmd.Parameters.AddWithValue("@Email", user.Email);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //Get the details of a particular Customer    
        public User GetUserData(int? id)
        {
            User user = new User();

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand("sp_GetUserByID", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserId", id);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {

                    user.ID = Convert.ToInt32(sdr["id"]);
                    user.TypeDocID = Convert.ToInt32(sdr["idTipoDocumento"]);
                    user.Name = sdr["Name"].ToString();
                    user.Date = Convert.ToDateTime(sdr["FechaNacimiento"]);
                    user.DocID = Convert.ToInt32(sdr["DocId"]);
                    user.Email = sdr["Email"].ToString();
                    user.Mobile1 = Convert.ToInt32(sdr["Telefono1"]);
                    user.Mobile2 = Convert.ToInt32(sdr["Telefono2"]);
                    user.Username = sdr["Username"].ToString();
                    user.Password = sdr["Password"].ToString();
                }
            }

            return user;
        }

        //To Delete the record on a particular Customer    
        public void DeleteUser(int? id)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_DeleteUser", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserId", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }
    }
}