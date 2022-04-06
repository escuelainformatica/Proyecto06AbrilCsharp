using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEstatico.configuracion
{
    class Configuracion
    {
        // variables globales
        // SINGLETON  (unico)
        public static string Nombre { set; get; }
        public static string Carpeta { set; get; }
        public static string Url { set; get; }
        public static int Dolar { set; get; }
        public const double IVA = 1.19;

    }
}
