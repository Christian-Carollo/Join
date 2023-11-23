using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join
{
    internal class Azienda
    {
        public int id {  get; set; }

        public string? name { get; set; }  
        

        public Azienda(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
