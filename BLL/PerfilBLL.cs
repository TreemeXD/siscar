using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
   public class PerfilBLL
    {
       public void SalvarCor(Perfil perfil)
       {
           perfil.Login = Login.User;
           PerfilDAL perfildall = new PerfilDAL();

           perfildall.SalvarCor(perfil);
       }
       public void SalvarImagem(Perfil perfil)
       {
           perfil.Login = Login.User;
           PerfilDAL perfildall = new PerfilDAL();

           perfildall.SalvarImagem(perfil);
       }
       public string VerificaCoreFundo(Perfil perfil)
       {
           PerfilDAL perfilDal = new PerfilDAL();
           perfil.Login = Login.User;
           return perfilDal.VerificaCoreFundo(perfil);
       }
       public string RetornaCoreFundo(Perfil perfil)
       {
           PerfilDAL perfilDal = new PerfilDAL();
           perfil.Login = Login.User;
           return perfilDal.RetornaCoreFundo(perfil);
       }
    }
}
