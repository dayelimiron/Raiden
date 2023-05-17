using System;
using System.Collections.Generic;
using TodoKiosco.Entities;
using TodoKiosco.DataAccess;

namespace TodoKiosco.BusinessLogic
{
    public class EmpresaBL
    {
        private static EmpresaBL instance;
        public static EmpresaBL Instance
        {
           get
           {
               if(instance == null)
                   instance = new EmpresaBL();
               return instance;
           }

        }

        public int Insert(Empresa entity)
        {
            int result=0;
            try
            {
               result= EmpresaDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception("Error. " + ex.Message);
            }
            return result;
         }


        public bool Update(Empresa entity)
        {
            bool result=false;
            try
            {
                result= EmpresaDAL.Instance.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception("Error. " + ex.Message);
            }
            return result;
         }


        public bool Delete(int id)
        {
            bool result=false;
            try
            {
                result= EmpresaDAL.Instance.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error. " + ex.Message);
            }
            return result;
         }


        public List<Empresa> SelectAll()
        {
            try
            {
                return EmpresaDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {

                throw new Exception("Error. " + ex.Message);
            }
         }


        public Empresa Select(int id)
        {
            try
            {
                return EmpresaDAL.Instance.Select(id);
            }
            catch (Exception ex)
            {

                throw new Exception("Error. " + ex.Message);
            }
         }


    }
}
