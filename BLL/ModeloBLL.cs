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
    public class ModeloBLL
    {
        public bool verificarCampos(Modelo modelo)
        {
            if (modelo.Ds_Modelo.Trim().Length == 0)
            {
                throw new Exception("É obrigatório o preenchimento do campo Modelo!");
            }

            if (modelo.Cod_Marca.Trim().Length == 0)
            {
                throw new Exception("É obrigatório o preenchimento do campo Marca!");
            }

            return true;
        }

        public void inserirCodigo(Modelo modelo)
        {
            ModeloDAL modelodal = new ModeloDAL();
            modelodal.InserirCodigo(modelo);
        }

        public void inserirModelo(Modelo modelo)
        {
            ModeloDAL modelodal = new ModeloDAL();
            modelodal.InserirModelo(modelo);
        }

        public void excluirModelo(Modelo modelo)
        {
            ModeloDAL modelodal = new ModeloDAL();
            modelodal.ExcluirModelo(modelo);
        }

        public DataTable consultarModelo(String NomeModelo)
        {
            ModeloDAL modelodal = new ModeloDAL();
            return modelodal.ConsultarModelo(NomeModelo);
        }

        public DataTable retornaModelo(String NomeMarca)
        {
            ModeloDAL modelodal = new ModeloDAL();
            return modelodal.RetornaModelo(NomeMarca);
        }
    }
}
