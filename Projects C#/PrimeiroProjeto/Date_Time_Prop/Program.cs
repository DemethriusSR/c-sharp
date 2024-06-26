﻿using System;
/* Vendo algumas propriedades do DateTime */
namespace Date_Time_Prop
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 245);

            string s1 = d.ToLongDateString();
            string s2 = d.ToLongTimeString();
            string s3 = d.ToShortDateString();
            string s4 = d.ToShortTimeString();
            string s5 = d.ToString("yyyy-MM-dd HH:mm:ss");

            DateTime d2 = d.AddHours(1);
            DateTime d3 = d.AddMinutes(10).AddSeconds(02);

            TimeSpan t = d2.Subtract(d);

            Console.WriteLine(d);
            Console.WriteLine($"1) Date: {d.Date}");
            Console.WriteLine($"2) Day: {d.Day}");
            Console.WriteLine($"3) DayOfWeek: {d.DayOfWeek}");
            Console.WriteLine($"4) DayOfYear: {d.DayOfYear}");
            Console.WriteLine($"5) Hours: {d.Hour}");
            Console.WriteLine($"6) Kind: {d.Kind}");
            Console.WriteLine($"7) Millisecond: {d.Millisecond}");
            Console.WriteLine($"8) Minute: {d.Minute}");
            Console.WriteLine($"9) Month: {d.Month}");
            Console.WriteLine($"10) Second: {d.Second}");
            Console.WriteLine($"11) Ticks: {d.Ticks}");
            Console.WriteLine($"12) TimeOfDay: {d.TimeOfDay}");
            Console.WriteLine($"13) year: {d.Year}");
            Console.WriteLine("=====================================");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine($" {d2} - {d} = {t}");

        }
    }
}