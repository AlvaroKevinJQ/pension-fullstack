using System;
using Npgsql;

namespace CSWORK
{
   public class Dbconnect
    {
        static Dbconnect(){

        }

    
        public static void conectar()
        {
                
                        using var conexion = new NpgsqlConnection("Host=localhost;Username=postgres;Password=KEVIN2001;Database=pensionv1");
                        conexion.Open();
                        Console.WriteLine("Base de Datos conectada con exito");
                        
                        string sql = "SELECT * FROM vehiculos";
                        using var cmd = new NpgsqlCommand(sql, conexion);

                        using NpgsqlDataReader leector = cmd.ExecuteReader();

                        while (leector.Read())
                        {
                                Console.WriteLine("{0} {1} {2} {3}", leector.GetInt32(0), leector.GetString(1),
                                        leector.GetInt32(2), leector.GetString(3));
                        }

            
        }
        public  void saludar(){
                Console.WriteLine("HOLA esto es un saludo");
        }

        public void consultar(NpgsqlConnection conexion){
                        string sql = "SELECT * FROM vehiculos";
                        using var cmd = new NpgsqlCommand(sql, conexion);

                        using NpgsqlDataReader leector = cmd.ExecuteReader();

                        while (leector.Read())
                        {
                                Console.WriteLine("{0} {1} {2} {3}", leector.GetInt32(0), leector.GetString(1),
                                        leector.GetInt32(2), leector.GetString(3));
                        }

        


        }
    }
}
