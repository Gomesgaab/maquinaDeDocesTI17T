using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{

     class ControlProduto
    {
        Produto prod;
        
        private int opcao;

        public ControlProduto()
        {
            prod = new Produto();
            ModificarOpcao = -1;
        }// fim do construtor



        // Metodo get set 
        public int ModificarOpcao
        {
            get { return opcao; }
            set { opcao = value; }
        }//FIm do metodo get set 



        public void Menu()
        {
            Console.WriteLine("\n\n\nEscolha uma das opções abaixo: \n" +
                              "0. Sair\n"                         +
                              "1. Castrar produto\n"              +
                              "2. Consultar produto\n"            +
                              "3. Atualizar produto\n"            +
                              "4. Mudar situação\n");
            ModificarOpcao = Convert.ToInt32(Console.ReadLine());
        }// fim do menu 

        // Realizar a opração 
        public void Operacao()
        {
            do
            {


                Menu();//Mostrando menu na tela 
                switch (ModificarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado");
                        Console.Clear();// limpa tela 
                        break;
                    case 1:
                        ColetarDados();
                        Console.Clear();// limpa tela 
                        break;
                    case 2:
                        Consultar();
                        Console.Clear();// limpa tela 
                        break;
                    case 3:
                        Atualizar();
                        Console.Clear();// limpa tela 
                        break;
                    case 4:
                        AlterarSituacao();
                        Console.Clear();// limpa tela 
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não e valida");
                        Console.Clear();// limpa tela 
                        break;



                }// fim do swich
            }while(ModificarOpcao !=0);
        }// fim do metodo opereção 

        //criar metodo de solicitação d dados
        public void ColetarDados()
        {
            //coletar dados 
            Console.WriteLine("Informe o codigo");
            int codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o nome do produto");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe a descrição do produtp");
            string descricao = Console.ReadLine();

            Console.WriteLine("Informe o preço");
            double preco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de produtos");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a data de validade do produto");
            DateTime dtValidade = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Informe a situação do produto");
            Boolean situacao = Convert.ToBoolean(Console.ReadLine());


            //cadastrar produto 
            prod.CadastrarProduto(codigo, nome, descricao, preco, quantidade, dtValidade, situacao);
            Console.WriteLine("Dado registrado!");
        }// fim do coletar dados

        // consultar
        //void usado quando naão tem retorno de dados 
        public void Consultar()
        {
            //consltar dados do produto 
            Console.WriteLine("\n\n\nInforme o código que deseja consultar");
            int codigo = Convert.ToInt32(Console.ReadLine());

            // escrever resultado na tela
            Console.WriteLine("Os dado do produto escolhido são: \n\n\n" + prod.ConsultarProduto(codigo));
        }//Fim do metodo 

        // atualizar 
        public void Atualizar()
        {
            //atualizar rpoduto 
            Console.WriteLine("\n\n\n Informe o codigo do produto que deseja atualizar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            
            short campo = 0;
            do
            {

                Console.WriteLine("\n\n\n Informe o campo que deseja atualizar de acordo com a regra abaixo: \n" +
                                  "1. Nome:\n" +
                                  "2. Descrição:\n" +
                                  "3. Preço:\n" +
                                  "4. Quantidade:\n" +
                                  "5. Situação:\n" +
                                  "6. Data de validade:\n");
            campo = Convert.ToInt16(Console.ReadLine());
                
                //avisar o usuario 
                if ((campo < 1) || (campo > 6))
                {
                    Console.WriteLine("Erro,escolha um codigo entro 1 e 6");
                }// fim do if

            } while ((campo < 1) || (campo > 6));
            
            
            Console.WriteLine("Informe o dado para a atualização: ");
                string novoDado = Console.ReadLine();

                // chamar metodo de atualização 
                prod.AtualizarProduto(codigo, campo, novoDado);

                // chamar o método alterar situação - classe produto 
                prod.AlterarSituacao(codigo);
                Console.WriteLine("Alterado com sucesso: ");

                Console.ReadLine();//Manter a janela aberta

           
        }// fim do metodo atualizar 

        public void AlterarSituacao()
        {
            Console.WriteLine("Infome o código do produto que deseja alterar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

        }// fim do metodo alterar 

    }//Fim da classe
}//Fim projeto
