using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Varaibles
            string A = "Mb`qsph`d`ftu`m(gvo";
            int ok = 0;
            string ok2 = "";
            string reponse = "";
            int rep1 = 0;
            string repFinal = "";
            //Saisie





            for (int i = 0; i < A.Length; i++)
            {
                ok = Convert.ToInt32(A[i]);
                ok = ok - 1;
                ok2 = ok2 + Convert.ToChar(ok);


            }
            Console.WriteLine("le message décripté est : " + ok2);


            //Affichage
            Console.WriteLine("entrez la réponse que vous voulez lui envoyer, la réponse seras ensuite kryptée");
            Console.WriteLine("entrez votre réponse ci-dessous:");

            //saisie
            reponse = Console.ReadLine();

            for (int i = 0; i < reponse.Length; i++)
            {
                rep1 = Convert.ToInt32(reponse[i]);
                rep1 = rep1 + 1;
                repFinal = repFinal + Convert.ToChar(rep1);


            }
            Console.WriteLine("le message cripté est : " + repFinal);












            Console.ReadKey();
        }
    }
}

