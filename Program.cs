// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
namespace SISTEMADOALUNO
{
//cd com a extencao completa, dotnet new com o nome, cd com o nome 
class program{
    static void Main(String[]args){
        Console.WriteLine("qual o nome do aluno: ");
        String nome = Console.ReadLine();

        Console.WriteLine("digite a primeira nota: ");
        double nota1 = double.Parse(
            Console.ReadLine(),
            CultureInfo.InvariantCulture
        );
        Console.WriteLine("digite a primeira nota: ");
        double nota2 = double.Parse(
            Console.ReadLine(),
            CultureInfo.InvariantCulture
        );
    }
}
}

