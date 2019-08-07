using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Movimentacao
    {
        private String cod_mov_veiculos;
        private String cod_marca;
        private String cod_modelo;
        private String versao;
        private String ano_fabricacao;
        private String ano_modelo;
        private String cor;
        private String placa;
        private String renavam;
        private String observacoes;
        private String valor_entrada;
        private String valor_saida;
        private String data_entrada;
        private String data_saida;
        private String cod_cliente_entrada;
        private String cod_cliente_saida;

        public String Cod_Mov_Veiculos
        {
            get { return cod_mov_veiculos; }
            set { cod_mov_veiculos = value; }
        }

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

        public String Versao
        {
            get { return versao; }
            set { versao = value; }
        }

        public String Ano_Fabricacao
        {
            get { return ano_fabricacao; }
            set { ano_fabricacao = value; }
        }

        public String Ano_Modelo
        {
            get { return ano_modelo; }
            set { ano_modelo = value; }
        }

        public String Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        public String Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        public String Renavam
        {
            get { return renavam; }
            set { renavam = value; }
        }

        public String Observacoes
        {
            get { return observacoes; }
            set { observacoes = value; }
        }

        public String Valor_Entrada
        {
            get { return valor_entrada; }
            set { valor_entrada = value; }
        }

        public String Valor_Saida
        {
            get { return valor_saida; }
            set { valor_saida = value; }
        }

        public String Data_Entrada
        {
            get { return data_entrada; }
            set { data_entrada = value; }
        }

        public String Data_Saida
        {
            get { return data_saida; }
            set { data_saida = value; }
        }

        public String Cod_Cliente_Entrada
        {
            get { return cod_cliente_entrada; }
            set { cod_cliente_entrada = value; }
        }

        public String Cod_Cliente_Saida
        {
            get { return cod_cliente_saida; }
            set { cod_cliente_saida = value; }
        }
    }
}
