using ConsoleAppEstatico.configuracion;
using ConsoleAppEstatico.modelo;
using ConsoleAppEstatico.servicio;
using System;

namespace ConsoleAppEstatico
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) crear una maquina
            var maq = new Maquinaria();
            maq.Modelo = "fp-2222";
            maq.Anyo = 2019;
            maq.Tipo = "impresora";

            var serv = new MaquinaSrv();
            serv.Mostrar(maq);

            // en visual basic, a trabajar con un modulo.
            // Module1.Funcion()
            MaquinaSrv.MostrarEstatica(maq);

            Configuracion.Nombre = "hhh";
            Configuracion.Carpeta = @"c:\temp";




        }
    }
}
