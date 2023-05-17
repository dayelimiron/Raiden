using System;
using System.Collections.Generic;
using TodoKiosco.Entities;
using TodoKiosco.DataAccess;

namespace TodoKiosco.BusinessLogic
{
    public class VentaBL
    {
        private static VentaBL instance;
        public static VentaBL Instance
        {
           get
           {
               if(instance == null)
                   instance = new VentaBL();
               return instance;
           }

        }

        public int Insert(Venta entity, List<VentaDetalle> detalles)
        {
            int result=0;
            try
            {
               result= VentaDAL.Instance.Insert(entity,detalles);
            }
            catch (Exception ex)
            {
               
            }
            return result;
         }


        public bool Update(Venta entity)
        {
            bool result=false;
            try
            {
                result= VentaDAL.Instance.Update(entity);
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
                result= VentaDAL.Instance.Delete(id);
            }
            catch (Exception ex)
            {
                
            }
            return result;
         }


        public List<Venta> SelectAll()
        {
            try
            {
                return VentaDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                return null;
            }
         }


        public Venta Select(int id)
        {
            try
            {
                return VentaDAL.Instance.Select(id);
            }
            catch (Exception ex)
            {

                return null;
            }
         }


    }
}
