using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Model
{
    public class Habitants
    {
        public string nom;
        public int age;

        public List<Commune> Communes { get; set; }
    }
}
