using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_labo2_Mendiburu_GeonasStunf
{
    class cPosicion
    {
        Random r= new Random();
        int fila;
        int columna;
        public void EleccionAlAzar() {
            fila=r.Next(8);
            columna = r.Next(8);
        }
    }
}
