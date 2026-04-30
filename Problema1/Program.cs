
class Usuario
{
    public string nombre;
    public string contrasena;

    public void Inciar()
    {
        Console.WriteLine("Bienvenido");
    }
}

class Alumno : Usuario
{
    public void Permiso1()
    {
        Console.WriteLine("Acceso permitido");
        Console.WriteLine(nombre+" esta estudiando...");
    }
}

class Profesor : Usuario
{
    public void Permiso2()
    {
        Console.WriteLine("Acceso permitido");
        Console.WriteLine(nombre + "esta Calificando...");
    }
}

class Coordinador : Usuario
{
    public void Permiso3()
    {
        Console.WriteLine("Acceso permitido");
        Console.WriteLine(nombre + "esta administrando...");
    }
}

class Program
{
    static void Main()
    {
        Alumno estudiante = new Alumno();
        Profesor maestro = new Profesor();  
        Coordinador coord = new Coordinador();

        int opcion;
        string nombre,contrasena;
      

        
        do
        {
            Console.WriteLine("");
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

            switch(opcion)
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

                            if(contrasena == "123456789")
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


                        if (nombre == "Carlos"&& nombre == "carlos")
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


                        if (nombre == "Ana"&& nombre == "ana")
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

