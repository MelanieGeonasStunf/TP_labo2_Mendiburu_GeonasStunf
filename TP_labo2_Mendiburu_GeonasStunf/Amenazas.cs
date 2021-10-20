using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TP_labo2_Mendiburu_GeonasStunf
{
    public class Amenazas : cTablero//HERENCIA
    {
        public int casillas_no_amenazadas;
        public cPosicion pos_max_amenazas;
        public int max_amenazas;
        public Amenazas() {
            casillas_no_amenazadas = 0;
            pos_max_amenazas = new cPosicion();
            max_amenazas = (int)tablero[0, 0];

        }
        public void AmenazasMovimientoCaballos(int[,] Amz_x_Cas, int[,] pos_piezas, Pieza pieza, bool sumar) //necesito poner el numero por eso{ 
        { for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i <= pieza.pos.fila - 2 || i <= pieza.pos.fila + 2)
                    {
                        if (j <= pieza.pos.columna - 2 || j <= pieza.pos.columna + 2)
                        {
                            if (sumar)
                            {
                                tablero[i, pieza.pos.columna] = pieza.tipoPieza;
                                Amz_x_Cas[i, pieza.pos.columna]++;
                            }
                            else
                                Amz_x_Cas[i, pieza.pos.columna]--;
                        }
                    }
                }
            }
        }
        public void AmenazasMovimientoTorre(int[,] Amz_x_Cas, int[,] pos_piezas, Pieza pieza, bool sumar) {
            for (int i = 0; i < 8; i++)
            {
                if (i == pieza.pos.fila)
                {
                    tablero[i, pieza.pos.columna] = pieza.tipoPieza;//completo matriz con amenazas con nro correspondiente
                    Amz_x_Cas[i, pieza.pos.columna] = +1;//completo matriz con cant ataques sumando 1
                }
            }
            for (int i = 0; i < 8; i++)
            {
                if (i == pieza.pos.columna)
                {
                    if (sumar)
                    {
                        tablero[pieza.pos.fila, i] = pieza.tipoPieza;
                        Amz_x_Cas[pieza.pos.fila, i] = +1;
                    }
                    else
                        Amz_x_Cas[pieza.pos.fila, i] = -1;
                }
            }
            //complete dos veces la matriz con 1 en la posicion propuesta
            Amz_x_Cas[pieza.pos.fila, pieza.pos.columna] -= 1;
        }
        public void AmenazasMovimientoAlfil(int[,] Amz_x_Cas, int[,] pos_piezas, Pieza pieza, bool sumar) {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i == pieza.pos.fila - 1 || i == pieza.pos.fila + 1)
                    {
                        if (j == pieza.pos.columna - 1 || j == pieza.pos.columna + 1)
                        {
                            tablero[i, j] = pieza.tipoPieza;
                            Amz_x_Cas[i, j] += 1;
                        }
                    }
                }
            }
        }
        public void AmenazasMovimientoReina(int[,] Amz_x_Cas, int[,] pos_piezas, Pieza pieza, bool sumar) {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                    if (i == pieza.pos.fila - 1 || i == pieza.pos.fila + 1)
                    {
                        if (j == pieza.pos.columna - 1 || j == pieza.pos.columna + 1)
                        {
                            if (sumar == true)
                            {
                                tablero[i, j] = pieza.tipoPieza;
                                Amz_x_Cas[i, j] += 1;
                            }
                            else
                                Amz_x_Cas[i, j] -= 1;

                        }
                    }
            }
            for (int i = 0; i < 8; i++)
            {
                if (i == pieza.pos.fila)
                {
                    tablero[i, pieza.pos.columna] = pieza.tipoPieza;//completo matriz con amenazas con nro correspondiente
                    Amz_x_Cas[i, pieza.pos.columna] += 1;//completo matriz con cant ataques sumando 1
                }
            }
            for (int i = 0; i < 8; i++)
            {
                if (i == pieza.pos.columna)
                {
                    if (sumar)
                        tablero[pieza.pos.fila, i] = pieza.tipoPieza;
                    Amz_x_Cas[pieza.pos.fila, i] += 1;
                }
                else
                    Amz_x_Cas[pieza.pos.fila, i] -= 1;
            }
            Amz_x_Cas[pieza.pos.fila, pieza.pos.columna] -= 1;
        }

        public void AmenazasMovimientoRey(int[,] Amz_x_Cas, int[,] pos_piezas, Pieza pieza, bool sumar) { }
        public void BuscarYdesamenazar_porPieza(int[,] Amz_x_Cas, Pieza pieza, int[,] pos_piezas) { }

    }
}
