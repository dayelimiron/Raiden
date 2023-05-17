using System;
using System.Collections.Generic;
using TodoKiosco.Entities;
using TodoKiosco.DataAccess;

namespace TodoKiosco.BusinessLogic
{
    public class CompraDetalleBL
    {
        private static CompraDetalleBL instance;
        public static CompraDetalleBL Instance
        {
           get
           {
               if(instance == null)
                   instance = new CompraDetalleBL();
               return instance;
           }

        }

        public int Insert(CompraDetalle entity)
        {
            int result=0;
            try
            {
               result= CompraDetalleDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                
            }
            return result;
         }


        public bool Update(CompraDetalle entity)
        {
            bool result=false;
            try
            {
                result= CompraDetalleDAL.Instance.Update(entity);
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
                result= CompraDetalleDAL.Instance.Delete(id);
            }
            catch (Exception ex)
            {
               
            }
            return result;
         }


        public List<CompraDetalle> SelectAll()
        {
            try
            {
                return CompraDetalleDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                
                return null;
            }
         }


        public CompraDetalle Select(int id)
        {
            try
            {
                return CompraDetalleDAL.Instance.Select(id);
            }
            catch (Exception ex)
            {
                
                return null;
            }
         }


    }
}
