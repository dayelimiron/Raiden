using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TodoKiosco.Entities;

namespace TodoKiosco.DataAccess
{
    public class ClienteDAL: Conexion
    {
        private static ClienteDAL instance;
        public static ClienteDAL Instance
        {
           get
           {
               if(instance == null)
                   instance = new ClienteDAL();
               return instance;
           }

        }

        public int Insert(Cliente entity)
        {
            int result = 0;
            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spClienteInsert", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@ClienteId", entity.ClienteId);
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", entity.Apellido);
                    cmd.Parameters.AddWithValue("@DUI", entity.DUI);
                    cmd.Parameters.AddWithValue("@Telefono", entity.Telefono);
                    cmd.CommandType = CommandType.StoredProcedure;
                    result = (int) cmd.ExecuteScalar();
                }
            }
            return result;
        }


        public bool Update(Cliente entity)
        {
            bool result = false;
            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spClienteUpdate", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@ClienteId", entity.ClienteId);
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", entity.Apellido);
                    cmd.Parameters.AddWithValue("@DUI", entity.DUI);
                    cmd.Parameters.AddWithValue("@Telefono", entity.Telefono);
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
                using(SqlCommand cmd = new SqlCommand("spClienteDelete", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@ClienteId", id);
                    cmd.CommandType = CommandType.StoredProcedure;

                    result= cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }


        public List<Cliente> SelectAll()
        {
            List<Cliente> listado= new List<Cliente>();

            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spClienteSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if(dr != null)
                        {
                            while (dr.Read())
                            {
                                Cliente _entity = new Cliente();
                                _entity.ClienteId=dr.GetInt32(0);
                                _entity.Nombre=dr.GetString(1);
                                _entity.Apellido=dr.GetString(2);
                                _entity.DUI=dr.GetString(3);
                                _entity.Telefono=dr.GetString(4);
                                listado.Add(_entity);
                            }
                        }
                    }
                }
            }
            return listado;
        }


        public Cliente Select(int id)
        {
            Cliente _entity= new Cliente();

            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spClienteSelect", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@ClienteId", id);

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if(dr != null)
                        {
                            while (dr.Read())
                            {
                                _entity.ClienteId=dr.GetInt32(0);
                                _entity.Nombre=dr.GetString(1);
                                _entity.Apellido=dr.GetString(2);
                                _entity.DUI=dr.GetString(3);
                                _entity.Telefono=dr.GetString(4);
                            }
                        }
                    }
                }
                return _entity;
            }


        }
    }
}
