using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_labo2_Mendiburu_GeonasStunf
{
    public class Amenazas: cTablero//HERENCIA
    {
        int casillas_no_amenazadas;

        public Amenazas() { casillas_no_amenazadas = 0; }
        public void AmenazasMovimientoCaballos() { }
        public void AmenazasMovimientoTorre() { }
        public void AmenazasMovimientoAlfil() { }
        public void AmenazasMovimientoReina() { }
        public void AmenazasMovimientoRey() { }
        public void BuscarYdesamenazar_porPieza() { }

    }
}
