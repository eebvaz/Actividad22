
interface ILogin
{
    void Registro();
}

interface IAutitoria
{
    void Inicio();
}

class Sistema : ILogin, IAutitoria
{
    public void Inicio()
    {
        Console.WriteLine("Se ha iniciado correctamente");
    }

    public void Registro()
    {
        Console.WriteLine("Se ha registrado correctamente");
    }
}
class Program
{
    static void Main()
    {
        Sistema sistema = new Sistema();

        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("Inicio");
            Console.WriteLine("Opcion1: Inicio");
            Console.WriteLine("Opcion2: Registro");
            Console.WriteLine("Opcion3; Salir");
            Console.Write("Eleccion: ");

            while (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.Write("Dato erroneo");
            }

            switch (opcion)
            {
                case 1:
                    sistema.Inicio();
                    Thread.Sleep(5000);
                    Console.ReadKey();
                    break;
                case 2:
                    sistema.Registro();
                    Thread.Sleep(5000);
                    Console.ReadKey();
                    break;
                default:
                    break;

            }

        } while (opcion != 3);
    }
}