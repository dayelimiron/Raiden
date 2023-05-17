using System;
using System.Collections.Generic;
using TodoKiosco.Entities;
using TodoKiosco.DataAccess;

namespace TodoKiosco.BusinessLogic
{
    public class TelefonicaBL
    {
        private static TelefonicaBL instance;
        public static TelefonicaBL Instance
        {
           get
           {
               if(instance == null)
                   instance = new TelefonicaBL();
               return instance;
           }

        }

        public bool Insert(Telefonica entity)
        {
            bool result =false;
            try
            {
               result= TelefonicaDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                
            }
            return result;
         }


        public bool Update(Telefonica entity)
        {
            bool result=false;
            try
            {
                result= TelefonicaDAL.Instance.Update(entity);
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
                result= TelefonicaDAL.Instance.Delete(id);
            }
            catch (Exception ex)
            {
                
            }
            return result;
         }


        public List<Telefonica> SelectAll()
        {
            try
            {
                return TelefonicaDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                return null;
            }
         }


        public Telefonica Select(int id)
        {
            try
            {
                return TelefonicaDAL.Instance.Select(id);
            }
            catch (Exception ex)
            {
                return null;
            }
         }


    }
}
