DateTime d1 = new(2001, 3, 29, 19, 45, 50);

Console.WriteLine(d1);
Console.WriteLine("1) Date: " + d1.Date);
Console.WriteLine("2) Day: " + d1.Day);
Console.WriteLine("3) DayOfWeek: " + d1.DayOfWeek);
Console.WriteLine("4) DayOfYear:" + d1.DayOfYear);
Console.WriteLine("5) Hour: " + d1.Hour);
Console.WriteLine("6) Kind:" + d1.Kind);
Console.WriteLine("7) Millisecnd:" + d1.Millisecond);
Console.WriteLine("8) Minute: " + d1.Minute);
Console.WriteLine("9) Month:" + d1.Month);
Console.WriteLine("10) Second: " + d1.Second);
Console.WriteLine("11) Ticks: " + d1.Ticks);
Console.WriteLine("12) TimeOfDay: " + d1.TimeOfDay);
Console.WriteLine("13) Year: " + d1.Year);

Console.WriteLine(d1.ToLongDateString());
Console.WriteLine(d1.ToLongTimeString());
Console.WriteLine(d1.ToShortDateString());
Console.WriteLine(d1.ToShortTimeString());
Console.WriteLine(d1.ToString());

Console.WriteLine(d1.ToString("dd/MM/yyyy HH:mm:ss"));
Console.WriteLine(d1.ToString("dd/MM/yyyy HH:mm:ss.fff"));

DateTime d2 = d1.AddHours(2);
Console.WriteLine(d2);

DateTime d3 = d1.AddMinutes(3);
Console.WriteLine(d3);

DateTime d4 = d1.AddDays(7);
Console.WriteLine(d4);

DateTime d5 = DateTime.Now;

Console.WriteLine(d5.Subtract(d1));