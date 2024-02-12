// See https://aka.ms/new-console-template for more information
Console.WriteLine("calcular nota");

// Solicitar al usuario ingresar las 4 notas
Console.WriteLine("Ingrese la primera nota:");
double nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese la segunda nota:");
double nota2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese la tercera nota:");
double nota3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese la cuarta nota:");
double nota4 = Convert.ToDouble(Console.ReadLine());

// Calcular el promedio
double promedio = (nota1 + nota2 + nota3 + nota4) / 4;

// Determinar si aprobó o reprobó
string estado = (promedio >= 70) ? "Aprobado" : "Reprobado";

// Imprimir resultados
Console.WriteLine("Promedio: " + promedio);
Console.WriteLine("Estado: " + estado);
