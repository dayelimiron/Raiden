using System;
using System.Collections.Generic;
using TodoKiosco.Entities;
using TodoKiosco.DataAccess;

namespace TodoKiosco.BusinessLogic
{
    public class UsuarioBL
    {
        private static UsuarioBL instance;
        public static UsuarioBL Instance
        {
           get
           {
               if(instance == null)
                   instance = new UsuarioBL();
               return instance;
           }

        }

        public int Insert(Usuario entity)
        {
            int result=0;
            try
            {
               result= UsuarioDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
         
            }
            return result;
         }


        public bool Update(Usuario entity)
        {
            bool result=false;
            try
            {
                result= UsuarioDAL.Instance.Update(entity);
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
                result= UsuarioDAL.Instance.Delete(id);
            }
            catch (Exception ex)
            {
                
            }
            return result;
         }


        public List<Usuario> SelectAll()
        {
            try
            {
                return UsuarioDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                return null;
            }
         }


        public Usuario Select(int id)
        {
            try
            {
                return UsuarioDAL.Instance.Select(id);
            }
            catch (Exception ex)
            {
              
                return null;
            }
         }


        public Usuario Login(string email, string password)
        {
            try
            {
                return UsuarioDAL.Instance.Login(email,password);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


    }
}
