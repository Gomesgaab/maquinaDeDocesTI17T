using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class Produto
    {
        //Definição de variavael 
        private int codigo;
        private string nome;
        private string descricao;
        private double preco;
        private int quantidade;
        private DateTime dtValidade;
        private Boolean situacao;

        //Metodo construtor 
        public Produto() 
        { 
            ModificarCodigo = 0;
            ModificarNome = "";
            Modificardescricao = "";
            ModificarPreco = 0; 
            ModificarQuantidade = 0;
            ModificarDataValidade = new DateTime();//0000/00/00 00:00:00
            ModificarSituacao = false;
        }// Fim do metodo Construtor 
    public Produto(int codigo, string nome, string descricao, double preco, int quantidade, DateTime dtValidade, Boolean situacao)
        {
            ModificarCodigo = codigo;
            ModificarNome = nome;   
            Modificardescricao = descricao;
            ModificarPreco = preco;
            ModificarQuantidade = quantidade;
            ModificarDataValidade = dtValidade;
            ModificarSituacao = situacao;

        }//Fom do metodo construto com parametros 

        //Metodos get e set 
       // Métodos de acesso e modificação
       public int ModificarCodigo
        {
            get{ return this.codigo;}//Fim do get - retornar o codigo , pegar o codigo 
            set{ this.codigo = value; }// fim do set - modificar, definir valor 
        }//Fim do modificar codigo 
         
        public string ModificarNome
        {
            get { return this.nome;}
            set { this.nome = value;}
        }// fim do Modificar nome 

        public string Modificardescricao
        {
            get { return this.descricao;}   
            set { this.descricao = value;}
        }// fim do modificar descrição 

        public double ModificarPreco
        {
            get { return this.preco; }
            set { this.preco = value; }
        }// fim do Modificar preço 

        public int ModificarQuantidade
        {
            get { return this.quantidade; }
            set { this.quantidade = value; }
        }//Fim Modificar quantidade 

        public DateTime ModificarDataValidade
        {
            get { return this.dtValidade; }
            set { this.dtValidade= value; }    
        }  //Fim Modificar data validade 

        public Boolean ModificarSituacao
        {
            get { return this.situacao; }
            set { this.situacao = value; }
        }//Fim modificar Situação 

        //Metodo cadastrar produtro 
        public void CadastrarProduto(int codigo, string nome, string descriccao, double preco, int quantidadde, DateTime dtValidade, Boolean situacao)
        {
            ModificarCodigo        = codigo;
            ModificarNome          = nome;    
            Modificardescricao     = descriccao;    
            ModificarPreco         = preco; 
            ModificarDataValidade  = dtValidade; 
            ModificarSituacao      = situacao;    
        }//Fim do métoro cadastrar produto  

        //COnsultar Produto 
        public string CnsultarProduto(int codigo)
        {
            string msg = ""; //criando uma variavel local 

            if(ModificarCodigo == codigo)
            {
                msg = "\nCódigo: "           + ModificarCodigo +
                      "\nNome: "             + ModificarNome +
                      "\nDescriço: "         + Modificardescricao +
                      "\nPreço: "            + ModificarPreco +
                      "\nQuantidade: "       + ModificarQuantidade +
                      "\nDaya de Validade: " + ModificarDataValidade +
                      "\nSituação: "         + ModificarSituacao;
            }
            else
            {
                msg = "O código digitado não existe!";
            }

            return msg;
        }//Fim do metodo 

        // Metodo Atualizar 
        public Boolean AtualizarProduto(int codigo, int campo, string NovoDado)
        {
            Boolean flag = false;

            if(ModificarCodigo == codigo)
            {
                switch (campo)
                {
                    case 1:
                        ModificarNome = NovoDado;
                        flag= true;
                        break; //Parar de executar, quebrar a operação 
                    case 2:
                        Modificardescricao = NovoDado;
                        flag= true; 
                        break;
                    case 3:
                        ModificarPreco = Convert.ToDouble(NovoDado);
                        flag= true;
                        break;
                    case 4:
                        ModificarQuantidade = Convert.ToInt32(NovoDado);
                        flag = true;
                        break;
                    case 5:
                        ModificarDataValidade = Convert.ToDateTime(NovoDado);
                        flag = true;
                        break;
                    case 6:
                        ModificarSituacao = Convert.ToBoolean(NovoDado);
                        flag = true;
                        break;
                    default:
                        break;
                }//Fim escolha 
                return flag;
            }// fim if
            return flag;
        }//Fim do atulizar Produto 

        public Boolean AlterarSituacao(int codigo)
        {
            Boolean Flag = false;

            if(ModificarCodigo == codigo)
            {
                if(ModificarSituacao == true)
                {
                    ModificarSituacao = false;
                }
                else
                {
                    ModificarSituacao = true;
                }//Fim so modificar situação 
                Flag = true;
            }//Fim do modificar código
            return Flag;
        }// Fim do alterar situação 

        //solicitar produtos 
        public Boolean SolicitarProdutos(int codigo)
        {
            if (ModificarCodigo == codigo)
            {
                if (ModificarQuantidade <= 3)
                {
                    return true;
                }
            }// fim do if 
            return false;
        }//FIm do solicitar produto 

    }// fim da classe 
}// fim do projeto 
