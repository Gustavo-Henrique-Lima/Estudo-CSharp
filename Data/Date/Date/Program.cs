using System.Globalization;

DateTime data = new DateTime(2024, 12, 01);
DateTime data2 = new DateTime(2024, 12, 01, 15, 53, 55);
DateTime data3 = DateTime.Now;
DateTime data4 = DateTime.Today;
DateTime data5 = DateTime.UtcNow;

DateTime d1 = DateTime.Parse("01/12/2024 15:56");
DateTime d2 = DateTime.ParseExact("2024-12-01", "yyyy-MM-dd", CultureInfo.InvariantCulture);
DateTime d3 = DateTime.ParseExact("01/12/2024 16:01", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);


Console.WriteLine(data);
Console.WriteLine(data2);
Console.WriteLine(data3);
Console.WriteLine(data4);
Console.WriteLine(data5);
Console.WriteLine(d1);
Console.WriteLine(d2);
Console.WriteLine(d3);