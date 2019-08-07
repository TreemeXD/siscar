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
    public class MovimentacaoBLL
    {
        public bool verificarCampos(Movimentacao movimentacao)
        {
            if (movimentacao.Cod_Marca.Trim().Length == 0)
            {    
                throw new Exception("É obrigatório o preenchimento do campo Marca!");                 
            }

            if (movimentacao.Cod_Modelo.Trim().Length == 0) 
            {
                throw new Exception("É obrigatório o preenchimento do campo Modelo!");
            }

            if (movimentacao.Versao.Trim().Length == 0)
            {
                throw new Exception("É obrigatório o preenchimento do campo Versão!");
            }

            if (movimentacao.Ano_Fabricacao.Trim().Length == 0)
            {
                throw new Exception("É obrigatório o preenchimento do campo Ano Fabricação!");
            }

            if (movimentacao.Ano_Modelo.Trim().Length == 0)
            {
                throw new Exception("É obrigatório o preenchimento do campo Ano Modelo!");
            }

            if (movimentacao.Cor.Trim().Length == 0)
            {
                throw new Exception("É obrigatório o preenchimento do campo Cor!");
            }

            if (movimentacao.Placa.Trim().Length == 0)
            {
                throw new Exception("É obrigatório o preenchimento do campo Placa!");
            }

            if (movimentacao.Renavam.Trim().Length == 0)
            {
                throw new Exception("É obrigatório o preenchimento do campo CPF!");
            }

            return true;
        }

        public bool verificarCamposCompra(Movimentacao movimentacao)
        {
            if (movimentacao.Valor_Entrada.ToString().Trim().Length == 0)
            {
                throw new Exception("É obrigatório o preenchimento do campo Valor de Entrada!");
            }

            if (movimentacao.Cod_Cliente_Entrada.Trim().Length == 0)
            {
                throw new Exception("É obrigatório o preenchimento do campo Cliente Entrada!");
            }

            try
            {
                Convert.ToString(Convert.ToDateTime(movimentacao.Data_Entrada));               
            }
            catch
            {
                throw new Exception("Preencha o campo Data Entrada Corretamente!");
            }

            return true;
        }

        public bool verificarCamposVenda(Movimentacao movimentacao)
        {
            if (movimentacao.Valor_Saida.ToString().Trim().Length == 0)
            {
                throw new Exception("É obrigatório o preenchimento do campo Valor de Saida!");
            }

            if (movimentacao.Cod_Cliente_Saida.Trim().Length == 0)
            {
                throw new Exception("É obrigatório o preenchimento do campo Cliente Saida!");
            }

            try
            {
                Convert.ToString(Convert.ToDateTime(movimentacao.Data_Saida));
            }
            catch
            {
                throw new Exception("Preencha o campo Data Saida Corretamente!");
            }
            
            return true;
        }


        public void inserirCodigo(Movimentacao movimentacao)
        {
            MovimentacaoDAL movimentacaodal = new MovimentacaoDAL();
            movimentacaodal.InserirCodigo(movimentacao);
        }

        public void inserirMovimentacaoEntrada(Movimentacao movimentacao)
        {
            MovimentacaoDAL movimentacaodal = new MovimentacaoDAL();
            movimentacaodal.InserirMovimentacaoEntrada(movimentacao);
        }

        public void inserirMovimentacaoSaida(Movimentacao movimentacao)
        {
            MovimentacaoDAL movimentacaodal = new MovimentacaoDAL();
            movimentacaodal.InserirMovimentacaoSaida(movimentacao);
        } 

        public void atulizarMovimentacaoEntrada(Movimentacao movimentacao)
        {
            MovimentacaoDAL movimentacaodal = new MovimentacaoDAL();
            movimentacaodal.AtualizarMovimentacaoEntrada(movimentacao);
        }

        public void atulizarMovimentacaoSaida(Movimentacao movimentacao)
        {
            MovimentacaoDAL movimentacaodal = new MovimentacaoDAL();
            movimentacaodal.AtualizarMovimentacaoSaida(movimentacao);
        }

        public void excluirMovimentacao(Movimentacao movimentacao)
        {
            MovimentacaoDAL movimentacaodal = new MovimentacaoDAL();
            movimentacaodal.ExcluirMovimentacao(movimentacao);
        }

        public DataTable consultarMovimentacaoEntrada(String TEXTO)
        {
            MovimentacaoDAL movimentacaodal = new MovimentacaoDAL();
            return movimentacaodal.ConsultarMovimentacaoEntrada(TEXTO); 
        }

        public DataTable consultarMovimentacaoSaida(String TEXTO)
        {
            MovimentacaoDAL movimentacaodal = new MovimentacaoDAL();
            return movimentacaodal.ConsultarMovimentacaoSaida(TEXTO);
        } 
    }
}
