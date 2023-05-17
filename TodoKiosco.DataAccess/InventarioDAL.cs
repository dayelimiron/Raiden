using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TodoKiosco.Entities;

namespace TodoKiosco.DataAccess
{
    public class InventarioDAL: Conexion
    {
        private static InventarioDAL instance;
        public static InventarioDAL Instance
        {
           get
           {
               if(instance == null)
                   instance = new InventarioDAL();
               return instance;
           }

        }

        public int Insert(Inventario entity)
        {
            int result = 0;
            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spInventarioInsert", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@DenominacionId", entity.DenominacionId);
                    cmd.Parameters.AddWithValue("@Cantidad", entity.Cantidad);
                    cmd.CommandType = CommandType.StoredProcedure;
                    result = (int) cmd.ExecuteScalar();
                }
            }
            return result;
        }


        public bool Update(Inventario entity)
        {
            bool result = false;
            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spInventarioUpdate", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@DenominacionId", entity.DenominacionId);
                    cmd.Parameters.AddWithValue("@Cantidad", entity.Cantidad);
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
                using(SqlCommand cmd = new SqlCommand("spInventarioDelete", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@", id);
                    cmd.CommandType = CommandType.StoredProcedure;

                    result= cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }


        public List<Inventario> SelectAll()
        {
            List<Inventario> listado= new List<Inventario>();

            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spInventarioSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if(dr != null)
                        {
                            while (dr.Read())
                            {
                                Inventario _entity = new Inventario();
                                _entity.DenominacionId=dr.GetInt32(0);
                                _entity.Cantidad=dr.GetInt32(1);
                                listado.Add(_entity);
                            }
                        }
                    }
                }
            }
            return listado;
        }


        public Inventario Select(int id)
        {
            Inventario _entity= new Inventario();

            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spInventarioSelect", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@", id);

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if(dr != null)
                        {
                            while (dr.Read())
                            {
                                _entity.DenominacionId=dr.GetInt32(0);
                                _entity.Cantidad=dr.GetInt32(1);
                            }
                        }
                    }
                }
                return _entity;
            }


        }
    }
}
