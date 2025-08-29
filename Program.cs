// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Linq.Expressions;
using System.Runtime.InteropServices;

public class Coche
{
    public string? Marca { get; set; }
    public int? Velocidad { get; set; }
    // Crear el constructor 
    public Coche(string marca, int velocidad)
    {
        Marca = marca;
        Velocidad = velocidad;
    }
    // Metodos
    public void Acelerar(int incremento)
    {
        Velocidad += incremento;
        Console.WriteLine($"El coche {Marca} acelera a: {Velocidad} km/h");
    }

}

// Clase principal
class Program
{
    static void Main(string[] args)
    {
        Coche coche1 = new Coche("Ferrari", 150);
        coche1.Acelerar(30);

        Coche coche2 = new Coche("Hyundai", 10);
        coche2.Acelerar(5);

        coche1 coche3 = new coche1();
        coche3.Acelerar(50);

        Vehiculo vehiculo1 = new Vehiculo();
        vehiculo1.Arrancar();

        auto2 auto2 = new auto2();
        auto2.Acelerar();

        Vehiculo1 vehiculo2 = new Vehiculo1();
        vehiculo2.SonarClaxon();

        Vehiculo1 vehiculo3 = new auto3();
        vehiculo3.SonarClaxon();
    }
}

// Encapsulamiento 
public class coche1
{
    private int _velocidad;
    public int Velocidad
    {
        get { return _velocidad; }
        set
        {
            if (value >= 0)
                _velocidad = value;
            else
                Console.WriteLine("Velocidad no puede se negativo");
        }
    }
    public void Acelerar(int incremento)
    {
        Velocidad += incremento;
        Console.WriteLine($"La velocidad es: {Velocidad} km/h");
    }
}

// Herencia
public class Vehiculo
{
    public string? Marca { get; set; }
    public void Arrancar()
    {
        Console.WriteLine("El vehiculo ha arrancado");
    }
}
// Clase hijo
public class auto2 : Vehiculo
{
    public void Acelerar()
    {
        Console.WriteLine("El auto2 ha arrancado");
    }
}
//Polimorfirmo
public class Vehiculo1
{
    public virtual void SonarClaxon()
    {
        Console.WriteLine("PiPi");
    }
}
public class auto3 : Vehiculo1
{
    public override void SonarClaxon()
    {
        Console.WriteLine("PiPiPiPi");
    }
}