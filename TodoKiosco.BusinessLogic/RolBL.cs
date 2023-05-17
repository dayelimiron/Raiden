using System;
using System.Collections.Generic;
using TodoKiosco.Entities;
using TodoKiosco.DataAccess;

namespace TodoKiosco.BusinessLogic
{
    public class RolBL
    {
        private static RolBL instance;
        public static RolBL Instance
        {
           get
           {
               if(instance == null)
                   instance = new RolBL();
               return instance;
           }

        }

        public bool Insert(Rol entity)
        {
            bool result=false;
            try
            {
               result= RolDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                
            }
            return result;
         }


        public bool Update(Rol entity)
        {
            bool result=false;
            try
            {
                result= RolDAL.Instance.Update(entity);
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
                result= RolDAL.Instance.Delete(id);
            }
            catch (Exception ex)
            {
               
            }
            return result;
         }


        public List<Rol> SelectAll()
        {
            try
            {
                return RolDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                
                return null;
            }
         }


        public Rol Select(int id)
        {
            try
            {
                return RolDAL.Instance.Select(id);
            }
            catch (Exception ex)
            {
               
                return null;
            }
         }


    }
}
