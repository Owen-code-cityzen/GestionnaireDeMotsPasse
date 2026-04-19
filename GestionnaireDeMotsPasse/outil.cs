using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireDeMotsPasse
{
    internal static class outil
    {
        public static int DemanderNombrePositifNonNul(string question)
        {
            return DemanderNombreEntre(question, 1, int.MaxValue);
        }
        public static int DemanderNombre(string question)
        {
            int Nombre = 0;

            while (true)
            {
                Console.Write(question);
                string NomDmd = Console.ReadLine();
                try
                {
                    Nombre = int.Parse(NomDmd);
                    return Nombre;
                }
                catch
                {
                    Console.WriteLine("Entrer un nombre");
                }
            }
        }

       public static int DemanderNombreEntre(string question, int Min, int Max)
        {
            int nombre = DemanderNombre(question);

            if (nombre >= Min && nombre <= Max)
            {
                return nombre;
            }
            Console.WriteLine($"Erreur veuillez entrer un nombre entre {Min} et {Max}");
            return DemanderNombreEntre(question, Min, Max);
        }

    }
}
