using System.Globalization;

namespace Aula2_POO_Desafios
{
     class Aluno
     {
         public string? nome;
         public string? rg;
         public string? dataNascimento;

         CultureInfo culture = new CultureInfo("pt-BR");


         public Aluno(string? nome)
         {
             this.nome = nome;
         }

         public Aluno(string? nome, string? rg)
         {
             this.nome = nome;
             this.rg = rg;
         }

         public Aluno(string? nome, string? rg, string? nascimento)
         {
             this.nome = nome;
             this.rg = rg;
             this.dataNascimento = nascimento;
         }


         //É fornecida a data para rematrícula
         public void rematrícula(DateTime data)
         {
             Console.WriteLine($"Rematrícula realizada em {data.ToString("d")}");
         }

         //Se não fornecida uma data, o padrão será o dia corrente 
         public void rematrícula()
         {
             Console.WriteLine($"Rematrícula realizada em {DateTime.Today.ToString("d")}");
         }


         public string pgMensalidadeDesconto(decimal valor)
         {
             return (valor - (valor * 0.1m)).ToString("C", culture);
         }

         public string pgMensalidadeDesconto(decimal valor, decimal desconto)
         {
             return (valor - (valor * desconto)).ToString("C", culture);
         }
     }
}
