using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Model
{
    public class Departement
    {
        public string nom;
        public int code;
        public List<Commune> Communes { get; set; }
    }
}
