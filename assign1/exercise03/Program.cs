// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Practice loops and operators
// 1
Console.WriteLine("Part 1!!!!!!!!!!!!!!!!!!!!!!");
// fizzbuzz
int inFB = 15;
if (inFB <= 100){
    if (inFB % 15 == 0) {
        Console.WriteLine("fizzbuzz");
    }else if (inFB % 3 == 0) {
        Console.WriteLine("fizz");
    }
    else if (inFB % 5 == 0){
        Console.WriteLine("buzz");
    }
    else {
        Console.WriteLine(inFB);
    }
}

int max = 500;
for(byte i = 0; i<max; i++) {
    Console.WriteLine(i);
    // add-in
    if (i == byte.MaxValue){
        Console.WriteLine("byte overflowing!");
        break;
    }
}
// infinite loop because max value of byte is 255


// 2 Print-a-Pyramid
Console.WriteLine("Part 2!!!!!!!!!!!!!!!!!!!!!!");
int layer = 6;

for (int i=1;i<=layer; i++) {
    for (int j=1;j<=layer-i; j++)
    {
        Console.Write(" ");
    }
    for (int j=1; j<=(2*i-1);j++)
    {
        Console.Write("*");
    }

    Console.WriteLine("\n");
}



//3
Console.WriteLine("Part 3!!!!!!!!!!!!!!!!!!!!!!");
int correctNum = new Random().Next(3) + 1;
while (true) {
    int guess = int.Parse(Console.ReadLine());
    if (guess == correctNum)
    {
        Console.WriteLine("correct");
        break;
    }
    else if (guess < correctNum)
    {
        Console.WriteLine("guess higher");
    }
    else
    {
        Console.WriteLine("guess lower");
    }
}



//4
Console.WriteLine("Part 4!!!!!!!!!!!!!!!!!!!!!!");
int[] month = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
int[] monthL = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

// birth date
Console.WriteLine("type birthday(mm /n dd /n yyyy):");
int bm = int.Parse(Console.ReadLine());
int bd = int.Parse(Console.ReadLine());
int by = int.Parse(Console.ReadLine());

// current date
DateTime date = DateTime.Today;
int today = date.Day;
int tomonth = date.Month;
int toyear = date.Year;

int age = 0;

// leap year?
int leapT = (int)((toyear / 4) - (toyear / 100) + (toyear / 400));
int leapD = (int)((by / 4) - (by / 100) + (by / 400));

// age
// year->day
age = (int)((toyear - by - 1) * 365.2425);

// month->day
for (int i=0;i<tomonth-1;i++)
{
    if (leapT == 1) age += monthL[i];
    else age += month[i];
}

for (int i = bm; i < 12; i++)
{
    if (leapD == 1) age += monthL[i];
    else age += month[i];
}

// day->day
age += today;
if (leapD == 1) age += monthL[bm]-bd;
else age += month[bm] - bd;

Console.WriteLine("Age in day:" + age);


// 5
Console.WriteLine("Part 5!!!!!!!!!!!!!!!!!!!!!!");
DateTime date2 = DateTime.Now;
int tohour = date2.Hour;

if (tohour>=6 && tohour<12) Console.WriteLine("Good Morning");
else if (tohour>=12 && tohour<18) Console.WriteLine("Good Afternoon");
else if (tohour >= 18 && tohour < 22) Console.WriteLine("Good Evening");
else Console.WriteLine("Good Night");

// 6
Console.WriteLine("Part 6!!!!!!!!!!!!!!!!!!!!!!");
for (int i=1;i<=4;i++)
{
    for (int j=0;j<=24;j+=i)
    {
        if(j==0) Console.Write(j);
        else Console.Write(", "+j);
    }
    Console.WriteLine();
}