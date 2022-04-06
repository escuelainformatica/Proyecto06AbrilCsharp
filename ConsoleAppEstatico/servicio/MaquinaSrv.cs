using ConsoleAppEstatico.configuracion;
using ConsoleAppEstatico.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEstatico.servicio
{
    // clase de servicio, es donde van a estar las funciones.
    class MaquinaSrv
    {
        public int campo;
        public int Propiedad { set; get; }


        public void Mostrar(Maquinaria maq)
        {
            Console.WriteLine(campo);
            Console.WriteLine(Propiedad);

            Console.WriteLine($"Modelo :{maq.Modelo}, Año: {maq.Anyo}");
        }

        public static void MostrarEstatica(Maquinaria maq)
        {
            //Console.WriteLine(campo); no es posible en una funcion estatica
            // Console.WriteLine(Propiedad); no es posible en una funcion estatica

            Console.WriteLine($"Modelo :{maq.Modelo}, Año: {maq.Anyo}");
            Console.WriteLine($"la carpeta se llama {Configuracion.Carpeta} ");

        }
    }
}
