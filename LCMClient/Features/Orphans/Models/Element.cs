using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCMClient.Features.Orphans.Models
{
    public class Element
    {
     
        public string Group { get; set; }

       
        public int Position { get; set; }

     
        public string Name { get; set; }

      
        public int Number { get; set; }

   
        public string Sign { get; set; }

       
        public double Molar { get; set; }

        public override string ToString()
        {
            return $"{Sign} - {Name}";
        }
    }
}
