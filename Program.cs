using System;

namespace Programa_0_a_10
{
    class Program
    {
        static void Main(string[] args)
        {   
            float nota;
            do{
                Console.WriteLine("Digite sua nota: ");
                nota = float.Parse(Console.ReadLine());

                if(nota < 0 || nota > 10){
                    Console.WriteLine("Esse número não é válido");
                }
            }while(nota < 0 || nota > 10);
            
            Console.WriteLine("Número Aceito");
        }
    }
}
