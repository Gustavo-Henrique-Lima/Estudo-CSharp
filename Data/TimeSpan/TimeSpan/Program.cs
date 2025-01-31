﻿TimeSpan t1 = new(0, 1, 30);
Console.WriteLine(t1);

TimeSpan t2 = new();
Console.WriteLine(t2);

TimeSpan t3 = new(900000000L);
Console.WriteLine(t3);

TimeSpan t4 = new(8, 12, 24);
Console.WriteLine(t4);

TimeSpan t5 = new(1, 2, 11, 21);
Console.WriteLine(t5);

TimeSpan t6 = new(1, 2, 11, 21, 321);
Console.WriteLine(t6);

TimeSpan t7 = TimeSpan.FromDays(1.5);
Console.WriteLine(t7);

TimeSpan t8 = TimeSpan.FromHours(1.5);
Console.WriteLine(t8);

TimeSpan t9 = TimeSpan.FromMinutes(1.5);
Console.WriteLine(t9);

TimeSpan t10 = TimeSpan.FromSeconds(1.5);
Console.WriteLine(t10);

TimeSpan t11 = TimeSpan.FromMilliseconds(1.5);
Console.WriteLine(t11);

TimeSpan t12 = TimeSpan.FromTicks(900000000L);
Console.WriteLine(t12);