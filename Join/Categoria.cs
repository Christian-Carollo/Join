﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join
{
    internal class Categoria
    {

        public string? nome {  get; set; }

        public int id { get; set; }

        public Categoria(string nome, int id)
        {
            this.nome = nome;
            this.id = id;
        }
    }
}
