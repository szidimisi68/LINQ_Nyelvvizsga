using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Vizsga> sikeresVizsgak = new List<Vizsga>();
            List<Vizsga> sikertelenVizsgak = new List<Vizsga>();

            //sikeres
            StreamReader sr1 = new StreamReader("sikeres.csv");
            sr1.ReadLine();
            while (!sr1.EndOfStream)
            {
                sikeresVizsgak.Add(new Vizsga($"{sr1.ReadLine()}"));
            }
            sr1.Close();

            //sikertelen
            StreamReader sr0 = new StreamReader("sikertelen.csv");
            sr0.ReadLine();
            while (!sr0.EndOfStream)
            {
                sikertelenVizsgak.Add(new Vizsga($"{sr0.ReadLine()}"));
            }
            sr0.Close();


            //2. feladat
            int sorIndex = 0;
            int[] nyelvek = new int[sikeresVizsgak.Count];
            for (int evIndex = 0; evIndex < 10; evIndex++)
            {
                sorIndex = 0;
                foreach (Vizsga vizsga in sikeresVizsgak)
                {
                    nyelvek[sorIndex] += vizsga.Evek[evIndex];
                    sorIndex += 1;
                }

                sorIndex = 0;
                foreach (Vizsga vizsga in sikertelenVizsgak)
                {
                    nyelvek[sorIndex] += vizsga.Evek[evIndex];
                    sorIndex += 1;
                }
            }
            Console.WriteLine("2. feladat: A legnépszerűbb nyelvek:");
            int[] osszegzettNyelvek = nyelvek;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"    {sikeresVizsgak[nyelvek.ToList().IndexOf(nyelvek.Max())].Nyelv}");
                nyelvek[nyelvek.ToList().IndexOf(nyelvek.Max())] = 0;
            }



            //3. feladat
            int bekertEvszam = 0;

            while ( 2009 > bekertEvszam || bekertEvszam > 2017)
            {
                Console.Write("Kérem az évszámot: ");
                bekertEvszam = int.Parse(Console.ReadLine());
            }

            //4.feladat
            bekertEvszam -= 2009;
            int segedIndex = 0;
            double sikertelenArany = 0;
            string sikertelenNyelve;
            foreach (Vizsga vizsga in sikertelenVizsgak)
            {
                if (sikertelenArany < vizsga.Evek[bekertEvszam] % (sikeresVizsgak[segedIndex].Evek[bekertEvszam] + vizsga.Evek[bekertEvszam] + 1))
                {
                    sikertelenArany = vizsga.Evek[bekertEvszam] % (sikeresVizsgak[segedIndex].Evek[bekertEvszam] + vizsga.Evek[bekertEvszam] + 1);
                    sikertelenNyelve = vizsga.Nyelv;
                }
                segedIndex++;
            }
            Console.WriteLine($"{sikertelenArany}");

            //5.feladat


            //6.feladat


        }
    }
}
