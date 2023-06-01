using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
     class Pagar
        // definição de variavel
    {
        private int        codigo; 
        private double     valorTotal;
        private short      formaDepagamento;
        private DateTime   dataHora;
        private int        CodCartao;
        private short      bandeira;
        private double     trocoMaquina;
        private double troco;


        // criação do metodo construtor 
        public Pagar()
        {
            ModificarCodigo           = 0;
            ModificarValortotal       = 0;
            ModificarFormadepagamento = 0;
            ModificarDataHora         = new DateTime();
            ModificarCodcartao        = 0;
            ModificarBandeira         = 0;
            ModificarTrocoMaquina     = 100;
            ModificarTroco = 0;

        }// fim do metodo construtor 
        public Pagar(int codigo, double valorTotal, short formaDepagamento, DateTime dataHora, int CodCartao, short bandeira)
        {
            ModificarCodigo           = codigo;
            ModificarValortotal       = valorTotal;
            ModificarFormadepagamento =  formaDepagamento;
            ModificarDataHora         =  dataHora;
            ModificarCodcartao        =  CodCartao;
            ModificarBandeira         =  bandeira;
            ModificarTroco= troco;

        }// fim do metodo construtor com parametros 

        // metodo get set
        public int Modificarcodigo
        {
            get { return this.codigo;}// fim do get 
            set { this.codigo = value; }// fim do set 
        }// fim do metodo modificar codigo 

        public double ModificarValortotal
        {
            get { return this.valorTotal;}
            set {this.valorTotal = value;}
        }// fim do modificar valor total 

        public short ModificarFormadepagamento
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

        public short ModificarBandeira
        {
            get { return this.bandeira; }
            set { this.bandeira = value;}
        }// fim do modificar bandeira 

        public double ModificarTrocoMaquina
        {
            get { return this.trocoMaquina; }
            set { this.trocoMaquina = value; }
        }

        public double ModificarTroco
        {
            get { return this.troco; }
            set { this.troco = value; }
        }

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

        public string VerificarNotas(double entradaDinheiro, double valorProduto)
        {
            if(entradaDinheiro >= valorProduto)
            {
                return "ok";
                    
            }
            else
            {
                return "NOK"
            }
        }// fim verificar notas 


        public Boolean ExisteTroco(double entradaDinheiro, double valorProduto)
        {
                if (entradaDinheiro > valorProduto)
                {
                    return true;
                }
                return false;
            
        }//fim do troco existente 
        
        // metodo verificar troco 
        public void VerificarTroco(double entradaDinheiro, double valorProduto)
        {
            Boolean resptroco = false;
            resptroco = ExisteTroco(entradaDinheiro,valorProduto);
            if(resptroco== true)
            {
                ModificarTroco = entradaDinheiro - valorProduto;
            }
            else
            {
                ModificarTroco = 0;
            }
              
        }// fim do verifica troco 

        public string MenuFormadepagamento()
        {
            return "Escolha uma forma de pagamento abaixo: " + "\n1. Dinheiro \n2. Cartão";
        }// fim do método
        
        pubic void ColetarFormaDePagamento(short opcao)
        {
            ModificarFormadepagamento = opcao;
        }// fim do coletar 

        public double EfetuarPagamentodinheiro(short opcao, double entradaPagamento, double valorProduto)
        {
            string resp = "";
            resp = VerificarNotas(entradaPagamento, valorProduto);
            if (resp == "ok")
            {
                Modificarcodigo++;
                ModificarValortotal = valorProduto;
                ModificarFormadepagamento = opcao;
                ModificarDataHora = DateTime.Now;//pegar data e hora da tranzação
                ModificarTrocoMaquina += valorProduto;
                VerificarTroco(entradaPagamento, valorProduto);
                imprimir();                         
            }
        }// fim do metodo efetuar pagamento 

        public void EfetuarPagamentoCartao(double entradaPagameto, double valorProduto, int codCartao, short baneira)
        {
            Modificarcodigo++;
            ModificarValortotal = valorProduto;
            ModificarFormadepagamento = opcao;
            ModificarDataHora = DateTime.Now;//pegar data e hora da tranzação
            ModificarBandeira = bandeira;
            ModificarCodcartao = codCartao;
            imprimir();
        }// dim do efetuar pagamento cartão 
            
         // metodo pagamento 
        public string imprimir()
        {
            return "Codigo: "               + Modificarcodigo +
                   "\nValor Total: "        + ModificarValortotal +
                   "\nTroco: "              + ModificarTroco +
                   "\nForma de Pagamento: " + ModificarFormadepagamento +
                   "\nData e Hora: "        + ModificarDataHora;
        }// fim imprimir 




    }// fim da definição de variavel 


}// fim do projeto    
