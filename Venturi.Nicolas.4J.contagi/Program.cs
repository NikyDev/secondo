using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Venturi.Nicolas._4J.contagi.Models;
using System.IO;

namespace Venturi.Nicolas._4J.contagi
{
    class Program
    {
        static void Main(string[] args)
        {
            int progStart,progEnd;
            string strProgstart="", StrProgEnd;
            StreamReader file = new StreamReader("ContagiRimini.json");
            string json = file.ReadToEnd();
            
           ContagiAlGiorno[] covid= JsonConvert.DeserializeObject<ContagiAlGiorno[]>(json);
            file.Close();
            Console.WriteLine("inserisci il progressivo da cui vuoi iniziare a vedere i contagi");
            strProgstart= Console.ReadLine();
            progStart = Convert.ToInt32(strProgstart);
            Console.WriteLine("inserisci il progressivo finale");
            StrProgEnd = Console.ReadLine();
            progEnd = Convert.ToInt32(StrProgEnd);
            int i = progStart - 1;
            while(i<=progEnd-1)
            {
                Console.WriteLine("progressivo=" + (i + 1) + " contagi= " + Convert.ToString(covid[i].Contagi));
                i++;
            }
                
            
            Console.ReadLine();
        }
    }
}
