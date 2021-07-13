using System;

namespace premier_program
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Déclaration de variable
            int age_int = 0;
            string age_str;
            string nom;
            // Demande le nom de la personne
            Console.WriteLine("Quel est votre nom ?");
            nom = Console.ReadLine();

            while (age_int == 0)
            {
                // Demande l'age de la personne
                Console.WriteLine("Vous avez quel age ?");
                age_str = Console.ReadLine();

                try
                {
                    age_int = int.Parse(age_str);
                }
                catch
                {
                    Console.WriteLine("Vous n'avez pas saisi votre age au bon format");
                }
            }

            Console.WriteLine("Vous vous appellez " + nom + " et vous avez " + age_int + " an(s)");
            age_int += 1;
            Console.WriteLine("Bientôt vous aurez " + age_int + " an(s)");

        }
    }
}
