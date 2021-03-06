﻿using Laboratorio8.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio8
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form1 = new Form1();
            Cinecontroller cinecontroller = new Cinecontroller(form1);
            Recreacionalcontroller recreacionalcontroller = new Recreacionalcontroller(form1);
            RestaurantController restaurantController = new RestaurantController(form1);
            Tiendascontroller tiendascontroller = new Tiendascontroller(form1);


            Application.Run(form1);
        }
    }
}
