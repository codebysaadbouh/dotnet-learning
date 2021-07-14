using System;

namespace premier_program
{
    class Program
    {
        // Here numeroPersonne is called "parameter"
        static string DemanderNom(int numeroPersonne)
        {
            string nom = "";

            // Trim() -> allows you to remove spaces
            while (nom.Trim() == "")
            {
                // Request the name of the person
                Console.WriteLine("Quel est le nom de la personne numéro " + numeroPersonne + " ?");
                nom = Console.ReadLine();
                if (nom.Trim() == "")
                {
                    Console.WriteLine("Le nom ne doit pas être vide !");
                }
            }
            return nom;
        }
        static int DemanderAge(string namePersonne)
        {
            string age_str;
            int age_int = 0;
            while (age_int <= 0)
            {
                // Ask for the person's age
                Console.WriteLine("Vous avez quel age de "+namePersonne+" ?");
                age_str = Console.ReadLine();

                try
                {
                    age_int = int.Parse(age_str);
                    if (age_int < 0)
                    {
                        Console.WriteLine("l'age ne doit pas être négatif quand même !");
                    }
                    if (age_int == 0)
                    {
                        Console.WriteLine("l'age ne doit pas être égale à 0 !");
                    }
                }
                catch
                {
                    Console.WriteLine("Vous n'avez pas saisi votre age au bon format");
                }
            }

            return age_int; 
        }

        
        static void DisplayResult(int age_int, string nom, float taille = 0)
        {
            // DISPLAY THE RESULTS
            Console.WriteLine("Vous vous appellez " + nom + " et vous avez " + age_int + " an(s)");

            //Console.WriteLine($"Vous vous appellez {nom} et vous avez {age_int}an(s)");

            age_int += 1;
            Console.WriteLine("Bientôt vous aurez " + age_int + " an(s)");

            bool personMaj = age_int > 18;

            Console.WriteLine(personMaj);

            if(age_int < 10)
            {
                Console.WriteLine("Vous êtes un enfant !");
            }
            else if(age_int == 17)
            {
                Console.WriteLine("Vousêtes tout juste majeur !");
            }
            else if (age_int == 18)
            {
                Console.WriteLine("Vous serrez bien majeur !");
            }
            else if ((age_int >= 12) &&( age_int < 18))
            {
                Console.WriteLine("Vous êtes un adolescent !");
            } else if ((age_int ==1)||(age_int ==2)) 
            {
                Console.WriteLine("Vous êtes un bébé !"); 
            }
            else if (age_int >= 60)
            {
                Console.WriteLine("Vous êtes un sénior !");
            }
            else if (personMaj)
            {
                Console.WriteLine("Vous êtes majeur !");
            }
            
            else
            {
                Console.WriteLine("Vous êtes mineur !"); 
            }

            if(taille != 0)
            {
                Console.WriteLine("Vous faites " + taille + "m"!);
            }
        }

        // When a function does not return a result the output type is called "void"
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Here "1" is called "argument"
            //string nom_1 = DemanderNom(1); 
            //string nom_2 = DemanderNom(2); 

            //int age_1 = DemanderAge(nom_1);
            //int age_2 = DemanderAge(nom_2);

            //Console.WriteLine(); 
            //DisplayResult(age_1, nom_1);
            //Console.WriteLine(); 
            //DisplayResult(age_2, nom_2);
            //Console.WriteLine(); 

            // Les paramètres opt. ne se mettent qu'a la fin tjrs !!!!!!


            //Les boucles for(){}
            const int NBR_PERSONNES = 3; 
            for(int i = 1; i <= NBR_PERSONNES;  i++ )
            {
                string nom = DemanderNom(i);
                int age = DemanderAge(nom);
                DisplayResult(age, nom, 1.78f);

            }
        }
    }
}
