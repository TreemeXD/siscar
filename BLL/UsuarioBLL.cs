using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;
using System.Data;

namespace BLL
{
    public class UsuarioBLL
    {
        public bool verificarCampos(Usuario usuario)
        {
            if (usuario.Login.Trim().Length == 0)
            {
                throw new Exception("É obrigatório o preenchimento do campo Login!");
            }

            if (usuario.Nome.Trim().Length == 0)
            {
                throw new Exception("É obrigatório o preenchimento do campo Nome!");
            }

            if (usuario.Senha.Trim().Length == 0)
            {
                throw new Exception("É obrigatório o preenchimento do campo Senha!");
            }            

            return true;
        }
              
        public void inserirUsuario(Usuario usuario)
        {
            UsuarioDAL usuariodal = new UsuarioDAL();
            usuariodal.InserirUsuario(usuario);
            usuariodal.InserirUsuarioConfig(usuario);
        }

        public void atulizarUsuario(Usuario usuario)
        {
            UsuarioDAL usuariodal = new UsuarioDAL();
            usuariodal.AtualizarUsuario(usuario);            
        }

        public void excluirUsuario(Usuario usuario)
        {
            UsuarioDAL usuariodal = new UsuarioDAL();            
            usuariodal.ExcluirUsuarioConfig(usuario);
            usuariodal.ExcluirUsuario(usuario);
        }

        public DataTable consultarUsuario(String NomeCliente)
        {
            UsuarioDAL usuariodal = new UsuarioDAL();
            return usuariodal.ConsultarUsuario(NomeCliente);
        }

        public bool verificarUsuario(Usuario usuario)
        {
            UsuarioDAL usuariodal = new UsuarioDAL();
            return usuariodal.VerificarUsuario(usuario);
        }
    }
}
