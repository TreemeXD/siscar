using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Modelo
    {
        private String cod_marca;
        private String cod_modelo;
        private String ds_modelo;

        public String Cod_Marca
        {
            get { return cod_marca; }
            set { cod_marca = value; }
        }

        public String Cod_Modelo
        {
            get { return cod_modelo; }
            set { cod_modelo = value; }
        }

        public String Ds_Modelo
        {
            get { return ds_modelo; }
            set { ds_modelo = value; }
        }
    }
}
