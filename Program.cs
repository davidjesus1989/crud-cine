using System;
using System.Collections.Generic;

class Program
{
    static List<string> peliculas = new List<string>()
    {
        "El demonio de la programación",
        "Volver al futuro",
        "Star wars: Episode I - La amenaza fantasma",
        "Caballo homosexual de las montañas",
        "The Lord of the Rings: El retorno del rey",
        "Forrest Gump",
        "Star Wars: Episode V - El imperio contraataca",
        "El efecto mariposa",
        "Super cool",
        "Mi novia Polly",
        "Saint seiya: Batalla contra Lucifer",
        "Doraemon: Quédate conmigo",
        "La pesadilla de Rafa y sus Colores",
        "Documental: ¿Como ser bueno en Pokémon Unite?",
    };
    static List<string> peliculasfavoritas = new List<string>()
    {
        "Neon genesis Evangelion",
        "La pesadilla de fundación mis perris",
        "Siempre a tu lado",
        "500 dias con Sumer",
        "Interestellar",
        "Gravedad",
        "Apollo XV",
        "¿Que, como que no? ¡Me colgó!",
    };

    static void Main(string[] args)
    {
        Console.WriteLine("¡Bienvenido!");
        Console.WriteLine("A continuación le presentamos la lista de películas que tenemos en los registros");
        Console.WriteLine("¿Que desea hacer?");

        while (true)
        {
            Console.WriteLine("\nSeleccione una opción:");
            Console.WriteLine("0. Ver lista de películas");
            Console.WriteLine("1. Añadir una película");
            Console.WriteLine("2. Actualizar una película");
            Console.WriteLine("3. Eliminar una película");
            Console.WriteLine("4. Buscar una pelicula");
            Console.WriteLine("5. Ver lista de peliculas favoritas");
            Console.WriteLine("6. Añadir una pelicula a favorita");
            Console.WriteLine("7. Actualizar una pelicula favorita");
            Console.WriteLine("8. Eliminar una pelicula favorita");
            Console.WriteLine("9. Buscar una pelicula favorita");
            Console.WriteLine("10. Salir");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 0:
                    VerPeliculas();
                    break;

                case 1:
                    AgregarPelicula();
                    break;

                case 2:
                    ActualizarPelicula();
                    break;

                case 3:
                    EliminarPelicula();
                    break;

                case 4:
                    BuscarPelicula();
                    break;

                case 5:
                    VerPeliculasfavoritas();
                    break;

                case 6:
                    AgregarPeliculafavoritas();
                    break;

                case 7:
                    ActualizarPeliculafavorita();
                    break;
               
                case 8:
                    EliminarPeliculafavorita();
                    break;

                case 9:
                    BuscarPeliculafavoritas();
                    break;

                case 10:
                    Console.WriteLine("Gracias por preferir nuestra App,¡Hasta pronto!");
                    return;

                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        }
    }

    static void VerPeliculas()
    {
        Console.WriteLine("\nLista de películas:");

        for (int i = 0; i < peliculas.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + peliculas[i]);
        }
    }

  

    static void AgregarPelicula()
    {
        Console.WriteLine("\nIngrese el nombre de la película:");

        string pelicula = Console.ReadLine();

        peliculas.Add(pelicula);

        Console.WriteLine("La película ha sido añadida exitosamente");
    }

    static void ActualizarPelicula()
    {
        Console.WriteLine("\nIngrese el número de la película que desea actualizar:");

        int index = int.Parse(Console.ReadLine()) - 1;

        Console.WriteLine("\nIngrese el nuevo nombre de la película:");

        string pelicula = Console.ReadLine();

        peliculas[index] = pelicula;

        Console.WriteLine("La película ha sido actualizada exitosamente");
    }

    static void EliminarPelicula()
    {
        Console.WriteLine("\nIngrese el número de la película que desea eliminar:");

        int index = int.Parse(Console.ReadLine()) - 1;

        peliculas.RemoveAt(index);

        Console.WriteLine("La película ha sido eliminada exitosamente");
    }



    static void BuscarPelicula()
    {
        Console.WriteLine("ingrese el nombre de la pelicula que desea buscar");

        string pelicula = Console.ReadLine();

        int index = peliculas.IndexOf(pelicula);

        if (index != -1)
        {
            Console.WriteLine("la pelicula se encuantra en la posición " + (index + 1));
        }
        else
        { 
            Console.WriteLine("¡la pelicula no se encuentra en la lista!");

            Console.WriteLine("Verifique mayúsculas y caracteres especiales");
        }



    }

    static void VerPeliculasfavoritas()
    {
        Console.WriteLine("\nLista de películas favoritas:");

        for (int i = 0; i < peliculasfavoritas.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + peliculasfavoritas[i]);
        }
    }

    static void AgregarPeliculafavoritas()
    {
        Console.WriteLine("\nIngrese el nombre de la película:");

        string pelicula = Console.ReadLine();

        peliculasfavoritas.Add(pelicula);

        Console.WriteLine("La película ha sido añadida exitosamente");
    }

    static void ActualizarPeliculafavorita()
    {
        Console.WriteLine("\nIngrese el número de la película que desea actualizar:");

        int index = int.Parse(Console.ReadLine()) - 1;

        Console.WriteLine("\nIngrese el nuevo nombre de la película:");

        string pelicula = Console.ReadLine();

        peliculasfavoritas[index] = pelicula;

        Console.WriteLine("La película ha sido actualizada exitosamente");
    }

    static void EliminarPeliculafavorita()
    {
        Console.WriteLine("\nIngrese el número de la película que desea eliminar:");

        int index = int.Parse(Console.ReadLine()) - 1;

        peliculasfavoritas.RemoveAt(index);

        Console.WriteLine("La película ha sido eliminada exitosamente");
    }
    static void BuscarPeliculafavoritas()
    {
        Console.WriteLine("ingrese el nombre de la pelicula que desea buscar");

        string pelicula = Console.ReadLine();

        int index = peliculasfavoritas.IndexOf(pelicula);

        if (index != -1)
        {
            Console.WriteLine("la pelicula se encuantra en la posición " + (index + 1));
        }
        else
        {
            Console.WriteLine("¡la pelicula no se encuentra en la lista!");

            Console.WriteLine("Verifique mayúsculas y caracteres especiales");
        }

    }

    }
