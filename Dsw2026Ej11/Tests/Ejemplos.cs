using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList casoList = new CasoList();
        Alumno alumno1 = new Alumno(1, "Nazarena", 7);
        casoList.AgregarAlumno(alumno1);
        Alumno alumno2 = new Alumno(2, "Nicolas", 8);
        casoList.AgregarAlumno(alumno2);
        Alumno alumno3 = new Alumno(3, "Martina", 5);
        casoList.AgregarAlumno(alumno3);

        //Listar por consola los alumnos
        foreach (Alumno alumno in casoList.ObtenerLista())
        {
            Console.WriteLine("Id: " + alumno.Id + " - Nombre: " + alumno.Nombre + " - Promedio: " + alumno.Promedio);
        }

        //Buscar alumnos por nombre
        Alumno nomBuscado = casoList.BuscarAlumno("Nazarena");

        if(nomBuscado != null)
        {
            Console.WriteLine("Alumno encontrado: " + nomBuscado.Nombre);
        }

        //Buscar alumno que no existe
        Alumno nombreBuscado = casoList.BuscarAlumno("Guadalupe");

        if (nomBuscado != null)
        {
            Console.WriteLine("No existe el alumno Guadalupe.");
        }

        //
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {

    }
}
