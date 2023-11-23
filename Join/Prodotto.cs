using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join
{
    internal class Prodotto
    {

        public string? nome {  get; set; }

        public int id { get; set; }

        public int categorieId { get; set; }

        public Prodotto(int id, string nome, int categorieId)
        {
            this.id = id;
            this.nome = nome;
            this.categorieId = categorieId;
        }
    }
}
