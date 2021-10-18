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
        public void AmenazasMovimientoTorre(int[,] Amz_x_Cas, int[,] pos_piezas, cPosicion pos, bool sumar) {
            for (int i = 0; i < 8; i++)
            {
                if (i == pos.fila)
                {
                    tablero[i, pos.columna] = 4;//completo matriz con amenazas con nro correspondiente
                    Amz_x_Cas[i, pos.columna] =+ 1;//completo matriz con cant ataques sumando 1
                }
            }
            for (int i = 0; i < 8; i++)
            {
                if (i == pos.columna)
                {
                    if (sumar)
                    {
                        tablero[pos.fila, i] = 4;
                        Amz_x_Cas[pos.fila, i] = +1;
                    }
                    else
                        Amz_x_Cas[pos.fila, i] =- 1;
                }
            }
            //complete dos veces la matriz con 1 en la posicion propuesta
            Amz_x_Cas[pos.fila, pos.columna] -= 1;
        }
        public void AmenazasMovimientoAlfil(int[,] Amz_x_Cas, int[,] pos_piezas, cPosicion pos, bool sumar) { }
        public void AmenazasMovimientoReina(int[,] Amz_x_Cas, int[,] pos_piezas, cPosicion pos, bool sumar) { }
        public void AmenazasMovimientoRey() { }
        public void BuscarYdesamenazar_porPieza() { }

    }
}
