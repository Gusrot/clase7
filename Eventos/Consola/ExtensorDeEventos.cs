﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public static class ExtensorDeEventos
    {
        public static void MiMetodo(this string dato)
        {
            Console.WriteLine(dato);
        }
    }
}
