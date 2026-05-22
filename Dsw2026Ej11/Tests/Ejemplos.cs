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
        //EJEMPLO DE AGREGAR 3 ALUMNOS A LA LISTA
        CasoList casoList = new CasoList();
        Alumno alumno1 = new Alumno(1, "Nazarena", 7);
        casoList.AgregarAlumno(alumno1);
        Alumno alumno2 = new Alumno(2, "Nicolas", 8);
        casoList.AgregarAlumno(alumno2);
        Alumno alumno3 = new Alumno(3, "Martina", 5);
        casoList.AgregarAlumno(alumno3);

        //LISTAR POR CONSOLA LOS ALUMNOS
        foreach (Alumno alumno in casoList.ObtenerLista())
        {
            Console.WriteLine("Id: " + alumno.Id + " - Nombre: " + alumno.Nombre + " - Promedio: " + alumno.Promedio);
        }

        //BUSCAR ALUMNO POR NOMBRE
        Alumno nomBuscado = casoList.BuscarAlumno("Nazarena");
        Console.WriteLine("Buscando alumno... ");
        if (nomBuscado != null)
            Console.WriteLine("Alumno encontrado: " + nomBuscado.Nombre);
        else
            Console.WriteLine("No existe.");

        //BUSCAR ALUMNO QUE NO EXISTE
        Alumno nombreBuscado = casoList.BuscarAlumno("Nazarena");
        Console.WriteLine("Buscando alumno... ");
        if (nombreBuscado != null)
            Console.WriteLine("Alumno encontrado: " + nombreBuscado.Nombre);
        else
            Console.WriteLine("No existe.");

        //ELIMINAR ALUMNO
        Console.WriteLine("Elimino un alumno: ");
        casoList.EliminarAlumno(alumno2);
        foreach (Alumno alumno in casoList.ObtenerLista())
        {
            Console.WriteLine("Id: " + alumno.Id + " - Nombre: " + alumno.Nombre + " - Promedio: " + alumno.Promedio);
        }

        //ELIMINAR EL PRIMER ALUMNO
        Console.WriteLine("Elimino el primer alumno ingresado: ");
        casoList.EliminarXPosicion(0);
        foreach (Alumno alumno in casoList.ObtenerLista())
        {
            Console.WriteLine("Id: " + alumno.Id + " - Nombre: " + alumno.Nombre + " - Promedio: " + alumno.Promedio);
        }

    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        //AGREGO 3 ALUMNOS AL DICCIONARIO
        CasoDictionary casoDictionary = new CasoDictionary();
        Alumno alumno1 = new Alumno(1, "Nazarena", 7);
        casoDictionary.AgregarAlumno(60445, alumno1);
        Alumno alumno2 = new Alumno(2, "Nicolas", 8);
        casoDictionary.AgregarAlumno(60810, alumno2);
        Alumno alumno3 = new Alumno(3, "Martina", 5);
        casoDictionary.AgregarAlumno(60782, alumno3);
        
        //LISTAR LOS ALUMNOS
        foreach (var alumno in casoDictionary.ObtenerDiccionario())
        {
            Console.WriteLine("Legajo: " + alumno.Key + ". Alumno: " + alumno.Value);
        }

        Alumno alumBuscado = casoDictionary.BuscarAlumno(60445);
        Console.WriteLine("Buscando alumno... ");
        if (alumBuscado != null)
            Console.WriteLine("Alumno encontrado: " + alumBuscado.Nombre);
        else
            Console.WriteLine("No existe.");

        //BUSCAR ALUMNO QUE NO EXISTE
        Alumno alumnoBuscado = casoDictionary.BuscarAlumno(50778);
        Console.WriteLine("Buscando alumno... ");
        if (alumnoBuscado != null)
            Console.WriteLine("Alumno encontrado: " + alumnoBuscado.Nombre);
        else
            Console.WriteLine("No existe.");

        //ELIMINAR ALUMNO
        Console.WriteLine("Elimino un alumno: ");
        casoDictionary.EliminarXclave(60810);
        foreach (var alumno in casoDictionary.ObtenerDiccionario())
        {
            Console.WriteLine("Legajo: " + alumno.Key + ". Alumno: " + alumno.Value);
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq casoLinq = new CasoLinq();

        //1.
        Console.WriteLine("Primer libro:" + casoLinq.GetPrimero(null).Titulo);

        //2.
        Console.WriteLine("Último libro:" + casoLinq.GetUltimo(null).Titulo);

        //3.
        Console.WriteLine("Suma total de precios:" + casoLinq.GetTotalPrecios());

        //4.
        Console.WriteLine("Promedio de precios:" + casoLinq.GetPromedioPrecios());

        //5.
        Console.WriteLine("\nLibros con ID mayor a 15:");

        foreach (var libro in casoLinq.GetLibroById())
        {
            Console.WriteLine(libro.Titulo);
        }

        //7.
        Console.WriteLine("\nLibro con mayor precio:" + casoLinq.GetMayorPrecio().Titulo);

        //8.
        Console.WriteLine("\nLibro con menor precio:" + casoLinq.GetMenorPrecio().Titulo);

        //9.
        Console.WriteLine("\nLibros con precio mayor al promedio:");

        foreach (var libro in casoLinq.GetMayorPromedio())
        {
            Console.WriteLine(libro.Titulo + " - " + libro.Precio);
        }

        //10.
        Console.WriteLine("\nLibros ordenados descendentemente:");

        foreach (var libro in casoLinq.OrdenDescendente())
        {
            Console.WriteLine(libro.Titulo);
        }

    }
}
