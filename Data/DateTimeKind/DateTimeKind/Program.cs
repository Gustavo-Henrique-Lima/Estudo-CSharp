/*
DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

Console.WriteLine("D1: " + d1);
Console.WriteLine("D1 KIND: " + d1.Kind);
Console.WriteLine("D1 TO LOCAL: " + d1.ToLocalTime());
Console.WriteLine("D1 TO UTC: " + d1.ToUniversalTime());
Console.WriteLine();

Console.WriteLine("D2: " + d2);
Console.WriteLine("D2 KIND: " + d2.Kind);
Console.WriteLine("D2 TO LOCAL: " + d2.ToLocalTime());
Console.WriteLine("D2 TO UTC: " + d2.ToUniversalTime());
Console.WriteLine();

Console.WriteLine("D3: " + d3);
Console.WriteLine("D3 KIND: " + d3.Kind);
Console.WriteLine("D3 TO LOCAL: " + d3.ToLocalTime());
Console.WriteLine("D3 TO UTC: " + d3.ToUniversalTime());
*/
DateTime d1 = new DateTime.Parse("2000-03-29 19:12:08");
DateTime d2 = new DateTime.Parse("2000-03-29T19:12:08Z");
Console.WriteLine(d1);
Console.WriteLine(d2);