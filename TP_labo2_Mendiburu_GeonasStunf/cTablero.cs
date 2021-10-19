using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//using cPosicion;//como incluimos clase?

namespace TP_labo2_Mendiburu_GeonasStunf
{
    public class cTablero
    {
        public int[,] tablero = new int[8, 8];

        //metodos:
        public cPosicion BuscarPosicionLibre(bool rey=false) {
            cPosicion pos = new cPosicion();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (rey)
                    {
                        if (0 == tablero[i, j]|| tablero[i, j]==6|| tablero[i, j]==7)
                        {
                            pos.fila = i;
                            pos.columna = j;
                            return pos;
                        }
                    }
                    else if (0 == tablero[i, j])
                    {
                        pos.fila = i;
                        pos.columna = j;
                        return pos;
                    }
                }
            }
           // throw Exceptio
           return pos;//seria -1, podemos tirar excepcion?
        }
        public void LiberarPieza(Pieza pieza) { }
        public cTablero()
        {
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    tablero[i, j] = 0;
                }
            }
        }
     
    }
}
