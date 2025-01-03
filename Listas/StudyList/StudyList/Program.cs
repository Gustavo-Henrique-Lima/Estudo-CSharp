using System.Collections.Generic;

List<string> list = new List<string>();
list.Add("Maria");
list.Add("Alex");
list.Add("Bob");
list.Add("Ana");

list.Insert(2, "Marco");

foreach (string name in list)
{
    Console.WriteLine(name);
}
Console.WriteLine("------------------");

Console.WriteLine("tamanho da lista: "+ list.Count);
Console.WriteLine("------------------");

string s1 = list.Find(x => x[0] == 'A');
Console.WriteLine("Primeira pessoa com a letra A: "+ s1);
Console.WriteLine("------------------");

string s2 = list.FindLast(x => x[0] == 'A');
Console.WriteLine("Última pessoa com a letra A: " + s2);
Console.WriteLine("------------------");

int p1 = list.FindIndex(x => x[0] == 'A');
Console.WriteLine("Primeira posição que começa com A: " + p1);
Console.WriteLine("------------------");

int p2 = list.FindLastIndex(x => x[0] == 'A');
Console.WriteLine("Última posição que começa com A: " + p2);
Console.WriteLine("------------------");

List<string> result = list.FindAll(x => x.Length == 5);
foreach(string name in result)
{
    Console.WriteLine(name);
}
Console.WriteLine("------------------");

list.Remove("Alex");
foreach(string name in list)
{
    Console.WriteLine(name);
}
Console.WriteLine("------------------");

list.RemoveAll(x => x[0] == 'M');
foreach (string name in list)
{
    Console.WriteLine(name);
}
Console.WriteLine("------------------");

list.RemoveAt(1);
foreach (string name in list)
{
    Console.WriteLine(name);
}
Console.WriteLine("------------------");

list.RemoveRange(2, 2);
foreach (string name in list)
{
    Console.WriteLine(name);
}
Console.WriteLine("------------------");