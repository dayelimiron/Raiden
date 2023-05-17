using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TodoKiosco.Entities;

namespace TodoKiosco.DataAccess
{
    public class VentaDAL: Conexion
    {
        private static VentaDAL instance;
        public static VentaDAL Instance
        {
           get
           {
               if(instance == null)
                   instance = new VentaDAL();
               return instance;
           }

        }

        public int Insert(Venta entity, List<VentaDetalle> detalles)
        {
            int result = 0;
            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spVentaInsert", conn))
                {
                    conn.Open();
                    
                    cmd.Parameters.AddWithValue("@Fecha", entity.Fecha);
                    cmd.Parameters.AddWithValue("@Total", entity.Total);
                    cmd.Parameters.AddWithValue("@ClienteId", entity.ClienteId);
                    cmd.Parameters.AddWithValue("@Email", entity.Email);
                    cmd.CommandType = CommandType.StoredProcedure;
                    result = (int) cmd.ExecuteScalar();

                    for (int i = 0; i < detalles.Count; i++)
                    {
                        detalles[i].VentaId = result;
                    }

                    for (int i = 0; i < detalles.Count; i++)
                    {
                        VentaDetalleDAL.Instance.Insert(detalles[i]);
                    }

                }
            }
            return result;
        }


        public bool Update(Venta entity)
        {
            bool result = false;
            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spVentaUpdate", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@VentaId", entity.VentaId);
                    cmd.Parameters.AddWithValue("@Fecha", entity.Fecha);
                    cmd.Parameters.AddWithValue("@Total", entity.Total);
                    cmd.Parameters.AddWithValue("@ClienteId", entity.ClienteId);
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
                using(SqlCommand cmd = new SqlCommand("spVentaDelete", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@VentaId", id);
                    cmd.CommandType = CommandType.StoredProcedure;

                    result= cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }


        public List<Venta> SelectAll()
        {
            List<Venta> listado= new List<Venta>();

            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spVentaSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if(dr != null)
                        {
                            while (dr.Read())
                            {
                                Venta _entity = new Venta();
                                _entity.VentaId=dr.GetInt32(0);
                                _entity.Fecha=dr.GetDateTime(1);
                                _entity.Total=dr.GetDecimal(2);
                                _entity.ClienteId=dr.GetInt32(3);
                                _entity.Email=dr.GetString(4);
                                listado.Add(_entity);
                            }
                        }
                    }
                }
            }
            return listado;
        }


        public Venta Select(int id)
        {
            Venta _entity= new Venta();

            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spVentaSelect", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@VentaId", id);

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if(dr != null)
                        {
                            while (dr.Read())
                            {
                                _entity.VentaId=dr.GetInt32(0);
                                _entity.Fecha=dr.GetDateTime(1);
                                _entity.Total=dr.GetDecimal(2);
                                _entity.ClienteId=dr.GetInt32(3);
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
