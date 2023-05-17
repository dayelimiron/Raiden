using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TodoKiosco.Entities;

namespace TodoKiosco.DataAccess
{
    public class EmpleadoDAL: Conexion
    {
        private static EmpleadoDAL instance;
        public static EmpleadoDAL Instance
        {
           get
           {
               if(instance == null)
                   instance = new EmpleadoDAL();
               return instance;
           }

        }

        public bool Insert(Empleado entity)
        {
            bool result = false;
            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spEmpleadoInsert", conn))
                {
                    conn.Open();
                    
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", entity.Apellido);
                    cmd.Parameters.AddWithValue("@DUI", entity.DUI);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", entity.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@FechaIngreso", entity.FechaIngreso);
                    cmd.Parameters.AddWithValue("@Telefono", entity.Telefono);
                    cmd.Parameters.AddWithValue("@Direccion", entity.Direccion);
                    cmd.Parameters.AddWithValue("@Observaciones", entity.Observaciones);
                    cmd.Parameters.AddWithValue("@CargoId", entity.CargoId);
                    cmd.CommandType = CommandType.StoredProcedure;

                    result =  cmd.ExecuteNonQuery()>0;
                }
            }
            return result;
        }


        public bool Update(Empleado entity)
        {
            bool result = false;
            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spEmpleadoUpdate", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@EmpleadoID", entity.EmpleadoID);
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", entity.Apellido);
                    cmd.Parameters.AddWithValue("@DUI", entity.DUI);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", entity.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@FechaIngreso", entity.FechaIngreso);
                    cmd.Parameters.AddWithValue("@Telefono", entity.Telefono);
                    cmd.Parameters.AddWithValue("@Direccion", entity.Direccion);
                    cmd.Parameters.AddWithValue("@Observaciones", entity.Observaciones);
                    cmd.Parameters.AddWithValue("@CargoId", entity.CargoId);
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
                using(SqlCommand cmd = new SqlCommand("spEmpleadoDelete", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@EmpleadoID", id);
                    cmd.CommandType = CommandType.StoredProcedure;

                    result= cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }


        public List<Empleado> SelectAll()
        {
            List<Empleado> listado= new List<Empleado>();

            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spEmpleadoSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if(dr != null)
                        {
                            while (dr.Read())
                            {
                                Empleado _entity = new Empleado();
                                _entity.EmpleadoID=dr.GetInt32(0);
                                _entity.Nombre=dr.GetString(1);
                                _entity.Apellido=dr.GetString(2);
                                _entity.DUI=dr.GetString(3);
                                _entity.FechaNacimiento=dr.GetDateTime(4);
                                _entity.FechaIngreso=dr.GetDateTime(5);
                                _entity.Telefono=dr.GetString(6);
                                _entity.Direccion=dr.GetString(7);
                                _entity.Observaciones=dr.GetString(8);
                                _entity.CargoId=dr.GetInt32(9);
                                listado.Add(_entity);
                            }
                        }
                    }
                }
            }
            return listado;
        }


        public Empleado Select(int id)
        {
            Empleado _entity= new Empleado();

            using(SqlConnection conn = new SqlConnection(_cadena))
            {
                using(SqlCommand cmd = new SqlCommand("spEmpleadoSelect", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@EmpleadoID", id);

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if(dr != null)
                        {
                            while (dr.Read())
                            {
                                _entity.EmpleadoID=dr.GetInt32(0);
                                _entity.Nombre=dr.GetString(1);
                                _entity.Apellido=dr.GetString(2);
                                _entity.DUI=dr.GetString(3);
                                _entity.FechaNacimiento=dr.GetDateTime(4);
                                _entity.FechaIngreso=dr.GetDateTime(5);
                                _entity.Telefono=dr.GetString(6);
                                _entity.Direccion=dr.GetString(7);
                                _entity.Observaciones=dr.GetString(8);
                                _entity.CargoId=dr.GetInt32(9);
                            }
                        }
                    }
                }
                return _entity;
            }


        }
    }
}
