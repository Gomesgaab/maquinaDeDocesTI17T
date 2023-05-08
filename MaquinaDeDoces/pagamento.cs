using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
     class pagar
        // definição de variavel
    {
        private int      codigo; 
        private string   descricao;
        private double   valorTotal;
        private int      formaDepagamento;
        private DateTime dataHora;
        private int      CodCartao;
        private int      bandeira;


        // metodo construtor 
        public pagar()
        {
            ModificarCodigo           = 0;
            ModificarDescricao        = "";
            ModificarValortotal       = 0;
            ModificarFormadepagamento = 0;
            ModificarDataHora         = new DateTime();
            ModificarCOdcartao        = 0;
            ModificarBandeira         = 0;

        }// fim do metodo construtor 
     public pagar(int codigo, string descricao, double valorTotal, int formaDepagamento, DateTime dataHora, int CodCartao, int bandeira)
        {
            ModificarCodigo           = codigo;
            ModificarDescricao        = descricao;
            ModificarValortotal       = valorTotal;
            ModificarFormadepagamento =  formaDepagamento;
            ModificarDataHora         =  dataHora;
            ModificarCOdcartao        =  CodCartao;
            ModificarBandeira         =  bandeira;

        }// fim do metodo construtor com parametros 

        // metodo get set
        public int Modificar




    }// fim da definição de variavel 


}   
