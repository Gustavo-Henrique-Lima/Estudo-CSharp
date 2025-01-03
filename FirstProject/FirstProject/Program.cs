// See https://aka.ms/new-console-template for more information
/*
sbyte x = 100; //(Sbyte) De -128 até 127
byte y = 254; //De 0 até 255
int n1 = 1000;
int n2 = 2147483647;
long n3 = 2147483648L;
bool completo = false;
char genero = 'F';
char letra = '\u0041';
float n4 = 4.5f;
double n5 = 4.5;
string nome = "Maria Green";
object obj1 = "Alex Brown";
object obj2 = 4.5f;
int min = int.MinValue;
int max = int.MaxValue;
sbyte minByte = sbyte.MinValue;
decimal de = decimal.MaxValue;


Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(n1);
Console.WriteLine(n2);
Console.WriteLine(n3);
Console.WriteLine(completo);
Console.WriteLine(genero);
Console.WriteLine(letra);
Console.WriteLine(n4);
Console.WriteLine(n5);
Console.WriteLine(nome);
Console.WriteLine(obj1);
Console.WriteLine(obj2);
Console.WriteLine(min);
Console.WriteLine(max);
Console.WriteLine(minByte);
Console.WriteLine(de);*/

using System.Globalization;

char genero = 'F';
int idade = 32;
double saldo = 10.35784;
string nome = "Maria";

Console.WriteLine("----------------------------");
Console.WriteLine(genero);
Console.WriteLine(idade);
Console.WriteLine(saldo);
Console.WriteLine(nome);
Console.WriteLine(saldo.ToString("F2"));
Console.WriteLine(saldo.ToString("F4"));
Console.WriteLine(saldo.ToString("F4",CultureInfo.InvariantCulture));
Console.WriteLine("----------------------------");
Console.WriteLine($"{nome} tem {idade} é do sexo {genero} e tem {saldo:F2} de saldo");
Console.WriteLine(nome + " tem " + idade + " é do sexo " + genero + " e tem " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " de saldo.");

int a = 10;
int b = a++; //Aqui primeiro coloca o valor de A em B e depois soma o valor em A
Console.WriteLine(a);
Console.WriteLine(b);
int c = 10;
int d = ++c; //Aqui soma o valor em A e coloca o valor em B
Console.WriteLine(c);
Console.WriteLine(d);