using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Uzdevums.UzdViens();
             Uzdevums.ApgrieztsMasivs();
             */
            // Uzdevums.UzdViens ();  - var ari ta izsaukt - bet tad jabut public static void, 
            
            Uzdevums.UzdDiv();
            Console.ReadLine();
        }
        public static void Piemeri()
        {
            int[] skaitluMasivs = new int[8]; // ---- ta veido masivu - [] <- masiva tips, otrajas [] <- cik elementus 
            

            skaitluMasivs[0] = 1;
            skaitluMasivs[2] = 2;
            // .... 
            skaitluMasivs[7] = 8; // mes varetu pieklut 
            skaitluMasivs[8] = 9; // si rinda izmestu kludu 

            int[] skaitluMasivs2 = { // tips ir noradits - tad tik janorada vertibas
            
                1, 3, 50, 100,500  // ja ir zinamas visas vertibas 
            }; 


            for(int i = 0; i < skaitluMasivs.Length; i++)      // cikls darbojas lidz sasniedz masiva garumu length = [8]
            {
                // panem skaitli no masiva, kurs atrodas pozicija 'i'
                int? skaitluMasiva = skaitluMasivs[i];
                     
                Console.WriteLine(skaitluMasivs);
            }
        }


        public static void Piemers2()
        {
            List<int> skaitlusSaraksts = new List<int>();  // sarakstam nav janorada garums jeb ietilpiba - jebkura bridi var pievienot izdzest elementu
            skaitlusSaraksts.Add(5);// katru nakosos pieliek pie iepriekseja
            skaitlusSaraksts.Add(7);
            skaitlusSaraksts.Add(20);

            List<int> skaitluSaraksts2 = new List<int>()
            {
                5, 7, 20
            };
            skaitluSaraksts2.Add(100);
            skaitluSaraksts2.AddRange(new[] { 45, 2090, 20 });

            skaitluSaraksts2
                .Where(s => s != 100)  // filtres atlasis elementu ieliks - s un tad nosacijums, vertibas kas nav vienadas ar 100 != nav vienads
                .OrderBy(s => s)   // sakartot augosa seciba  .OrderBy.Descending butu dilstosa seciba
                .ToList();        // parvers atpakal uz sarakstu  pasaka izpildit sis ieprieksejas darbibas



            // saisinats for cikla pieraksts masiviem 
            // kas iet cauri visiem saraksta/ masiva elementiem 
            foreach(int skaitlis in skaitluSaraksts2) // - !!!!!!!!!!!!!!!
            {
                Console.WriteLine(skaitlis);
            }


        }
    }
}
