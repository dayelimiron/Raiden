using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TodoKiosco.Entities;

namespace TodoKiosco.DataAccess
{
    public class TelefonicaDAL: Conexion
    {
        private static TelefonicaDAL instance;
        public static TelefonicaDAL Instance
        {
           get
           {
               if(instance == null)
                   instance = new TelefonicaDAL();
               return instance;
           }

        }

        public bool Insert(Telefonica entity)
        {
            bool result = false;
            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spTelefonicaInsert", conn))
                {
                    conn.Open();                    
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.CommandType = CommandType.StoredProcedure;
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }


        public bool Update(Telefonica entity)
        {
            bool result = false;
            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spTelefonicaUpdate", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@TelefonicaId", entity.TelefonicaId);
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.CommandType = CommandType.StoredProcedure;
                    result= cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }


        public bool Delete(int id)
        {
            bool result = false;
            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spTelefonicaDelete", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@TelefonicaId", id);
                    cmd.CommandType = CommandType.StoredProcedure;

                    result= cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }


        public List<Telefonica> SelectAll()
        {
            List<Telefonica> listado= new List<Telefonica>();

            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spTelefonicaSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if(dr != null)
                        {
                            while (dr.Read())
                            {
                                Telefonica _entity = new Telefonica();
                                _entity.TelefonicaId=dr.GetInt32(0);
                                _entity.Nombre=dr.GetString(1);
                                listado.Add(_entity);
                            }
                        }
                    }
                }
            }
            return listado;
        }


        public Telefonica Select(int id)
        {
            Telefonica _entity= new Telefonica();

            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spTelefonicaSelect", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@TelefonicaId", id);

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if(dr != null)
                        {
                            while (dr.Read())
                            {
                                _entity.TelefonicaId=dr.GetInt32(0);
                                _entity.Nombre=dr.GetString(1);
                            }
                        }
                    }
                }
                return _entity;
            }


        }
    }
}
