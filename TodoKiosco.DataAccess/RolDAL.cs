using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TodoKiosco.Entities;

namespace TodoKiosco.DataAccess
{
    public class RolDAL: Conexion
    {
        private static RolDAL instance;
        public static RolDAL Instance
        {
           get
           {
               if(instance == null)
                   instance = new RolDAL();
               return instance;
           }

        }

        public bool Insert(Rol entity)
        {
            bool result = false;
            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spRolInsert", conn))
                {
                    conn.Open();                    
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.CommandType = CommandType.StoredProcedure;
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }


        public bool Update(Rol entity)
        {
            bool result = false;
            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spRolUpdate", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@RolId", entity.RolId);
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
                using(SqlCommand cmd = new SqlCommand("spRolDelete", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@RolId", id);
                    cmd.CommandType = CommandType.StoredProcedure;

                    result= cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }


        public List<Rol> SelectAll()
        {
            List<Rol> listado= new List<Rol>();

            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spRolSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if(dr != null)
                        {
                            while (dr.Read())
                            {
                                Rol _entity = new Rol();
                                _entity.RolId=dr.GetInt32(0);
                                _entity.Nombre=dr.GetString(1);
                                listado.Add(_entity);
                            }
                        }
                    }
                }
            }
            return listado;
        }


        public Rol Select(int id)
        {
            Rol _entity= new Rol();

            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spRolSelect", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@RolId", id);

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if(dr != null)
                        {
                            while (dr.Read())
                            {
                                _entity.RolId=dr.GetInt32(0);
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
