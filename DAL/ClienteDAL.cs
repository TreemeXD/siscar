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
                    "CPF       = '{1}', " +
                    "DATA_NASC = '{2}', " +
                    "ENDERECO  = '{3}', " +
                    "BAIRRO    = '{4}', " +
                    "CEP       = '{5}', " +
                    "CIDADE    = '{6}', " +
                    "ESTADO    = '{7}', " +
                    "FONE1     = '{8}', " +
                    "FONE2     = '{9}', " +
                    "SEXO      = '{10}', " +
                    "RESTRICAO = '{11}' " +
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
                throw new Exception("Falha ao Atualizar os Dados do Cliente!" + ex.Message);
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
                String insereC = (String.Format(
                    "INSERT INTO CLIENTES (COD_CLIENTE, " +
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
                    "RESTRICAO) " +
                    "VALUES ('{0}', " +
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

        public void ExcluirCliente(Cliente cliente)
        {
            try
            {
                int Codigo = Convert.ToInt32(cliente.Cod_Cliente);

                String excluiC = (String.Format(
                    "DELETE FROM CLIENTES " +
                    "WHERE COD_CLIENTE = '{0}'",
                    Codigo));

                NpgsqlCommand comandoDelete = new NpgsqlCommand
                    (excluiC, ConnectionFactory.Connect());
                comandoDelete.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Excluir Cliente!" + ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
        }

        public void InserirCodigo(Cliente cliente)
        {
            try
            {
                String insereCo = (String.Format(
                    "SELECT MAX(COD_CLIENTE) " +
                    "FROM CLIENTES "));

                NpgsqlDataAdapter da = new NpgsqlDataAdapter
                    (new NpgsqlCommand(insereCo, ConnectionFactory.Connect()));
                DataTable dt = new DataTable();
                da.Fill(dt);

                cliente.Cod_Cliente = dt.Rows[0]["max"].ToString();

                if (cliente.Cod_Cliente == "")
                    cliente.Cod_Cliente = "0";

                int Codigo = Convert.ToInt32(cliente.Cod_Cliente);
                Codigo = Codigo + 1;
                cliente.Cod_Cliente = Codigo.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao incluir campo na base de dados!" + ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
        }

        public DataTable ConsultarCliente(String NomeCliente) 
        {
            String consultaC = (String.Format(
                     "SELECT *                 " +
                     "  FROM CLIENTES          " +
                     " WHERE NOME LIKE '%{0}%' ",
                     NomeCliente));

            NpgsqlDataAdapter da = new NpgsqlDataAdapter
                   (new NpgsqlCommand(consultaC, ConnectionFactory.Connect()));
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public void PesquisarCliente(Cliente cliente)
        {
            String pesquisaC = (String.Format(
                     "SELECT COD_CLIENTE " +
                     "  FROM CLIENTES " +
                     " WHERE NOME = '{0}' ",
                     cliente.Nome));

            NpgsqlDataAdapter da = new NpgsqlDataAdapter
                    (new NpgsqlCommand(pesquisaC, ConnectionFactory.Connect()));
            DataTable dt = new DataTable();
            da.Fill(dt);

            cliente.Cod_Cliente = dt.Rows[0]["COD_CLIENTE"].ToString();
        }
    }
}
