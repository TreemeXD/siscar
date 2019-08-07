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
    public class ModeloDAL
    {
        public void InserirModelo(Modelo modelo)
        {
            try
            {
                String insereMo = (String.Format(
                    "INSERT INTO MODELOS (COD_MARCA, " +
                    "COD_MODELO, " +
                    "DS_MODELO)" +
                    "VALUES ('{0}', " +
                    "'{1}', " +
                    "'{2}')",
                    modelo.Cod_Marca,
                    modelo.Cod_Modelo,
                    modelo.Ds_Modelo));

                NpgsqlCommand comandoInsert = new NpgsqlCommand
                    (insereMo, ConnectionFactory.Connect());
                comandoInsert.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Inserir Modelo!" + ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
        }

        public void ExcluirModelo(Modelo modelo)
        {
            try
            {
                int Codigo = Convert.ToInt32(modelo.Cod_Modelo);

                String excluiMo = (String.Format(
                    "DELETE FROM MODELOS " +
                    "WHERE COD_MODELO = '{0}'",
                    Codigo));

                NpgsqlCommand comandoDelete = new NpgsqlCommand
                    (excluiMo, ConnectionFactory.Connect());
                comandoDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao Excluir Modelo!" + ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
        }

        public void InserirCodigo(Modelo modelo)
        {
            try
            {
                String insereCo = (String.Format(
                    "SELECT MAX(COD_MODELO) " +
                    "FROM MODELOS "));

                NpgsqlDataAdapter da = new NpgsqlDataAdapter
                    (new NpgsqlCommand(insereCo, ConnectionFactory.Connect()));
                DataTable dt = new DataTable();
                da.Fill(dt);

                modelo.Cod_Modelo = dt.Rows[0]["max"].ToString();

                if (modelo.Cod_Modelo == "")
                    modelo.Cod_Modelo = "0";

                int Codigo = Convert.ToInt32(modelo.Cod_Modelo);
                Codigo = Codigo + 1;
                modelo.Cod_Modelo = Codigo.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao inserir Código!" + ex.Message);
            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
        }

        public DataTable ConsultarModelo(String NomeModelo)
        {
            String consultaM = (String.Format(
                "SELECT A.COD_MODELO, " +
                "B.DS_MARCA, " +
                "A.DS_MODELO " +
                "FROM MODELOS A, " +
                "MARCAS  B " +
                "WHERE A.COD_MARCA = B.COD_MARCA " +
                "AND A.DS_MODELO LIKE '%{0}%' ",
                NomeModelo));

            NpgsqlDataAdapter da = new NpgsqlDataAdapter
                   (new NpgsqlCommand(consultaM, ConnectionFactory.Connect()));
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable RetornaModelo(String NomeMarca)
        {
            String retornaM = (String.Format(
                "SELECT A.COD_MODELO, " +
                "B.DS_MARCA, " +
                "A.DS_MODELO " +
                "FROM MODELOS A, " +
                "MARCAS  B " +
                "WHERE A.COD_MARCA = B.COD_MARCA " +
                "AND B.DS_MARCA = '{0}' ", NomeMarca));

            NpgsqlDataAdapter da = new NpgsqlDataAdapter
                   (new NpgsqlCommand(retornaM, ConnectionFactory.Connect()));
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
