using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploSistemaComForWhileVetor
{
    class Sistema
    {
        Barco barco = new Barco();
        public Sistema()
        {
            GerirMenu();
        }
        // Apresentar o menu para o usuário
        public void Menu()
        {
            Console.WriteLine(@"1 - Cadastro de barcos 
2 - Editar barco 
3 - Listar barcos
4 - Buscar barco
20 - Sair");
            
        }

        public void GerirMenu()
        {
            // Chama o método para apresentar o menu para o usuário
            Menu();
            int menuEscolha = Convert.ToInt32(Console.ReadLine());
            while (menuEscolha != 20)
            {

                //Como se fosse um "if", porém com "==" 

                switch (menuEscolha)
                {
                    case 1:
                        barco.CadastrarBarco();
                        break;
                    case 2:
                        barco.EditarBarco();
                        break;
                    case 3:
                        barco.ListarBarcos();
                        break;
                    case 4:
                        barco.BuscarBarco();
                        break;

                        
                }
                Menu();
                menuEscolha = Convert.ToInt32(Console.ReadLine());
            }
        }
    }


}
