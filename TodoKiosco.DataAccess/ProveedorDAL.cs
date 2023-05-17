using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TodoKiosco.Entities;

namespace TodoKiosco.DataAccess
{
    public class ProveedorDAL: Conexion
    {
        private static ProveedorDAL instance;
        public static ProveedorDAL Instance
        {
           get
           {
               if(instance == null)
                   instance = new ProveedorDAL();
               return instance;
           }

        }

        public int Insert(Proveedor entity)
        {
            int result = 0;
            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spProveedorInsert", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@ProveedorId", entity.ProveedorId);
                    cmd.Parameters.AddWithValue("@NombreEmpresa", entity.NombreEmpresa);
                    cmd.Parameters.AddWithValue("@NombreContacto", entity.NombreContacto);
                    cmd.Parameters.AddWithValue("@NIT", entity.NIT);
                    cmd.Parameters.AddWithValue("@Telefono", entity.Telefono);
                    cmd.Parameters.AddWithValue("@Direccion", entity.Direccion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    result = (int) cmd.ExecuteScalar();
                }
            }
            return result;
        }


        public bool Update(Proveedor entity)
        {
            bool result = false;
            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spProveedorUpdate", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@ProveedorId", entity.ProveedorId);
                    cmd.Parameters.AddWithValue("@NombreEmpresa", entity.NombreEmpresa);
                    cmd.Parameters.AddWithValue("@NombreContacto", entity.NombreContacto);
                    cmd.Parameters.AddWithValue("@NIT", entity.NIT);
                    cmd.Parameters.AddWithValue("@Telefono", entity.Telefono);
                    cmd.Parameters.AddWithValue("@Direccion", entity.Direccion);
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
                using(SqlCommand cmd = new SqlCommand("spProveedorDelete", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@ProveedorId", id);
                    cmd.CommandType = CommandType.StoredProcedure;

                    result= cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }


        public List<Proveedor> SelectAll()
        {
            List<Proveedor> listado= new List<Proveedor>();

            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spProveedorSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if(dr != null)
                        {
                            while (dr.Read())
                            {
                                Proveedor _entity = new Proveedor();
                                _entity.ProveedorId=dr.GetInt32(0);
                                _entity.NombreEmpresa=dr.GetString(1);
                                _entity.NombreContacto=dr.GetString(2);
                                _entity.NIT=dr.GetString(3);
                                _entity.Telefono=dr.GetString(4);
                                _entity.Direccion=dr.GetString(5);
                                listado.Add(_entity);
                            }
                        }
                    }
                }
            }
            return listado;
        }


        public Proveedor Select(int id)
        {
            Proveedor _entity= new Proveedor();

            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spProveedorSelect", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@ProveedorId", id);

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if(dr != null)
                        {
                            while (dr.Read())
                            {
                                _entity.ProveedorId=dr.GetInt32(0);
                                _entity.NombreEmpresa=dr.GetString(1);
                                _entity.NombreContacto=dr.GetString(2);
                                _entity.NIT=dr.GetString(3);
                                _entity.Telefono=dr.GetString(4);
                                _entity.Direccion=dr.GetString(5);
                            }
                        }
                    }
                }
                return _entity;
            }


        }
    }
}
