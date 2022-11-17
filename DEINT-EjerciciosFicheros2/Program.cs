//C:\Users\Dam\Downloads\prueba
String ruta1 = "";
String nomFichero = "";
String[] ficheros;

/*
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
        String extension = Console.ReadLine();

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
        Console.WriteLine("No hay ficheros dentro de la carpeta introducida.");
    }
}
else
{
    Console.WriteLine("La ruta introducida no existe.");
}
*/