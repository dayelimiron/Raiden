using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TodoKiosco.Entities;

namespace TodoKiosco.DataAccess
{
    public class DenominacionDAL: Conexion
    {
        private static DenominacionDAL instance;
        public static DenominacionDAL Instance
        {
           get
           {
               if(instance == null)
                   instance = new DenominacionDAL();
               return instance;
           }

        }

        public bool Insert(Denominacion entity)
        {
            bool result = false;
            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spDenominacionInsert", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@DenominacionId", entity.DenominacionId);
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@Precio", entity.Precio);
                    cmd.Parameters.AddWithValue("@Costo", entity.Costo);
                    cmd.Parameters.AddWithValue("@TelefonicaId", entity.TelefonicaId);
                    cmd.CommandType = CommandType.StoredProcedure;
                    result = cmd.ExecuteNonQuery()>0;
                }
            }
            return result;
        }


        public bool Update(Denominacion entity)
        {
            bool result = false;
            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spDenominacionUpdate", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@DenominacionId", entity.DenominacionId);
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@Precio", entity.Precio);
                    cmd.Parameters.AddWithValue("@Costo", entity.Costo);
                    cmd.Parameters.AddWithValue("@TelefonicaId", entity.TelefonicaId);
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
                using(SqlCommand cmd = new SqlCommand("spDenominacionDelete", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@DenominacionId", id);
                    cmd.CommandType = CommandType.StoredProcedure;

                    result= cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }


        public List<Denominacion> SelectAll()
        {
            List<Denominacion> listado= new List<Denominacion>();

            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spDenominacionSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if(dr != null)
                        {
                            while (dr.Read())
                            {
                                Denominacion _entity = new Denominacion();
                                _entity.DenominacionId=dr.GetString(0);
                                _entity.Nombre=dr.GetString(1);
                                _entity.Precio=dr.GetDecimal(2);
                                _entity.Costo=dr.GetDecimal(3);
                                _entity.TelefonicaId=dr.GetInt32(4);
                                listado.Add(_entity);
                            }
                        }
                    }
                }
            }
            return listado;
        }


        public Denominacion Select(int id)
        {
            Denominacion _entity= new Denominacion();

            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spDenominacionSelect", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@DenominacionId", id);

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if(dr != null)
                        {
                            while (dr.Read())
                            {
                                _entity.DenominacionId=dr.GetString(0);
                                _entity.Nombre=dr.GetString(1);
                                _entity.Precio=dr.GetDecimal(2);
                                _entity.Costo=dr.GetDecimal(3);
                                _entity.TelefonicaId=dr.GetInt32(4);
                            }
                        }
                    }
                }
                return _entity;
            }


        }
    }
}
