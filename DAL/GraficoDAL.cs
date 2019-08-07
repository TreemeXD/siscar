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
    public class GraficoDAL
    {
        public DataTable ConsultarMarca()
        {
            String ConsultaMa = (String.Format(
                "SELECT MA.DS_MARCA X, " +
                "COUNT(1) Y " +
                "FROM MOV_VEICULOS MV, " +
                "MARCAS MA " +
                "WHERE MV.COD_MARCA = MA.COD_MARCA " +
                "GROUP BY MA.DS_MARCA"));                     

            NpgsqlDataAdapter da = new NpgsqlDataAdapter
                    (new NpgsqlCommand(ConsultaMa, ConnectionFactory.Connect()));
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable ConsultarModelo()
        {
            String ConsultaMo = (String.Format(
                "SELECT MO.DS_MODELO X, " +
                "COUNT(1) Y " +
                "FROM MOV_VEICULOS MV, " +
                "MODELOS MO " +
                "WHERE MV.COD_MODELO = MO.COD_MODELO " +
                "GROUP BY MO.DS_MODELO"));

            NpgsqlDataAdapter da = new NpgsqlDataAdapter
                    (new NpgsqlCommand(ConsultaMo, ConnectionFactory.Connect()));
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

    }
}
