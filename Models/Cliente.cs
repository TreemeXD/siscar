using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cliente
    {
        private String cod_cliente;
        private String nome;
        private String cpf;
        private String data_nasc;
        private String endereco;
        private String bairro;
        private String cep;
        private String cidade;
        private String estado;
        private String fone1;
        private String fone2;
        private String sexo;
        private String restricao;        

        public String Cod_Cliente
        {
            get { return cod_cliente; }
            set { cod_cliente = value; }
        }

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public String CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public String Data_Nasc
        {
            get { return data_nasc; }
            set { data_nasc = value; }
        }

        public String Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public String Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public String CEP
        {
            get { return cep; }
            set { cep = value; }
        }

        public String Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public String Fone1
        {
            get { return fone1; }
            set { fone1 = value; }
        }

        public String Fone2
        {
            get { return fone2; }
            set { fone2 = value; }
        }

        public String Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public String Restricao
        {
            get { return restricao; }
            set { restricao = value; }
        }        
    }
}
