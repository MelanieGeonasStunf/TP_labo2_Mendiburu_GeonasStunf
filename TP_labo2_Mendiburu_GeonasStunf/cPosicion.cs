using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_labo2_Mendiburu_GeonasStunf
{
    public class cPosicion
    {
        Random r;
        
        int fila;
        int columna;
        public cPosicion() {
            r = new Random();
            fila = -1;
            columna = -1;
        }
        public void EleccionAlAzar() {
            fila=r.Next(8);
            columna = r.Next(8);
        }
    }
}
