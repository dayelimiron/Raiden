using System;
using System.Collections.Generic;
using TodoKiosco.Entities;
using TodoKiosco.DataAccess;

namespace TodoKiosco.BusinessLogic
{
    public class CompraBL
    {
        private static CompraBL instance;
        public static CompraBL Instance
        {
           get
           {
               if(instance == null)
                   instance = new CompraBL();
               return instance;
           }

        }

        public int Insert(Compra entity)
        {
            int result=0;
            try
            {
               result= CompraDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception("Error. " + ex.Message);
            }
            return result;
         }


        public bool Update(Compra entity)
        {
            bool result=false;
            try
            {
                result= CompraDAL.Instance.Update(entity);
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
                result= CompraDAL.Instance.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error. " + ex.Message);
            }
            return result;
         }


        public List<Compra> SelectAll()
        {
            List<Compra> result;
            try
            {
                result= CompraDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Error. " + ex.Message);
            }
            return result;
         }


        public Compra Select(int id)
        {
            Compra result=null;
            try
            {
                result= CompraDAL.Instance.Select(id);
            }
            catch (Exception ex)
            {
                
            }
            return result;
         }


    }
}
