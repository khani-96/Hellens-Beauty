using System;
using System.Data.SqlClient;
using HellensBeauty.entity;

namespace HellensBeauty.Service
{
    public class UserService
    {
        private static string connString = "Data Source=sqlserver.dynamicdna.co.za;Initial Catalog=DDB-USERMANAGER-PROJECT;User ID=BBD;Password=123";
        private SqlConnection sqlConnection = new SqlConnection(connString);
        public void Create(UserEntity user)
        {
            string insert = "INSERT INTO [User](Fisrtname, Lastname, Email, Usertype)" +
                "VALUES ('" + user.Firstname+"','" + user.Lastname + "','" + user.Email + "','" + user.Usertype + "')";
            try
            {
                sqlConnection.Open();
                try
                {
                    var command = new SqlCommand(insert, sqlConnection);
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    throw;
                }
                sqlConnection.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public UserEntity Read(int id)
        {
            string select = "SELECT * FROM [User] WHERE ID =" + id;


            try
            {
                sqlConnection.Open();
                var command = new SqlCommand(select, sqlConnection);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    UserEntity user = new UserEntity();

                    user.Firstname = reader.GetString(1);
                    user.Lastname = reader.GetString(2);
                    user.Email = reader.GetString(3);
                    user.Usertype = reader.GetInt32(4);

                    return user;

                }
                sqlConnection.Close(); 
            }
            catch (Exception)
            {

                throw;
            }
            return null;
        }
    

        public void Update(int id)
        {
            try
            {
                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand("UPDATE [User] SET fisrtname = @firstname,lastname = @lastname, Email = @Email WHERE ID = @ID", sqlConnection))
                {
                    command.Parameters.AddWithValue("@firstname", "Lesiba");
                    //command.Parameters.AddWithValue("@Name", lastname); 
                    //command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@ID", id);

                    command.ExecuteNonQuery();
                }

                sqlConnection.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand("DELETE FROM [User] WHERE ID = @ID", sqlConnection))
                {
                    command.Parameters.AddWithValue("@ID", id);

                    command.ExecuteNonQuery();
                }

                sqlConnection.Close();
            }
            catch (Exception)
            {

                throw;
            }




        }

    }
}
