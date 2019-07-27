using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Marca
    {
        private String cod_marca;
        private String ds_marca;

        public String Cod_Marca
        {
            get { return cod_marca; }
            set { cod_marca = value; }
        }

        public String Ds_Marca
        {
            get { return ds_marca; }
            set { ds_marca = value; }
        }
    }
}
