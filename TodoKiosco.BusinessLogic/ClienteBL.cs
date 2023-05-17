using System;
using System.Collections.Generic;
using TodoKiosco.Entities;
using TodoKiosco.DataAccess;

namespace TodoKiosco.BusinessLogic
{
    public class ClienteBL
    {
        private static ClienteBL instance;
        public static ClienteBL Instance
        {
           get
           {
               if(instance == null)
                   instance = new ClienteBL();
               return instance;
           }

        }

        public int Insert(Cliente entity)
        {
            int result=0;
            try
            {
               result= ClienteDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                
            }
            return result;
         }


        public bool Update(Cliente entity)
        {
            bool result=false;
            try
            {
                result= ClienteDAL.Instance.Update(entity);
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
                result= ClienteDAL.Instance.Delete(id);
            }
            catch (Exception ex)
            {
              
            }
            return result;
         }


        public List<Cliente> SelectAll()
        {
            List<Cliente> result=null;
            try
            {
                result =  ClienteDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
              
            }
            return result;
         }


        public Cliente Select(int id)
        {
            Cliente result=null;
            try
            {
                ClienteDAL.Instance.Select(id);
            }
            catch (Exception ex)
            {
              
            }
            return result;
        }


    }
}
