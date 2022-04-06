using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // caracteres de escape:
            Console.WriteLine("salto: \ntabulacion: \thola");  // es un salto de linea
            Console.WriteLine("\notaria"); // salta una linea y escribe otaria
            Console.WriteLine("\\notaria"); // "\notaria"
            //Console.WriteLine("c:\carpeta\temporal"); da error
            Console.WriteLine("c:\\carpeta\\temporal"); // ok
            Console.WriteLine(@"c:\carpeta\temporal"); // @ = no se usa un caracter de escape

            string texto = "hola";
            Console.WriteLine("la variable se llama " + texto + ".");
            Console.WriteLine($"la variable se llama {texto}.");

            Console.WriteLine("-----------------");

            var gato = new Gato();
            gato.Nombre = "garfield";
            gato.Dueño = "john";
            gato.Peso = 100;

            var perro = new Perro();
            perro.Nombre = "Oddie";
            perro.Dueño = "john";
            perro.Peso = 20;
            perro.Muerde = true;

            MostrarAnimal(gato,"gato");
            MostrarAnimal(perro,"perro");

            // listados
            var lista = new List<int>();
            lista.Add(1);
            lista.Add(2);
            lista.Add(3);
            var listaHash = new HashSet<int>();
            listaHash.Add(1);
            listaHash.Add(2);
            listaHash.Add(3);

            MostrarLista(lista);
            MostrarLista(listaHash);

            // Stack, Queue, etc.

            // Dictionary.
            var dic = new Dictionary<string, string>();

            dic["hola"] = "hello";
            dic["mundo"] = "world";

            var listadic = new List<string>();
            listadic.Add("hello");
            listadic.Add("world");

            // dynamic, object

            var dicperro = new Dictionary<string, dynamic>();
            dicperro["nombre"] = "Oddie";
            dicperro["dueño"] = "John";
            dicperro["peso"] = 30;
            dicperro["listado"] = new List<int> { 1, 2, 3 };

            Console.WriteLine("el perro se llama " + dicperro["nombre"]);

            int peso = dicperro["peso"];
            dicperro["listado"].Add(4);
            Console.WriteLine(dicperro["listado"][0]);



        }
        static void MostrarLista(ICollection<int> lista)
        {
            Console.WriteLine("la lista tiene los siguiente valores:");
            foreach(var item in lista)
            {
                Console.WriteLine(item);
            }
        }
        static void MostrarAnimal(Animal animal,string tipo)
        {
            // #1
            Console.WriteLine($"el nombre del {tipo} es {animal.Nombre}");
        }
        static void MostrarPersona(IPersona persona)
        {
            Console.WriteLine($"el nombre de la persona es {persona.Nombre} y la direccion es {persona.Direccion}");
        }

    }

    // herencia
    class Animal
    {
        public string Nombre { set; get; }
        public int Peso { set; get; }
        public string Dueño { set; get; }
    }

    class Gato : Animal // herencia.  Gato hereda de animal (dependencia).
    { 

    }
    class Perro : Animal // perro hereda de animal
    {
        public bool Muerde { set; get; }
    }

    // interface
    // 1) solo tiene encabezados de las funciones
    // 2) no tiene ni public ni private
    // las interfaces son un contrato.
    interface IPersona
    {
        string Nombre { set; get; }
        string Direccion { set; get; }
    }

    class Cliente : IPersona // la clase cliente implemente ipersona
    {
        public string Nombre { set; get; }
        public string Direccion { set; get; }
    }
    class Personal : IPersona
    {
        public string Nombre { set; get; }
        public string Direccion { set; get; }
        public int Salario { set; get; }
    }
    class Proveedor : IPersona
    {
        public string Nombre { set; get; }
        public string Direccion { set; get; }
        public string Giro { set; get; }
    }
       




}
