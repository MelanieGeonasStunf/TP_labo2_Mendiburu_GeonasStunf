using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 public enum e_Pieza { CABALLO1 = 2, CABALLO2, TORRE1, TORRE2, ALFIL1, ALFIL2, REINA, REY };

namespace TP_labo2_Mendiburu_GeonasStunf
{
    public class Pieza
    {
        
        public cPosicion pos;
        public e_Pieza tipoPieza;

    }
}
