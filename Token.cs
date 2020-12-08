using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorSintatico
{
    class Token
    {
        public string tipo { get; set; }
        public int identificador { get; set; }
        public string lexema { get; set; }
    }

    class Par
    {
        public int estado { get; set; }
        public int token { get; set; }

        public Par(int e, int t)
        {
            estado = e;
            token = t;
        }
    }
}
