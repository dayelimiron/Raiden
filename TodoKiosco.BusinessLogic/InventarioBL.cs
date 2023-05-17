using System;
using System.Collections.Generic;
using TodoKiosco.Entities;
using TodoKiosco.DataAccess;

namespace TodoKiosco.BusinessLogic
{
    public class InventarioBL
    {
        private static InventarioBL instance;
        public static InventarioBL Instance
        {
           get
           {
               if(instance == null)
                   instance = new InventarioBL();
               return instance;
           }

        }

        public int Insert(Inventario entity)
        {
            int result=0;
            try
            {
               result= InventarioDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
               
            }
            return result;
         }


        public bool Update(Inventario entity)
        {
            bool result=false;
            try
            {
                result= InventarioDAL.Instance.Update(entity);
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
                result= InventarioDAL.Instance.Delete(id);
            }
            catch (Exception ex)
            {
               
            }
            return result;
         }


        public List<Inventario> SelectAll()
        {
            try
            {
                return InventarioDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                
                return null;
            }
         }


        public Inventario Select(int id)
        {
            try
            {
                return InventarioDAL.Instance.Select(id);
            }
            catch (Exception ex)
            {
                
                return null;
            }
         }


    }
}
