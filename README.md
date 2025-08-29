# Programación orientado a objetos con c#

### Como crear un proyecto en c# en consola
```bash
dotnet new console
```

### Estructura de una clase en c#
```csharp
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
```
# Iniciar git
```bash
git init
```
Agregar todos los cambios 
```bash
git add .
```
Poner nombre a la version 
```bash
git commit -m "nombreversion"
```
Para verificar la rama
```bash
git branch
```