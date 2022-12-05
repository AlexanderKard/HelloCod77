int a = 1;
int b = 2;
int c = 3;
int d = 4;
int f = 5;

int max = a;

if (a > max) max = a;
if (b > max) max =b;
if (c > max) max =c;
if (d > max) max =d;
if (f > max) max =f;

Console.WriteLine("max = ");
Console.WriteLine(max);