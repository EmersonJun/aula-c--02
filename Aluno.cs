using System.Text.Encodings.Web;

namespace SISTEMADOALUNO{
    public class ALuno{
        public String Nome { get; set;} = "";//guarda o nome
        public double Nota1 { get; set;}
        public double Nota2 { get; set;}
        //construtor da classe aluno (recebe nota e nota)
        public ALuno (String nome, double nota1, double nota2){
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
        }

        //metodoo de calcular
        public double calcularMedia(){
            return (Nota1 + Nota2) / 2;
        }
        public void EXibirResultados(){
            double media = calcularMedia();
            Console.WriteLine($"\n\naluno: {Nome}");
            Console.WriteLine($"media: {media}");

            //verificar se a media e maior que 6
            if (media >= 6){
                Console.WriteLine("Status: Aprovado");
            }else{
                Console.WriteLine("Status: Reprovado");
            }
        }
    }
}