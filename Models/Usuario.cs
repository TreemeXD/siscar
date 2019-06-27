using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Usuario
    {
       private string login;
       private int senha;

       public string Login
       {
           get { return login; }
           set { login = value; }
       }

       public int Senha
       {
           get { return senha; }
           set { senha = value; }
       }
    }
}
