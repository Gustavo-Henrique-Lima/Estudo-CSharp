﻿using System.Globalization;
using Triangulo;

Tri x, y;
x = new Tri();
y = new Tri();

Console.WriteLine("Entre com as medidas do triângulo X:");
 x.A= double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
 x.B= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
 x.C= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com as medidas do triângulo Y:");
y.A= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double areaX = x.Area();

double areaY = y.Area();

Console.WriteLine($"Área de X = {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Área de Y = {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

Console.WriteLine(areaX > areaY ? "Maior área: X" : "Maior área: Y");

