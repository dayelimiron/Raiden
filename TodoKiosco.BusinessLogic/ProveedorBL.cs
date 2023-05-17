using System;
using System.Collections.Generic;
using TodoKiosco.Entities;
using TodoKiosco.DataAccess;

namespace TodoKiosco.BusinessLogic
{
    public class ProveedorBL
    {
        private static ProveedorBL instance;
        public static ProveedorBL Instance
        {
           get
           {
               if(instance == null)
                   instance = new ProveedorBL();
               return instance;
           }

        }

        public int Insert(Proveedor entity)
        {
            int result=0;
            try
            {
               result= ProveedorDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
               
            }
            return result;
         }


        public bool Update(Proveedor entity)
        {
            bool result=false;
            try
            {
                result= ProveedorDAL.Instance.Update(entity);
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
                result= ProveedorDAL.Instance.Delete(id);
            }
            catch (Exception ex)
            {
                
            }
            return result;
         }


        public List<Proveedor> SelectAll()
        {
            try
            {
                return ProveedorDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
               
                return null;
            }
         }


        public Proveedor Select(int id)
        {
            try
            {
                return ProveedorDAL.Instance.Select(id);
            }
            catch (Exception ex)
            {
               
                return null;
            }
         }


    }
}
