
using System.Drawing;

class Persona
{
  
    public string nombre;

    public void Inicio()
    {
        Console.WriteLine("Bienvenido");
    }

}

class Empleado: Persona
{
    public void Permiso1()
    {
        Console.WriteLine("");
    }
}

class Visitante : Persona
{
    public void Permiso2()
    {
        Console.WriteLine("");
    }
}


class Seguridad : Persona
{
    public void Permiso3()
    {
        Console.WriteLine("");
    }
}


class Program
{
    static void Main()
    {
       Empleado trabajador = new Empleado();
        trabajador.Permiso1();

       Visitante visita = new Visitante();
        visita.Permiso2();

       Seguridad seguridad = new Seguridad();
        seguridad.Permiso3();


        int opcion;
        string nombre, contrasena;



        do
        {
           
            Console.Clear();
            Console.WriteLine("Inicio");
            Console.WriteLine("Opcion1: Alumno");
            Console.WriteLine("Opcion2: Profesor");
            Console.WriteLine("Opcion3: Coordinador");
            Console.WriteLine("Opcion4; Salir");
            Console.Write("Eleccion: ");

            while (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.Write("Dato erroneo");
            }

            switch (opcion)
            {
                case 1:
                    bool validar1 = false;

                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Alumno");
                        Console.Write("Ingrese el usuario: ");
                        nombre = Console.ReadLine();
                        Console.Write("Ingrese la contraseña: ");
                        contrasena = Console.ReadLine();


                        if (nombre == "Mario")
                        {

                            if (contrasena == "123456789")
                            {
                                estudiante.nombre = nombre;
                                estudiante.Inciar();
                                estudiante.Permiso1();
                                Thread.Sleep(5000);
                                validar1 = true;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Error");
                            Thread.Sleep(5000);
                            Console.ReadKey();

                        }
                    } while (!validar1);

                    break;
                case 2:
                    bool validar2 = false;

                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Profesor");
                        Console.Write("Ingrese el usuario: ");
                        nombre = Console.ReadLine();
                        Console.Write("Ingrese la contraseña: ");
                        contrasena = Console.ReadLine();


                        if (nombre == "Carlos" && nombre == "carlos")
                        {

                            if (contrasena == "examen")
                            {
                                maestro.nombre = nombre;
                                maestro.Inciar();
                                maestro.Permiso2();
                                Thread.Sleep(5000);
                                validar2 = true;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Error");
                            Thread.Sleep(5000);
                            Console.ReadKey();

                        }
                    } while (!validar2);
                    break;
                case 3:
                    bool validar3 = false;

                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Coordinador");
                        Console.Write("Ingrese el usuario: ");
                        nombre = Console.ReadLine();
                        Console.Write("Ingrese la contraseña: ");
                        contrasena = Console.ReadLine();


                        if (nombre == "Ana" && nombre == "ana")
                        {

                            if (contrasena == "principal")
                            {
                                coord.nombre = nombre;
                                coord.Inciar();
                                coord.Permiso3();
                                Thread.Sleep(5000);
                                validar3 = true;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Error");
                            Thread.Sleep(5000);
                            Console.ReadKey();

                        }
                    } while (!validar3);
                    break;
                default:
                    break;


            }




        } while (opcion != 4);

    }
}