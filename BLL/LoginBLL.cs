using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class LoginBLL
    {
        public bool verificarLogin(Usuario usuario)
        {
            if (usuario.Login.Trim().Length == 0)
            {
                throw new Exception("Por favor, informe seu usuário!");
            }
            if (usuario.Senha == null)
            {
                throw new Exception("Por favor, informe sua senha!");
            }
            usuario.Login = usuario.Login.ToUpper();

            LoginDAL usuarioDal = new LoginDAL();
            return usuarioDal.verificarLogin(usuario);

        }
    }
}
