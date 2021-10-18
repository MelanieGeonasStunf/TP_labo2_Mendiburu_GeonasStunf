using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TP_labo2_Mendiburu_GeonasStunf
{
    class cJuego
    {
        int cant_tableros_a_generar;//a hacer
        int cant_tab_generados;//ya hechos
        cTablero matriz_alfil;
        Amenazas casillas_amenazadas;
        cTablero pos_piezas;
        Amenazas cant_amenazasxCasillas;
        Pieza[] arrayPiezas;
    
        public void GenerarTableros() {
            while(cant_tab_generados < cant_tableros_a_generar)//-> necesito completar n tableros
            {
                //---------------------------------------------------------
                //TORRE1
                arrayPiezas[2].pos.EleccionAlAzar();
                casillas_amenazadas.AmenazasMovimientoTorre(cant_amenazasxCasillas.tablero, pos_piezas.tablero, arrayPiezas[2].pos, true);
                //TORRE 2:
                cPosicion aux = new cPosicion();
                aux.EleccionAlAzar();
                    while (pos_piezas.tablero[aux.fila, aux.columna] != 0 && aux.fila == arrayPiezas[2].pos.fila && arrayPiezas[2].pos.columna == aux.columna)
                    {
                    aux.EleccionAlAzar();
                    }
                arrayPiezas[3].pos = aux;

                    if (pos_piezas.tablero[aux.fila, aux.columna] == 0)
                    {
                        pos_piezas.tablero[aux.fila, aux.columna] = 5;//torre2
                                                                      //COMPLETO POSICIONES AMENAZADAS CON EL CABALLO DESDE POSICION PROPUESTA
                        casillas_amenazadas.AmenazasMovimientoTorre(cant_amenazasxCasillas.tablero, pos_piezas.tablero, arrayPiezas[3].pos, true);
                    }

                //ALFIL 1
                while (pos_piezas.tablero[aux.fila, aux.columna] != 0 && matriz_alfil.tablero[aux.fila, aux.columna] != 1)//condicion para ver si se puede mover el alfil{
                { 
                        aux.EleccionAlAzar();
                }
                pos_piezas.tablero[aux.fila, aux.columna] = 6;//alfil 1
                arrayPiezas[4].pos = aux;
                casillas_amenazadas.AmenazasMovimientoAlfil(cant_amenazasxCasillas.tablero, pos_piezas.tablero, arrayPiezas[4].pos, true);

                //ALFIL 2
                while (pos_piezas.tablero[aux.fila, aux.columna] != 0 && matriz_alfil.tablero[aux.fila, aux.columna] != 2)//condicion para ver si se puede mover el alfil{
                {
                    aux.EleccionAlAzar();
                }
                pos_piezas.tablero[aux.fila, aux.columna] = 7;//alfil 2
                arrayPiezas[5].pos = aux;
                casillas_amenazadas.AmenazasMovimientoAlfil(cant_amenazasxCasillas.tablero, pos_piezas.tablero, arrayPiezas[5].pos, true);
                
                //REINA

                while (pos_piezas.tablero[aux.fila, aux.columna] != 0 
                    && (casillas_amenazadas.tablero[aux.fila, aux.columna] == 6 || 
                    casillas_amenazadas.tablero[aux.fila, aux.columna] == 2) && ((aux.columna == arrayPiezas[2].pos.columna || 
                    aux.fila == arrayPiezas[2].pos.fila) || (aux.columna == arrayPiezas[3].pos.columna ||
                    aux.fila == arrayPiezas[3].pos.fila)))
                    {
                        aux.EleccionAlAzar();
                    }


                if (pos_piezas.tablero[aux.fila, aux.columna] == 0)
                {
                    pos_piezas.tablero[aux.fila, aux.columna] = 8;//alfil 2
                    arrayPiezas[6].pos = aux;
                    casillas_amenazadas.AmenazasMovimientoAlfil(cant_amenazasxCasillas.tablero, pos_piezas.tablero, arrayPiezas[6].pos, true);
                }
                    //------------HASTA ACA HICIMOS-------------------------------
                    //busco primer posición vacia ->pongo caballo
                    while (matriz_piezas[fila][columna] != 0)
                {
                    posicion = BuscarPosicionLibre();
                }
                int matriz_piezas[fila][columna]= 2;//caballo
                                                    //Lleno matriz con posiciones que amenazan

                //COMPLETO POSICIONES AMENAZADAS CON EL CABALLO DESDE POSICION PROPUESTA
                //...
                //COMPLETO MATRIZ cant_amenazas_casillas CON 1 EN LAS POSICIONES DONDE AMENAZA CABALLO

                AmenazasMovimientoCaballo(matriz_amenazada, cant_amenazas_casillas, fila, columna, true);
                //busco segunda->otro caballo
                while (matriz_piezas[fila][columna] != 0)
                {
                    posicion = BuscarPosicionLibre();
                }
                if (matriz_piezas[fila][columna] == 0)
                {
                    matriz_piezas[fila][columna] = 3;//caballo2
                                                     //COMPLETO POSICIONES AMENAZADAS CON EL CABALLO DESDE POSICION PROPUESTA
                   // ...
                 //COMPLETO MATRIZ cant_amenazas_casillas CON 1 EN LAS POSICIONES DONDE AMENAZA CABALLO
                AmenazasMovimientoCaballo(matriz_amenazada, cant_amenazas_casillas, fila, columna, true);
                    //busco tercera->rey
                    while (matriz_piezas[fila][columna] != 0 || matriz_piezas[fila][columna] != 6 || matriz_piezas[fila][columna] != 7) ;//REY -> me fijo si no hay ninguna pieza o si esta el alfil -> puedo superponer
                    {
                        posicion = BuscarPosicionLibre();
                    }
                    matriz_piezas[fila][columna] = 9;//REY
                    AmenazasMovimientoRey(matriz_amenazada, cant_amenazas_casillas, fila, columna, true);
                    --------------------------------------------------------------
                    ------------------------------------------------------------------
                    //UNA VEZ QUE TENGO COMPLETA MATRICES
                    int fila_sin_amenaza;
                    int columna_sin_amenaza;
                    int contador = 0;
                    while (contador < 5)
                    {
                        //1) Nos fijamos si la matriz propuesta (aleatoriamente) -> si esta toda amenazada corto el while
                        //-> tenemos un tablero
                        for (int i = 0; i < 8; i++)
                        {
                            for (int j = 0; j < 8; j++)
                            {
                                if (matriz_amenazada[i][j] == 0)
                                {
                                    fila_sin_amenaza = i;
                                    columna_sin_amenaza = j;//en un futuro capaz hacer un struct posición           que tenga columna y fila
                                                            //ya significa que no encontro una solucion
                                    cant_casillas_no_amenazadas++;
                                }
                            }
                        }
                        //fijarme si esta completo
                    }
                    if (cant_casillas_no_amenazadas == 0)//si matriz amenazada completa que termine el while
                        break;//tengo tablero

                    //Si no esta del todo amenazado tengo que empezar a mover piezas hasta tener una solucion


                    //MUEVO PIEZA DONDE HAY MAYOR CANTIDAD DE AMENAZAS -> me fijo con matriz cant_amenazas 
                    //muevo 1 pieza por 2/3 casillas no amenazadas -> lo intento 3 veces si no funca empieza de nuevo

                    int max_amenazas = cant_amenazas_casillas[0][0];
                    int fila_max_amenazas;
                    int columna_max_amenazas;

                    for (int i = 0; i < 8; i++)
                    {
                        for (j = 0; j < 8; j++)
                        {
                            if (cant_amenazas_casillas[i][j] > max_amenazas)
                                max_amenazas = cant_amenazas_casillas[i][j];
                            fila_max_amenazas = i;
                            columna_max_amenazas = j;

                        }
                    }

                    //ya tengo posicion con mi maximo-> movemos pieza posicionada en lugar de mas amenazas
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {

                            //TENEMOS QUE CAMBIAR LA PIEZA DE LUGAR -> movemos la pieza donde mayor amenazas hay a la primer posicion libre que encontremos.

                            if( matriz_amenazada[fila_max_amenazas][columna_max_amenazas]== 2 o == 3{
                                matriz_piezas[fila_sin_amenaza][columna_sin_amenaza] = 2 o 3;
                                LiberarPieza(2, matriz_piezas);
                                BuscarYdesamenazar_porPieza(matriz_amenazada, cant_amenazas_casillas, fila, columna, pieza, matrizpiezas)
                                  AmenazasMovimientoCaballo(matriz_amenazada,
         cant_amenazas_casillas, fila_sin_amenaza, columna_sin_amenaza, sumar)
                                 }
                            //falta vaciar las casillas que se liberan al mover la pieza
                            //una mega funcion que chequee todo
                            si matriz_amenazada[fila_max_amenazas][columna_max_amenazas]== 4 o == 5{
                                matriz_piezas[fila_sin_amenaza][columna_sin_amenaza] = 4 o 5;
                                BuscarYdesamenazar_porPieza(matriz_amenazada, cant_amenazas_casillas, fila, columna, pieza, matrizpiezas)
                                  LiberarPieza(4 o 5, matriz_piezas);
                                AmenazasMovimientoTorre(matriz_amenazada,
                                 cant_amenazas_casillas, fila_sin_amenaza, columna_sin_amenaza, numero)
                                 }
                            si matriz_amenazada[fila_max_amenazas][columna_max_amenazas]== 6 o 7{
                                if (matriz_mov_alfiles[fila_sin_amenazas][columna_sin_amenazas] == 1)
                                    matriz_piezas[fila_sin_amenaza][columna_sin_amenaza] = 6;
                                BuscarYdesamenazar_porPieza(matriz_amenazada, cant_amenazas_casillas, fila, columna, pieza, matrizpiezas)
                                  LiberarPieza(6, matriz_piezas);
                                AmenazasMovimientoAlfil(matriz_amenazada,
                                 cant_amenazas_casillas, fila_sin_amenaza, columna_sin_amenaza, 6);
    else
                                {
                                    matriz_piezas[fila_sin_amenaza][columna_sin_amenaza] = 7;
                                    BuscarYdesamenazar_porPieza(matriz_amenazada, cant_amenazas_casillas, fila, columna, pieza, matrizpiezas)
        LiberarPieza(7, matriz_piezas);
                                    AmenazasMovimientoAlfil(matriz_amenazada,
                                     cant_amenazas_casillas, fila_sin_amenaza, columna_sin_amenaza, 7);
                                }
                                //falta vaciar las casillas que se liberan al mover la pieza
                                //una mega funcion que chequee todo
                                si matriz_amenazada[fila_max_amenazas][columna_max_amenazas]== 8
                                 matriz_piezas[fila_sin_amenaza][columna_sin_amenaza] = 8;
                                BuscarYdesamenazar_porPieza(matriz_amenazada, cant_amenazas_casillas, fila, columna, pieza, matrizpiezas)
                                  LiberarPieza(8, matriz_piezas);
                                AmenazasMovimientoReina(matriz_amenazada,
                                 cant_amenazas_casillas, fila_sin_amenaza, columna_sin_amenaza, 8);
                                si matriz_amenazada[fila_max_amenazas][columna_max_amenazas]== 9
                                   matriz_piezas[fila_sin_amenaza][columna_sin_amenaza] = 9;
                                BuscarYdesamenazar_porPieza(matriz_amenazada, cant_amenazas_casillas, fila, columna, pieza, matrizpiezas)
                                  LiberarPieza(9, matriz_piezas);
                                AmenazasMovimientoRey(matriz_amenazada,
                                 cant_amenazas_casillas, fila_sin_amenaza, columna_sin_amenaza, 9);
                            }
                            for (int i = 0; i < 8; i++)
                            {
                                for (j = 0; j < 8; j++)
                                {
                                    if (matriz_amenazada[i][j] == 0)
                                    {
                                        fila_sin_amenaza = i;
                                        columna_sin_amenaza = j;//en un futuro capaz hacer un struct posición           que tenga columna y fila
                                                                //ya significa que no encontro una solucion
                                        cant_casillas_no_amenazadas++;
                                    }
                                }
                            }
                            //fijarme si esta completo
                        }

                    }
                    //HAGO NUEVOS MOVIMIENTOS DE PIEZAS

                    contador++;//si no llegamos a obtener un tablero despues de repetir proceso 3 veces-> empezamos de 0
}//termina el while




 
                
            cJuego() { 
            cant_tableros_a_generar = 0;
            cant_tab_generados = 0;
            matriz_alfil = new cTablero();
            casillas_amenazadas = new Amenazas();
            pos_piezas = new cTablero();
            cant_amenazasxCasillas = new Amenazas();
            arrayPiezas = new Pieza[8];//yo recibiria una por parametro
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
