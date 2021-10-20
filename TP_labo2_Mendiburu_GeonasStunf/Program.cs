using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_labo2_Mendiburu_GeonasStunf
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            cJuego partida = new cJuego();
            partida.InicializarTableroAlfil();
            partida.arrayPiezas = CrearPiezas();
            partida.GenerarTableros();
            Console.ReadKey();
           // Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
        /*
        Creamos juego
    
        pedimos cant tableros por teclado(form)
        llamamos a inicializar alfiles
        llamamos a generar tableros
        hacer las fichas en una función

         */
        static Pieza[] CrearPiezas()
        {
            Pieza[] piezas = new Pieza[8];
            for (int i = 0; i < 8; i++)
            {
                piezas[i] = new Pieza((e_Pieza)i+2);
            }
            return piezas;
        }

    }
   
}

//
/*
 Constructores para matrices
-> MATRICES:
getLenght( num ), num=0 -> fila | num=1-> columna
 */
