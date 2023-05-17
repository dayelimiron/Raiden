using System;
using System.Collections.Generic;
using TodoKiosco.Entities;
using TodoKiosco.DataAccess;

namespace TodoKiosco.BusinessLogic
{
    public class EmpleadoBL
    {
        private static EmpleadoBL instance;
        public static EmpleadoBL Instance
        {
           get
           {
               if(instance == null)
                   instance = new EmpleadoBL();
               return instance;
           }

        }

        public bool Insert(Empleado entity)
        {
            bool result=false;
            try
            {
               result= EmpleadoDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                
            }
            return result;
         }


        public bool Update(Empleado entity)
        {
            bool result=false;
            try
            {
                result= EmpleadoDAL.Instance.Update(entity);
            }
            catch (Exception ex)
            {
              
            }
            return result;
         }


        public bool Delete(int id)
        {
            bool result=false;
            try
            {
                result= EmpleadoDAL.Instance.Delete(id);
            }
            catch (Exception ex)
            {
              
            }
            return result;
         }


        public List<Empleado> SelectAll()
        {
            try
            {
                return EmpleadoDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                return null;
            }
         }


        public Empleado Select(int id)
        {
            try
            {
                return EmpleadoDAL.Instance.Select(id);
            }
            catch (Exception ex)
            {
             
                return null;
            }
         }


    }
}
