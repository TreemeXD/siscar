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
    public class MovimentacaoDAL
    {
        public void AtualizarMovimentacaoSaida(Movimentacao movimentacao)
        {
            try
            {
                String atualizaS = (String.Format(
                    "UPDATE MOV_VEICULOS " +
                    "SET COD_MARCA = '{1}', " +
                    "COD_MODELO = '{2}', " +
                    "VERSAO = '{3}', " +
                    "ANO_FABRICACAO = '{4}', " +
                    "ANO_MODELO = '{5}', " +
                    "COR = '{6}', " +
                    "PLACA = '{7}', " +
                    "RENAVAM = '{8}', " +
                    "OBSERVACOES = '{9}', " +
                    "VALOR_SAIDA = '{10}', " +
                    "DATA_SAIDA = '{11}', " +
                    "COD_CLIENTE_SAIDA = '{12}' " +
                    "WHERE COD_MOV_VEICULOS  = '{0}'",
                    movimentacao.Cod_Mov_Veiculos,
                    movimentacao.Cod_Marca,
                    movimentacao.Cod_Modelo,
                    movimentacao.Versao,
                    movimentacao.Ano_Fabricacao,
                    movimentacao.Ano_Modelo,
                    movimentacao.Cor,
                    movimentacao.Placa,
                    movimentacao.Renavam,
                    movimentacao.Observacoes,
                    movimentacao.Valor_Saida,
                    movimentacao.Data_Saida,
                    movimentacao.Cod_Cliente_Saida));

                NpgsqlCommand comandoUpdate = new NpgsqlCommand
                    (atualizaS, ConnectionFactory.Connect());
                comandoUpdate.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Atualizar os Dados da Movimentação!" + ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
        }

        public void AtualizarMovimentacaoEntrada(Movimentacao movimentacao)
        {
            try
            {                
                String atualizaE = (String.Format(
                    "UPDATE MOV_VEICULOS " +
                    "SET COD_MARCA = '{1}', " +
                    "COD_MODELO = '{2}', " +
                    "VERSAO = '{3}', " +
                    "ANO_FABRICACAO = '{4}', " +
                    "ANO_MODELO = '{5}', " +
                    "COR = '{6}', " +
                    "PLACA = '{7}', " +
                    "RENAVAM = '{8}', " +
                    "OBSERVACOES = '{9}', " +
                    "VALOR_ENTRADA = '{10}', " +                    
                    "DATA_ENTRADA = '{11}', " +                    
                    "COD_CLIENTE_ENTRADA = '{12}' " +                    
                    "WHERE COD_MOV_VEICULOS  = '{0}'",
                    movimentacao.Cod_Mov_Veiculos,
                    movimentacao.Cod_Marca,
                    movimentacao.Cod_Modelo,
                    movimentacao.Versao,
                    movimentacao.Ano_Fabricacao,
                    movimentacao.Ano_Modelo,
                    movimentacao.Cor,
                    movimentacao.Placa,
                    movimentacao.Renavam,
                    movimentacao.Observacoes,
                    movimentacao.Valor_Entrada,                    
                    movimentacao.Data_Entrada,                   
                    movimentacao.Cod_Cliente_Entrada));                   

                NpgsqlCommand comandoUpdate = new NpgsqlCommand
                    (atualizaE, ConnectionFactory.Connect());
                comandoUpdate.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Atualizar os Dados da Movimentação!" + ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
        }

        public void InserirMovimentacaoEntrada(Movimentacao movimentacao)
        {
            try
            {               
                
                String insereE = (String.Format(
                    "INSERT INTO MOV_VEICULOS " +
                    "(COD_MOV_VEICULOS, " +
                    "COD_MARCA, " +
                    "COD_MODELO, " +
                    "VERSAO, " +
                    "ANO_FABRICACAO, " +
                    "ANO_MODELO, " +
                    "COR, " +
                    "PLACA, " +
                    "RENAVAM, " +
                    "OBSERVACOES, " +
                    "VALOR_ENTRADA, " +                    
                    "DATA_ENTRADA, " +                   
                    "COD_CLIENTE_ENTRADA) " +                    
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
                    movimentacao.Cod_Mov_Veiculos,
                    movimentacao.Cod_Marca,
                    movimentacao.Cod_Modelo,
                    movimentacao.Versao,
                    movimentacao.Ano_Fabricacao,
                    movimentacao.Ano_Modelo,
                    movimentacao.Cor,
                    movimentacao.Placa,
                    movimentacao.Renavam,
                    movimentacao.Observacoes,
                    movimentacao.Valor_Entrada,                    
                    movimentacao.Data_Entrada,                    
                    movimentacao.Cod_Cliente_Entrada));                   

                NpgsqlCommand comandoInsert = new NpgsqlCommand
                    (insereE, ConnectionFactory.Connect());
                comandoInsert.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Inserir Movimentação!" + ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
        }

        public void InserirMovimentacaoSaida(Movimentacao movimentacao)
        {
            try
            {
                String insereS = (String.Format(
                    "INSERT INTO MOV_VEICULOS " +
                    "(COD_MOV_VEICULOS, " +
                    "COD_MARCA, " +
                    "COD_MODELO, " +
                    "VERSAO, " +
                    "ANO_FABRICACAO, " +
                    "ANO_MODELO, " +
                    "COR, " +
                    "PLACA, " +
                    "RENAVAM, " +
                    "OBSERVACOES, " +
                    "VALOR_SAIDA, " +
                    "DATA_SAIDA, " +
                    "COD_CLIENTE_SAIDA) " +
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
                    movimentacao.Cod_Mov_Veiculos,
                    movimentacao.Cod_Marca,
                    movimentacao.Cod_Modelo,
                    movimentacao.Versao,
                    movimentacao.Ano_Fabricacao,
                    movimentacao.Ano_Modelo,
                    movimentacao.Cor,
                    movimentacao.Placa,
                    movimentacao.Renavam,
                    movimentacao.Observacoes,
                    movimentacao.Valor_Saida,
                    movimentacao.Data_Saida,
                    movimentacao.Cod_Cliente_Saida));

                NpgsqlCommand comandoInsert = new NpgsqlCommand
                    (insereS, ConnectionFactory.Connect());
                comandoInsert.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Inserir Movimentação!" + ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
        }

        public void ExcluirMovimentacao(Movimentacao movimentacao)
        {
            try
            {
                String excluiC = (String.Format(
                    "DELETE FROM MOV_VEICULOS " +
                    "WHERE COD_MOV_VEICULOS = '{0}'",
                    movimentacao.Cod_Mov_Veiculos));

                NpgsqlCommand comandoDelete = new NpgsqlCommand
                    (excluiC, ConnectionFactory.Connect());
                comandoDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Excluir Movimentação!" + ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
        }

        public void InserirCodigo(Movimentacao movimentacao)
        {
            try
            {
                String insereCo = (String.Format(
                    "SELECT MAX(COD_MOV_VEICULOS) " +
                    "FROM MOV_VEICULOS "));

                NpgsqlDataAdapter da = new NpgsqlDataAdapter
                    (new NpgsqlCommand(insereCo, ConnectionFactory.Connect()));
                DataTable dt = new DataTable();
                da.Fill(dt);

                movimentacao.Cod_Mov_Veiculos = dt.Rows[0]["max"].ToString();

                if (movimentacao.Cod_Mov_Veiculos == "")
                    movimentacao.Cod_Mov_Veiculos = "0";

                int Codigo = Convert.ToInt32(movimentacao.Cod_Mov_Veiculos);
                Codigo = Codigo + 1;
                movimentacao.Cod_Mov_Veiculos = Codigo.ToString();
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

        public DataTable ConsultarMovimentacaoEntrada(String TEXTO)
        {
            String consultaE = (String.Format(
                     "SELECT MV.COD_MOV_VEICULOS, " +
                     "MA.DS_MARCA, " +
                     "MO.DS_MODELO, " +
                     "MV.VERSAO, " +
                     "MV.ANO_FABRICACAO, " +
                     "MV.ANO_MODELO, " +
                     "MV.COR, " +
                     "MV.PLACA, " +
                     "MV.RENAVAM, " +
                     "MV.OBSERVACOES, " +
                     "TO_CHAR(MV.DATA_ENTRADA,'DD/MM/YYYY') AS DATA_ENTRADA, " +
                     "MV.VALOR_ENTRADA, " +
                     "C1.NOME " +                     
                     "FROM MOV_VEICULOS MV, " +
                     "MARCAS MA, " +
                     "MODELOS MO, " +
                     "CLIENTES C1 " +                     
                     "WHERE MV.COD_MARCA = MA.COD_MARCA " +
                     "AND MV.COD_MODELO = MO.COD_MODELO " +
                     "AND MV.COD_CLIENTE_ENTRADA = C1.COD_CLIENTE " +                     
                     "AND MV.PLACA LIKE '%{0}%' " +
                     "ORDER BY MV.COD_MOV_VEICULOS ", TEXTO));

            NpgsqlDataAdapter da = new NpgsqlDataAdapter
                   (new NpgsqlCommand(consultaE, ConnectionFactory.Connect()));
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable ConsultarMovimentacaoSaida(String TEXTO)
        {
            String consultaS = (String.Format(
                     "SELECT MV.COD_MOV_VEICULOS, " +
                     "MA.DS_MARCA, " +
                     "MO.DS_MODELO, " +
                     "MV.VERSAO, " +
                     "MV.ANO_FABRICACAO, " +
                     "MV.ANO_MODELO, " +
                     "MV.COR, " +
                     "MV.PLACA, " +
                     "MV.RENAVAM, " +
                     "MV.OBSERVACOES, " +    
                     "TO_CHAR(MV.DATA_SAIDA,'DD/MM/YYYY') AS DATA_SAIDA, " +
                     "MV.VALOR_SAIDA, " +
                     "C2.NOME " +
                     "FROM MOV_VEICULOS MV, " +
                     "MARCAS MA, " +
                     "MODELOS MO, " +                    
                     "CLIENTES C2 " +
                     "WHERE MV.COD_MARCA = MA.COD_MARCA " +
                     "AND MV.COD_MODELO = MO.COD_MODELO " +
                     "AND MV.COD_CLIENTE_SAIDA = C2.COD_CLIENTE " +
                     "AND MV.PLACA LIKE '%{0}%' " +
                     "ORDER BY MV.COD_MOV_VEICULOS ", TEXTO));

            NpgsqlDataAdapter da = new NpgsqlDataAdapter
                   (new NpgsqlCommand(consultaS, ConnectionFactory.Connect()));
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
