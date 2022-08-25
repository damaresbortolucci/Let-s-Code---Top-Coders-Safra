using System.Globalization;

public class Program

{
    public static void Main()
    {
        string nome;
        string nascimento;
        string senha;
        bool dataValidada;
        bool senhaValidada=true; 
        bool StringTemConteudo;

        DateTimeStyles styles = DateTimeStyles.None;
        DateTime dateResult;
        CultureInfo culture = CultureInfo.CreateSpecificCulture("pt-BR");


        do
        {
            Console.Write("Informe seu nome completo: ");
            nome = Console.ReadLine();
            StringTemConteudo = !String.IsNullOrWhiteSpace(nome);
        } while (!StringTemConteudo);


        do
        {
            Console.Write("Informe sua data de nascimento (dd/mm/aaaa): ");
            nascimento = Console.ReadLine();
            dataValidada = DateTime.TryParse(nascimento, culture, styles, out dateResult);

            if (dataValidada)
                nascimento = dateResult.ToString("d");
        
        } while (!dataValidada);


        do
        {
            Console.Write("Crie uma senha: ");
            senha = Console.ReadLine();
            StringTemConteudo = !String.IsNullOrWhiteSpace(senha);

            if (StringTemConteudo)
            {
                var nomeCompleto = nome.Split().ToList();
                var dataNascimento = nascimento.Split("/").ToList();    
                senhaValidada = true;

                foreach (string n in nomeCompleto)
                {
                    string senhaToLower = senha.ToLower();
              
                    if (senhaToLower.Contains(n.ToLower()))
                    {
                        senhaValidada = false;
                        Console.WriteLine("A senha não pode conter seu nome ou sobrenome");
                    }
                }

                foreach (string d in dataNascimento)
                {
                    if (senha.Contains(d))
                    {
                        senhaValidada = false;
                        Console.WriteLine("A senha não pode conter o dia, mês e/ou ano do seu nascimento");
                    }
                }

            }       
        } while (!StringTemConteudo || !senhaValidada);
             


        if (senhaValidada)
            Console.WriteLine("Cadastro realizado com sucesso!");
    }
}
