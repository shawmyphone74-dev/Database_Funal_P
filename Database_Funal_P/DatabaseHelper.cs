using System.Data;
using System.Data.SqlClient;

namespace Database_Funal_P
{
    public static class DatabaseHelper
    {
        static string connectionString =
        @"Server=ABDELMGEED\SQLEXPRESS;
        Database=Messi2009;
        Trusted_Connection=True;
        TrustServerCertificate=True;";

        

        public static void Execute(string query)
        {
            using (SqlConnection con =
                new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.ExecuteNonQuery();
            }
        }

        
        
        
        
        

        public static DataTable GetData(string query)
        {
            using (SqlConnection con =
                new SqlConnection(connectionString))
            {
                SqlDataAdapter da =
                    new SqlDataAdapter(query, con);

                DataTable dt =
                    new DataTable();

                da.Fill(dt);

                return dt;
            }
        }

        
       

       
    }
}