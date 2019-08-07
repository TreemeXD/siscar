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
    public class GraficoBLL
    {
        public DataTable ConsultarMarca()
        {
            GraficoDAL graficodal = new GraficoDAL();
            return graficodal.ConsultarMarca();
        }

        public DataTable ConsultarModelo()
        {
            GraficoDAL graficodal = new GraficoDAL();
            return graficodal.ConsultarModelo();
        }
    }
}
