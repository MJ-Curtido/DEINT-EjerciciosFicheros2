//C:\Users\Dam\Downloads\prueba
//C:\Users\manu1\Downloads\prueba
using System.Text.RegularExpressions;

String ruta1 = "C:\\Users\\Dam\\Downloads\\prueba";
String rutaDirectorio = "";
String nomFichero = "";
String nomCarpeta = "";
String[] ficheros;
String[] rutaSeparada;
String extension = "";
String rutaFichero = "";

Console.WriteLine("-------1-------");
Console.WriteLine("Introduzca una ruta");
ruta1 = Console.ReadLine();

DateTime fechaMin = DateTime.MinValue;

if (Directory.Exists(ruta1))
{
	if (Directory.GetFiles(ruta1).Length > 0)
	{
		ficheros = Directory.GetFiles(ruta1);

		DateTime tiempo = File.GetLastAccessTime(Path.Combine(ruta1, ficheros[0]));
		String ultFicheroAbierto = ficheros[0];

        foreach (String file in ficheros)
		{
			if (File.GetLastAccessTime(file) > tiempo)
			{
				tiempo = File.GetLastAccessTime(file);
				ultFicheroAbierto = file;
            }
        }

		Console.WriteLine($"El fichero al que se ha accedido más recientemente es: {ultFicheroAbierto}");
	}
	else
	{
        Console.WriteLine("No hay ficheros dentro de la carpeta introducida.");
    }
}
else
{
    Console.WriteLine("La ruta introducida no existe.");
}


Console.WriteLine("-------2-------");
Console.WriteLine("Introduzca una ruta");
ruta1 = Console.ReadLine();

if (Directory.Exists(ruta1))
{
    if (Directory.GetFiles(ruta1).Length > 0)
    {
        ficheros = Directory.GetFiles(ruta1);

        Console.WriteLine("Escriba una extensión:");
        extension = Console.ReadLine();

        if (extension[0].Equals("."))
        {
            foreach (String file in ficheros)
            {
                if (extension.ToLower().Equals(Path.GetExtension(file).ToLower()))
                {
                    Console.WriteLine(file);
                }
            
            }
        }
        else
        {
            Console.WriteLine("La extensión tiene que empezar por un punto.");
        }
    }
    else
    {
        Console.WriteLine("No hay ficheros dentro de la carpeta introducida.");
    }
}
else
{
    Console.WriteLine("La ruta introducida no existe.");
}


Console.WriteLine("-------3-------");
Console.WriteLine("Introduzca una ruta");
ruta1 = Console.ReadLine();

if (Directory.Exists(ruta1))
{
    nomCarpeta = "";

    while (!Regex.IsMatch(nomCarpeta, @"^[\w\d]+$"))
    {
        Console.WriteLine("Introduzca el nombre de una carpeta");
        nomCarpeta = Console.ReadLine();

        rutaDirectorio = Path.Combine(ruta1, nomCarpeta);

        if (!Directory.Exists(rutaDirectorio))
        {
            Directory.CreateDirectory(rutaDirectorio);
        }

        ficheros = Directory.GetFiles(ruta1);

        Console.WriteLine("Escriba una extensión:");
        extension = Console.ReadLine();

        if (extension[0].Equals("."))
        {
            foreach (String file in ficheros)
            {
                if (extension.ToLower().Equals(Path.GetExtension(file).ToLower()))
                {
                    rutaSeparada = file.Split("\\");

                    nomFichero = rutaSeparada[rutaSeparada.Length - 1];

                    rutaFichero = Path.Combine(rutaDirectorio, nomFichero);

                    File.Copy(file, rutaFichero, true);

                    Console.WriteLine("Archivo copiado");
                }
            }

            Console.WriteLine("\nCopia realizada");
        }
        else
        {
            Console.WriteLine("La extensión tiene que empezar por un punto.");
        }
    }
}
else
{
    Console.WriteLine("La ruta introducida no existe.");
}


Console.WriteLine("-------4-------");
Console.WriteLine("Introduzca una ruta");
ruta1 = Console.ReadLine();

if (Directory.Exists(ruta1))
{
    ficheros = Directory.GetFiles(ruta1);

    Console.WriteLine("Escriba una extensión:");
    extension = Console.ReadLine();
    
    if (extension[0].Equals("."))
    {
        foreach (String file in ficheros)
        {
            if (extension.ToLower().Equals(Path.GetExtension(file).ToLower()))
            {
                rutaSeparada = file.Split("\\");

                nomFichero = rutaSeparada[rutaSeparada.Length - 1];

                Console.WriteLine("- " + nomFichero);
            }
        }

        Console.WriteLine("¿Desea borrar los archivos? (s/n)");
        String respuesta = Console.ReadLine();

        if (respuesta.ToLower().Equals("s"))
        {
            foreach (String file in ficheros)
            {
                if (extension.ToLower().Equals(Path.GetExtension(file).ToLower()))
                {
                    File.Delete(file);
                }
                else
                {
                    rutaSeparada = file.Split("\\");

                    nomFichero = rutaSeparada[rutaSeparada.Length - 1];

                    Console.WriteLine("- " + nomFichero);
                }
            }
        }
        else if (respuesta.ToLower().Equals("n"))
        {
            Console.WriteLine("Vale.");
        }
        else
        {
            Console.WriteLine("La respuesta introducida es incorrecta.");
        }
    }
    else
    {
        Console.WriteLine("La extensión tiene que empezar por un punto.");
    }
}
else
{
    Console.WriteLine("La ruta introducida no existe.");
}

Console.WriteLine("-------5-------");
Console.WriteLine("Introduzca una ruta de un fichero");
ruta1 = Console.ReadLine();

if (File.Exists(ruta1))
{
    Console.WriteLine("Escriba la nueva extensión que desea que tenga:");
    extension = Console.ReadLine();

    if (extension[0].Equals("."))
    {
        rutaSeparada = ruta1.Split("\\");
        nomFichero = rutaSeparada[rutaSeparada.Length - 1];

        String[] nomSeparado = nomFichero.Split(".");
        String extensionFichero = nomSeparado[nomSeparado.Length - 1];
        String nomFicheroSinExtension = nomFichero.Substring(0, (nomFichero.Length - extensionFichero.Length - 1));
        String rutaSinFichero = ruta1.Substring(0, (ruta1.Length - nomFichero.Length));
        String nomNuevoFichero = nomFicheroSinExtension + extension;
        String rutaNueva = rutaSinFichero + nomNuevoFichero;

        File.Copy(ruta1, rutaNueva);
        File.Delete(ruta1);
    }
    else
    {
        Console.WriteLine("La extensión tiene que empezar por un punto.");
    }
}
else
{
    Console.WriteLine("El fichero introducido no existe.");
}