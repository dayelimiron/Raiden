using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoKiosco.Entities;
using System.Data.SqlClient;

namespace TodoKiosco.DataAccess
{
    public class CargoDAL:Conexion
    {
        private static CargoDAL _instance;

        public static CargoDAL Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new CargoDAL();
                }
                return _instance;
            }
        }
        //CRUD => Create, Retrive (Read), Update, Delete
        //Evitar en todo momento escribir codigo 
        //SelectAll: Devuelve todos los registros de la tabla Cargo
        public List<Cargo> SelectAll()
        {
            List<Cargo> result = null;
            //1. Definir cadena de conexion
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                //2. El comando a enviar  a la DB 
                using (SqlCommand cmd = new SqlCommand("spCargoSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //Explicar la ventaja del sp, (compilacion)
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if(dr != null)
                        {
                            result = new List<Cargo>();   
                            while (dr.Read())
                            {
                                Cargo entity = new Cargo
                                {
                                    CargoId = dr.GetInt32(0),
                                    Nombre = dr.GetString(1)
                                };

                                result.Add(entity);
                            }
                        }
                    }
                }
            }

            return result;
        }

        //SelectById: Devuelve unicamente el registro segun id
        public Cargo SelectById(int id)
        {
            Cargo result = null;
            //1. Definir cadena de conexion
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                //2. El comando a enviar  a la DB 
                using (SqlCommand cmd = new SqlCommand("spCargoSelectById", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //Explicar la ventaja del sp, (compilacion)
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {                            
                            while (dr.Read())
                            {
                                result = new Cargo
                                {
                                    CargoId = dr.GetInt32(0),
                                    Nombre = dr.GetString(1)
                                };                                
                            }
                        }
                    }
                }
            }

            return result;
        }

        //Insert
        public bool Insert(Cargo entity) 
        {
            bool result = false;

            using(SqlConnection conn = new SqlConnection(_cadena))
	        {
                using (SqlCommand cmd = new SqlCommand("spCargoInsert",conn))
                {                    
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    
                    conn.Open();
                    result = cmd.ExecuteNonQuery()>0;
                }
	        }

            return result;
        }
      
        public bool Update(Cargo entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spCargoUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CargoId", entity.CargoId);
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }


        public bool Delete(int id)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spCargoDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CargoId", id);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }





    }
}
