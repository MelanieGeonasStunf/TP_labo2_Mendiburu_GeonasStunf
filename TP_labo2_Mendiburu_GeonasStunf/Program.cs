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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        /*
        Creamos juego
    
        pedimos cant tableros por teclado(form)
        llamamos a inicializar alfiles
        llamamos a generar tableros

         */

    }
}

//
/*
 Constructores para matrices
-> MATRICES:
getLenght( num ), num=0 -> fila | num=1-> columna
 */
