using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class ControlPagamento
    {
        Pagar pag;

        private int opcao;

        public ControlPagamento()
        {
            pag = new Pagar();
            ModificarOpcao = -1;
        }// fim do construtor

        // metodo get set 
        public int ModificarOpcao
        {
            get { return opcao; }
            set { opcao = value; }
        }// fim do metodo get set 
        
        
        public void Menu()
        {
            Console.WriteLine("\n\n\nEscolhe uma opção: \n" +
                              "0. Sair\n" +
                              "1. Cadastrar Oagamento\n" +
                              "2. Consultar Pagamento\n" +
                              "3. Verificar troco\n");
            ModificarOpcao = Convert.ToInt32(Console.ReadLine());
        } // fim do menu 

        // realizar operação 
        public void Operacao()
        {
            do
            {

                Menu();// mostrando o menu
                switch (ModificarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado")
                        Console.Clear(); 
                }
            }
        }
    }
}
