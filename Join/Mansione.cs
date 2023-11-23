using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join
{
    internal class Mansione
    {
        public int id {  get; set; }
        public string? nome {  get; set; }

        public int aziendaId { get; set; }

        public Mansione(int id,int aziendaId, string nome)
        {
            this.id = id;
            this.nome = nome;
            this.aziendaId = aziendaId;
        }
    }
}
