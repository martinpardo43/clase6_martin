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

        Perro perro1 = new Perro("Carlo", 2);
        perro1.HacerSonido();

        Gato gato1 = new Gato("Pelin", 1);
        gato1.HacerSonido();
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

// Ejercicios 
public interface IMascota
{
    void HacerSonido();
}
public class Perro : IMascota
{
    public string? Nombre { get; set; }
    public int Edad { get; set; }
    public Perro(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }
    public void HacerSonido()
    {
        Console.WriteLine($"El nombre de tu perro es {Nombre} y tiene {Edad} años");
        Console.WriteLine("Guau Guau");
    }
}
public class Gato : IMascota
{
    public string? Nombre { get; set; }
    public int Edad { get; set; }
    public Gato(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }
    public void HacerSonido()
    {
        Console.WriteLine($"El nombre de tu gato es {Nombre} y tiene {Edad} año");
        Console.WriteLine("Miau Miau");
    }
}
