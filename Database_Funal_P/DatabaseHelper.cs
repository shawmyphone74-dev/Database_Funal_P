using System.Data;
using System.Data.SqlClient;

namespace Database_Funal_P
{
    public static class DatabaseHelper
    {
        static string connectionString =
        @"Server=ABDELMGEED\SQLEXPRESS;
        Database=School_System;
        Trusted_Connection=True;
        TrustServerCertificate=True;";

        // =====================================
        // INSERT UPDATE DELETE
        // =====================================

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

        // =====================================
        // ExecuteQuery(query)
        // =====================================

        public static void ExecuteQuery(string query)
        {
            Execute(query);
        }

        // =====================================
        // ExecuteQuery(query, parameters)
        // =====================================

        public static void ExecuteQuery(
            string query,
            SqlParameter[] parameters)
        {
            using (SqlConnection con =
                new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand cmd =
                    new SqlCommand(query, con);

                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                cmd.ExecuteNonQuery();
            }
        }

        // =====================================
        // SELECT
        // =====================================

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

        // =====================================
        // SELECT WITH PARAMETERS
        // =====================================

        public static DataTable GetData(
            string query,
            SqlParameter[] parameters)
        {
            using (SqlConnection con =
                new SqlConnection(connectionString))
            {
                SqlCommand cmd =
                    new SqlCommand(query, con);

                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                SqlDataAdapter da =
                    new SqlDataAdapter(cmd);

                DataTable dt =
                    new DataTable();

                da.Fill(dt);

                return dt;
            }
        }
    }
}