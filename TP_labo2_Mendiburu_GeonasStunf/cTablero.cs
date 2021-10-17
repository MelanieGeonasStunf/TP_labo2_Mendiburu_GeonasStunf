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
        public cPosicion BuscarPiezaLibre() {
            cPosicion pos = new cPosicion();
            return pos;
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
