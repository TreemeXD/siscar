using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;
using Npgsql;

namespace DAL
{
   public class ClienteDAL
    {
       public void AtualizarCliente(Cliente cliente)
       {
           try
           {
               String atualizaC = (String.Format(
                   "UPDATE CLIENTES SET NOME = '{0}', " +
                   "CPF = '{1}', " +
                   "DATA_NASC = '{2}', " +
                   "ENDERECO = '{3}', " +
                   "BAIRRO = '{4}', " +
                   "CEP = '{5}', " +
                   "CIDADE = '{6}', " +
                   "ESTADO = '{7}', " +
                   "FONE1 = '{8}', " +
                   "FONE2 = '{9}', " +
                   "SEXO = '{10}', " +
                   "RESTRICAO = '{11}', " +
                   "WHERE COD_CLIENTE = '{12}'",
               cliente.Nome,
               cliente.CPF,
               cliente.Data_Nasc,
               cliente.Endereco,
               cliente.Bairro,
               cliente.CEP,
               cliente.Cidade,
               cliente.Estado,
               cliente.Fone1,
               cliente.Fone2,
               cliente.Sexo,
               cliente.Restricao,
               cliente.Cod_Cliente));


               NpgsqlCommand comandoUpdate = new NpgsqlCommand
               (atualizaC, ConnectionFactory.Connect());
               comandoUpdate.ExecuteNonQuery();
           }
           catch (Exception ex)
           {
               throw new Exception("Falha ao atualizar os dados do cliente!" + ex.Message);
           }
           finally
           {
               ConnectionFactory.Connect().Close();
           }
       }

       public void InserirCliente(Cliente cliente)
       {
           try
           {
               string insereC = (string.Format(
                   "INSERT INTO CLIENTES (COD_CLIENTES, " +
                   "NOME, " +
                   "CPF, " +
                   "DATA_NASC, " +
                   "ENDERECO, " +
                   "BAIRRO, " +
                   "CEP, " +
                   "CIDADE, " +
                   "ESTADO, " +
                   "FONE1, " +
                   "FONE2, " +
                   "SEXO, " +
                   "RESTRICAO)" +
                   "VALUES ('{0}, " +
                   "'{1}', " +
                   "'{2}', " +
                   "'{3}', " +
                   "'{4}', " +
                   "'{5}', " +
                   "'{6}', " +
                   "'{7}', " +
                   "'{8}', " +
                   "'{9}', " +
                   "'{10}', " +
                   "'{11}', " +
                   "'{12}') ",
                   cliente.Cod_Cliente,
                   cliente.Nome,
                   cliente.CPF,
                   cliente.Data_Nasc,
                   cliente.Endereco,
                   cliente.Bairro,
                   cliente.CEP,
                   cliente.Cidade,
                   cliente.Estado,
                   cliente.Fone1,
                   cliente.Fone2,
                   cliente.Sexo,
                   cliente.Restricao));

               NpgsqlCommand comandoInsert = new NpgsqlCommand
               (insereC, ConnectionFactory.Connect());
               comandoInsert.ExecuteNonQuery();

           }

           catch (Exception ex)
           {
               throw new Exception("Falha ao Inserir Cliente!" + ex.Message);
           }
           finally
           {
               ConnectionFactory.Connect().Close();
           }

       }
    }
}
