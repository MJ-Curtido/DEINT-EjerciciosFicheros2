//C:\Users\Dam\Downloads\prueba
String ruta1 = "";
String nomFichero = "";
String[] ficheros;
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

		foreach (String file in ficheros)
		{
            //combinar rutas

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