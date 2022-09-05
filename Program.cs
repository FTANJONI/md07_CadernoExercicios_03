using System;

namespace md07_CadernoExercicios_03
{
    /*
     3. Faça um programa com uma função que solicita a digitação da idade de um
        nadador. Classifique-o em uma das seguintes categorias:
        - Infantil A = 5 a 7 anos
        - Infantil B = 8 a 11 anos
        - Juvenil A = 12 a 13 anos
        - Juvenil B = 14 a 17 anos
        - Adultos = Maiores de 18 ano
     */

    class Program
    {
        public static int idade;
        public static string classificacaoIndicatoria;


        public static void EntradaDeDados()
        {
            Console.WriteLine("\nDigite a idade do nadador:");
            idade = Convert.ToInt32(Console.ReadLine());

        }
        public static void Classificacao(int idad)
        {
            if (idad >= 5 && idad <= 7)
            {
                classificacaoIndicatoria = "Infantil A";
            }
            else if (idad >= 8 && idad <= 11)
            {
                classificacaoIndicatoria = "Infantil B";
            }
            else if (idad >= 12 && idad <= 13)
            {
                classificacaoIndicatoria = "Juvenil A";
            }
            else if (idad >= 14 && idad <= 17)
            {
                classificacaoIndicatoria = "Juvenil B";
            }
            else if (idad >= 18)
            {
                classificacaoIndicatoria = "Adulto";
            }
            else
            {
                classificacaoIndicatoria = "Menor que cinco anos, não participa de campionatos";
            }
        }
        static void Main(string[] args)
        {
            string continuar = "s";
            do
            {
                EntradaDeDados();
                Classificacao(idade);
                if (classificacaoIndicatoria.Equals("Menor que cinco anos, não participa de campionatos"))
                {
                    Console.WriteLine("\nMenor que cinco anos, não participa de campionatos");
                }
                else
                {
                    Console.WriteLine("\nA classificação indicativa do atleta é: " + classificacaoIndicatoria);
                }
                Console.WriteLine("\nDeseja classificar outro atleta?\nSim(S) ou Não(N)");
                continuar = Console.ReadLine();

            } while (continuar.Equals("s"));
        }

    }
}
