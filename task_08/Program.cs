// procedure

Console.Clear();

void f(ref int x)
{
    x = x + 10;
}

int n = 5;
Console.WriteLine(n);
f(ref n);
Console.WriteLine(n);