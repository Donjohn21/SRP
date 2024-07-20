
//John aquino 2022-0417.
ublic class Persona
{
    private string nombre;
    private int edad;
    private string direccion;
    private string correoElectronico;

    public void ImprimirDatos()
    {
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Dirección: {direccion}");
        Console.WriteLine($"Correo electrónico: {correoElectronico}");
    }
}

public class CorreoElectronico
{
    public void EnviarCorreoElectronico(string destinatario, string mensaje)
    {
        // Lógica para enviar correo electrónico
    }
}

public class Impresora
{
    public void Imprimir(string texto)
    {
        Console.WriteLine(texto);
    }
}
