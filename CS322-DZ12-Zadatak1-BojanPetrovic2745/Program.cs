using MySql.Data.MySqlClient;
using System;

namespace CS322_DZ12_Zadatak1_BojanPetrovic2745
{
    class Program
    {
        static void Main(string[] args)
        {
            // potrebno je koristi xampp

            MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=cs322;Uid=root;Pwd=;");

            connection.Open();

            String sql = "INSERT INTO korisnik (username,password)VALUES('nesto', 'nesto')";
            
            MySqlCommand comm = new MySqlCommand(sql, connection);
            try
            {
                comm.ExecuteNonQuery();
            }
            catch(Exception e){
                Console.WriteLine("Error");
            }
            finally { connection.Close(); }
        }
    }
}
