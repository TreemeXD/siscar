using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
   public class ClienteBLL
    {
       public bool VerificaCampos(Cliente cliente)
       {
           if (cliente.Nome.Trim().Length == 0)
           {
               throw new Exception("É obrigatório o preenchimento do campo nome!");
           }
           if (cliente.CPF.Trim().Length == 0)
           {
               throw new Exception("É obrigatorio o preenchimento do campo CPF!");
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
                 public void atualizarCliente(Cliente cliente)
                 {
                     ClienteDAL clientedal = new ClienteDAL();
                     clientedal.AtualizarCliente(cliente);
                 }
                 public void excluirCliente(Cliente cliente)
                 {
                     ClienteDAL clientedal = new ClienteDAL();
                     clientedal.ExcluirCliente(cliente);
                 }
    }
}
