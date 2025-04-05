using System.Text.Encodings.Web;

namespace SISTEMADOALUNO{
    public class ALuno{
        public String Nome { get; set;} = "";//guarda o nome
        public double nota1 { get; set;}
        public double nota2 { get; set;}
        //construtor da classe aluno (recebe nota e nota)
        public ALuno (String nome, double nota1, double nota2){
            nome = nome;
            nota1 = nota1;
            nota2 = nota2;
        }

        //metodoo de calcular
        public double calcularMedia(){
            return (nota1 + nota2) / 2;
        }
        public void EXibirResultados(){
            double media = calcularMedia();
            Console.WriteLine($"\naluno: {Nome}");
            Console.WriteLine($"\nmedia: {media}");

            //verificar se a media e maior que 6
            if (media >= 6){
                Console.WriteLine("Status: Aprovado");
            }else{
                Console.WriteLine("Status: Reprovado");
            }
        }
    }
}