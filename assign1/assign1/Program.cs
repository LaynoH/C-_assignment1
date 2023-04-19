// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Practice number sizes and ranges

Console.WriteLine("Input: ");
uint century = uint.Parse(Console.ReadLine());
uint year = century * 100;
uint day = (uint)(year * 365.2425);
ulong hour = (ulong)(day * 24);
ulong min = hour * 60;
ulong sec = min * 60;
String milisec = sec+"000";
String microsec = milisec + "000";
String nanosec = microsec + "000";

Console.WriteLine("Output: {0} centeries = {1}  years = {2} days = {3} hours = " +
    "{4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",
    century, year, day, hour, min, sec, milisec, microsec, nanosec);

