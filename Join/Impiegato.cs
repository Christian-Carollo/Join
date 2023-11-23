using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join
{
    internal class Impiegato
    {
        public int id {  get; set; }
        public string? nome {  get; set; }

        public int aziendaId { get; set; }

        public int mansioneId { get; set; }


        public Impiegato(int id, string nome, int aziendaId, int mansioneId)
        {
            this.id = id;
            this.nome = nome;
            this.aziendaId = aziendaId;
            this.mansioneId = mansioneId;
        }

     
    }
}
