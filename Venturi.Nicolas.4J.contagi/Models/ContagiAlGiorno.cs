using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Venturi.Nicolas._4J.contagi.Models
{
    class ContagiAlGiorno
    {

        string data;
        int progressivo;
        int contagi;
        
        
        public string Data { get => data; set => data=value; }
        public int Progressivo { get=> progressivo; set=>progressivo=value; }
        public int Contagi { get=>contagi; set=>contagi=value; }

        public override string ToString()
        {
            return "progressivo =" + Progressivo + " , " + Data + " contagi =" + Contagi;
        }
    }
}
