using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_labo2_Mendiburu_GeonasStunf
{ 
    public class Amenazas: cTablero//HERENCIA
    {
        public int casillas_no_amenazadas;
        public cPosicion pos_max_amenazas;
        public int max_amenazas;
        public Amenazas() { 
            casillas_no_amenazadas = 0;
            pos_max_amenazas = new cPosicion();
            max_amenazas=tablero[0,0];

        }
        public void AmenazasMovimientoCaballos(int[,] Amz_x_Cas, int[,] pos_piezas, cPosicion pos, bool sumar) { }
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
        public void AmenazasMovimientoRey(int[,] Amz_x_Cas, int[,] pos_piezas, cPosicion pos, bool sumar) { }
        public void BuscarYdesamenazar_porPieza(int[,] Amz_x_Cas, Pieza pieza, int[,] pos_piezas) { }

    }
}
