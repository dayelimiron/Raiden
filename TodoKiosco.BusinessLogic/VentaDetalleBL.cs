using System;
using System.Collections.Generic;
using TodoKiosco.Entities;
using TodoKiosco.DataAccess;

namespace TodoKiosco.BusinessLogic
{
    public class VentaDetalleBL
    {
        private static VentaDetalleBL instance;
        public static VentaDetalleBL Instance
        {
           get
           {
               if(instance == null)
                   instance = new VentaDetalleBL();
               return instance;
           }

        }

        public bool Insert(VentaDetalle entity)
        {
            bool result =false;
            try
            {
               result= VentaDetalleDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                
            }
            return result;
         }


        public bool Update(VentaDetalle entity)
        {
            bool result=false;
            try
            {
                result= VentaDetalleDAL.Instance.Update(entity);
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
                result= VentaDetalleDAL.Instance.Delete(id);
            }
            catch (Exception ex)
            {
               
            }
            return result;
         }


        public List<VentaDetalle> SelectAll()
        {
            try
            {
                return VentaDetalleDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
              
                return null;
            }
         }


        public VentaDetalle Select(int id)
        {
            try
            {
                return VentaDetalleDAL.Instance.Select(id);
            }
            catch (Exception ex)
            {
               
                return null;
            }
         }


    }
}
