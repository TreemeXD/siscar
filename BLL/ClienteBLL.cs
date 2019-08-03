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
    public class ClienteBLL
    {
        public bool verificarCampos(Cliente cliente)
        {
            if (cliente.Nome.Trim().Length == 0)
            {    
                throw new Exception("É obrigatório o preenchimento do campo Nome!");                 
            }

            if (cliente.CPF.Trim().Length == 0) 
            {
                throw new Exception("É obrigatório o preenchimento do campo CPF!");
            }

            try
            {
                Convert.ToString(Convert.ToDateTime(cliente.Data_Nasc));
            }
            catch
            {
                throw new Exception("Verifique se o campo Data de Nascimento foi preenchido corretamente!");
            }

            return true;            
        }

        public void inserirCodigo(Cliente cliente)
        {
            ClienteDAL clientedal = new ClienteDAL();
            clientedal.InserirCodigo(cliente);
        }

        public void inserirCliente(Cliente cliente)
        {
            ClienteDAL clientedal = new ClienteDAL();
            clientedal.InserirCliente(cliente);
        }

        public void atulizarCliente(Cliente cliente)
        {
            ClienteDAL clientedal = new ClienteDAL();
            clientedal.AtualizarCliente(cliente);
        }

        public void excluirCliente(Cliente cliente)
        {
            ClienteDAL clientedal = new ClienteDAL();
            clientedal.ExcluirCliente(cliente);
        }

        public DataTable consultarCliente(String NomeCliente)
        {
            ClienteDAL clientedal = new ClienteDAL();
            return clientedal.ConsultarCliente(NomeCliente);
        }

        public void pesquisarCliente(Cliente cliente)
        {
            ClienteDAL clientedal = new ClienteDAL();
            clientedal.PesquisarCliente(cliente);
        }
    }
}
