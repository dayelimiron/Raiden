using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TodoKiosco.Entities;

namespace TodoKiosco.DataAccess
{
    public class CompraDAL: Conexion
    {
        private static CompraDAL instance;
        public static CompraDAL Instance
        {
           get
           {
               if(instance == null)
                   instance = new CompraDAL();
               return instance;
           }

        }

        public int Insert(Compra entity)
        {
            int result = 0;
            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spCompraInsert", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@CompraId", entity.CompraId);
                    cmd.Parameters.AddWithValue("@Fecha", entity.Fecha);
                    cmd.Parameters.AddWithValue("@Total", entity.Total);
                    cmd.Parameters.AddWithValue("@ProveedorId", entity.ProveedorId);
                    cmd.Parameters.AddWithValue("@Email", entity.Email);
                    cmd.CommandType = CommandType.StoredProcedure;
                    result = (int) cmd.ExecuteScalar();
                }
            }
            return result;
        }


        public bool Update(Compra entity)
        {
            bool result = false;
            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spCompraUpdate", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@CompraId", entity.CompraId);
                    cmd.Parameters.AddWithValue("@Fecha", entity.Fecha);
                    cmd.Parameters.AddWithValue("@Total", entity.Total);
                    cmd.Parameters.AddWithValue("@ProveedorId", entity.ProveedorId);
                    cmd.Parameters.AddWithValue("@Email", entity.Email);
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
                using(SqlCommand cmd = new SqlCommand("spCompraDelete", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@CompraId", id);
                    cmd.CommandType = CommandType.StoredProcedure;

                    result= cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }


        public List<Compra> SelectAll()
        {
            List<Compra> listado= new List<Compra>();

            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spCompraSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if(dr != null)
                        {
                            while (dr.Read())
                            {
                                Compra _entity = new Compra();
                                _entity.CompraId=dr.GetInt32(0);
                                _entity.Fecha=dr.GetDateTime(1);
                                _entity.Total=dr.GetDecimal(2);
                                _entity.ProveedorId=dr.GetInt32(3);
                                _entity.Email=dr.GetString(4);
                                listado.Add(_entity);
                            }
                        }
                    }
                }
            }
            return listado;
        }


        public Compra Select(int id)
        {
            Compra _entity= new Compra();

            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spCompraSelect", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@CompraId", id);

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if(dr != null)
                        {
                            while (dr.Read())
                            {
                                _entity.CompraId=dr.GetInt32(0);
                                _entity.Fecha=dr.GetDateTime(1);
                                _entity.Total=dr.GetDecimal(2);
                                _entity.ProveedorId=dr.GetInt32(3);
                                _entity.Email=dr.GetString(4);
                            }
                        }
                    }
                }
                return _entity;
            }


        }
    }
}
