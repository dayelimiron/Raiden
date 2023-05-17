using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TodoKiosco.Entities;

namespace TodoKiosco.DataAccess
{
    public class VentaDetalleDAL: Conexion
    {
        private static VentaDetalleDAL instance;
        public static VentaDetalleDAL Instance
        {
           get
           {
               if(instance == null)
                   instance = new VentaDetalleDAL();
               return instance;
           }

        }

        public bool Insert(VentaDetalle entity)
        {
            bool result = false;
            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spVentaDetalleInsert", conn))
                {
                    conn.Open();                    
                    cmd.Parameters.AddWithValue("@VentaId", entity.VentaId);
                    cmd.Parameters.AddWithValue("@DenominacionId", entity.DenominacionId);
                    cmd.Parameters.AddWithValue("@Cantidad", entity.Cantidad);
                    cmd.Parameters.AddWithValue("@Subtotal", entity.Subtotal);
                    cmd.CommandType = CommandType.StoredProcedure;
                    result = cmd.ExecuteNonQuery()>0;
                }
            }
            return result;
        }


        public bool Update(VentaDetalle entity)
        {
            bool result = false;
            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spVentaDetalleUpdate", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@VentaDetalleId", entity.VentaDetalleId);
                    cmd.Parameters.AddWithValue("@VentaId", entity.VentaId);
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
                using(SqlCommand cmd = new SqlCommand("spVentaDetalleDelete", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@VentaDetalleId", id);
                    cmd.CommandType = CommandType.StoredProcedure;

                    result= cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }


        public List<VentaDetalle> SelectAll()
        {
            List<VentaDetalle> listado= new List<VentaDetalle>();

            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spVentaDetalleSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if(dr != null)
                        {
                            while (dr.Read())
                            {
                                VentaDetalle _entity = new VentaDetalle();
                                _entity.VentaDetalleId=dr.GetInt32(0);
                                _entity.VentaId=dr.GetInt32(1);
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


        public VentaDetalle Select(int id)
        {
            VentaDetalle _entity= new VentaDetalle();

            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spVentaDetalleSelect", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@VentaDetalleId", id);

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if(dr != null)
                        {
                            while (dr.Read())
                            {
                                _entity.VentaDetalleId=dr.GetInt32(0);
                                _entity.VentaId=dr.GetInt32(1);
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
