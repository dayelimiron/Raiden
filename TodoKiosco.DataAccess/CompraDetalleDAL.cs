using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TodoKiosco.Entities;

namespace TodoKiosco.DataAccess
{
    public class CompraDetalleDAL: Conexion
    {
        private static CompraDetalleDAL instance;
        public static CompraDetalleDAL Instance
        {
           get
           {
               if(instance == null)
                   instance = new CompraDetalleDAL();
               return instance;
           }

        }

        public int Insert(CompraDetalle entity)
        {
            int result = 0;
            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spCompraDetalleInsert", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@CompraDetalleId", entity.CompraDetalleId);
                    cmd.Parameters.AddWithValue("@CompraId", entity.CompraId);
                    cmd.Parameters.AddWithValue("@DenominacionId", entity.DenominacionId);
                    cmd.Parameters.AddWithValue("@Cantidad", entity.Cantidad);
                    cmd.Parameters.AddWithValue("@Subtotal", entity.Subtotal);
                    cmd.CommandType = CommandType.StoredProcedure;
                    result = (int) cmd.ExecuteScalar();
                }
            }
            return result;
        }


        public bool Update(CompraDetalle entity)
        {
            bool result = false;
            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spCompraDetalleUpdate", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@CompraDetalleId", entity.CompraDetalleId);
                    cmd.Parameters.AddWithValue("@CompraId", entity.CompraId);
                    cmd.Parameters.AddWithValue("@DenominacionId", entity.DenominacionId);
                    cmd.Parameters.AddWithValue("@Cantidad", entity.Cantidad);
                    cmd.Parameters.AddWithValue("@Subtotal", entity.Subtotal);
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
                using(SqlCommand cmd = new SqlCommand("spCompraDetalleDelete", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@CompraDetalleId", id);
                    cmd.CommandType = CommandType.StoredProcedure;

                    result= cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }


        public List<CompraDetalle> SelectAll()
        {
            List<CompraDetalle> listado= new List<CompraDetalle>();

            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spCompraDetalleSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if(dr != null)
                        {
                            while (dr.Read())
                            {
                                CompraDetalle _entity = new CompraDetalle();
                                _entity.CompraDetalleId=dr.GetInt32(0);
                                _entity.CompraId=dr.GetInt32(1);
                                _entity.DenominacionId=dr.GetString(2);
                                _entity.Cantidad=dr.GetInt32(3);
                                _entity.Subtotal=dr.GetDecimal(4);
                                listado.Add(_entity);
                            }
                        }
                    }
                }
            }
            return listado;
        }


        public CompraDetalle Select(int id)
        {
            CompraDetalle _entity= new CompraDetalle();

            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spCompraDetalleSelect", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@CompraDetalleId", id);

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if(dr != null)
                        {
                            while (dr.Read())
                            {
                                _entity.CompraDetalleId=dr.GetInt32(0);
                                _entity.CompraId=dr.GetInt32(1);
                                _entity.DenominacionId=dr.GetString(2);
                                _entity.Cantidad=dr.GetInt32(3);
                                _entity.Subtotal=dr.GetDecimal(4);
                            }
                        }
                    }
                }
                return _entity;
            }


        }
    }
}
