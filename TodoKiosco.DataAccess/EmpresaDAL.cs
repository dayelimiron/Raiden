using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TodoKiosco.Entities;

namespace TodoKiosco.DataAccess
{
    public class EmpresaDAL: Conexion
    {
        private static EmpresaDAL instance;
        public static EmpresaDAL Instance
        {
           get
           {
               if(instance == null)
                   instance = new EmpresaDAL();
               return instance;
           }

        }

        public int Insert(Empresa entity)
        {
            int result = 0;
            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spEmpresaInsert", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@EmpresaId", entity.EmpresaId);
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@Direccion", entity.Direccion);
                    cmd.Parameters.AddWithValue("@Telefono", entity.Telefono);
                    cmd.Parameters.AddWithValue("@NIT", entity.NIT);
                    cmd.CommandType = CommandType.StoredProcedure;
                    result = (int) cmd.ExecuteScalar();
                }
            }
            return result;
        }


        public bool Update(Empresa entity)
        {
            bool result = false;
            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spEmpresaUpdate", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@EmpresaId", entity.EmpresaId);
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@Direccion", entity.Direccion);
                    cmd.Parameters.AddWithValue("@Telefono", entity.Telefono);
                    cmd.Parameters.AddWithValue("@NIT", entity.NIT);
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
                using(SqlCommand cmd = new SqlCommand("spEmpresaDelete", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@EmpresaId", id);
                    cmd.CommandType = CommandType.StoredProcedure;

                    result= cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }


        public List<Empresa> SelectAll()
        {
            List<Empresa> listado= new List<Empresa>();

            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spEmpresaSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if(dr != null)
                        {
                            while (dr.Read())
                            {
                                Empresa _entity = new Empresa();
                                _entity.EmpresaId=dr.GetInt32(0);
                                _entity.Nombre=dr.GetString(1);
                                _entity.Direccion=dr.GetString(2);
                                _entity.Telefono=dr.GetString(3);
                                _entity.NIT=dr.GetString(4);
                                listado.Add(_entity);
                            }
                        }
                    }
                }
            }
            return listado;
        }


        public Empresa Select(int id)
        {
            Empresa _entity= new Empresa();

            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spEmpresaSelect", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@EmpresaId", id);

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if(dr != null)
                        {
                            while (dr.Read())
                            {
                                _entity.EmpresaId=dr.GetInt32(0);
                                _entity.Nombre=dr.GetString(1);
                                _entity.Direccion=dr.GetString(2);
                                _entity.Telefono=dr.GetString(3);
                                _entity.NIT=dr.GetString(4);
                            }
                        }
                    }
                }
                return _entity;
            }


        }
    }
}
