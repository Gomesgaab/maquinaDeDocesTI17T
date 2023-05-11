using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
     class Pagar
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
        public Pagar()
        {
            ModificarCodigo           = 0;
            ModificarDescricao        = "";
            ModificarValortotal       = 0;
            ModificarFormadepagamento = 0;
            ModificarDataHora         = new DateTime();
            ModificarCodcartao        = 0;
            ModificarBandeira         = 0;

        }// fim do metodo construtor 
     public Pagar(int codigo, string descricao, double valorTotal, int formaDepagamento, DateTime dataHora, int CodCartao, int bandeira)
        {
            ModificarCodigo           = codigo;
            ModificarDescricao        = descricao;
            ModificarValortotal       = valorTotal;
            ModificarFormadepagamento =  formaDepagamento;
            ModificarDataHora         =  dataHora;
            ModificarCodcartao        =  CodCartao;
            ModificarBandeira         =  bandeira;

        }// fim do metodo construtor com parametros 

        // metodo get set
        public int Modificarcodigo
        {
            get { return this.codigo;}// fim do get 
            set { this.codigo = value; }// fim do set 
        }// fim do metodo modificar codigo 

        public int ModificarCodigo { get; private set; }

        public string ModificarDescricao
        {
            get { return this.descricao;}
            set { this.descricao = value;}
        }// fim do metodo mOdificar descrição 

        public double ModificarValortotal { get; private set; }

        public double ModificarValorttal
        {
            get { return this.valorTotal;}
            set {this.valorTotal = value;}
        }// fim do modificar valor total 

        public int ModificarFormadepagamento
        {
            get { return this.formaDepagamento;}
            set { this.formaDepagamento = value;}
        }// fim do modificar forma de pagamento

        public DateTime ModificarDataHora
        {
            get { return this.dataHora; }
            set { this.dataHora = value;}
        }// fim do modificar data hora 

        public int ModificarCodcartao
        {
            get { return this.CodCartao; }
            set { this.CodCartao = value; }
        }// fim do modificar co cartão 

        public int ModificarBandeira
        {
            get { return this.bandeira; }
            set { this.bandeira = value;}
        }// fim do modificar bandeira 

        // Metodo consultar pagamento 
        public void cadastrarPagamento(int codigo, string descricao, double valorTotal, int formaDepagamento, DateTime dataHora, int CodCartao, int bandeira)
        {
            ModificarCodigo           = codigo;
            ModificarDescricao        = descricao;
            ModificarValortotal       = valorTotal;
            ModificarFormadepagamento = formaDepagamento;
            ModificarDataHora         = dataHora;
            ModificarCodcartao        = CodCartao;
            ModificarBandeira         = bandeira;
            
        }// fim do metodo consultar pagamento 

        public string ConsultarPagamento(int codgo)
        {
            string msg = ""; // crinando uma variavel local 

            if(ModificarCodigo == codigo)
            {
                msg = "\nCódigo: " + ModificarCodigo +
                      "\nNome: " + ModificarDescricao +
                      "\nValortotal: " + ModificarValortotal +
                      "\nForma de pagamento: " + ModificarFormadepagamento +
                      "\nData hora: " + ModificarDataHora +
                      "\nCod cartão: " + ModificarCodcartao +
                      "\nBandeira: " + ModificarBandeira;
            }
            else
            {
                msg = "O código informado não e valido!";
            }
            return msg;
        }// fim do metodo consultar 

        public Boolean ValidarCartao(int CodCatao)
        {
            Boolean sistemaExterno = false;

            if(ModificarCodcartao == CodCatao)
            {
                if(sistemaExterno == true)
                {
                      sistemaExterno = false;
                }
                else
                {
                    sistemaExterno = true;
                }// fim da situação
                sistemaExterno = true;
            }// fim do modificar código 
            return sistemaExterno;
        }// fim do metodo vlaidar cartão 

        // metodo verificar troco 
        public Boolean VerificarTroco(int formaDepagamento)
        {
            Boolean TrocoDisponivel = false;

            if(ModificarFormadepagamento == formaDepagamento)
            {
                if(TrocoDisponivel == true)
                {
                    TrocoDisponivel = false;
                }
                else
                {
                    TrocoDisponivel = true;
                }// fim da situação 
                TrocoDisponivel = true;
            }// fim do se 
            return TrocoDisponivel;
        }// fim do metodo 




    }// fim da definição de variavel 


}   
