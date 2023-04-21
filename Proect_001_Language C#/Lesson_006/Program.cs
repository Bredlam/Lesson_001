int a = 1;
int b = 12;
int c = 6;
int d = 8;
int e = 4;

int max = a;

if (max < a) max = a;
if (max < b) max = b;
if (max < c) max = c;
if (max < d) max = d;
if (max < e) max = e;

Console.Write("Мах равен = ");
Console.WriteLine(max);
