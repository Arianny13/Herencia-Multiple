// See https://aka.ms/new-console-template for more information
using Figurageometrica_eje1;


Console.WriteLine("calculo de circulo");

Circulo circulo = new Circulo();
Console.Write("RADIO: ");
circulo.Radio = double.Parse(Console.ReadLine());

double resultado = circulo.CalcularArea();
double perimetro = circulo.CalcularPerimetro();

Console.WriteLine("El area de un circulo es: " + resultado);
Console.WriteLine($"El perimetro del circulo es {perimetro} ");

