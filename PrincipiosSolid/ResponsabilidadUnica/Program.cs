// See https://aka.ms/new-console-template for more information
using ResponsabilidadUnica;

Console.WriteLine("Hello, World!");


ImprimirVehiculo imprimir = new ImprimirVehiculo();
imprimir.Marca = "Ford";
imprimir.Velocidad = 100;

imprimir.ImprimirDatos();

imprimir.Acelerar(100);

imprimir.ImprimirDatos();


Console.ReadKey();
