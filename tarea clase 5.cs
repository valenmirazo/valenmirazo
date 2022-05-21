Console.WriteLine("HOLA MUNDO");
    
Console.Clear();

Console.WriteLine("ingrese su nombre: ");

string nombre = Console.ReadLine();

Console.WriteLine("hola " + nombre);

Console.WriteLine("quieres continuar? S para si o N para no");

string respuesta = Console.ReadLine();

if (respuesta.ToUpper() =="N" )

{
    Console.WriteLine("programa finalizado correctamente");
        }

else {
    Console.WriteLine("la opcion no es valida");
        }

while (respuesta.ToUpper() == "S")
{
    Console.Clear();

    Console.WriteLine("ingrese su nombre: ");

    string nombre1 = Console.ReadLine();

    Console.WriteLine("hola " + nombre1);

    Console.WriteLine("quieres continuar? S para si o N para no");

    respuesta = Console.ReadLine();

    // prueba n°1
    if (respuesta.ToUpper() == "N")

    {
        Console.WriteLine("programa finalizado correctamente");
    }

    else
    {
        Console.WriteLine("la opcion no es valida");
    }


}

