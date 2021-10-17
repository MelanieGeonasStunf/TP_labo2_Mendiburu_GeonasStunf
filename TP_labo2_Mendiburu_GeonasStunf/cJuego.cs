using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_labo2_Mendiburu_GeonasStunf
{
    class cJuego
    {
        int cant_tableros;//a hacer
        int cant_tab_generados;//ya hechos
        cTablero matriz_alfil;
        Amenazas casillas_amenazadas;
        cTablero pos_piezas;
        Amenazas cant_amenazasxCasillas;
        Pieza[] arrayPiezas;
        public void GenerarTableros() { }
        cJuego() { 
            cant_tableros = 0;
            cant_tab_generados = 0;
            matriz_alfil = new cTablero();
            casillas_amenazadas = new Amenazas();
            pos_piezas = new cTablero();
            cant_amenazasxCasillas = new Amenazas();
            arrayPiezas = new Pieza[8];
        }
        public void InicializarTableroAlfil() {
            int cont = 0;
            for(int i=0;i<matriz_alfil.tablero.GetLength(0) ;i++)
            {
                for(int j=0;j<matriz_alfil.tablero.GetLength(1) ;j++)
                {           
                    if(cont%2==0 || cont==0)
                    {
                        matriz_alfil.tablero[i, j] = 1;
                    }
                    else
                    {
                        matriz_alfil.tablero[i, j] = 2;
                    }
                    cont++;
                }
            }
        }

    }
}
