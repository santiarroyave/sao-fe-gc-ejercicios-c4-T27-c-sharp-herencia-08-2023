# C4-T27 C# Herencia

<!-- ## Enlaces al código
- M5 Exercicio Jobs
    - [Milestone 1]()
    - [Milestone 2]()
    - [Milestone 3]()
- M6 Exercicio Vehicles
    - [Milestone 1]()
    - [Milestone 2]()
    - [Milestone 3]()

## M5 Exercicio Jobs
[Enunciados M5 (pdf)]()
- Milestone 1: Crear clase empleado y 4 empleados que hereden de esa clase, cada uno cobrando un porcentaje diferente.
- Milestone 2: Añadir 3 empleados más y validar sueldos.
- Milestone 3: 

## M6 Exercicio Vehicles
[Enunciados M6 (pdf)]()
- Milestone 1: 
- Milestone 2: 
- Milestone 3:  -->

## Notas

### Heredar métodos
- Al crear un método en la clase base no necesariametne es obligatorio que la clase derivada lo herede.
- Si queremos que la clase derivada obligatoriamente herede un método, tendremos que poner en la clase base que es abstracta.
- Para modificar el método de la clase base en la clase derivada hay que usar el *override*.

```csharp
// Clase base
internal abstract class Empleat
{
    int salari;

    public Empleat() { }

    public abstract void AfegirSalari();
}

// Clase derivada
internal class Manager : Empleat
{
    public Manager() { }

    public override void AfegirSalari()
    {
        Console.WriteLine("Hola");
    }
}
```