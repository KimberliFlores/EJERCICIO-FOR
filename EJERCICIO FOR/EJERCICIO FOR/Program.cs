// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int n = 5; // numero de filas del triangulo

for (int i = 0; i < n; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}