using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TodoKiosco.Entities;

namespace TodoKiosco.DataAccess
{
    public class UsuarioDAL: Conexion
    {
        private static UsuarioDAL instance;
        public static UsuarioDAL Instance
        {
           get
           {
               if(instance == null)
                   instance = new UsuarioDAL();
               return instance;
           }

        }

        public int Insert(Usuario entity)
        {
            int result = 0;
            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spUsuarioInsert", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Email", entity.Email);
                    cmd.Parameters.AddWithValue("@Password", entity.Password);
                    cmd.Parameters.AddWithValue("@EmpleadoId", entity.EmpleadoId);
                    cmd.Parameters.AddWithValue("@RolId", entity.RolId);
                    cmd.CommandType = CommandType.StoredProcedure;
                    result = (int) cmd.ExecuteScalar();
                }
            }
            return result;
        }


        public bool Update(Usuario entity)
        {
            bool result = false;
            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spUsuarioUpdate", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Email", entity.Email);
                    cmd.Parameters.AddWithValue("@Password", entity.Password);
                    cmd.Parameters.AddWithValue("@EmpleadoId", entity.EmpleadoId);
                    cmd.Parameters.AddWithValue("@RolId", entity.RolId);
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
                using(SqlCommand cmd = new SqlCommand("spUsuarioDelete", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Email", id);
                    cmd.CommandType = CommandType.StoredProcedure;

                    result= cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }


        public List<Usuario> SelectAll()
        {
            List<Usuario> listado= new List<Usuario>();

            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spUsuarioSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if(dr != null)
                        {
                            while (dr.Read())
                            {
                                Usuario _entity = new Usuario();
                                _entity.Email=dr.GetString(0);
                                _entity.Password=dr.GetString(1);
                                _entity.EmpleadoId=dr.GetInt32(2);
                                _entity.RolId=dr.GetInt32(3);
                                listado.Add(_entity);
                            }
                        }
                    }
                }
            }
            return listado;
        }


        public Usuario Select(int id)
        {
            Usuario _entity= new Usuario();

            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spUsuarioSelect", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Email", id);

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if(dr != null)
                        {
                            while (dr.Read())
                            {
                                _entity.Email=dr.GetString(0);
                                _entity.Password=dr.GetString(1);
                                _entity.EmpleadoId=dr.GetInt32(2);
                                _entity.RolId=dr.GetInt32(3);
                            }
                        }
                    }
                }
                return _entity;
            }


        }


        public Usuario Login(string email, string password)
        {
            Usuario _entity = new Usuario();

            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spUsuarioLogin", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                _entity.Email = dr.GetString(0);
                                _entity.Password = dr.GetString(1);
                                _entity.EmpleadoId = dr.GetInt32(2);
                                _entity.RolId = dr.GetInt32(3);
                            }
                        }
                    }
                }
                return _entity;
            }


        }
    }
}
