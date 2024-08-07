
using System;
using System.Collections.Generic;


namespace Colecciones_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creacion de la cola
            Queue<string> abc = new Queue<string>();

            //Creando el array saludos
            string[] saludos = new string[10];

            //agregando elementos a la cola
            abc.Enqueue("A");
            abc.Enqueue("B");
            abc.Enqueue("C");
            abc.Enqueue("D");
            abc.Enqueue("E");
            abc.Enqueue("F");
            abc.Enqueue("G");
            abc.Enqueue("H");
            abc.Enqueue("I");
            abc.Enqueue("J");

            Console.WriteLine("Cantidad de elementos al principio de la colección");
            int h = abc.Count;
            Console.WriteLine(h);
            
            //Devolviendo el primer elemento de la cola sin quitarlo
            Console.WriteLine("\nDevolviendo el primer elemento de la cola sin quitarlo");
            Console.WriteLine(abc.Peek());

            //Sacando el primer elemento de la cola "A"
            Console.WriteLine("\nSacando el primer elemento de la cola con el metodo Dequeue \n'A'");          

            Console.WriteLine(abc.TryDequeue(out string x));
            
            
            
            //Recorriendo los elementos de la cola
            Console.WriteLine("\nColeccion");
            foreach (string elementos in abc)
            {
                Console.WriteLine(elementos);
            }            

            //Utilizando Contains para determinar si un elemento se encuentra en la cola
            Console.WriteLine("\nUtilizando Contains para determinar 'Z' se encuentra en la cola");
            Console.WriteLine(abc.Contains("Z"));

            /*Utilizando el método CopyTo para copiar
            los elementos de la colección 'abc' en el array 'saludos'*/
            abc.CopyTo(saludos, 0);

            //Copiando los elementos de la cola en el array
            saludos = abc.ToArray();

            //Recorriendo los elementos copiados del array 'saludos'
            Console.WriteLine("\nArray");
            for(int i = 0; i<saludos.Length; i++)
            {
                Console.WriteLine(saludos[i]);
            }

            //Sacando el primer elemento de una lista y devolviendo True si sale correctamente
            Console.WriteLine("\nSacando el primer elemento de una lista y devolviendo True si sale correctamente");
            Console.WriteLine(abc.TryDequeue(out string E1)+ " Salio 'B'");

            Console.WriteLine("\nColeccion actual");
            foreach(string elementos in abc)
            {
                Console.WriteLine(elementos);
            }


            //quitando todos lo elementos de la cola
            Console.WriteLine("\nUtilizando Clear para limpiar la cola");
            abc.Clear();

            //Viendo si existe un algún elemento en la primera posición de la colección 
            Console.WriteLine("\nUtilizando TryPeek para determinar si hay un elemento en la primera posición de la cola");
            Console.WriteLine(abc.TryPeek(out string E));
            

            Console.ReadKey();
        }
    }
}
