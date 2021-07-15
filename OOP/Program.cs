using System;

namespace OOP
{
    class Program
    {
        static void Main()
        {
            // Exemplo de herança
            Pessoa gabriel = new PessoaFisica(
                "Gabriel",
                "Paulucci",
                "604.102.918-11"
            );

            Console.WriteLine(gabriel);

            try
            {
                gabriel.Idade = 21;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(gabriel);

            Pessoa catarina = new PessoaFisica(
                "Catarina",
                "Amador Boeno",
                "633.412.328-93"
            );

            try
            {
                catarina.Idade = -19;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if (gabriel != catarina)
            {
                Console.WriteLine("Gabriel e Catarina são pessoas diferentes");
            }

            var moveisAngular = new PessoaJuridica(
                "Moveis",
                "Angular",
                "58.332.751/0001-95",
                "Mov Angular LTDA"
            );

            Console.WriteLine(moveisAngular);

            // Exemplo de encapsulamento

            // Não é possivel pois o cpf so pode ser definido uma vez
            // (gabriel as PessoaFisica).Cpf = "154.880.538-67";
            // Já nesse caso é possivel pois o cpf pode ser obtido
            var cpf = (gabriel as PessoaFisica).Cpf;

            Console.WriteLine("Cpf do gabriel: {0}", cpf);
        }
    }
}
