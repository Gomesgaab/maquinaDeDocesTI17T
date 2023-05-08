using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class Program
    {
        static void Main(string[] args)
        {
            //conecta com a classe controlv produto
            ControlProduto controlProd= new ControlProduto();

            // chamar metodo pricinpal daquela classe 
            controlProd.Operacao();

            //Console.ReadLine();//Manter a janela aberta 

        }// fim do metodo main
    }//fim da classe 
}// fim do projeto 
