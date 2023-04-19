// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

sbyte sbyteMin = sbyte.MinValue, sbyteMax = sbyte.MaxValue;
byte byteMin = byte.MinValue, byteMax = byte.MaxValue;
short shortMin = short.MinValue, shortMax = short.MaxValue;
ushort ushortMin = ushort.MinValue, ushortMax = ushort.MaxValue;
int intMin = int.MinValue, intMax = int.MaxValue;
uint uintMin = uint.MinValue, uintMax = uint.MaxValue;
long longMin = long.MinValue, longMax = long.MaxValue;
ulong ulongMin = ulong.MinValue, ulongMax = ulong.MaxValue;
float floatMin = float.MinValue, floatMax = float.MaxValue;
double doubleMin = double.MinValue, doubleMax = double.MaxValue;
decimal decimalMin = decimal.MinValue, decimalMax = decimal.MaxValue;

string[] dt = { "sbyte", "byte", "short", "ushort", "int", "uint", "long", "ulong", "float", "double", "decimal" };
int[] byteSize = { sizeof(sbyte), sizeof(byte), sizeof(short), sizeof(ushort), sizeof(int), sizeof(uint), sizeof(long), sizeof(ulong), sizeof(float), sizeof(double), sizeof(decimal) };

Console.WriteLine(String.Format("{0,15}{1,20}{2,35}{3,35}", "Data Type", "bytes in memory", "minimum", "maximum"));
Console.WriteLine(String.Format("{0,15}{1,20}{2,35}{3,35}", dt[0], byteSize[0], sbyteMin, sbyteMax));
Console.WriteLine(String.Format("{0,15}{1,20}{2,35}{3,35}", dt[1], byteSize[1], byteMin, byteMax));
Console.WriteLine(String.Format("{0,15}{1,20}{2,35}{3,35}", dt[2], byteSize[2], shortMin, shortMax));
Console.WriteLine(String.Format("{0,15}{1,20}{2,35}{3,35}", dt[3], byteSize[3], ushortMin, ushortMax));
Console.WriteLine(String.Format("{0,15}{1,20}{2,35}{3,35}", dt[4], byteSize[4], intMin, intMax));
Console.WriteLine(String.Format("{0,15}{1,20}{2,35}{3,35}", dt[5], byteSize[5], uintMin, uintMax));
Console.WriteLine(String.Format("{0,15}{1,20}{2,35}{3,35}", dt[6], byteSize[6], longMin, longMax));
Console.WriteLine(String.Format("{0,15}{1,20}{2,35}{3,35}", dt[7], byteSize[7], ulongMin, ulongMax));
Console.WriteLine(String.Format("{0,15}{1,20}{2,35}{3,35}", dt[8], byteSize[8], floatMin, floatMax));
Console.WriteLine(String.Format("{0,15}{1,20}{2,35}{3,35}", dt[9], byteSize[9], doubleMin, doubleMax));
Console.WriteLine(String.Format("{0,15}{1,20}{2,35}{3,35}", dt[10], byteSize[10], decimalMin, decimalMax));


//sbyte, byte, short, ushort, int, uint, long, ulong, float, double, decimal 