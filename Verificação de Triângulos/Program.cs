using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Verificação_de_Triângulos
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true){
            int option;
            decimal lado1, lado2, lado3;
            Console.Clear();
            Console.WriteLine("            ============ Verificação de Triângulos ============");
            Console.WriteLine("Verificar triângulo (1)");
            Console.WriteLine("SAIR (0)");
            option = Convert.ToInt16(Console.ReadLine());
            Console.Clear();

        switch(option)
        {   case 1:
                Console.WriteLine("Informe a medida do lado 1");
                lado1 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Informe a medida do lado 2");
                lado2 = Convert.ToDecimal(Console.ReadLine());
            
                Console.WriteLine("Informe a medida do lado 3");
                lado3 = Convert.ToDecimal(Console.ReadLine());

                verificador(lado1, lado2, lado3);
            break;

            case 0:
            Console.WriteLine("Bye!");
            Environment.Exit(1);
            break;

            default:
            Console.WriteLine("Opção inválida, tente novamente");
            Console.WriteLine("Press ENTER to continue ...");
            Console.ReadKey();
            break;
          }
        
        }
          
        
  
  
      //FUNÇÃO DE VERIFICAÇÃO
        static void verificador(decimal lado1, decimal lado2, decimal lado3)
        {
            if (lado1 + lado2 >= lado3 && lado1 + lado3 >= lado2 && lado2 + lado3 >= lado1)
            {
       
              if (lado1 == lado2 && lado2 == lado3 && lado3 == lado1)
             {
                    Console.Clear();
                    Console.WriteLine("Triângulo Equilátero");
             }
       
             else if (lado1 == lado2 || lado2 == lado3 || lado3 == lado1)
              {
                     Console.Clear();
                     Console.WriteLine("Triângulo Isósceles");
             }
       
           else if (lado1 != lado2 && lado2 != lado3 && lado3 != lado1)
             {
                    Console.Clear();
                    Console.WriteLine("Triangulo Escaleno");
             }
            }
        
  
        else
            Console.Clear();
            Console.WriteLine("Valores invalidos para formar um triangulo");
            Console.WriteLine("Press ENTER to continue ...");
            Console.ReadKey();
            return;
        }
   }   
}
}
