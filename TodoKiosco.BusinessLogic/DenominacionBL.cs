using System;
using System.Collections.Generic;
using TodoKiosco.Entities;
using TodoKiosco.DataAccess;

namespace TodoKiosco.BusinessLogic
{
    public class DenominacionBL
    {
        private static DenominacionBL instance;
        public static DenominacionBL Instance
        {
           get
           {
               if(instance == null)
                   instance = new DenominacionBL();
               return instance;
           }

        }

        public bool Insert(Denominacion entity)
        {
            bool result =false;
            try
            {
               result= DenominacionDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
              
            }
            return result;
         }


        public bool Update(Denominacion entity)
        {
            bool result=false;
            try
            {
                result= DenominacionDAL.Instance.Update(entity);
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
                result= DenominacionDAL.Instance.Delete(id);
            }
            catch (Exception ex)
            {
               
            }
            return result;
         }


        public List<Denominacion> SelectAll()
        {
            try
            {
                return DenominacionDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
         }


        public Denominacion Select(int id)
        {
            try
            {
                return DenominacionDAL.Instance.Select(id);
            }
            catch (Exception ex)
            {
               
                return null;
            }
         }


    }
}
