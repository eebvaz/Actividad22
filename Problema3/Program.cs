
using System.Drawing;

class Personal
{
  
    public string nombre;

    public virtual void TipoAcceso()
    {
        Console.WriteLine("Acceso General");
    }
}

class Empleado: Personal
{
    public override void TipoAcceso()
    {
        Console.WriteLine("Acceso de empleado");
    }
}

class Visitante : Personal
{
    public override void TipoAcceso()
    {
        Console.WriteLine("Acceso limitado");
    }
}


class Seguridad : Personal
{
    public override void TipoAcceso()
    {
        Console.WriteLine("Acceso completo");
    }
}


class Program
{
    static void Main()
    {
        Personal dato1 = new Empleado();
        Personal dato2 = new Visitante();
        Personal dato3 = new Seguridad();

        int opcion;
        string nombre;



        do
        {
           
            Console.Clear();
            Console.WriteLine("Inicio");
            Console.WriteLine("Opcion1: Emepleado");
            Console.WriteLine("Opcion2: Visitante");
            Console.WriteLine("Opcion3: Seguridad");
            Console.WriteLine("Opcion4; Salir");
            Console.Write("Eleccion: ");

            while (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.Write("Dato erroneo");
            }

            switch (opcion)
            {
                case 1:

                        Console.Clear();
                        Console.WriteLine("Empleado");
                        Console.Write("Ingrese el usuario: ");
                        nombre = Console.ReadLine();
                    dato1.nombre = nombre;
                    dato1.TipoAcceso();
                    Thread.Sleep(5000);
                    Console.ReadKey();
                    break;
                case 2:
                        Console.Clear();
                        Console.WriteLine("Visitante");
                        Console.Write("Ingrese el usuario: ");
                        nombre = Console.ReadLine();
                    dato2.nombre = nombre;
                    dato2.TipoAcceso();
                    Thread.Sleep(5000);
                    Console.ReadKey();
                    break;
                case 3:
                        Console.Clear();
                        Console.WriteLine("Seguridad");
                        Console.Write("Ingrese el usuario: ");
                        nombre = Console.ReadLine();
                    dato3.nombre = nombre;
                    dato3.TipoAcceso();
                    Thread.Sleep(5000);
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
        } while (opcion != 4);

    }
}